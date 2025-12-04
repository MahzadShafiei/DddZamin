using DDDZamin.Core.Contract.Data.Commands;
using MiniBlog.Core.Domain.People.Entities;

namespace MiniBlog.Core.Contract.People.Commands
{
    public interface IPersonCommandRepository : ICommandRepository<Person, int>
    {
    }
}
