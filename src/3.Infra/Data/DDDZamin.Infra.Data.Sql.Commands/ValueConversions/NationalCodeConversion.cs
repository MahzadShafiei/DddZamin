using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DDDZamin.Core.Domain.Toolkits.ValueObjects;

namespace DDDZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class NationalCodeConversion : ValueConverter<NationalCode, string>
    {
        public NationalCodeConversion() : base(c => c.Value, c => NationalCode.FromString(c))
        {

        }
    }
}
