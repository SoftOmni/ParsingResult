namespace ParsingResults;

/// <summary>
///     Represents the result of a progressive parsing operation.
///
///     <para>
///         This class is used to return the result of a parsing operation that is done progressively, meaning that
///         the parsing operation is done in multiple steps and the result of each step is returned as a
///         <see cref="ProgressiveParsingResult"/> instance.
///     </para>
/// </summary>
public sealed class ProgressiveParsingResult
{
    /// <summary>
    ///     Represents the value that is returned when the parsing operation is successful.
    /// </summary>
    public const int ValidValue = -1;

    /// <summary>
    ///     The value of the parsing result.
    ///
    ///     <para>
    ///         If the parsing operation was successful, this value will be <see cref="ValidValue"/>.
    ///     </para>
    ///     <para>
    ///         If the parsing operation was unsuccessful, this value will be the index of the character that caused the
    ///         parsing operation to fail.
    ///     </para>
    ///     <para>
    ///         If the parsing operation failed for any other reason, this value will be a negative value different from
    ///         <see cref="ValidValue"/>. The meaning of this value is custom and should be defined by the user.
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         All these rules apply only if the parsing result is not a custom one. If the parsing result is a custom
    ///         one, the value can be anything and the meaning of the value should be defined by the user.
    ///     </para>
    /// </remarks>
    public int Value { get; }

    /// <summary>
    ///     The message of the parsing result if the parsing operation was unsuccessful.
    ///
    ///     <para>
    ///         If the parsing operation was successful, this value will be an empty string.
    ///     </para>
    ///     <para>
    ///         If the parsing operation was unsuccessful, this value will be a message that describes the reason of the
    ///         failure.
    ///     </para>
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         These rules apply only if the parsing result is not a custom one. If the parsing result is a custom one, the
    ///         message can be anything and the meaning of the message should be defined by the user.
    ///     </para>
    /// </remarks>
    public string Message { get; }

    /// <summary>
    ///     Indicates whether the parsing result is a custom one.
    ///
    ///     <para>
    ///         If the parsing result is a custom one, the value and the message can be anything and the meaning of the value
    ///         and the message should be defined by the user.
    ///     </para>
    /// </summary>
    private readonly bool _isCustom;

    /// <summary>
    ///     The index of the character that should be parsed next.
    ///
    ///     <para>
    ///        This index is used to indicate the position of the character that should be parsed next in the input string.
    ///     </para>
    /// </summary>
    public int NewIndex { get; }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ParsingResult"/> class with the specified value and message.
    ///
    ///     <para>
    ///         This constructor is private and should not be used directly. Use the static methods of the class to create
    ///         instances of this class.
    ///     </para>
    /// </summary>
    /// <param name="value">
    ///     The <see cref="Value"/> of the parsing result.
    ///
    ///     <para>
    ///         If the parsing operation was successful, this value should be <see cref="ValidValue"/>.
    ///     </para>
    ///     <para>
    ///         If the parsing operation was unsuccessful, this value should be the index of the character that caused the
    ///         parsing operation to fail. This value may also be a negative value different from <see cref="ValidValue"/> if
    ///         the parsing operation failed for any other reason.
    ///     </para>
    ///     <para>
    ///         If the parsing result is a custom one, this value can be anything and the meaning of the value should be
    ///         defined by the user.
    ///     </para>
    /// </param>
    /// <param name="message">
    ///     The <see cref="Message"/> of the parsing result.
    ///
    ///     <para>
    ///         If the parsing operation was successful, this value should be an empty string.
    ///         If the parsing operation was unsuccessful, this value should be a message that describes the reason of the
    ///         failure.
    ///     </para>
    ///     <para>
    ///         If the parsing result is a custom one, this value can be anything and the meaning of the message should be
    ///         defined by the user.
    ///     </para>
    /// </param>
    /// <param name="isCustom">
    ///     Indicates whether the parsing result is a custom one.
    ///
    ///     <para>
    ///         If this value is <see langword="true"/>, the parsing result is a custom one. If this value is <see langword="false"/>,
    ///         the parsing result is not a custom one.
    ///     </para>
    /// </param>
    /// <param name="newIndex">
    ///     Represents the index of the character that should be parsed next.
    ///
    ///     <para>
    ///         This index is used to indicate the position of the character that should be parsed next in the input string.
    ///     </para>
    /// </param>
    private ProgressiveParsingResult(int value, string message, int newIndex, bool isCustom = false)
    {
        Value = value;
        Message = message;
        NewIndex = newIndex;
        _isCustom = isCustom;
    }

