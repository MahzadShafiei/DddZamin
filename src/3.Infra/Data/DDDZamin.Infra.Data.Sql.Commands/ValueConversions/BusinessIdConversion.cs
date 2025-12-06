using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DDDZamin.Core.Domain.ValueObjects;

namespace DDDZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class BusinessIdConversion : ValueConverter<BusinessId, Guid>
    {
        public BusinessIdConversion() : base(c => c.Value, c => BusinessId.FromGuid(c))
        {

        }
    }
}
