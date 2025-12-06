using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DDDZamin.Core.Domain.Toolkits.ValueObjects;

namespace DDDZamin.Infra.Data.Sql.Commands.ValueConversions
{
    public class TitleConversion : ValueConverter<Title, string>
    {
        public TitleConversion() : base(c => c.Value, c => Title.FromString(c))
        {

        }
    }
}
