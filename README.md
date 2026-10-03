# TextTransformer

A collection of small .NET console applications that transform and display text from command-line arguments.

## Features

- Display input text in the console
- Convert text to uppercase
- Add a configurable number of spaces between words
- Parse command-line arguments using several approaches
- Generate command-line help in the library-based variants

## Project variants

- `TextTransformer.Classic` - manual argument parsing
- `TextTransformer.CommandLine` - parsing with `System.CommandLine`
- `TextTransformer.Configuration.CommandLine` - parsing with `Microsoft.Extensions.Configuration.CommandLine`
- `TextTransformer.CommandLine.DragonFruit` - historical example using DragonFruit argument parsing

## Requirements

- .NET 8 SDK

## Examples

Run the `System.CommandLine` version:

```bash
dotnet run --project TextTransformer.CommandLine/TextTransformer.CommandLine.csproj -- "hello world" --uppercase --add-spaces 2
```

Run the classic version:

```bash
dotnet run --project TextTransformer.Classic/TextTransformer.Classic.csproj -- "hello world" --uppercase --add-spaces 2
```

To build all variants:

```bash
dotnet build TextTransformer.sln
```

## Purpose

This project compares multiple approaches to command-line argument processing in C#, from manual parsing to dedicated .NET libraries.

The DragonFruit project is included for educational purposes only. Its package is deprecated and should not be used for new applications.