namespace SoftOmni.ParsingResults.Tests.ProgressiveParsingResult;

public class ToParsingResult
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
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Success_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_Default()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_Default()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, FailedIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, NegativeIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_PositiveValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, PositiveValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_PositiveValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, PositiveValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyString, NegativeValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_TestZero()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestZero);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestZero()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestZero);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_TestOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_TestNegativeOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestNegativeOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyString, TestNegativeOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigPositive()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestBigPositive);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestBigPositive()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestBigPositive);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigNegative()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, TestBigNegative);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestBigNegative()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, TestBigNegative);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_ValidValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, ValidValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_ValidValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyString, ValidValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}*/

    [Fact]
    public void Failure_WithTestBigPositive_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(-2, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    /*[Fact]
    public void Failure_WithValidValue_Default()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_Default()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_FailedIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, FailedIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_FailedIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, FailedIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_NegativeIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, NegativeIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_NegativeIndex()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, NegativeIndex);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_PositiveValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, PositiveValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_PositiveValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, PositiveValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_NegativeValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, NegativeValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_NegativeValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, NegativeValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_TestZero()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestZero);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestZero()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestZero);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_TestOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_TestNegativeOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestNegativeOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestNegativeOne()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestNegativeOne);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_TestBigPositive()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestBigPositive);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestBigPositive()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestBigPositive);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_TestBigNegative()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, TestBigNegative);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestBigNegative()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, TestBigNegative);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_ValidValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, ErrorMessage, ValidValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_ValidValue()
    {SoftOmni.ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue, EmptyString, ValidValue);

SoftOmni.ParsingResults.ParsingResult parsingResult = progressiveParsingResult.ToParsingResult();

Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
Assert.Equal(parsingResult.IsSuccess, progressiveParsingResult.IsSuccess);
Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

Assert.Equal(, progressiveParsingResult.NewIndex );}*/


    [Fact]
    public void Custom_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithTestBigPositive_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithTestBigNegative_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }


    [Fact]
    public void Custom_WithValidValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, FailedIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, NegativeIndex);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, PositiveValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, NegativeValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestZero);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestNegativeOne);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestBigPositive);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, TestBigNegative);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyString, ValidValue);

        ParsingResults.ParsingResult parsingResult =
            progressiveParsingResult.ToParsingResult();

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.IsSuccess,
            progressiveParsingResult.IsSuccess);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }
}