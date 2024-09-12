namespace DiamondKata.Test;

public class DiamondPrinterTests
{
    private readonly DiamondPrinter _printer = new DiamondPrinter();

    [Fact]
    public void Print_WhenAParameterSend_ReturnA()
    {
        // Arrange
        var input = 'A';

        // Act
        var result = _printer.Print(input);

        // Assert
        Assert.Equal("A", result);
    }
    
    [Fact]
    public void Print_WhenNonLetterParameterSend_ReturnNull()
    {
        // Arrange
        var input = '1';

        // Act
        var result = _printer.Print(input);

        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public void Print_WhenBParameterSend_ReturnStringWithABChars()
    {
        // Arrange
        var input = 'B';

        // Act
        var result = _printer.Print(input);

        // Assert
        Assert.Contains("A", result);
        Assert.Contains("B", result);
    }
}