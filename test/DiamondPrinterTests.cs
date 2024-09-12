namespace DiamondKata.Test;

public class DiamondPrinterTests
{
    private readonly DiamondPrinter _printer = new DiamondPrinter();

    [Fact]
    public void Build_WhenALetterSend_ReturnA()
    {
        // Arrange
        var input = 'A';

        // Act
        var result = _printer.Build(input);

        // Assert
        Assert.Equal("A", result);
    }
    
    [Fact]
    public void Build_WhenNonLetterParameterSend_ReturnNull()
    {
        // Arrange
        var input = '1';

        // Act
        var result = _printer.Build(input);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void Build_WhenBLetterSend_ReturnStringWithABChars()
    {
        // Arrange
        var input = 'B';

        // Act
        var result = _printer.Build(input);

        // Assert
        Assert.Contains("A", result);
        Assert.Contains("B", result);
    }
    
    [Fact]
    public void Build_WhenCLetterSend_ReturnStringWithAllCharsFromAToC()
    {
        // Arrange
        var input = 'C';

        // Act
        var result = _printer.Build(input);

        // Assert
        Assert.Contains("A", result);
        Assert.Contains("B", result);
        Assert.Contains("C", result);
    }
    
    [Fact]
    public void Build_WhenLowerCaseLetterSend_ReturnStringWithAllCharsFromAToC()
    {
        // Arrange
        var input = 'a';

        // Act
        var result = _printer.Build(input);

        // Assert
        Assert.Equal("A", result);
    }
    
    [Fact]
    public void Build_WhenCLetterSend_ReturnMultilineString()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.True(lines.Length > 1);
    }
    
    [Fact]
    public void Build_WhenCLetterSend_ReturnMutlilineStringWithEachCharacterInSeparateLine()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.Contains("A", lines[0]);
        Assert.Contains("B", lines[1]);
        Assert.Contains("C", lines[2]);
    }
    
    [Fact]
    public void Build_WhenCLetterSend_ReturnAnyCharacterOtherThanATwiceInEachLine()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.Equal(1, lines[0].Count(l => l == 'A'));
        Assert.Equal(2, lines[1].Count(l => l == 'B'));
        Assert.Equal(2, lines[2].Count(l => l == 'C'));
    }
    
    [Fact]
    public void Build_WhenCLetterSend_ReturnTwiceManyLinesPerEachLetterExceptProvidedOne()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.Equal(5, lines.Length);
    }

    [Fact]
    public void Build_WhenCLetterSend_ReturnLinesStartingFromAToProvidedLetterAndBack()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.Contains("A", lines[0]);
        Assert.Contains("B", lines[1]);
        Assert.Contains("C", lines[2]);
        Assert.Contains("B", lines[3]);
        Assert.Contains("A", lines[4]);
    }

    [Fact]
    public void Build_WhenCLetterSend_ReturnLinesWithLeftSpacesEqualDistanceBetweenFirstAndLastLetter()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.StartsWith("  A", lines[0]);
        Assert.StartsWith(" B", lines[1]);
        Assert.StartsWith("C", lines[2]);
        Assert.StartsWith(" B", lines[3]);
        Assert.StartsWith("  A", lines[4]);
    }

    [Fact]
    public void Build_WhenCLetterSend_ReturnLinesWithRightSpacesEqualDistanceBetweenFirstAndLastLetter()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.EndsWith("A  ", lines[0]);
        Assert.EndsWith("B ", lines[1]);
        Assert.EndsWith("C", lines[2]);
        Assert.EndsWith("B ", lines[3]);
        Assert.EndsWith("A  ", lines[4]);
    }

    [Fact]
    public void Build_WhenCLetterSend_ReturnLinesWithSpacesBetweenCharsEqualDistanceBetweenFirstAndLastLetter()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.Contains("B B", lines[1]);
        Assert.Contains("C   C", lines[2]);
        Assert.Contains("B B", lines[3]);
    }
    
    [Fact]
    public void Build_WhenCLetterSend_ReturnDiamondShapeFromLettersFromAToC()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);

        // Assert
        Assert.NotNull(diamond);
        var lines = diamond.Split(Environment.NewLine);
        Assert.Equal("  A  ", lines[0]);
        Assert.Equal(" B B ", lines[1]);
        Assert.Equal("C   C", lines[2]);
        Assert.Equal(" B B ", lines[3]);
        Assert.Equal("  A  ", lines[4]);
    }
}