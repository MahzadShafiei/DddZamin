using DDDZamin.Infra.Data.Sql.Commands;
using MiniBlog.Core.Contract.People.Commands;
using MiniBlog.Core.Domain.People.Entities;

namespace MiniBlog.Infra.Data.Sql.Command.People
{
    internal class PersonCommandRepository: BaseCommandRepository<Person,MiniBlogCommandDBContext, int>, IPersonCommandRepository
    {
        public PersonCommandRepository(MiniBlogCommandDBContext dBContext): base(dBContext)
        {
            
        }
    }
}
