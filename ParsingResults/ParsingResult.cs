namespace ParsingResults;

/// <summary>
///     Represents the result of a parsing operation.
/// </summary>
public sealed class ParsingResult
{
    /// <summary>
    ///     The value that indicates a successful parsing operation.
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
    ///     Initializes a new instance of the <see cref="ParsingResult"/> class with the specified value and message.
    ///
    ///     <para>
    ///         This constructor is private and should not be used directly. Use the static methods of the class to create
    ///         instances of this class.
    ///     </para>
    /// </summary>
    /// <param name="returnValue">
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
    private ParsingResult(int returnValue, string message,
        bool isCustom = false)
    {
        Value = returnValue;
        Message = message;
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
    /// <returns>
    ///     A new instance of the <see cref="ParsingResult"/> class that represents a successful parsing operation.
    /// </returns>
    /// <remarks>
    ///     This will not create a custom parsing result.
    /// </remarks>
    public static ParsingResult CreateSuccess()
    {
        return new ParsingResult(ValidValue, string.Empty);
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
    /// <returns>
    ///     A new instance of the <see cref="ParsingResult"/> class that represents an unsuccessful parsing operation.
    /// </returns>
    /// <exception cref="ValidityIndexOnFailedParsingResultException">
    ///     Thrown when the <paramref name="problematicIndex"/> is equal to <see cref="ValidValue"/>.
    /// </exception>
    /// <remarks>
    ///     This will not create a custom parsing result.
    /// </remarks>
    public static ParsingResult CreateFailure(int problematicIndex,
        string message)
    {
        if (problematicIndex == ValidValue)
        {
            throw new ValidityIndexOnFailedParsingResultException(message);
        }

        return new ParsingResult(problematicIndex, message);
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
    /// <returns>
    ///     A new instance of the <see cref="ParsingResult"/> class that represents a custom parsing operation.
    /// </returns>
    /// <remarks>
    ///     This will create a custom parsing result.
    /// </remarks>
    public static ParsingResult CreateCustom(int value, string message)
    {
        return new ParsingResult(value, message, true);
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
    ///     Determines whether two <see cref="ParsingResult"/> instances are equal.
    ///
    ///     <para>
    ///         Two <see cref="ParsingResult"/> instances are considered equal if their <see cref="Value"/>, 
    ///         <see cref="Message"/> properties are equal and if they are both custom parsing results or not.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The first <see cref="ParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The second <see cref="ParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///    <see langword="true"/> if the two <see cref="ParsingResult"/> instances are equal; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator ==(ParsingResult left, ParsingResult right)
    {
        return left.Value == right.Value
               && left._isCustom == right._isCustom
               && left.Message == right.Message;
    }

    /// <summary>
    ///     Determines whether two <see cref="ParsingResult"/> instances are not equal.
    ///
    ///     <para>
    ///         Two <see cref="ParsingResult"/> instances are considered not equal if their <see cref="Value"/>,
    ///         <see cref="Message"/> properties are not equal or if one is a custom parsing result and the other is not.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The first <see cref="ParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The second <see cref="ParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the two <see cref="ParsingResult"/> instances are not equal; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool operator !=(ParsingResult left, ParsingResult right)
    {
        return !(left == right);
    }

    /// <summary>
    ///     Determines whether a <see cref="ParsingResult"/> instance is equal to a <see cref="string"/> instance.
    ///
    ///     <para>
    ///         A <see cref="ParsingResult"/> instance is considered equal to a <see cref="string"/> instance if the
    ///         <see cref="Message"/> property of the <see cref="ParsingResult"/> instance is equal to the <see cref="string"/>
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="ParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="string"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="ParsingResult"/> instance is equal to the <see cref="string"/> instance;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator ==(ParsingResult left, string right)
    {
        return left.Message == right;
    }

    /// <summary>
    ///     Determines whether a <see cref="ParsingResult"/> instance is not equal to a <see cref="string"/> instance.
    ///
    ///     <para>
    ///         A <see cref="ParsingResult"/> instance is considered not equal to a <see cref="string"/> instance if the
    ///         <see cref="Message"/> property of the <see cref="ParsingResult"/> instance is not equal to the <see cref="string"/>
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="ParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="string"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="ParsingResult"/> instance is not equal to the <see cref="string"/> instance;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator !=(ParsingResult left, string right)
    {
        return !(left == right);
    }

    /// <summary>
    ///     Determines whether a <see cref="string"/> instance is equal to a <see cref="ParsingResult"/> instance.
    ///
    ///     <para>
    ///         A <see cref="string"/> instance is considered equal to a <see cref="ParsingResult"/> instance if the
    ///         <see cref="Message"/> property of the <see cref="ParsingResult"/> instance is equal to the <see cref="string"/>
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="string"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="ParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="string"/> instance is equal to the <see cref="ParsingResult"/> instance;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator ==(string left, ParsingResult right)
    {
        return right.Message == left;
    }

    /// <summary>
    ///     Determines whether a <see cref="string"/> instance is not equal to a <see cref="ParsingResult"/> instance.
    ///
    ///     <para>
    ///         A <see cref="string"/> instance is considered not equal to a <see cref="ParsingResult"/> instance if the
    ///         <see cref="Message"/> property of the <see cref="ParsingResult"/> instance is not equal to the <see cref="string"/>
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="string"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="ParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="string"/> instance is not equal to the <see cref="ParsingResult"/> instance;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator !=(string left, ParsingResult right)
    {
        return !(left == right);
    }

    /// <summary>
    ///     Determines whether a <see cref="ParsingResult"/> instance is equal to an <see cref="int"/> value.
    ///
    ///     <para>
    ///         A <see cref="ParsingResult"/> instance is considered equal to an <see cref="int"/> value if the
    ///         <see cref="Value"/> property of the <see cref="ParsingResult"/> instance is equal to the <see cref="int"/> value.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="ParsingResult"/> instance to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="int"/> value to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="ParsingResult"/> instance is equal to the <see cref="int"/> value;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator ==(ParsingResult left, int right)
    {
        return left.Value == right;
    }

    /// <summary>
    ///     Determines whether a <see cref="ParsingResult"/> instance is not equal to an <see cref="int"/> value.
    ///
    ///     <para>
    ///         A <see cref="ParsingResult"/> instance is considered not equal to an <see cref="int"/> value if the
    ///         <see cref="Value"/> property of the <see cref="ParsingResult"/> instance is not equal to the <see cref="int"/> value.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="ParsingResult"/> instance to compare.
    /// </param>
    /// <param name="right">
    ///     The <see cref="int"/> value to compare.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="ParsingResult"/> instance is not equal to the <see cref="int"/> value;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator !=(ParsingResult left, int right)
    {
        return !(left == right);
    }

    /// <summary>
    ///     Determines whether an <see cref="int"/> value is equal to a <see cref="ParsingResult"/> instance.
    ///
    ///     <para>
    ///         An <see cref="int"/> value is considered equal to a <see cref="ParsingResult"/> instance if the
    ///         <see cref="Value"/> property of the <see cref="ParsingResult"/> instance is equal to the <see cref="int"/> value.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="int"/> value to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="ParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="int"/> value is equal to the <see cref="ParsingResult"/> instance;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator ==(int left, ParsingResult right)
    {
        return right.Value == left;
    }

    /// <summary>
    ///     Determines whether an <see cref="int"/> value is not equal to a <see cref="ParsingResult"/> instance.
    ///
    ///     <para>
    ///         An <see cref="int"/> value is considered not equal to a <see cref="ParsingResult"/> instance if the
    ///         <see cref="Value"/> property of the <see cref="ParsingResult"/> instance is not equal to the <see cref="int"/> value.
    ///     </para>
    /// </summary>
    /// <param name="left">
    ///     The <see cref="int"/> value to compare.
    ///     This is the left operand.
    /// </param>
    /// <param name="right">
    ///     The <see cref="ParsingResult"/> instance to compare.
    ///     This is the right operand.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the <see cref="int"/> value is not equal to the <see cref="ParsingResult"/> instance;
    ///     <see langword="false"/> otherwise.
    /// </returns>
    public static bool operator !=(int left, ParsingResult right)
    {
        return !(left == right);
    }

    /// <summary>
    ///     Determines whether the specified object is equal to the current <see cref="ParsingResult"/> instance.
    ///     Depending on the type of the object, the comparison will be done as follows:
    ///
    ///     <list type="bullet">
    ///         <item>
    ///             <description>
    ///                 If the object is a <see cref="ParsingResult"/> instance, the comparison will be done by comparing the
    ///                 <see cref="Value"/>, <see cref="Message"/> and <see cref="IsCustom"/> properties of the
    ///                 <see cref="ParsingResult"/> instance with the current instance.
    ///                 If all these values are equal, the two instances are considered equal.
    ///                 If any of these values are not equal, the two instances are considered not equal.
    ///             </description>
    ///         </item>
    ///         <item>
    ///             <description>
    ///                 If the object is a <see cref="string"/> instance, the comparison will be done by comparing the
    ///                 <see cref="Message"/> property of the <see cref="ParsingResult"/> instance with the <see cref="string"/>
    ///                 instance.
    ///                 If these values are equal, the two instances are considered equal.
    ///                 If these values are not equal, the two instances are considered not equal.
    ///             </description>
    ///         </item>
    ///         <item>
    ///             <description>
    ///                 If the object is an <see cref="int"/> value, the comparison will be done by comparing the
    ///                 <see cref="Value"/> property of the <see cref="ParsingResult"/> instance with the <see cref="int"/> value.
    ///                 If these values are equal, the two instances are considered equal.
    ///                 If these values are not equal, the two instances are considered not equal.
    ///             </description>
    ///         </item>
    ///         <item>
    ///             <description>
    ///                 In all other cases, the two instances are considered not equal.
    ///                 This includes the case where the object is <see langword="null"/>.
    ///                 This also includes the case where the object is a <see cref="ProgressiveParsingResult"/>
    ///                 instance or any other type of object.
    ///             </description>
    ///         </item>
    ///     </list>
    /// </summary>
    /// <param name="obj">
    ///     The object to compare with the current <see cref="ParsingResult"/> instance.
    ///     This is the object to compare.
    /// </param>
    /// <returns>
    ///     <see langword="true"/> if the specified object is equal to the current <see cref="ParsingResult"/> instance;
    ///     <see langword="false"/> otherwise.
    ///
    ///     <para>
    ///         For the comparison rules, see the method summary.
    ///     </para>
    /// </returns>
    public override bool Equals(object? obj)
    {
        return obj switch
        {
            ParsingResult result => Value == result.Value
                                    && Message == result.Message
                                    && _isCustom == result._isCustom,
            string message => Message == message,
            int value => Value == value,
            _ => false
        };
    }

    /// <summary>
    ///     Returns the hash code for the current <see cref="ParsingResult"/> instance.
    /// </summary>
    /// <returns>
    ///     A 32-bit signed integer hash code.
    /// </returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Message);
    }

    /// <summary>
    ///     Returns a string that represents the current <see cref="ParsingResult"/> instance.
    ///
    ///     <para>
    ///         If the parsing operation was successful, this method will return 'Successful parsing result'.
    ///     </para>
    ///     <para>
    ///         If the parsing operation was unsuccessful, this method will return 'Failed parsing result at index {Value} in
    ///         "{Message}"'.
    ///     </para>
    ///     <para>
    ///         If the parsing operation was a custom one, this method will return 'Custom parsing result at index {Value} in
    ///         "{Message}"'.
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
            return "Successful parsing result";
        }

        if (IsFailure)
        {
            return $"Failed parsing result at index {Value} in \"{Message}\"";
        }

        return $"Custom parsing result at index {Value} in \"{Message}\"";
    }

    /// <summary>
    ///     Converts the current <see cref="ParsingResult"/> instance to a <see cref="ProgressiveParsingResult"/> instance.
    ///
    ///     <para>
    ///         The <see cref="ProgressiveParsingResult"/> instance will have the same <see cref="Value"/>, <see cref="Message"/>
    ///         and <see cref="IsCustom"/> properties as the current <see cref="ParsingResult"/> instance.
    ///     </para>
    ///
    ///     <para>
    ///         The <see cref="ProgressiveParsingResult.NewIndex"/> property of the <see cref="ProgressiveParsingResult"/> instance will be equal to the
    ///         provided <paramref name="indexValue"/>.
    ///     </para>
    /// </summary>
    /// <param name="indexValue">
    ///     The value of the <see cref="ProgressiveParsingResult.NewIndex"/> property of the <see cref="ProgressiveParsingResult"/> instance.
    /// </param>
    /// <returns>
    ///     A new instance of the <see cref="ProgressiveParsingResult"/> class that represents the current <see cref="ParsingResult"/> instance.
    /// </returns>
    public ProgressiveParsingResult ToProgressiveParsingResult(int indexValue)
    {
        if (_isCustom)
        {
            return ProgressiveParsingResult.CreateCustom(Value, Message,
                indexValue);
        }

        if (IsSuccess)
        {
            return ProgressiveParsingResult.CreateSuccess(indexValue);
        }

        return ProgressiveParsingResult.CreateFailure(Value, Message,
            indexValue);
    }
}