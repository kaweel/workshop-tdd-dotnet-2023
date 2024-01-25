namespace di.example.framework.test;

public class FizzBuzzTests
{
    private string FizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
            return "FizzBuzz";
        if (number % 3 == 0)
            return "Fizz";
        if (number % 5 == 0)
            return "Buzz";
        return number.ToString();
    }

    [Fact]
    public void Should_return_Fizz_when_modulo_3()
    {
        var actual = FizzBuzz(3);
        Assert.Equal("Fizz", actual);
    }

    [Fact]
    public void Should_return_Buzz_when_modulo_5()
    {
        var actual = FizzBuzz(5);
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void Should_return_FizzBuzz_when_modulo_3_and_5()
    {
        var actual = FizzBuzz(15);
        Assert.Equal("FizzBuzz", actual);
    }

    [Fact]
    public void Should_return_it_self_when_can_not_modulo_3_or_5()
    {
        var actual = FizzBuzz(16);
        Assert.Equal("16", actual);
    }
}