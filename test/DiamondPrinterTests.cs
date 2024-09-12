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
    public void Build_WhenCLetterSend_ReturnThreeLineString()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);
        var lines = diamond.Split(Environment.NewLine);

        // Assert
        Assert.Equal(3, lines.Length);
    }
    
    [Fact]
    public void Build_WhenCLetterSend_ReturnMutlilineStringWithEachCharacterInSeparateLine()
    {
        // Arrange
        var input = 'C';

        // Act
        var diamond = _printer.Build(input);
        var lines = diamond.Split(Environment.NewLine);

        // Assert
        Assert.Contains("A", lines[0]);
        Assert.Contains("B", lines[1]);
        Assert.Contains("C", lines[2]);
    }
}