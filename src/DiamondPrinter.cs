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

        AppendTopDiamondPartIncludingMiddleLine(stringBuilder, inputCharIndex);
        AppendBottomDiamondPart(stringBuilder, inputCharIndex);

        return stringBuilder.ToString();
    }

    private void AppendTopDiamondPartIncludingMiddleLine(StringBuilder stringBuilder,
        int inputCharIndex)
    {
        for (int i = FIRST_LETTER_INDEX; i <= inputCharIndex; i++)
        {
            var currentChar = (char)i;
            AppendCharToLine(stringBuilder, currentChar);
            AppendNewLineExceptLastChar(stringBuilder, i, inputCharIndex);
        }
    }

    private void AppendBottomDiamondPart(StringBuilder stringBuilder,
        int inputCharIndex)
    {
        for (int i = inputCharIndex-1; i >= FIRST_LETTER_INDEX; i--)
        {
            var currentChar = (char)i;
            AppendNewLineExceptLastChar(stringBuilder, i, inputCharIndex);
            AppendCharToLine(stringBuilder, currentChar);
        }
    }

    private void AppendCharToLine(StringBuilder stringBuilder, 
        char currentChar)
    {
        stringBuilder.Append(currentChar);

        if (currentChar != FIRST_LETTER)
        {
            stringBuilder.Append(currentChar);
        }
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
