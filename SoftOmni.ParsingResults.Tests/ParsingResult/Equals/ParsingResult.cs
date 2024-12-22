namespace SoftOmni.ParsingResults.Tests.ParsingResult.Equals;

public class ParsingResult
{
    private const string ErrorMessage = "ERROR: this isn't right";

    private static readonly string EmptyString = string.Empty;

    private const int FailedIndex = 5;

    private const int NegativeIndex = -87;

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
}