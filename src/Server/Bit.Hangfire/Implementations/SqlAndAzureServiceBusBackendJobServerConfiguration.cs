using Bit.Core.Models;
using Bit.Hangfire.Contracts;
using Hangfire;
using Hangfire.Azure.ServiceBusQueue;
using Hangfire.Logging;
using Hangfire.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bit.Hangfire.Implementations
{
    public class SqlAndAzureServiceBusBackendJobServerConfiguration : IJobSchedulerBackendConfiguration
    {
        public virtual JobActivator JobActivator { get; set; }

        public virtual AppEnvironment AppEnvironment { get; set; }

        public virtual ILogProvider LogProvider { get; set; }

        public virtual IEnumerable<IHangfireOptionsCustomizer> Customizers { get; set; }

        private BackgroundJobServer _backgroundJobServer;

        public virtual void Init()
        {
            string jobSchedulerDbConnectionString = AppEnvironment.GetConfig<string>(AppEnvironment.KeyValues.Hangfire.JobSchedulerDbConnectionString);

            SqlServerStorage storage = new SqlServerStorage(jobSchedulerDbConnectionString, new SqlServerStorageOptions
            {
                PrepareSchemaIfNecessary = false,
                UseRecommendedIsolationLevel = true,
                SchemaName = "HangFire",
                CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                QueuePollInterval = TimeSpan.Zero,
                UsePageLocksOnDequeue = true,
                DisableGlobalLocks = true
            }); // https://docs.hangfire.io/en/latest/configuration/using-sql-server.html#configuration

            if (AppEnvironment.TryGetConfig(AppEnvironment.KeyValues.Hangfire.JobSchedulerAzureServiceBusConnectionString, out string signalRAzureServiceBusConnectionString))
            {
                storage.UseServiceBusQueues(signalRAzureServiceBusConnectionString);
            }

            JobStorage.Current = storage;
            GlobalConfiguration.Configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseStorage(storage)
                .UseLogProvider(LogProvider);

            if (GlobalJobFilters.Filters.Any(f => f.Instance is AutomaticRetryAttribute))
            {
                GlobalConfiguration.Configuration.UseFilter(new DefaultAutomaticRetryAttribute { });
                GlobalJobFilters.Filters.Remove(GlobalJobFilters.Filters.ExtendedSingle("Finding automatic retry job filter attribute to remove it from global job filters", f => f.Instance is AutomaticRetryAttribute).Instance);
            }

            BackgroundJobServerOptions options = new BackgroundJobServerOptions
            {
                Activator = JobActivator
            };

            foreach (IHangfireOptionsCustomizer customizer in Customizers)
            {
                customizer.Customize(GlobalConfiguration.Configuration, options, storage);
            }

            _backgroundJobServer = new BackgroundJobServer(options, storage);
        }

        public virtual void Dispose()
        {
            _backgroundJobServer?.Stop(force: true);
            _backgroundJobServer?.Dispose();
        }
    }
}