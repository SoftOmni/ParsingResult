// ReSharper disable SuspiciousTypeConversion.Global

namespace SoftLights.ParsingResults.Tests.ParsingResult.Equals;

public class Integer
{
    private const string ErrorMessage = "ERROR: this isn't right";

    private static readonly string EmptyString = string.Empty;

    private const int PositiveValue = 5;

    private const int NegativeValue = -5;

    private const int TestZero = 0;

    private const int TestOne = 1;

    private const int TestNegativeOne = -1;

    private const int TestBigPositive = 17;

    private const int TestBigNegative = -17;

    private const int ValidValue = ParsingResults.ParsingResult.ValidValue;

    [Fact]
    public void Success_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void Success_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void Success_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void Success_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void Success_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.True(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void Success_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void Success_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void Success_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.True(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.True(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailure_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.True(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailure_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.True(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailure_WithZeroValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailure_WithOneValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailure_WithOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailure_WithOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailure_WithOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.True(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailure_WithOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailure_WithOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailure_WithOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailure_WithOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void RegularFailure_WithNegativeOneValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));

    }*/

    [Fact]
    public void RegularFailure_WithBigPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailure_WithBigPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailure_WithBigPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailure_WithBigPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailure_WithBigPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailure_WithBigPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailure_WithBigPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailure_WithBigPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailure_WithBigNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void RegularFailure_WithValidValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailure_WithValidValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailure_WithValidValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailure_WithValidValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailure_WithValidValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailure_WithValidValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailure_WithValidValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailure_WithValidValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));

    }*/

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.True(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailureEmptyString_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.True(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.True(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailureEmptyString_WithZeroValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.True(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailureEmptyString_WithOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.True(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));

    }*/

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.True(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.True(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void RegularFailureEmptyString_WithBigNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void RegularFailureEmptyString_WithValidValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.True(parsingResult.Equals(ValidValue));

    }*/

    [Fact]
    public void Custom_WithPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.True(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void Custom_WithPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void Custom_WithPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void Custom_WithPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void Custom_WithPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void Custom_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void Custom_WithNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.True(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void Custom_WithNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void Custom_WithNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void Custom_WithNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void Custom_WithNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void Custom_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void Custom_WithZeroValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void Custom_WithZeroValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void Custom_WithZeroValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.True(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void Custom_WithZeroValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void Custom_WithZeroValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void Custom_WithZeroValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void Custom_WithZeroValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void Custom_WithZeroValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void Custom_WithOneValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void Custom_WithOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void Custom_WithOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void Custom_WithOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.True(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void Custom_WithOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void Custom_WithOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void Custom_WithOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void Custom_WithOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void Custom_WithNegativeOneValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ValidValue));

    }*/

    [Fact]
    public void Custom_WithBigPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void Custom_WithBigPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void Custom_WithBigPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void Custom_WithBigPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void Custom_WithBigPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void Custom_WithBigPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void Custom_WithBigPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void Custom_WithBigPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void Custom_WithBigNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void Custom_WithValidValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void Custom_WithValidValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void Custom_WithValidValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void Custom_WithValidValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void Custom_WithValidValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void Custom_WithValidValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void Custom_WithValidValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void Custom_WithValidValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(ValidValue));

    }*/

    [Fact]
    public void CustomEmptyString_WithPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.True(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void CustomEmptyString_WithPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(PositiveValue,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.True(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void CustomEmptyString_WithNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeValue,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.True(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void CustomEmptyString_WithZeroValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestZero, EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.True(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void CustomEmptyString_WithOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestOne, EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void CustomEmptyString_WithNegativeOneValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));

    }*/

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.True(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void CustomEmptyString_WithBigPositiveValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigPositive,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_PositiveResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.True(parsingResult.Equals(TestBigNegative));
    }

    [Fact]
    public void CustomEmptyString_WithBigNegativeValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestBigNegative,
                EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));
    }

    /*[Fact]
    public void CustomEmptyString_WithValidValue_PositiveResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_NegativeResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_ZeroResult()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_OneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_NegativeOneTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_BigPositiveTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_BigNegativeTest()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_ValidValue()
    {
        SoftLights.ParsingResults.ParsingResult parsingResult =
            SoftLights.ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));

    }*/
}