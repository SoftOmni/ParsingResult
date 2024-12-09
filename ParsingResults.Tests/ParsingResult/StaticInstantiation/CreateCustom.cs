namespace ParsingResults.Tests.ParsingResult.StaticInstantiation;

public class CreateCustom
{
    [Fact]
    public void Regular()
    {
        const string errorMessage = "ERROR: this isn't right";
        const int failedIndex = 5;

        PerformSimpleTest(errorMessage, failedIndex);
    }

    [Fact]
    public void RegularEmptyString()
    {
        const string errorMessage = "";
        const int failedIndex = 5;

        PerformSimpleTest(errorMessage, failedIndex);
    }

    [Fact]
    public void NegativeIndexString()
    {
        const string errorMessage = "ERROR: this isn't right";
        const int failedIndex = -87;

        PerformSimpleTest(errorMessage, failedIndex);
    }

    [Fact]
    public void NegativeIndexEmptyStringString()
    {
        const string errorMessage = "";
        const int failedIndex = -87;

        PerformSimpleTest(errorMessage, failedIndex);
    }

    [Fact]
    public void ValidityIndex()
    {
        const string errorMessage = "ERROR: this isn't right";
        const int failedIndex = ParsingResults.ParsingResult.ValidValue;

        PerformSimpleTest(errorMessage, failedIndex);
    }

    [Fact]
    public void ValidityEmptyStringIndex()
    {
        const string errorMessage = "";
        const int failedIndex = ParsingResults.ParsingResult.ValidValue;

        PerformSimpleTest(errorMessage, failedIndex);
    }

    private static void PerformSimpleTest(string errorMessage, int failedIndex)
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateCustom(failedIndex,
                errorMessage);

        Assert.Equal(errorMessage, parsingResult.Message);
        Assert.Equal(failedIndex, parsingResult.Value);

        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsFailure);

        Assert.True(parsingResult.IsCustom);
    }
}