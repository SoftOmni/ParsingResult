namespace SoftOmni.ParsingResults.Tests.ParsingResult.EqualityOperators;

public class String
{
    private const string ErrorMessage = "ERROR: this isn't right";

    private static readonly string EmptyString = string.Empty;

    private const string DifferentErrorMessage = "ERROR: this isn't right either";

    private const int FailedIndex = 5;

    private const int NegativeIndex = -87;

    [Fact]
    public void Success_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void Success_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult == ErrorMessage);
        Assert.False(ErrorMessage == parsingResult);

        Assert.True(parsingResult != ErrorMessage);
        Assert.True(ErrorMessage != parsingResult);
    }

    [Fact]
    public void Success_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularFailure_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, ErrorMessage);

        Assert.False(parsingResult == EmptyString);
        Assert.False(EmptyString == parsingResult);

        Assert.True(parsingResult != EmptyString);
        Assert.True(EmptyString != parsingResult);
    }

    [Fact]
    public void RegularFailure_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, ErrorMessage);

        Assert.True(parsingResult == ErrorMessage);
        Assert.True(ErrorMessage == parsingResult);

        Assert.False(parsingResult != ErrorMessage);
        Assert.False(ErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularFailure_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, ErrorMessage);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularFailureEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void RegularFailureEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, EmptyString);

        Assert.False(parsingResult == ErrorMessage);
        Assert.False(ErrorMessage == parsingResult);

        Assert.True(parsingResult != ErrorMessage);
        Assert.True(ErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularFailureEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(FailedIndex, EmptyString);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexFailure_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, ErrorMessage);

        Assert.False(parsingResult == EmptyString);
        Assert.False(EmptyString == parsingResult);

        Assert.True(parsingResult != EmptyString);
        Assert.True(EmptyString != parsingResult);
    }

    [Fact]
    public void NegativeIndexFailure_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, ErrorMessage);

        Assert.True(parsingResult == ErrorMessage);
        Assert.True(ErrorMessage == parsingResult);

        Assert.False(parsingResult != ErrorMessage);
        Assert.False(ErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexFailure_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, ErrorMessage);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexFailureEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void NegativeIndexFailureEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, EmptyString);

        Assert.False(parsingResult == ErrorMessage);
        Assert.False(ErrorMessage == parsingResult);

        Assert.True(parsingResult != ErrorMessage);
        Assert.True(ErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexFailureEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateFailure(NegativeIndex, EmptyString);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void RegularCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, ErrorMessage);

        Assert.True(parsingResult == ErrorMessage);
        Assert.True(ErrorMessage == parsingResult);

        Assert.False(parsingResult != ErrorMessage);
        Assert.False(ErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, ErrorMessage);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularCustomEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void RegularCustomEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.False(parsingResult == ErrorMessage);
        Assert.False(ErrorMessage == parsingResult);

        Assert.True(parsingResult != ErrorMessage);
        Assert.True(ErrorMessage != parsingResult);
    }

    [Fact]
    public void RegularCustomEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(FailedIndex, EmptyString);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void NegativeIndexCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, ErrorMessage);

        Assert.True(parsingResult == ErrorMessage);
        Assert.True(ErrorMessage == parsingResult);

        Assert.False(parsingResult != ErrorMessage);
        Assert.False(ErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, ErrorMessage);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexCustomEmptyString_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void NegativeIndexCustomEmptyString_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, EmptyString);

        Assert.False(parsingResult == ErrorMessage);
        Assert.False(ErrorMessage == parsingResult);

        Assert.True(parsingResult != ErrorMessage);
        Assert.True(ErrorMessage != parsingResult);
    }

    [Fact]
    public void NegativeIndexCustomEmptyString_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(NegativeIndex, EmptyString);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void ValidValueCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void ValidValueCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue, ErrorMessage);

        Assert.True(parsingResult == ErrorMessage);
        Assert.True(ErrorMessage == parsingResult);

        Assert.False(parsingResult != ErrorMessage);
        Assert.False(ErrorMessage != parsingResult);
    }

    [Fact]
    public void ValidValueCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue, ErrorMessage);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }

    [Fact]
    public void ValidValueEmptyStringCustom_EmptyString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.True(parsingResult == EmptyString);
        Assert.True(EmptyString == parsingResult);

        Assert.False(parsingResult != EmptyString);
        Assert.False(EmptyString != parsingResult);
    }

    [Fact]
    public void ValidValueEmptyStringCustom_ErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.False(parsingResult == ErrorMessage);
        Assert.False(ErrorMessage == parsingResult);

        Assert.True(parsingResult != ErrorMessage);
        Assert.True(ErrorMessage != parsingResult);
    }

    [Fact]
    public void ValidValueEmptyStringCustom_DifferentErrorString()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(ParsingResults.ParsingResult.ValidValue, EmptyString);

        Assert.False(parsingResult == DifferentErrorMessage);
        Assert.False(DifferentErrorMessage == parsingResult);

        Assert.True(parsingResult != DifferentErrorMessage);
        Assert.True(DifferentErrorMessage != parsingResult);
    }
}