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
}