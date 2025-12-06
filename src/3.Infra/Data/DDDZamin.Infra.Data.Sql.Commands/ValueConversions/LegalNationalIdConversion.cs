using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DDDZamin.Core.Domain.Toolkits.ValueObjects;

namespace DDDZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class LegalNationalIdConversion : ValueConverter<LegalNationalId, string>
    {
        public LegalNationalIdConversion() : base(c => c.Value, c => LegalNationalId.FromString(c))
        {

        }
    }
}
