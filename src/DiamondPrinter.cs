using System.Text;

namespace DiamondKata;

public class DiamondPrinter
{
    public string? Build(char input)
    {
        if (!char.IsLetter(input))
        {
            return null;
        }

        var diamond = new StringBuilder();
        if (input == 'A')
        {
            diamond.Append('A');
            return diamond.ToString();
        }
        diamond.Append('A');
        diamond.Append('B');
        return diamond.ToString();
    }
}
