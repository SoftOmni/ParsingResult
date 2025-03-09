// ReSharper disable SuspiciousTypeConversion.Global

namespace SoftOmni.Parsing.Commons.ParsingResults.Tests.ParsingResult.Equals;

public class Other
{
    [Fact]
    public void ProgressiveParsingResult()
    {
        ParsingResults.ParsingResult parsingResult = ParsingResults.ParsingResult.CreateSuccess();

        ParsingResults.ProgressiveParsingResult progressiveParsingResult =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(0);

        Assert.False(parsingResult.Equals(progressiveParsingResult));
    }

    [Fact]
    public void Null()
    {
        ParsingResults.ParsingResult parsingResult = ParsingResults.ParsingResult.CreateSuccess();

        Assert.False(parsingResult.Equals(null));
    }
}