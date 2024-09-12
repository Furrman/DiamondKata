using System;

namespace DiamondKata;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: diamond <char>");
            return;
        }

        var input = args[0];
        if (input.Length != 1 || !char.IsLetter(input[0]))
        {
            Console.WriteLine("Invalid input. Please provide a letter.");
            return;
        }

        char inputChar = input[0];
        var printer = new DiamondPrinter();
        var diamond = printer.Build(inputChar);
        Console.WriteLine(diamond);
    }
}
