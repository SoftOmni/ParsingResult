namespace SoftOmni.ParsingResults.Tests.ProgressiveParsingResult.StaticInstantiation;

public class CreateFailure
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
    public void Failure_WithFailedIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_Default()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_PositiveValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestZero()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestNegativeOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigPositive()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigNegative()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_ValidValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }*/

    [Fact]
    public void Failure_WithTestBigPositive_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithValidValue_Default()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_FailedIndex()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, FailedIndex));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeIndex()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeIndex));
    }

    [Fact]
    public void Failure_WithValidValue_PositiveValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, PositiveValue));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeValue));
    }

    [Fact]
    public void Failure_WithValidValue_TestZero()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestZero));
    }

    [Fact]
    public void Failure_WithValidValue_TestOne()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestOne));
    }

    [Fact]
    public void Failure_WithValidValue_TestNegativeOne()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestNegativeOne));
    }

    [Fact]
    public void Failure_WithValidValue_TestBigPositive()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigPositive));
    }

    [Fact]
    public void Failure_WithValidValue_TestBigNegative()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigNegative));
    }

    [Fact]
    public void Failure_WithValidValue_ValidValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, ValidValue));
    }

    [Fact]
    public void Failure_WithFailedIndex_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_WithDifferentErrorMessage_Default()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestZero()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }*/

    [Fact]
    public void Failure_WithTestBigPositive_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_Default()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_FailedIndex()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, FailedIndex));
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_NegativeIndex()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeIndex));
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_PositiveValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, PositiveValue));
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_NegativeValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeValue));
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_TestZero()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestZero));
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_TestOne()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestOne));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestNegativeOne()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestNegativeOne));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigPositive()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigPositive));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigNegative()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigNegative));
    }

    [Fact]
    public void Failure_WithValidValue_WithDifferentErrorMessage_ValidValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, ValidValue));
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_Default()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_PositiveValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestZero()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestBigPositive()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_TestBigNegative()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_ValidValue()
    {
        SoftOmni.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }*/

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigPositive_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithTestBigNegative_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.True(parsingResult.IsFailure);
        Assert.False(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_Default()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_FailedIndex()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, FailedIndex));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_NegativeIndex()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeIndex));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_PositiveValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, PositiveValue));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_NegativeValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeValue));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestZero()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestZero));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestOne()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestOne));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestNegativeOne()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestNegativeOne));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestBigPositive()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigPositive));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_TestBigNegative()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigNegative));
    }

    [Fact]
    public void Failure_WithValidValue_AndEmptyMessage_ValidValue()
    {
        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
            SoftOmni.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, ValidValue));
    }
}