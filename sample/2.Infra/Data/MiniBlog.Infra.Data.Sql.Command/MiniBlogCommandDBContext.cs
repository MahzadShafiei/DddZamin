using DDDZamin.Infra.Data.Sql.Commands;
using Microsoft.EntityFrameworkCore;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.Domain.People.ValueObjects;
using MiniBlog.Infra.Data.Sql.Command.People;

namespace MiniBlog.Infra.Data.Sql.Command
{
    public class MiniBlogCommandDBContext: BaseCommandDbContext
    {
        public MiniBlogCommandDBContext(DbContextOptions options): base(options)
        {
            
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<FirstName>().HaveConversion<FirstNameConversion>();
            configurationBuilder.Properties<LastName>().HaveConversion<LastNameConversion>();
        }

        public DbSet<Person> MyProperty { get; set; }
    }
}
