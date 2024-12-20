namespace ParsingResults.Tests.ProgressiveParsingResult.Equals;

public class ProgressiveParsingResult
{
    private const string ErrorMessage = "ERROR: this isn't right";

    private static readonly string EmptyMessage = string.Empty;

    private const int FailedIndex = 5;

    private const int NegativeIndex = -87;

    private const int TestZero = 0;

    private const int TestOne = 1;

    private const int TestNegativeOne = -1;

    [Fact]
    public void Success_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Success_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Success_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }*/

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }*/

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Success_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    /*[Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestZero_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Success_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateSuccess(NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }*/

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    /*[Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Failure_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateFailure(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }*/

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, ErrorMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithNegativeIndex_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(NegativeIndex, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestZero_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestZero, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestOne, EmptyMessage, NegativeIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_FailedIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, FailedIndex);

        Assert.False(left.Equals(right));
        Assert.False(right.Equals(left));
    }

    [Fact]
    public void
        Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex_And_Custom_WithTestNegativeOne_AndEmptyMessage_NegativeIndex()
    {
        ParsingResults.ProgressiveParsingResult left =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);
        ParsingResults.ProgressiveParsingResult right =
            ParsingResults.ProgressiveParsingResult.CreateCustom(TestNegativeOne, EmptyMessage, NegativeIndex);

        Assert.True(left.Equals(right));
        Assert.True(right.Equals(left));
    }
}