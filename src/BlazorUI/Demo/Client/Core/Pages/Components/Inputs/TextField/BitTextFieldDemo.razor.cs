﻿namespace Bit.BlazorUI.Demo.Client.Core.Pages.Components.Inputs.TextField;

public partial class BitTextFieldDemo
{
    private readonly List<ComponentParameter> componentParameters = new()
    {
        new()
        {
            Name = "AutoComplete",
            Type = "string?",
            DefaultValue = "null",
            Description = "AutoComplete is a string that maps to the autocomplete attribute of the HTML input element.",
        },
        new()
        {
            Name = "AutoFocus",
            Type = "bool",
            DefaultValue = "false",
            Description = "Determines if the text field is auto focused on first render.",
        },
        new()
        {
            Name = "CanRevealPassword",
            Type = "bool",
            DefaultValue = "false",
            Description = "Whether to show the reveal password button for input type 'password'.",
        },
        new()
        {
            Name = "Classes",
            Type = "BitTextFieldClassStyles?",
            DefaultValue = "null",
            LinkType = LinkType.Link,
            Href = "#textfield-class-styles",
            Description = "Custom CSS classes for different parts of the BitTextField.",
        },
        new()
        {
            Name = "DefaultValue",
            Type = "string?",
            DefaultValue = "null",
            Description = "Default value of the text field. Only provide this if the text field is an uncontrolled component; otherwise, use the value property.",
        },
        new()
        {
            Name = "Description",
            Type = "string?",
            DefaultValue = "null",
            Description = "Description displayed below the text field to provide additional details about what text to enter.",
        },
        new()
        {
            Name = "DescriptionTemplate",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "Shows the custom description for text field.",
        },
        new()
        {
            Name = "HasBorder",
            Type = "bool",
            DefaultValue = "true",
            Description = "Whether or not the text field is borderless.",
        },
        new()
        {
            Name = "IsMultiline",
            Type = "bool",
            DefaultValue = "false",
            Description = "Whether or not the text field is a Multiline text field.",
        },
        new()
        {
            Name = "IsReadonly",
            Type = "bool",
            DefaultValue = "false",
            Description = "If true, the text field is readonly.",
        },
        new()
        {
            Name = "IsRequired",
            Type = "bool",
            DefaultValue = "false",
            Description = "Whether the associated input is required or not, add an asterisk \"*\" to its label.",
        },
        new()
        {
            Name = "IsUnderlined",
            Type = "bool",
            DefaultValue = "false",
            Description = "Whether or not the text field is underlined.",
        },
        new()
        {
            Name = "IsResizable",
            Type = "bool",
            DefaultValue = "true",
            Description = "For multiline text fields, whether or not the field is resizable.",
        },
        new()
        {
            Name = "IconName",
            Type = "string?",
            DefaultValue = "null",
            Description = "The icon name for the icon shown in the far right end of the text field.",
        },
        new()
        {
            Name = "IsTrimmed",
            Type = "bool",
            DefaultValue = "false",
            Description = "Specifies whether to remove any leading or trailing whitespace from the value.",
        },
        new()
        {
            Name = "Label",
            Type = "string?",
            DefaultValue = "null",
            Description = "Label displayed above the text field and read by screen readers.",
        },
        new()
        {
            Name = "LabelTemplate",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "Shows the custom label for text field.",
        },
        new()
        {
            Name = "MaxLength",
            Type = "int",
            DefaultValue = "-1",
            Description = "Specifies the maximum number of characters allowed in the input.",
        },
        new()
        {
            Name = "OnFocus",
            Type = "EventCallback<FocusEventArgs>",
            Description = "Callback for when focus moves into the input.",
        },
        new()
        {
            Name = "OnFocusIn",
            Type = "EventCallback<FocusEventArgs>",
            Description = "Callback for when focus moves into the input.",
        },
        new()
        {
            Name = "OnFocusOut",
            Type = "EventCallback<FocusEventArgs>",
            Description = "Callback for when focus moves out of the input.",
        },
        new()
        {
            Name = "OnKeyDown",
            Type = "EventCallback<KeyboardEventArgs>",
            Description = "Callback for when a keyboard key is pressed.",
        },
        new()
        {
            Name = "OnKeyUp",
            Type = "EventCallback<KeyboardEventArgs>",
            Description = "Callback for When a keyboard key is released.",
        },
        new()
        {
            Name = "OnChange",
            Type = "EventCallback<string?>",
            Description = "Callback for when the input value changes. This is called on both input and change events.",
        },
        new()
        {
            Name = "OnClick",
            Type = "EventCallback<MouseEventArgs>",
            Description = "Callback for when the input clicked.",
        },
        new()
        {
            Name = "Placeholder",
            Type = "string?",
            DefaultValue = "null",
            Description = "Input placeholder text.",
        },
        new()
        {
            Name = "Prefix",
            Type = "string?",
            DefaultValue = "null",
            Description = "Prefix displayed before the text field contents. This is not included in the value. \r\n Ensure a descriptive label is present to assist screen readers, as the value does not include the prefix.",
        },
        new()
        {
            Name = "PrefixTemplate",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "Shows the custom prefix for text field.",
        },
        new()
        {
            Name = "Rows",
            Type = "int",
            DefaultValue = "3",
            Description = "For multiline text, Number of rows.",
        },
        new()
        {
            Name = "RevealPasswordAriaLabel",
            Type = "string?",
            DefaultValue = "null",
            Description = "Suffix displayed after the text field contents. This is not included in the value. \r\n Ensure a descriptive label is present to assist screen readers, as the value does not include the suffix.",
        },
        new()
        {
            Name = "Styles",
            Type = "BitTextFieldClassStyles?",
            DefaultValue = "null",
            LinkType = LinkType.Link,
            Href = "#textfield-class-styles",
            Description = "Custom CSS styles for different parts of the BitTextField.",
        },
        new()
        {
            Name = "Suffix",
            Type = "string?",
            DefaultValue = "null",
            Description = "Suffix displayed after the text field contents. This is not included in the value. \r\n Ensure a descriptive label is present to assist screen readers, as the value does not include the suffix.",
        },
        new()
        {
            Name = "SuffixTemplate",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "Shows the custom suffix for text field.",
        },
        new()
        {
            Name = "Type",
            Type = "BitTextFieldType",
            DefaultValue = "BitTextFieldType.Text",
            Description = "Input type.",
            LinkType = LinkType.Link,
            Href = "#text-field-type-enum"
        }
    };

