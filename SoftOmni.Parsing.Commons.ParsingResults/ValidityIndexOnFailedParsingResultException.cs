namespace SoftOmni.Parsing.Commons.ParsingResults;

/// <summary>
///     An exception that is thrown when a failed <see cref="ParsingResult"/>
///     or <see cref="ProgressiveParsingResult"/> instance is created with a problematic index value
///     that is equal to the validity value <see cref="ParsingResult.ValidValue"/> or <see cref="ProgressiveParsingResult.ValidValue"/>.
/// 
///     <para>
///         This is not allowed because the validity value is reserved for successful <see cref="ParsingResult"/> and
///         <see cref="ProgressiveParsingResult"/> instances
///         (custom instances may use this value without any issues though).
///     </para>
/// </summary>
/// <remarks>
///     This message is only thrown for non-custom failed <see cref="ParsingResult"/> and
///     <see cref="ProgressiveParsingResult"/> instances.
/// </remarks>
public sealed class ValidityIndexOnFailedParsingResultException : ArgumentException
{
    /// <summary>
    ///     Creates a new instance of the <see cref="ValidityIndexOnFailedParsingResultException"/> exception.
    ///
    ///     <para>
    ///          The message provided to this constructor is the message that was passed to the
    ///          <see cref="ParsingResult.CreateFailure"/> or <see cref="ProgressiveParsingResult.CreateFailure"/>
    ///          method so that the user can understand the context of the exception.
    ///      </para>
    ///
    ///      <para>
    ///          As this exception is thrown only for non-custom failed <see cref="ParsingResult"/> and
    ///          <see cref="ProgressiveParsingResult"/> instances,
    ///          the constructor's visibility is set to internal to prevent the user from creating instances of this exception
    ///          manually.
    ///      </para>
    /// </summary>
    /// <param name="message">
    ///     The message that was passed to the <see cref="ParsingResult.CreateFailure(int, string)"/> or
    ///     <see cref="ProgressiveParsingResult.CreateFailure"/> method.
    /// </param>
    /// <remarks>
    ///     This message is only thrown for non-custom failed ParsingResult instances.
    /// </remarks>
    internal ValidityIndexOnFailedParsingResultException(string message) : base(
        "ERROR: ValidityIndexOnFailedParsingResultException: in the creation of a failed ParsingResult " +
        "or ProgressiveParsingInstance instance" +
        " (through the ParsingResult.CreateFailure(int problematicIndex, string message) method), you passed a problematic index value" +
        $" which is equal to the validity value {ParsingResult.ValidValue} but this is not allowed.\n" +
        $"The message you passed was the following: \n\"{message}\"")
    { }
}