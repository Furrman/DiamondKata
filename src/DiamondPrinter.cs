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
        for (int i = inputCharIndex - 1; i >= FIRST_LETTER_INDEX; i--)
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

        AddPadding(stringBuilder, sideSpaceLength);
        AddCharsAndMiddleSpace(stringBuilder, currentChar, middleSpaceLength);
        AddPadding(stringBuilder, sideSpaceLength);
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

    private void AddPadding(StringBuilder stringBuilder, 
        int spaceLength)
    {
        if (spaceLength > 0)
        {
            stringBuilder.Append(' ', spaceLength);
        }
    }

    private void AddCharsAndMiddleSpace(StringBuilder stringBuilder, 
        char currentChar, 
        int middleSpaceLength)
    {
        stringBuilder.Append(currentChar);
        if (middleSpaceLength > 0)
        {
            stringBuilder.Append(' ', middleSpaceLength);
            stringBuilder.Append(currentChar);
        }
    }
}
