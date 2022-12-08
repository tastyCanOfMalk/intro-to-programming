
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();
<<<<<<< HEAD
        var result = calculator.Add("");
=======

        var result = calculator.Add("");

>>>>>>> 5e1b4612c6e321c79c575e398cc0bfe770e4d381
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
<<<<<<< HEAD
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();            
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
      
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("1,4", 5)]
    [InlineData("10,24", 34)]
    public void DoubleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result); 
=======
    [InlineData("192", 192)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,1", 2)]
    [InlineData("1,2", 3)]
    [InlineData("8,9", 17)]
    [InlineData("12,8", 20)]
    [InlineData("100,42", 142)]
    [InlineData("422,3", 425)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
>>>>>>> 5e1b4612c6e321c79c575e398cc0bfe770e4d381
    }

    [Theory]
    [InlineData("1,2,3", 6)]
<<<<<<< HEAD
    [InlineData("1,2,3,4", 10)]
    [InlineData("1,2,3,4,5,6,7", 28)]
    public void ManyDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
=======
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    [InlineData("100,200,8", 308)]
    public void ArbitraryNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2\n3", 6)]
    [InlineData("100\n200\n8", 308)]
    
    public void NewLinesAsDelimeters(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

>>>>>>> 5e1b4612c6e321c79c575e398cc0bfe770e4d381
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2,3", 6)]
<<<<<<< HEAD
    [InlineData("1\n2\n3", 6)]
    [InlineData("2\n2\n3", 7)]

    public void NewLines(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result); 
    }
=======
    [InlineData("100\n200,8", 308)]

    public void MixedDelimeters(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n2;50", 52)]
    [InlineData("//%\n1%2", 3)]
    public void CustomDelimeter(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//*\n1*2,3", 6)]
    public void MixedAndCustom(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

>>>>>>> 5e1b4612c6e321c79c575e398cc0bfe770e4d381
}
