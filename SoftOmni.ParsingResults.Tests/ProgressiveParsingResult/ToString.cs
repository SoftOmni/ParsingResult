namespace SoftOmni.ParsingResults.Tests.ProgressiveParsingResult;

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

    private const int ValidValue = ParsingResults.ProgressiveParsingResult.ValidValue;

    [Fact]
    public void Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.Equal($"Successful parsing result with new index {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.Equal(
            $"Successful parsing result with new index {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.Equal(
            $"Successful parsing result with new index {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.Equal(
            $"Successful parsing result with new index {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.Equal($"Successful parsing result with new index {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.Equal($"Successful parsing result with new index {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.Equal(
            $"Successful parsing result with new index {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.Equal(
            $"Successful parsing result with new index {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.Equal(
            $"Successful parsing result with new index {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Success_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.Equal($"Successful parsing result with new index {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_Default()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {-2}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_Default()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {-2}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {FailedIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, FailedIndex);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {FailedIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, NegativeIndex);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {NegativeIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_PositiveValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {PositiveValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_PositiveValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, PositiveValue);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {PositiveValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {NegativeValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestZero()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestZero);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestZero}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestZero()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestZero);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestZero}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestOne);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestOne}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestOne);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestOne}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestNegativeOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigPositive()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestBigPositive()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestBigPositive);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestBigPositive}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigNegative()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestBigNegative()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestBigNegative);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestBigNegative}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_ValidValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, ValidValue);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {ValidValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_ValidValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, ValidValue);

        Assert.Equal($"Failed parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {ValidValue}", parsingResult.ToString());
    }*/

    [Fact]
    public void Failure_WithTestBigPositive_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {-2}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, FailedIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, NegativeIndex);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, PositiveValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, NegativeValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestZero);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestBigPositive);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestBigNegative);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, ValidValue);

        Assert.Equal(
            $"Failed parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    /*[Fact]
    public void Failure_WithValidValue_Default()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {-2}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_Default()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {-2}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_FailedIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, FailedIndex);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {FailedIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_FailedIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, FailedIndex);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {FailedIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_NegativeIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, NegativeIndex);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_NegativeIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, NegativeIndex);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {NegativeIndex}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_PositiveValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, PositiveValue);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {PositiveValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_PositiveValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, PositiveValue);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {PositiveValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_NegativeValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, NegativeValue);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {NegativeValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_NegativeValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, NegativeValue);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {NegativeValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_TestZero()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestZero);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestZero}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestZero()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestZero);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestZero}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_TestOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestOne);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestOne}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestOne);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestOne}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_TestNegativeOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestNegativeOne);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestNegativeOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestNegativeOne);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestNegativeOne}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_TestBigPositive()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestBigPositive);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestBigPositive()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestBigPositive);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestBigPositive}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_TestBigNegative()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestBigNegative);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestBigNegative()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestBigNegative);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestBigNegative}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_ValidValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, ValidValue);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {ValidValue}", parsingResult.ToString());
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_ValidValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, ValidValue);

        Assert.Equal($"Failed parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {ValidValue}", parsingResult.ToString());
    }*/


    [Fact]
    public void Custom_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {FailedIndex} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeIndex} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {PositiveValue} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {NegativeValue} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestZero} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestOne} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestNegativeOne} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithTestBigPositive_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigPositive} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithTestBigNegative_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {TestBigNegative} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }


    [Fact]
    public void Custom_WithValidValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, FailedIndex);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {FailedIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, NegativeIndex);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {NegativeIndex}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, PositiveValue);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {PositiveValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, NegativeValue);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {NegativeValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestZero);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestZero}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestOne);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestNegativeOne);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestNegativeOne}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestBigPositive);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestBigPositive}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestBigNegative);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {TestBigNegative}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{ErrorMessage}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, ValidValue);

        Assert.Equal(
            $"Custom parsing result at index {ValidValue} in \"{EmptyString}\"\nNew index: {ValidValue}",
            parsingResult.ToString());
    }
}