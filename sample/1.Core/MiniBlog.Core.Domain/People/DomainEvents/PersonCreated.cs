using DDDZamin.Core.Domain.Events;

namespace MiniBlog.Core.Domain.People.DomainEvents;

public record PersonCreated(int Id, Guid BusinessId, string FirstName, string LastName):IDomainEvent
{

}
