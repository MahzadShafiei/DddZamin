using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace MiniBlog.Infra.Data.Sql.Queries
{
    public class MiniBlogQueyDBContext : BaseQueryDbContext
    {
        public MiniBlogQueyDBContext(DbContextOptions<MiniBlogQueyDBContext> options) : base(options)
        {
        }
    }
}