    private readonly List<ComponentSubClass> componentSubClasses = new()
    {
        new()
        {
            Id = "textfield-class-styles",
            Title = "BitTextFieldClassStyles",
            Description = "",
            Parameters = new()
            {
                new()
                {
                    Name = "Description",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's description."
                },
                new()
                {
                    Name = "DescriptionContainer",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's description container."
                },
                new()
                {
                    Name = "Label",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's label."
                },
                new()
                {
                    Name = "FieldGroup",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's field group."
                },
                new()
                {
                    Name = "Focused",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles of the root element in focus state."
                },
                new()
                {
                    Name = "Icon",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's icon."
                },
                new()
                {
                    Name = "Input",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's input."
                },
                new()
                {
                    Name = "InputIcon",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's input icon."
                },
                new()
                {
                    Name = "InputWrapper",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the wrapper of label and input in the text field."
                },
                new()
                {
                    Name = "Prefix",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's prefix."
                },
                new()
                {
                    Name = "PrefixContainer",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's prefix container."
                },
                new()
                {
                    Name = "RevealPassword",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's reveal password."
                },
                new()
                {
                    Name = "RevealPasswordIcon",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's reveal password icon."
                },
                new()
                {
                    Name = "RevealPasswordIconContainer",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's reveal password icon container."
                },
                new()
                {
                    Name = "Root",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's root element."
                },
                new()
                {
                    Name = "Suffix",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's suffix."
                },
                new()
                {
                    Name = "SuffixContainer",
                    Type = "string?",
                    DefaultValue = "null",
                    Description = "Custom CSS classes/styles for the text field's suffix container."
                }
            }
        }
    };

    private readonly List<ComponentSubEnum> componentSubEnums = new()
    {
        new()
        {
            Id = "text-field-type-enum",
            Name = "BitTextFieldType",
            Description = "",
            Items = new()
            {
                new()
                {
                    Name= "Text",
                    Description="The TextField characters are shown as text.",
                    Value="0",
                },
                new()
                {
                    Name= "Password",
                    Description="The TextField characters are masked.",
                    Value="1",
                },
                new()
                {
                    Name= "Number",
                    Description="The TextField characters are number.",
                    Value="2",
                },
                new()
                {
                    Name= "Email",
                    Description="The TextField act as an email input.",
                    Value="3",
                },
                new()
                {
                    Name= "Tel",
                    Description="The TextField act as a tel input.",
                    Value="4",
                },
                new()
                {
                    Name= "Url",
                    Description="The TextField act as a url input.",
                    Value="5",
                }
            }
        }
    };



