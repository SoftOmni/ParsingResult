namespace ParsingResults.Tests.ParsingResult;

public class ToString
{
    private const string ErrorMessage = "ERROR: this isn't right";

    private static readonly string EmptyString = string.Empty;

    private const int FailedIndex = 5;

    private const int NegativeIndex = -87;

    private const int PositiveValue = 5;

    private const int NegativeValue = -5;

    private const int TestZero = 0;

    private const int TestOne = 1;

    private const int TestNegativeOne = -1;

    private const int TestBigPositive = 17;

    private const int TestBigNegative = -17;

    private const int ValidValue = ParsingResults.ParsingResult.ValidValue;

    [Fact]
    public void Success()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.Equal("Successful parsing result", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithZero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithBigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithBigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"",
            parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithFailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, EmptyString);

        Assert.Equal($"Failed parsing result at index {FailedIndex} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, EmptyString);

        Assert.Equal($"Failed parsing result at index {NegativeIndex} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithPositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue, EmptyString);

        Assert.Equal($"Failed parsing result at index {PositiveValue} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithNegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue, EmptyString);

        Assert.Equal($"Failed parsing result at index {NegativeValue} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithZero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.Equal($"Failed parsing result at index {TestZero} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.Equal($"Failed parsing result at index {TestOne} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithBigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive, EmptyString);

        Assert.Equal($"Failed parsing result at index {TestBigPositive} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void FailureEmptyString_WithBigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative, EmptyString);

        Assert.Equal($"Failed parsing result at index {TestBigNegative} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithZero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithBigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithBigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        Assert.Equal($"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithFailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.Equal($"Custom parsing result at index {FailedIndex} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithNegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, EmptyString);

        Assert.Equal($"Custom parsing result at index {NegativeIndex} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue, EmptyString);

        Assert.Equal($"Custom parsing result at index {PositiveValue} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue, EmptyString);

        Assert.Equal($"Custom parsing result at index {NegativeValue} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithZero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.Equal($"Custom parsing result at index {TestZero} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.Equal($"Custom parsing result at index {TestOne} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithNegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne, EmptyString);

        Assert.Equal($"Custom parsing result at index {TestNegativeOne} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithBigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive, EmptyString);

        Assert.Equal($"Custom parsing result at index {TestBigPositive} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithBigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative, EmptyString);

        Assert.Equal($"Custom parsing result at index {TestBigNegative} in \"\"", parsingResult.ToString());
    }

    [Fact]
    public void CustomEmptyString_WithValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.Equal($"Custom parsing result at index {ValidValue} in \"\"", parsingResult.ToString());
    }
}