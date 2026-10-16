using hello_c_sharp;

namespace hello_c_sharp.Tests;

public class GreeterTests
{
    [Fact]
    public void MyMethod_GivenName_ReturnsGreetingWithName()
    {
        // Arrange
        string name = "Prince";

        // Act
        string result = Greeter.MyMethod(name);

        // Assert
        Assert.Equal("HelloPrince", result);
    }
}