    private string? oneWayValue;
    private string? twoWayValue;
    private string? onChangeValue;

    private string? trimmedValue;
    private string? notTrimmedValue;

    private ValidationTextFieldModel validationTextFieldModel = new();
    public bool formIsValidSubmit;

    private async Task HandleValidSubmit()
    {
        formIsValidSubmit = true;

        await Task.Delay(2000);

        validationTextFieldModel = new();

        formIsValidSubmit = false;

        StateHasChanged();
    }

    private void HandleInvalidSubmit()
    {
        formIsValidSubmit = false;
    }



    private readonly string example1RazorCode = @"
<BitTextField Label=""Basic"" />
<BitTextField Label=""Placeholder"" Placeholder=""Enter a text..."" />
<BitTextField Label=""Disabled"" IsEnabled=""false"" />
<BitTextField Label=""Readonly"" IsReadonly=""true"" />
<BitTextField Label=""Description"" Description=""This is Description"" />
<BitTextField Label=""IsRequired"" IsRequired=""true"" />
<BitTextField Label=""MaxLength: 5"" MaxLength=""5"" />
<BitTextField Label=""Auto focused"" AutoFocus=""true"" />";

    private readonly string example2RazorCode = @"
<BitTextField Label=""Basic"" IsUnderlined=""true"" />
<BitTextField Label=""Placeholder"" IsUnderlined=""true"" Placeholder=""Enter a text..."" />
<BitTextField Label=""Disabled"" IsUnderlined=""true"" IsEnabled=""false"" />
<BitTextField Label=""Required"" IsUnderlined=""true"" IsRequired=""true"" />";

    private readonly string example3RazorCode = @"
<BitTextField Label=""Basic"" Placeholder=""Enter a text..."" HasBorder=""false"" />
<BitTextField Label=""Disabled"" Placeholder=""Enter a text..."" HasBorder=""false"" IsEnabled=""false"" />
<BitTextField Label=""Required"" Placeholder=""Enter a text..."" HasBorder=""false"" IsRequired=""true"" />";

    private readonly string example4RazorCode = @"
<BitTextField Label=""Resizable"" IsMultiline=""true"" />
<BitTextField Label=""Unresizable (Fixed)"" IsMultiline=""true"" IsResizable=""false"" />
<BitTextField Label=""Rows = 10"" IsMultiline=""true"" Rows=""10"" />";

    private readonly string example5RazorCode = @"
<BitTextField Label=""Email"" IconName=""@BitIconName.EditMail"" />
<BitTextField Label=""Calendar"" IconName=""@BitIconName.Calendar"" />";

    private readonly string example6RazorCode = @"
<BitTextField Label=""Prefix"" Prefix=""https://"" />
<BitTextField Label=""Suffix"" Suffix="".com"" />
<BitTextField Label=""Prefix and Suffix"" Prefix=""https://"" Suffix="".com"" />
<BitTextField Label=""Disabled"" Prefix=""https://"" Suffix="".com"" IsEnabled=""false"" />";

    private readonly string example7RazorCode = @"
<BitTextField>
    <LabelTemplate>
        <BitLabel Style=""color:coral"">Custom Label</BitLabel>
    </LabelTemplate>
</BitTextField>

<BitTextField Label=""Custom Description"">
    <DescriptionTemplate>
        <BitLabel Style=""color:coral"">Description</BitLabel>
    </DescriptionTemplate>
</BitTextField>

<BitTextField Label=""Custom Prefix"">
    <PrefixTemplate>
        <BitLabel Style=""color:coral;margin:0 5px"">Prefix</BitLabel>
    </PrefixTemplate>
</BitTextField>

<BitTextField Label=""Custom Suffix"">
    <SuffixTemplate>
        <BitLabel Style=""color:coral;margin:0 5px"">Suffix</BitLabel>
    </SuffixTemplate>
</BitTextField>";

    private readonly string example8RazorCode = @"
<BitTextField Label=""Password"" Type=""BitTextFieldType.Password"" />
<BitTextField Label=""Reveal Password"" Type=""BitTextFieldType.Password"" CanRevealPassword=""true"" />";

    private readonly string example9RazorCode = @"
<BitTextField Label=""One-way"" Value=""@oneWayValue"" />
<BitOtpInput Length=""4"" Style=""margin-top: 5px;"" @bind-Value=""oneWayValue"" />

<BitTextField Label=""Two-way"" @bind-Value=""twoWayValue"" IsMultiline=""true"" />
<BitOtpInput Length=""4"" Style=""margin-top: 5px;"" @bind-Value=""twoWayValue"" />

<BitTextField Label=""OnChange"" OnChange=""(v) => onChangeValue = v"" />
<BitLabel>Value: @onChangeValue</BitLabel>";
    private readonly string example9CsharpCode = @"
private string oneWayValue;
private string twoWayValue;
private string onChangeValue;";

