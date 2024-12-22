namespace SoftOmni.ParsingResults;

/// <summary>
///     An exception that is thrown when a failed ParsingResult instance is created with a problematic index value
///     that is equal to the validity value <see cref="ParsingResult.ValidValue"/>.
///
///     <para>
///         This is not allowed because the validity value is reserved for successful ParsingResult instances.
///     </para>
/// </summary>
/// <param name="message">
///     The message that was passed to the <see cref="ParsingResult.CreateFailure(int, string)"/> method.
/// </param>
/// <remarks>
///     This message is only thrown for non-custom failed ParsingResult instances.
/// </remarks>
public class ValidityIndexOnFailedParsingResultException(string message) : ArgumentException(
    "ERROR: ValidityIndexOnFailedParsingResultException: in the creation of a failed ParsingResult instance" +
    " (through the ParsingResult.CreateFailure(int problematicIndex, string message) method), you passed a problematic index value" +
    $" which is equal to the validity value {ParsingResult.ValidValue} but this is not allowed.\n" +
    $"The message you passed was the following: \n\"{message}\"");