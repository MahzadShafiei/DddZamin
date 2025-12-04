using DDDZamin.Core.ApplicationServices.Commands;
using DDDZamin.Core.RequestResponse.Commands;
using DDDZamin.Utilities;
using MiniBlog.Core.Contract.People.Commands;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.RequestResponse.People.Commands.ChangeName;

namespace MiniBlog.Core.ApplicationServices.People.Commands.ChangeName
{
    public class ChangePersonNameHandler: CommandHandler<ChangePersonName, int>
    {
        private readonly IPersonCommandRepository repository;
        public ChangePersonNameHandler(ZaminServices zaminServices, IPersonCommandRepository repository): base(zaminServices)
        {
            this.repository = repository;            
        }

        public override async Task<CommandResult<int>> Handle(ChangePersonName command)
        {
            Person person = repository.GetGraph(command.Id);
            person.ChangeFirstName(command.FirstName);            
            await repository.CommitAsync();
            return await OkAsync(person.Id);
        }
    }
}
