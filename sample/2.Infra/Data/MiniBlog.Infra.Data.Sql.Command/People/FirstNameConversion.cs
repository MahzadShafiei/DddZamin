using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniBlog.Core.Domain.People.ValueObjects;

namespace MiniBlog.Infra.Data.Sql.Command.People
{
    public class FirstNameConversion : ValueConverter<FirstName, string>
    {
        public FirstNameConversion() : base(c => c.Value, c => FirstName.FromString(c))
        {

        }
    }
}
