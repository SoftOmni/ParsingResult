namespace ParsingResults.Tests.ParsingResult;

public class ToProgressiveParsingResult
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
    public void Success_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Success_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithFailedIndex_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithZero_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithZero_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }
    
    /*[Fact]
    public void Failure_WithNegativeOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithNegativeOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }*/
    
    [Fact]
    public void Failure_WithBigPositive_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigPositive_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Failure_WithBigNegative_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Failure_WithBigNegative_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithFailedIndex_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithZero_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithZero_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }
    
    /*[Fact]
    public void FailureEmptyString_WithNegativeOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithNegativeOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }*/

    [Fact]
    public void FailureEmptyString_WithBigPositive_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigPositive_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void FailureEmptyString_WithBigNegative_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void FailureEmptyString_WithBigNegative_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithFailedIndex_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeIndex_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithZero_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithZero_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithNegativeOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithNegativeOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithBigPositive_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigPositive_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithBigNegative_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithBigNegative_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void Custom_WithValidValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void Custom_WithValidValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, ErrorMessage);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithFailedIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithFailedIndex_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithZero_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithZero_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithNegativeOne_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithNegativeOne_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithBigPositive_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigPositive_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithBigNegative_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithBigNegative_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithValidValue_FailedIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(FailedIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(FailedIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_NegativeIndex()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeIndex);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeIndex, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_NegativeValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(NegativeValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(NegativeValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_PositiveValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(PositiveValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(PositiveValue, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_Zero()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestZero);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestZero, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_One()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_NegativeOne()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestNegativeOne);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestNegativeOne, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_BigPositive()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigPositive);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigPositive, progressiveParsingResult.NewIndex);
    }
    
    [Fact]
    public void CustomEmptyString_WithValidValue_BigNegative()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(TestBigNegative);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(TestBigNegative, progressiveParsingResult.NewIndex);
    }

    [Fact]
    public void CustomEmptyString_WithValidValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            parsingResult.ToProgressiveParsingResult(ValidValue);

        Assert.Equal(parsingResult.Value, progressiveParsingResult.Value);
        Assert.Equal(parsingResult.Message, progressiveParsingResult.Message);
        Assert.Equal(parsingResult.IsCustom, progressiveParsingResult.IsCustom);

        Assert.Equal(ValidValue, progressiveParsingResult.NewIndex);
    }
}