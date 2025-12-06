using MiniBlog.Core.Contract.People.Queries;
using Zamin.Infra.Data.Sql.Queries;

namespace MiniBlog.Infra.Data.Sql.Queries.People
{
    internal class PersonQueryRepository : BaseQueryRepository<MiniBlogQueyDBContext>, IPersonQueryRepository
    {
        public PersonQueryRepository(MiniBlogQueyDBContext dbContext) : base(dbContext)
        {
        }
    }
}