    /// <summary>
    ///     Creates a new instance of the <see cref="ParsingResult"/> class that represents a successful parsing operation.
    ///
    ///     <para>
    ///         The <see cref="Value"/> of the parsing result will be <see cref="ValidValue"/> and the <see cref="Message"/> will be an
    ///         empty string.
    ///     </para>
    /// </summary>
    /// <param name="newIndex">
    ///     Represents the index of the character that should be parsed next.
    ///
    ///     <para>
    ///         This index is used to indicate the position of the character that should be parsed next in the input string.
    ///     </para>
    /// </param>
    /// <returns>
    ///     A new instance of the <see cref="ParsingResult"/> class that represents a successful parsing operation.
    /// </returns>
    /// <remarks>
    ///     This will not create a custom parsing result.
    /// </remarks>
    public static ProgressiveParsingResult CreateSuccess(int newIndex)
    {
        return new ProgressiveParsingResult(ValidValue, string.Empty, newIndex);
    }
    
    /// <summary>
    ///     Creates a new instance of the <see cref="ParsingResult"/> class that represents an unsuccessful parsing operation.
    ///
    ///     <para>
    ///         The <see cref="Value"/> of the parsing result will be the <paramref name="problematicIndex"/>
    ///         of the character that caused the parsing operation to
    ///         fail and the <see cref="Message"/> will be the specified <paramref name="message"/>.
    ///     </para>
    /// </summary>
    /// <param name="problematicIndex">
    ///     The index of the character that caused the parsing operation to fail.
    ///
    ///     <para>
    ///         This value should be a positive integer if the parsing operation failed because of a character in the input
    ///     </para>
    ///
    ///     <para>
    ///         If the parsing operation failed for any other reason, this value can be any negative integer different from
    ///         <see cref="ValidValue"/>. The meaning of this value should be defined by the user.
    ///     </para>
    /// </param>
    /// <param name="message">
    ///     The message that describes the reason of the failure.
    /// </param>
    /// <param name="newIndex">
    ///     Represents the index of the character that should be parsed next.
    ///
    ///     <para>
    ///         This index is used to indicate the position of the character that should be parsed next in the input string.
    ///     </para>
    ///
    ///     <para>
    ///         Since this is a failed parsing result, the value of this parameter may not be important.
    ///         It is thus optional and its default value is <c>-2</c>.
    ///     </para>
    /// </param>
    /// <returns>
    ///     A new instance of the <see cref="ParsingResult"/> class that represents an unsuccessful parsing operation.
    /// </returns>
    /// <exception cref="ValidityIndexOnFailedParsingResultException">
    ///     Thrown when the <paramref name="problematicIndex"/> is equal to <see cref="ValidValue"/>.
    /// </exception>
    /// <remarks>
    ///     This will not create a custom parsing result.
    /// </remarks>
    public static ProgressiveParsingResult CreateFailure(int problematicIndex, string message, int newIndex = -2)
    {
        if (problematicIndex == ValidValue)
        {
            throw new ValidityIndexOnFailedParsingResultException(message);
        }

        return new ProgressiveParsingResult(problematicIndex, message, newIndex);
    }

