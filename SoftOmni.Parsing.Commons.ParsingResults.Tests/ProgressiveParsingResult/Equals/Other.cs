// ReSharper disable SuspiciousTypeConversion.Global

namespace SoftOmni.Parsing.Commons.ParsingResults.Tests.ProgressiveParsingResult.Equals;

public class Other
{
    [Fact]
    public void ParsingResult()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(0);

        ParsingResults.ParsingResult parsingResult = ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(progressiveParsingResult.Equals(parsingResult));
    }

    [Fact]
    public void Int()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(0);

        Assert.False(progressiveParsingResult.Equals(0));
        Assert.False(progressiveParsingResult.Equals(ParsingResults.ProgressiveParsingResult.ValidValue));
    }

    [Fact]
    public void Null()
    {
        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(0);

        Assert.False(progressiveParsingResult.Equals(null));
    }
}