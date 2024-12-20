namespace ParsingResults.Tests.ProgressiveParsingResult.StaticInstantiation;

public class CreateSuccess
{
    private const string ErrorMessage = "ERROR: this isn't right";

    private const string DifferentErrorMessage =
        "ERROR: this isn't right either";

    private static readonly string EmptyMessage = string.Empty;

    private const int FailedIndex = 5;

    private const int NegativeIndex = -87;

    private const int PositiveValue = 5;

    private const int NegativeValue = -5;

    private const int TestZero = 0;

    private const int TestOne = 1;

    private const int TestNegativeOne = -1;

    private const int TestBigPositive = 17;

    private const int TestBigNegative = -17;

    private const int ValidValue =
        ParsingResults.ProgressiveParsingResult.ValidValue;

    [Fact]
    public void Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Success_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.NotNull(parsingResult);
        Assert.True(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(ParsingResults.ProgressiveParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }
}