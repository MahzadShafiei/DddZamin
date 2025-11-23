using DDDZamin.Core.Domain.Exceptions;
using DDDZamin.Core.Domain.ValueObjects;
using MiniBlog.Core.Domain.Resources;

namespace MiniBlog.Core.Domain.People.ValueObjects;

public class FirstName : BaseValueObject<FirstName>
{
    public static FirstName FromString(string value) => new(value);
    public string Value { get; private set; }
    public FirstName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new InvalidValueObjectStateException(MessagePattern.EmptyStringValidationMessage, nameof(FirstName));
        }
        if (value.Length < 2 || value.Length > 50)
        {
            throw new InvalidValueObjectStateException(MessagePattern.StringLengthValidationMessage, nameof(FirstName), "2", "50");
        }
        Value = value;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static explicit operator string(FirstName firstName) => firstName.Value.ToString();
    public static implicit operator FirstName(string value) => new(value);
}
