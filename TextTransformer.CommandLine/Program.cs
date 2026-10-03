using System.CommandLine;
using System.Globalization;

// Deklarujeme si argumenty s typmi, príkazy a voľby, ktoré chceme spracovávať
var textArgument = new Argument<string>("text") { Description = "Input text." };
var uppercaseOption = new Option<bool>("--uppercase", "-u") { Description = "Change the letters to uppercase." };
var addSpacesOption = new Option<int>("--add-spaces", "-a") { Description = "Add spaces between words." };

var rootCommand = new RootCommand("Display text to output.") { textArgument, uppercaseOption, addSpacesOption };

rootCommand.SetAction(parseResult =>
{
    string? text = parseResult.GetValue(textArgument);
    bool uppercase = parseResult.GetValue(uppercaseOption);
    int addSpaces = parseResult.GetValue(addSpacesOption);

    DisplayToOutput(text, uppercase, addSpaces);
    return 0;
});

var parseResult = rootCommand.Parse(args);
return parseResult.Invoke();

// V metóde spracujeme argumenty, ktoré nám knižnica rozparsuje:
static void DisplayToOutput(string? text, bool uppercase, int addSpaces)
{
    ArgumentNullException.ThrowIfNull(text);

    if (uppercase)
    {
        text = text.ToUpper(CultureInfo.InvariantCulture);
    }

    if (addSpaces > 0)
    {
        string spaces = new(' ', addSpaces);
        text = text.Replace(" ", spaces, StringComparison.Ordinal);
    }

    Console.WriteLine(text);
}