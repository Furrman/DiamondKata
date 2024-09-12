namespace DiamondKata.Test;

public class DiamondPrinterTests
{
    private readonly DiamondPrinter _printer = new DiamondPrinter();

    [Fact]
    public void Build_WhenAParameterSend_ReturnA()
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
    public void Build_WhenBParameterSend_ReturnStringWithABChars()
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
    public void Build_WhenCParameterSend_ReturnStringWithAllCharsFromAToC()
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
}