    /// <summary>
    ///     Creates a new instance of the <see cref="ParsingResult"/> class that represents a custom parsing operation.
    ///
    ///     <para>
    ///         The <see cref="Value"/> of the parsing result will be the specified <paramref name="value"/> and the
    ///         <see cref="Message"/> will be the specified <paramref name="message"/>.
    ///     </para>
    /// </summary>
    /// <param name="value">
    ///     The value of the parsing result.
    ///
    ///     <para>
    ///         This value can be anything and the meaning of the value should be defined by the user.
    ///     </para>
    /// </param>
    /// <param name="message">
    ///     The message of the parsing result.
    ///
    ///     <para>
    ///         This value can be anything and the meaning of the message should be defined by the user.
    ///     </para>
    /// </param>
    /// <param name="newIndex">
    ///     Represents the index of the character that should be parsed next.
    ///
    ///     <para>
    ///         This index is used to indicate the position of the character that should be parsed next in the input string.
    ///     </para>
    /// </param>
    /// <returns>
    ///     A new instance of the <see cref="ParsingResult"/> class that represents a custom parsing operation.
    /// </returns>
    /// <remarks>
    ///     This will create a custom parsing result.
    /// </remarks>
    public static ProgressiveParsingResult CreateCustom(int value, string message, int newIndex)
    {
        return new ProgressiveParsingResult(value, message, newIndex, true);
    }

    /// <summary>
    ///     Indicates whether the parsing operation was successful.
    ///
    ///     <para>
    ///         If this value is <see langword="true"/>, the parsing operation was successful.
    ///         If this value is <see langword="false"/>, the parsing operation was unsuccessful.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the parsing operation was successful; otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    ///     If the parsing result is a custom one, this property will always return <see langword="false"/>.
    /// </remarks>
    public bool IsSuccess => Value == ValidValue && !_isCustom;

    /// <summary>
    ///     Indicates whether the parsing operation was unsuccessful.
    ///
    ///     <para>
    ///         If this value is <see langword="true"/>, the parsing operation was unsuccessful.
    ///         If this value is <see langword="false"/>, the parsing operation was successful.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the parsing operation was unsuccessful; otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    ///     If the parsing result is a custom one, this property will always return <see langword="false"/>.
    /// </remarks>
    public bool IsFailure => Value != ValidValue && !_isCustom;

    /// <summary>
    ///     Indicates whether the parsing result is a custom one.
    ///
    ///     <para>
    ///         If this value is <see langword="true"/>, the parsing result is a custom one.
    ///         If this value is <see langword="false"/>, the parsing result is not a custom one.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     <see langword="true"/> if the parsing result is a custom one; otherwise, <see langword="false"/>.
    /// </returns>
    public bool IsCustom => _isCustom;

    /// <summary>
    ///     Determines whether two <see cref="ProgressiveParsingResult"/> instances are equal.
    ///
    ///     <para>
    ///         Two <see cref="ProgressiveParsingResult"/> instances are considered equal if their <see cref="Value"/>, 
    ///         <see cref="Message"/> properties are equal and if they are both custom parsing results or not.
    ///     </para>
    ///
    ///     <para>
    ///         Additionally, the <see cref="NewIndex"/> property is also compared to determine the equality of the two
    ///         instances. Two <see cref="ProgressiveParsingResult"/> instances are considered equal if their
    ///         <see cref="NewIndex"/> properties are equal.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The first <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The second <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///    <see langword="true"/> if the two <see cref="ProgressiveParsingResult"/> instances are equal;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(ProgressiveParsingResult left, ProgressiveParsingResult right)
    {
        return left.Value == right.Value
               && left._isCustom == right._isCustom
               && left.NewIndex == right.NewIndex
               && left.Message == right.Message;
    }

    /// <summary>
    ///     Determines whether two <see cref="ProgressiveParsingResult"/> instances are not equal.
    ///
    ///     <para>
    ///         Two <see cref="ProgressiveParsingResult"/> instances are considered not equal if their <see cref="Value"/>,
    ///         <see cref="Message"/> properties are not equal or if they are both custom parsing results or not.
    ///     </para>
    ///
    ///     <para>
    ///         Additionally, the <see cref="NewIndex"/> property is also compared to determine the inequality of the two
    ///         instances. Two <see cref="ProgressiveParsingResult"/> instances are considered not equal if their
    ///         <see cref="NewIndex"/> properties are not equal.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The first <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The second <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///    <see langword="true"/> if the two <see cref="ProgressiveParsingResult"/> instances are not equal;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(ProgressiveParsingResult left, ProgressiveParsingResult right)
    {
        return !(left == right);
    }
    
