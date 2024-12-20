// ReSharper disable SuspiciousTypeConversion.Global

namespace SoftLights.ParsingResults.Tests.ProgressiveParsingResult.Equals;

public class String
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
    public void Success_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult
                .CreateSuccess(NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Success_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(
                TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Success_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithFailedIndex_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeIndex_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithPositiveValue_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithNegativeValue_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_Default_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_Default_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_Default_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_FailedIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_NegativeIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_PositiveValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_PositiveValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_PositiveValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_NegativeValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestZero_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestZero_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestZero_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestNegativeOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_TestNegativeOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestNegativeOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigPositive_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_TestBigPositive_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigPositive_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigNegative_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_TestBigNegative_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_TestBigNegative_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_ValidValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_ValidValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_ValidValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }*/

    [Fact]
    public void Failure_WithTestBigPositive_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigPositive_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestBigNegative_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    /*[Fact]
    public void Failure_WithValidValue_Default_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_Default_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_Default_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_FailedIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_FailedIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_FailedIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_PositiveValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_PositiveValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_PositiveValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_NegativeValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestZero_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestZero_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestZero_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestNegativeOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_TestNegativeOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestNegativeOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestBigPositive_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_TestBigPositive_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestBigPositive_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestBigNegative_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_TestBigNegative_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_TestBigNegative_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithValidValue_ValidValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_ValidValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithValidValue_ValidValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }*/

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    /*[Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }*/

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    /*[Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }*/

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithFailedIndex_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithPositiveValue_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithNegativeValue_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    /*[Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_Default_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_Default_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }*/

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigPositive_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithTestBigNegative_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateFailure(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    /*[Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_Default_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_Default_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Failure_WithValidValue_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        SoftLights.ParsingResults.ProgressiveParsingResult parsingResult =
            SoftLights.ParsingResults.ProgressiveParsingResult.CreateFailure(ValidValue,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }*/

    [Fact]
    public void Custom_WithFailedIndex_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithFailedIndex_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeIndex_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithPositiveValue_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithNegativeValue_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigPositive_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestBigNegative_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, -2);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                ErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, -2);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, -2);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, FailedIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, FailedIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, PositiveValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, PositiveValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, NegativeValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestZero);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestZero);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, ValidValue);

        Assert.True(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_WithDifferentErrorMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                DifferentErrorMessage, ValidValue);

        Assert.False(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithFailedIndex_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(FailedIndex,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithPositiveValue_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(PositiveValue,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithNegativeValue_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeValue,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestNegativeOne, EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigPositive_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigPositive, EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithTestBigNegative_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(
                TestBigNegative, EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_Default_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_Default_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, -2);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_Default_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, -2);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_FailedIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_FailedIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, FailedIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_FailedIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, FailedIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_NegativeIndex_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_NegativeIndex_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeIndex);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_NegativeIndex_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeIndex);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_PositiveValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_PositiveValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, PositiveValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_PositiveValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, PositiveValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_NegativeValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_NegativeValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_NegativeValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, NegativeValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestZero_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestZero_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestZero);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestZero_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestZero);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void Custom_WithValidValue_AndEmptyMessage_TestOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestNegativeOne_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestNegativeOne_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestNegativeOne);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestNegativeOne_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestNegativeOne);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestBigPositive_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestBigPositive_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigPositive);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestBigPositive_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigPositive);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestBigNegative_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestBigNegative_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigNegative);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_TestBigNegative_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, TestBigNegative);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_ValidValue_And_ErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_ValidValue_And_DifferentErrorMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, ValidValue);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void
        Custom_WithValidValue_AndEmptyMessage_ValidValue_And_EmptyMessage()
    {
        ParsingResults.ProgressiveParsingResult parsingResult =
            ParsingResults.ProgressiveParsingResult.CreateCustom(ValidValue,
                EmptyMessage, ValidValue);

        Assert.True(parsingResult.Equals(EmptyMessage));
    }
}