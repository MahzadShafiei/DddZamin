using DDDZamin.Infra.Data.Sql.Commands;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.Domain.People.ValueObjects;
using MiniBlog.Infra.Data.Sql.Command.People;

namespace MiniBlog.Infra.Data.Sql.Command
{
    public class MiniBlogCommandDBContext : BaseCommandDbContext
    {
        public MiniBlogCommandDBContext(DbContextOptions<MiniBlogCommandDBContext> options) : base(options)
        {

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<FirstName>().HaveConversion<FirstNameConversion>();
            configurationBuilder.Properties<LastName>().HaveConversion<LastNameConversion>();
        }

        public DbSet<Person> People { get; set; }
    }

    public class BloggingContextFactory : IDesignTimeDbContextFactory<MiniBlogCommandDBContext>
    {
        public MiniBlogCommandDBContext CreateDbContext(string[] args)
        {   
            var optionsBuilder = new DbContextOptionsBuilder<MiniBlogCommandDBContext>();
            optionsBuilder.UseSqlServer("Server =.; Database=MiniBlogDb;User Id = sa;Password=sa; MultipleActiveResultSets=true; Encrypt = false");
            return new MiniBlogCommandDBContext(optionsBuilder.Options);
    }
    }
}
