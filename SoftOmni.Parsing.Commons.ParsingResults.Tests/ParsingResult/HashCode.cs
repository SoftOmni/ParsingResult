namespace SoftOmni.Parsing.Commons.ParsingResults.Tests.ParsingResult;

public class HashCode
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

        Assert.Equal(success.GetHashCode(), success2.GetHashCode());
    }

    [Fact]
    public void Success_RegularFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);

        Assert.NotEqual(success.GetHashCode(), failure.GetHashCode());
    }

    [Fact]
    public void Success_RegularEmptyStringFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);

        Assert.NotEqual(success.GetHashCode(), failure.GetHashCode());
    }

    [Fact]
    public void Success_NegativeIndexFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);

        Assert.NotEqual(success.GetHashCode(), failure.GetHashCode());
    }

    [Fact]
    public void Success_NegativeIndexEmptyStringFailure()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.NotEqual(success.GetHashCode(), failure.GetHashCode());
    }

    [Fact]
    public void Success_RegularCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);

        Assert.NotEqual(success.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void Success_RegularEmptyStringCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);

        Assert.NotEqual(success.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void Success_NegativeIndexCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);

        Assert.NotEqual(success.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void Success_NegativeIndexEmptyStringCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);

        Assert.NotEqual(success.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void Success_ValidValueCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(success.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void Success_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult success =
            ParsingResults.ParsingResult.CreateSuccess();
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(success.GetHashCode(), custom.GetHashCode());
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

        Assert.Equal(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void RegularFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void RegularFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.Equal(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void RegularEmptyStringFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void RegularEmptyStringFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.Equal(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void NegativeIndexFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void NegativeIndexFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_NegativeIndexEmptyStringFailure()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult failure2 =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);

        Assert.Equal(failure.GetHashCode(), failure2.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_ValidValueCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
    }

    [Fact]
    public void NegativeIndexEmptyStringFailure_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult failure =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(failure.GetHashCode(), custom.GetHashCode());
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

        Assert.Equal(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void RegularCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void RegularCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.Equal(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void RegularEmptyStringCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void RegularEmptyStringCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.Equal(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void NegativeIndexCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void NegativeIndexCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
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

        Assert.Equal(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void NegativeIndexEmptyStringCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void NegativeIndexEmptyStringCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void ValidValueCustom_ValidValueCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);

        Assert.Equal(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void ValidValueCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                ErrorMessage);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.NotEqual(custom.GetHashCode(), custom2.GetHashCode());
    }

    [Fact]
    public void ValidValueEmptyStringCustom_ValidValueEmptyStringCustom()
    {
        ParsingResults.ParsingResult custom =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);
        ParsingResults.ParsingResult custom2 =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue,
                EmptyString);

        Assert.Equal(custom.GetHashCode(), custom2.GetHashCode());
    }
}