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
        var inputChar = char.ToUpper(input);
        var inputCharIndex = (int)inputChar;
        var lineLength = 2 * (inputCharIndex - FIRST_LETTER_INDEX) + 1;

        AppendTopDiamondPartIncludingMiddleLine(stringBuilder, inputChar, inputCharIndex, lineLength);
        AppendBottomDiamondPart(stringBuilder, inputChar, inputCharIndex, lineLength);

        return stringBuilder.ToString();
    }

    private void AppendTopDiamondPartIncludingMiddleLine(StringBuilder stringBuilder,
        char inputChar,
        int inputCharIndex,
        int lineLength)
    {
        for (int i = FIRST_LETTER_INDEX; i <= inputCharIndex; i++)
        {
            AppendDiamondLine(stringBuilder, i, inputChar, lineLength);
            AppendNewLineExceptLastChar(stringBuilder, i, inputCharIndex);
        }
    }

    private void AppendBottomDiamondPart(StringBuilder stringBuilder,
        char inputChar,
        int inputCharIndex,
        int lineLength)
    {
        for (int i = inputCharIndex-1; i >= FIRST_LETTER_INDEX; i--)
        {
            AppendNewLineExceptLastChar(stringBuilder, inputCharIndex, i);
            AppendDiamondLine(stringBuilder, i, inputCharIndex, lineLength);
        }
    }

    private void AppendDiamondLine(StringBuilder stringBuilder,
        int currentCharIndex,
        int inputCharIndex,
        int lineLength)
    {
        var currentChar = (char)currentCharIndex;
        var hasOneCharInLine = currentCharIndex == FIRST_LETTER_INDEX;
        var charCountInLine = hasOneCharInLine ? 1 : 2;
        var sideSpaceLength = inputCharIndex - currentCharIndex;
        var middleSpaceLength = lineLength - 2 * sideSpaceLength - charCountInLine;

        // Add space before left letter
        if (sideSpaceLength > 0)
        {
            stringBuilder.Append(' ', sideSpaceLength);
        }

        stringBuilder.Append(currentChar);

        // Add space between letters
        if (middleSpaceLength > 0)
        {
            stringBuilder.Append(' ', middleSpaceLength);
        }

        // Add letter again if it's not the first letter 
        if (!hasOneCharInLine)
        {
            stringBuilder.Append(currentChar);
        }
        
        // Add space after right letter
        if (sideSpaceLength > 0)
        {
            stringBuilder.Append(' ', sideSpaceLength);
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