    private readonly string example10RazorCode = @"
<BitTextField Label=""Trimmed"" IsTrimmed=""true"" @bind-Value=""trimmedValue"" />
<pre>[@trimmedValue]</pre>

<BitTextField Label=""Not Trimmed"" @bind-Value=""notTrimmedValue"" />
<pre>[@notTrimmedValue]</pre>";
    private readonly string example10CsharpCode = @"
private string trimmedValue;
private string notTrimmedValue;";

    private readonly string example11RazorCode = @"
<style>
    .custom-class {
        border: 1px solid red;
        box-shadow: aqua 0 0 1rem;
    }

    .custom-input {
        color: darkgreen;
        font-weight: 900;
        font-size: 1rem;
        padding: 1rem;
        height: 3rem;
    }

    .custom-field {
        margin-top: 0.5rem;
        border-radius: 1rem;
        background-color: tomato;
    }

    .custom-focus .custom-field::after {
        border-radius: 1rem;
        border-width: 0.25rem;
        border-color: rebeccapurple;
    }

    .custom-focus .custom-label {
        color: chartreuse;
    }
</style>

<BitTextField Style=""background-color: lightskyblue; border-radius: 1rem; padding: 0.5rem;"" />

<BitTextField Class=""custom-class"" />



<BitTextField Label=""Custom label style""
              IconName=""@BitIconName.Microphone""
              Styles=""@(new() { Root = ""background-color: pink;"",
                                Icon = ""color: darkorange;"",
                                Label = ""color: blue; font-weight: 900; font-size: 1.25rem;"",
                                Input = ""padding: 0.5rem; background-color: goldenrod;"" })"" />

<BitTextField Label=""Custom label class""
              DefaultValue=""Custom input class""
              Classes=""@(new() { FieldGroup = ""custom-field"",
                                 Focused = ""custom-focus"",
                                 Input = ""custom-input"",
                                 Label = ""custom-label"" })"" />";

    private readonly string example12RazorCode = @"
<style>
    .validation-message {
        color: red;
    }
</style>

<EditForm Model=""validationTextFieldModel"" OnValidSubmit=""HandleValidSubmit"" OnInvalidSubmit=""HandleInvalidSubmit"" novalidate>
    <DataAnnotationsValidator />

    <BitTextField Label=""Required"" IsRequired=""true"" @bind-Value=""validationTextFieldModel.Text"" />
    <ValidationMessage For=""() => validationTextFieldModel.Text"" />

    <BitTextField Label=""Numeric"" @bind-Value=""validationTextFieldModel.NumericText"" />
    <ValidationMessage For=""() => validationTextFieldModel.NumericText"" />

    <BitTextField Label=""Only chars"" @bind-Value=""validationTextFieldModel.CharacterText"" />
    <ValidationMessage For=""() => validationTextFieldModel.CharacterText"" />

    <BitTextField Label=""Email"" @bind-Value=""validationTextFieldModel.EmailText"" />
    <ValidationMessage For=""() => validationTextFieldModel.EmailText"" />

    <BitTextField Label=""3 < Length < 5"" @bind-Value=""validationTextFieldModel.RangeText"" />
    <ValidationMessage For=""() => validationTextFieldModel.RangeText"" />

    <BitButton ButtonType=""BitButtonType.Submit"">Submit</BitButton>
</EditForm>";
    private readonly string example12CsharpCode = @"
public class ValidationTextFieldModel
{
    [Required(ErrorMessage = ""This field is required."")]
    public string Text { get; set; }

    [RegularExpression(""0*[1-9][0-9]*"", ErrorMessage = ""Only numeric values are allowed."")]
    public string NumericText { get; set; }

    [RegularExpression(""^[a-zA-Z0-9.]*$"", ErrorMessage = ""Only letters(a-z), numbers(0-9), and period(.) are allowed."")]
    public string CharacterText { get; set; }

    [EmailAddress(ErrorMessage = ""Invalid e-mail address."")]
    public string EmailText { get; set; }

    [StringLength(5, MinimumLength = 3, ErrorMessage = ""The text length must be between 3 and 5 chars."")]
    public string RangeText { get; set; }
}

private ValidationTextFieldModel validationTextFieldModel = new();

private void HandleValidSubmit() { }
private void HandleInvalidSubmit() { }";
}
