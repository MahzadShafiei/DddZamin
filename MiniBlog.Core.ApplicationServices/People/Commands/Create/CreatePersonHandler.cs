using DDDZamin.Core.ApplicationServices.Commands;
using DDDZamin.Core.RequestResponse.Commands;
using DDDZamin.Utilities;
using MiniBlog.Core.Contract.People.Commands;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.RequestResponse.People.Commands.Create;

namespace MiniBlog.Core.ApplicationServices.People.Commands.Create
{
    public class CreatePersonHandler: CommandHandler<CreatePerson, int>
    {
        private readonly IPersonCommandRepository repository;
        public CreatePersonHandler(ZaminServices zaminServices, IPersonCommandRepository repository): base(zaminServices)
        {
            this.repository = repository;            
        }

        public override async Task<CommandResult<int>> Handle(CreatePerson command)
        {
            Person person = new Person(command.Id, command.FirstName, command.LastName);
            repository.Insert(person);
            await repository.CommitAsync();
            return await OkAsync(person.Id);
        }
    }
}
