using System.Text;

namespace DiamondKata;

public class DiamondPrinter
{
    private const char FIRST_LETTER = 'A';
    private const int FIRST_LETTER_INDEX = (int)FIRST_LETTER;

    public string? Build(char input)
    {
        if (!char.IsLetter(input))
        {
            return null;
        }

        var stringBuilder = new StringBuilder();
        var inputCharIndex = (int)char.ToUpper(input);
        for (int i = FIRST_LETTER_INDEX; i <= inputCharIndex; i++)
        {
            var currentChar = (char)i;
            stringBuilder.Append(currentChar);
            AppendNewLineExceptLastChar(stringBuilder, i, inputCharIndex);
        }

        return stringBuilder.ToString();
    }

    private void AppendNewLineExceptLastChar(StringBuilder stringBuilder, 
        int index, 
        int inputCharIndex)
    {
        if (index != inputCharIndex)
        {
            stringBuilder.AppendLine();
        }
    }
}
