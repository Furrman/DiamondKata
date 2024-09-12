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
            var distance = GetDistanceBetweenChars(inputCharIndex, i);
            AppendCharToLine(stringBuilder, currentChar, distance);
            AppendNewLineExceptLastChar(stringBuilder, i, inputCharIndex);
        }
    }

    private void AppendBottomDiamondPart(StringBuilder stringBuilder,
        int inputCharIndex)
    {
        for (int i = inputCharIndex-1; i >= FIRST_LETTER_INDEX; i--)
        {
            var currentChar = (char)i;
            var distance = GetDistanceBetweenChars(inputCharIndex, i);
            AppendNewLineExceptLastChar(stringBuilder, inputCharIndex, distance);
            AppendCharToLine(stringBuilder, currentChar, distance);
        }
    }

    private void AppendCharToLine(StringBuilder stringBuilder, 
        char currentChar,
        int distance)
    {
        if (distance > 0)
        {
            stringBuilder.Append(' ', distance);
        }

        stringBuilder.Append(currentChar);
        
        if (currentChar != FIRST_LETTER)
        {
            stringBuilder.Append(currentChar);
        }
        
        if (distance > 0)
        {
            stringBuilder.Append(' ', distance);
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

    private int GetDistanceBetweenChars(int inputCharIndex, 
        int currentCharIndex)
    {
        return Math.Abs(inputCharIndex - currentCharIndex);
    }
}
