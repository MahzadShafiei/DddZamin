using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DDDZamin.Core.Domain.Toolkits.ValueObjects;

namespace DDDZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class DescriptionConversion : ValueConverter<Description, string>
    {
        public DescriptionConversion() : base(c => c.Value, c => Description.FromString(c))
        {

        }
    }
}
