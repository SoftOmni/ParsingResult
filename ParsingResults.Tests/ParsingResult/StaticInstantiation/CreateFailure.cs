namespace ParsingResults.Tests.ParsingResult.StaticInstantiation;

public class CreateFailure
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

        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
        {
            ParsingResults.ParsingResult.CreateFailure(failedIndex, errorMessage);
        });
    }
    
    [Fact]
    public void ValidityEmptyStringIndex()
    {
        const string errorMessage = "";
        const int failedIndex = ParsingResults.ParsingResult.ValidValue;

        Assert.Throws<ValidityIndexOnFailedParsingResultException>(() =>
        {
            ParsingResults.ParsingResult.CreateFailure(failedIndex, errorMessage);
        });
    }

    private static void PerformSimpleTest(string errorMessage, int failedIndex)
    {
        ParsingResults.ParsingResult parsingResult = ParsingResults.ParsingResult.CreateFailure(failedIndex, errorMessage);

        Assert.Equal(errorMessage, parsingResult.Message);
        Assert.Equal(failedIndex, parsingResult.Value);
        
        Assert.False(parsingResult.IsSuccess);
        Assert.False(parsingResult.IsCustom);
        
        Assert.True(parsingResult.IsFailure);
    }
}