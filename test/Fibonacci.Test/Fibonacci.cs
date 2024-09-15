namespace Fibonacci.Test;

public class FibonacciTest
{
    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-3)]
    [InlineData(-10)]
    public void Fibonacci_Negatif_Number_Is_Equal_To_Zero(int value)
    {
        var fibonacci = Fibonacci.fibonacci(value);
        Assert.Equal(0,fibonacci);
    }

    [Theory]
    [InlineData(0,1)]
    [InlineData(1,1)]
    [InlineData(2,2)]
    [InlineData(3,3)]
    [InlineData(4,5)]
    [InlineData(5,8)]
    [InlineData(6,13)]
    [InlineData(7,21)]
    public void Fibonacci_Positif_Number_Is_Positif_Number(int value,int value2){
        System.Console.WriteLine($"({value},{value2})");
        var fibonacci = Fibonacci.fibonacci(value);
        // System.Console.WriteLine(fibonacci);
        Assert.Equal((int)value2,fibonacci);

    }
}