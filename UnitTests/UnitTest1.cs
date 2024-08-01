using MainProject;

namespace UnitTests;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(5, 5, 10)]
    public void AddTest(int a, int b, int expected)
    {
        //Arrange
        var helper = new Helper();
        
        //Act
        var actual = helper.Add(a, b);
        
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 5, 0)]
    [InlineData(10, 20, -10)]
    public void SubtractTest(int a, int b, int expected)
    {
        //Arrange
        var helper = new Helper();
        
        //Act
        var actual = helper.Subtract(a, b);
        
        //Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("Seth", "Hello, Seth!")]
    [InlineData("Mack", "Hello, Mack!")]
    [InlineData("", "Hello!")]
    [InlineData(null, "Hello!")]
    public void GreetTest(string name, string expected)
    {
        //Arrange
        var helper = new Helper();
        
        //Act
        var actual = helper.Greet(name);
        
        //Assert
        Assert.Equal(expected, actual);
    }
}