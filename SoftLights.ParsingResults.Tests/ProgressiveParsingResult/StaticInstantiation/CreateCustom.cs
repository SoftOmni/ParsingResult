namespace SoftLights.ParsingResults.Tests.ProgressiveParsingResult.StaticInstantiation;

public class CreateCustom
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
    public void Custom_WithFailedIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(ErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_WithDifferentErrorMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(DifferentErrorMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(FailedIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeIndex, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(PositiveValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(NegativeValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestZero, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestNegativeOne, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigPositive_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigPositive, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithTestBigNegative_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(TestBigNegative, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_Default()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, -2);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(-2, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, FailedIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(FailedIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeIndex);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeIndex, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_PositiveValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, PositiveValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(PositiveValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_NegativeValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(NegativeValue, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestZero()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestZero);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestZero, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestNegativeOne()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestNegativeOne);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestNegativeOne, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestBigPositive()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigPositive);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigPositive, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestBigNegative()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigNegative);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(TestBigNegative, parsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_ValidValue()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, ValidValue);

        Assert.NotNull(parsingResult);
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsCustom);
        Assert.Equal(ValidValue, parsingResult.Value);
        Assert.Equal(EmptyMessage, parsingResult.Message);
        Assert.Equal(ValidValue, parsingResult.NewIndex);
    }
}