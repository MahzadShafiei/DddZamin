using DDDZamin.Core.Domain.Exceptions;
using DDDZamin.Core.Domain.ValueObjects;
using MiniBlog.Core.Domain.Resources;

namespace MiniBlog.Core.Domain.People.ValueObjects;

public class LastName : BaseValueObject<LastName>
{
    public static LastName FromString(string value) => new(value);
    public string Value { get; private set; }
    public LastName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new InvalidValueObjectStateException(MessagePattern.EmptyStringValidationMessage, nameof(LastName));
        }
        if (value.Length < 2 || value.Length > 50)
        {
            throw new InvalidValueObjectStateException(MessagePattern.StringLengthValidationMessage, nameof(LastName), "2", "50");
        }
        Value = value;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static explicit operator string(LastName lastName) => lastName.Value.ToString();
    public static implicit operator LastName(string value) => new(value);
}
