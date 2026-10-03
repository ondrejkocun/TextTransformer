// Varovanie: Táto knižnica bola 19. 6. 2025 označená ako zastaralá (deprecated) a nebude už viac udržiavaná, takže by ste ju už nemali v nových projektoch používať.
// Nechávam ju tu na ukážku, ako sa pomocou nej dali jednoducho spracovávať argumenty príkazového riadka. A okrem toho si môžete tiež všimnúť,
// že  pri otvorení NuGet Package Managera je označený balíček výkričníkom s popisom "This package version si deprecated" a "This package has been deprecated as it is legacy and no longer maintained.".

// Ak sa použije knižnica DragonFruit, je nutné vytvoriť metódu Main s parametrami vo vnútri nejakej inej triedy.
// Na základe dokumentačných komentárov sa automaticky vygeneruje help a argumenty sa dajú zadať aj cez príkazový riadok.

internal class Program
{
    /// <summary>
    /// Display text to output.
    /// </summary>
    /// <param name="argument">Input text.</param>
    /// <param name="uppercase">Change the letters to uppercase.</param>
    /// <param name="addSpaces">Add spaces between words.</param>
    private static void Main(string argument, bool uppercase = false, int addSpaces = 0)
    {
        if (uppercase)
            argument = argument.ToUpper();

        if (addSpaces > 0)
        {
            var newSpaces = new string(' ', addSpaces);
            argument = argument.Replace(" ", newSpaces);
        }

        Console.WriteLine(argument);
    }
}