    /// <summary>
    ///     Determines whether a <see cref="ProgressiveParsingResult"/> instance is equal to a string.
    ///
    ///     <para>
    ///         A <see cref="ProgressiveParsingResult"/> instance is considered equal to a string if its <see cref="Message"/>
    ///         property is equal to the string.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The string to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///    <see langword="true"/> if the <see cref="ProgressiveParsingResult"/> instance is equal to the string;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(ProgressiveParsingResult left, string right)
    {
        return left.Message == right;
    }

    /// <summary>
    ///     Determines whether a <see cref="ProgressiveParsingResult"/> instance is not equal to a string.
    ///
    ///     <para>
    ///         A <see cref="ProgressiveParsingResult"/> instance is considered not equal to a string if its <see cref="Message"/>
    ///         property is not equal to the string.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The string to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///    <see langword="true"/> if the <see cref="ProgressiveParsingResult"/> instance is not equal to the string;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(ProgressiveParsingResult left, string right)
    {
        return !(left == right);
    }

    /// <summary>
    ///     Determines whether a <see cref="ProgressiveParsingResult"/> instance is equal to a string.
    ///
    ///     <para>
    ///         A <see cref="ProgressiveParsingResult"/> instance is considered equal to a string if its <see cref="Message"/>
    ///         property is equal to the string.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The string to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///    <see langword="true"/> if the <see cref="ProgressiveParsingResult"/> instance is equal to the string;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(string left, ProgressiveParsingResult right)
    {
        return right.Message == left;
    }

    /// <summary>
    ///     Determines whether a <see cref="ProgressiveParsingResult"/> instance is not equal to a string.
    /// 
    ///     <para>
    ///         A <see cref="ProgressiveParsingResult"/> instance is considered not equal to a string if its <see cref="Message"/>
    ///         property is not equal to the string.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The string to compare.
    ///     This is the right operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="ProgressiveParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <returns>
    ///    <see langword="true"/> if the <see cref="ProgressiveParsingResult"/> instance is not equal to the string;
    ///     otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(string left, ProgressiveParsingResult right)
    {
        return !(left == right);
    }
    
    /// <summary>
    ///     Determines whether the specified object is equal to the current <see cref="ProgressiveParsingResult"/> instance.
    ///     Depending on the type of the object, the comparison will be done as follows:
    ///
    ///     <list type="bullet">
    ///         <item>
    ///             <description>
    ///                 If the object is a <see cref="ProgressiveParsingResult"/> instance, the comparison will be done by comparing the
    ///                 <see cref="Value"/>, <see cref="Message"/> and <see cref="IsCustom"/> properties of the
    ///                 <see cref="ProgressiveParsingResult"/> instance with the current instance.
    ///                 If all these values are equal, the two instances are considered equal.
    ///                 If any of these values are not equal, the two instances are considered not equal.
    ///             </description>
    ///         </item>
    ///         <item>
    ///             <description>
    ///                 If the object is a <see cref="string"/> instance, the comparison will be done by comparing the
    ///                 <see cref="Message"/> property of the <see cref="ProgressiveParsingResult"/> instance with the <see cref="string"/>
    ///                 instance.
    ///                 If these values are equal, the two instances are considered equal.
    ///                 If these values are not equal, the two instances are considered not equal.
    ///             </description>
    ///         </item>
    ///         <item>
    ///             <description>
    ///                 In all other cases, the two instances are considered not equal.
    ///                 This includes the case where the object is <see langword="null"/>.
    ///                 This also includes the case where the object is a <see cref="ParsingResult"/>
    ///                 instance or any other type of object.
    ///             </description>
    ///         </item>
    ///     </list>
    /// </summary>
    /// <param name="obj">
    ///     The object to compare with the current <see cref="ProgressiveParsingResult"/> instance.
    ///     This is the object to compare.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the specified object is equal to the current <see cref="ProgressiveParsingResult"/> instance;
    ///     <see langword="false"/> otherwise.
    ///
    ///     <para>
    ///         For the comparison rules, see the method summary.
    ///     </para>
    /// </returns>
    /// <remarks>
    ///     Unlike the <see cref="ParsingResult.Equals(object)"/> class,
    ///     an object of type <see cref="int"/> is not considered equal to the current <see cref="ProgressiveParsingResult"/> instance.
    ///
    ///     <para>
    ///         This is because there are two properties of the <see cref="ProgressiveParsingResult"/> class which are of type
    ///         <see cref="int"/>: the <see cref="Value"/> and the <see cref="NewIndex"/> properties.
    ///     </para>
    /// </remarks>
    public override bool Equals(object? obj)
    {
        return obj switch
        {
            ProgressiveParsingResult result => Value == result.Value
                                    && Message == result.Message
                                    && _isCustom == result._isCustom
                                    && NewIndex == result.NewIndex,
            string message => Message == message,
            _ => false
        };
    }

