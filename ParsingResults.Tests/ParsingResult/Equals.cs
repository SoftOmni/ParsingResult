// ReSharper disable SuspiciousTypeConversion.Global

namespace ParsingResults.Tests.ParsingResult;

public class Equals
{
    private const string ErrorMessage = "ERROR: this isn't right";

    private const string DifferentErrorMessage =
        "ERROR: this isn't right either";

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
    public void Success_Success()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult success2 =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.True(success.Equals(success2));
        Assert.True(success2.Equals(success));
    }

    [Fact]
    public void Success_RegularFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.False(success.Equals(failure));
        Assert.False(failure.Equals(success));
    }

    [Fact]
    public void Success_RegularEmptyStringFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.False(success.Equals(failure));
        Assert.False(failure.Equals(success));
    }

    [Fact]
    public void Success_NegativeIndexFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.False(success.Equals(failure));
        Assert.False(failure.Equals(success));
    }

    [Fact]
    public void Success_NegativeIndexEmptyStringFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.False(success.Equals(failure));
        Assert.False(failure.Equals(success));
    }

    [Fact]
    public void Success_RegularCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.False(success.Equals(custom));
        Assert.False(custom.Equals(success));

        Assert.True(success != custom);
        Assert.True(custom != success);
    }

    [Fact]
    public void Success_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.False(success.Equals(custom));
        Assert.False(custom.Equals(success));

        Assert.True(success != custom);
        Assert.True(custom != success);
    }

    [Fact]
    public void Success_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(success.Equals(custom));
        Assert.False(custom.Equals(success));
    }

    [Fact]
    public void Success_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(success.Equals(custom));
        Assert.False(custom.Equals(success));
    }

    [Fact]
    public void Success_ValidValueCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(success.Equals(custom));
        Assert.False(custom.Equals(success));
    }

    [Fact]
    public void Success_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(success.Equals(custom));
        Assert.False(custom.Equals(success));
    }

    [Fact]
    public void RegularFailure_RegularFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.True(failure.Equals(failure2));
        Assert.True(failure2.Equals(failure));
    }

    [Fact]
    public void RegularFailure_RegularEmptyStringFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.False(failure.Equals(failure2));
        Assert.False(failure2.Equals(failure));
    }

    [Fact]
    public void RegularFailure_NegativeIndexFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.False(failure.Equals(failure2));
        Assert.False(failure2.Equals(failure));
    }

    [Fact]
    public void RegularFailure_NegativeIndexEmptyStringFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.False(failure.Equals(failure2));
        Assert.False(failure2.Equals(failure));
    }

    [Fact]
    public void RegularFailure_RegularCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularFailure_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularFailure_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularFailure_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_RegularEmptyStringFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.True(failure.Equals(failure2));
        Assert.True(failure2.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_NegativeIndexFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.False(failure.Equals(failure2));
        Assert.False(failure2.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_NegativeIndexEmptyStringFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.False(failure.Equals(failure2));
        Assert.False(failure2.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_RegularCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularEmptyStringFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_NegativeIndexFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.True(failure.Equals(failure2));
        Assert.True(failure2.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_NegativeIndexEmptyStringFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.False(failure.Equals(failure2));
        Assert.False(failure2.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_RegularCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void
        NegativeIndexEmptyStringFailure_NegativeIndexEmptyStringFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.True(failure.Equals(failure2));
        Assert.True(failure2.Equals(failure));
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_RegularCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(failure.Equals(custom));
        Assert.False(custom.Equals(failure));
    }

    [Fact]
    public void RegularCustom_RegularCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.True(custom.Equals(custom2));
        Assert.True(custom2.Equals(custom));
    }

    [Fact]
    public void RegularCustom_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularCustom_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularCustom_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularEmptyStringCustom_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.True(custom.Equals(custom2));
        Assert.True(custom2.Equals(custom));
    }

    [Fact]
    public void RegularEmptyStringCustom_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularEmptyStringCustom_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularEmptyStringCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void RegularEmptyStringCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void NegativeIndexCustom_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.True(custom.Equals(custom2));
        Assert.True(custom2.Equals(custom));
    }

    [Fact]
    public void NegativeIndexCustom_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void NegativeIndexCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void NegativeIndexCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void NegativeIndexEmptyStringCustom_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.True(custom.Equals(custom2));
        Assert.True(custom2.Equals(custom));
    }

    [Fact]
    public void NegativeIndexEmptyStringCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void NegativeIndexEmptyStringCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void ValidValueCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.True(custom.Equals(custom2));
        Assert.True(custom2.Equals(custom));
    }

    [Fact]
    public void ValidValueCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.False(custom.Equals(custom2));
        Assert.False(custom2.Equals(custom));
    }

    [Fact]
    public void ValidValueEmptyStringCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.True(custom.Equals(custom2));
        Assert.True(custom2.Equals(custom));
    }

    [Fact]
    public void Success_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void Success_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void Success_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void RegularFailure_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void RegularFailure_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void RegularFailure_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void RegularFailureEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void RegularFailureEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void RegularFailureEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void NegativeIndexFailure_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void NegativeIndexFailure_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void NegativeIndexFailure_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void NegativeIndexFailureEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void NegativeIndexFailureEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void NegativeIndexFailureEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void RegularCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void RegularCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void RegularCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void RegularCustomEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void RegularCustomEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void RegularCustomEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void NegativeIndexCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void NegativeIndexCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void NegativeIndexCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void NegativeIndexCustomEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void NegativeIndexCustomEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void NegativeIndexCustomEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void ValidValueCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void ValidValueCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue, ErrorMessage);

        Assert.True(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void ValidValueCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue, ErrorMessage);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

    [Fact]
    public void ValidValueEmptyStringCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.True(parsingResult.Equals(EmptyString));
    }

    [Fact]
    public void ValidValueEmptyStringCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(ErrorMessage));
    }

    [Fact]
    public void ValidValueEmptyStringCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(
                ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(DifferentErrorMessage));
    }

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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailure_WithNegativeOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailure_WithValidValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailure_WithValidValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailure_WithValidValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailure_WithValidValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailure_WithValidValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailure_WithValidValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailure_WithValidValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue,
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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.True(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailureEmptyString_WithNegativeOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(TestNegativeOne,
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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void RegularFailureEmptyString_WithValidValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(ValidValue, EmptyString);

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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                ErrorMessage);

        Assert.True(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void Custom_WithNegativeOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void Custom_WithValidValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void Custom_WithValidValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void Custom_WithValidValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void Custom_WithValidValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void Custom_WithValidValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void Custom_WithValidValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
                ErrorMessage);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void Custom_WithValidValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue,
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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
                EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void CustomEmptyString_WithNegativeOneValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(TestNegativeOne,
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
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(PositiveValue));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_NegativeResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(NegativeValue));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_ZeroResult()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestZero));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_OneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestOne));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_NegativeOneTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestNegativeOne));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_BigPositiveTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigPositive));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_BigNegativeTest()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(TestBigNegative));

    }

    [Fact]
    public void CustomEmptyString_WithValidValue_ValidValue()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ValidValue, EmptyString);

        Assert.False(parsingResult.Equals(ValidValue));

    }*/
}