namespace SoftOmni.ParsingResults.Tests.ParsingResult.StaticInstantiation;

public class CreateSuccess
{
    [Fact]
    public void Creation()
    {
        ParsingResults.ParsingResult parsingResult =
            ParsingResults.ParsingResult.CreateSuccess();

        Assert.Equal(ParsingResults.ParsingResult.ValidValue,
            parsingResult.Value);
        Assert.Equal(string.Empty, parsingResult.Message);

        Assert.False(parsingResult.IsCustom);
        Assert.False(parsingResult.IsFailure);
        Assert.True(parsingResult.IsSuccess);
    }
}