    /// <summary>
    ///     Returns the hash code for the current <see cref="ProgressiveParsingResult"/> instance.
    /// </summary>
    /// <returns>
    ///     A 32-bit signed integer hash code.
    /// </returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Message, NewIndex, _isCustom);
    }

    /// <summary>
    ///     Returns a string that represents the current <see cref="ParsingResult"/> instance.
    ///
    ///     <para>
    ///         If the parsing operation was successful, this method will return 'Successful parsing result with new index {NewIndex}'.
    ///     </para>
    ///     <para>
    ///         If the parsing operation was unsuccessful, this method will return 'Failed parsing result at index {Value} in
    ///         "{Message} \nNew index: {NewIndex}"'.
    ///     </para>
    ///     <para>
    ///         If the parsing operation was a custom one, this method will return 'Custom parsing result at index {Value} in
    ///         "{Message}" \nNew index: {NewIndex}'.
    ///     </para>
    /// </summary>
    /// <returns>
    ///     A string that represents the current <see cref="ParsingResult"/> instance.
    ///
    ///     <para>
    ///         For the specific string that will be returned, see the method summary.
    ///     </para>
    /// </returns>
    public override string ToString()
    {
        if (IsSuccess)
        {
            return $"Successful parsing result with new index {NewIndex}";
        }

        if (IsFailure)
        {
            return $"Failed parsing result at index {Value} in \"{Message}\"\nNew index: {NewIndex}";
        }
        
        return $"Custom parsing result at index {Value} in \"{Message}\"\nNew index: {NewIndex}";
    }

    /// <summary>
    ///     Converts the current <see cref="ProgressiveParsingResult"/> instance to a <see cref="ParsingResult"/> instance.
    /// </summary>
    /// <returns>
    ///     A <see cref="ParsingResult"/> instance that represents the current <see cref="ProgressiveParsingResult"/> instance.
    /// </returns>
    /// <remarks>
    ///     This method will return a <see cref="ParsingResult"/> instance with the same <see cref="Value"/> and <see cref="Message"/>
    ///     properties as the current <see cref="ProgressiveParsingResult"/> instance.
    ///
    ///     <para>
    ///         The <see cref="NewIndex"/> property of the current <see cref="ProgressiveParsingResult"/> instance will be ignored.
    ///         The <see cref="ParsingResult"/> instance will not have a new index.
    ///     </para>
    /// </remarks>
    public ParsingResult ToParsingResult()
    {
        if (_isCustom)
        {
            return ParsingResult.CreateCustom(Value, Message);
        }

        if (IsSuccess)
        {
            return ParsingResult.CreateSuccess();
        }
        
        return ParsingResult.CreateFailure(Value, Message);
    }
}