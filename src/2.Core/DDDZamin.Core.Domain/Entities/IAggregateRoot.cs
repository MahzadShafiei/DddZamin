using DDDZamin.Core.Domain.Events;

namespace DDDZamin.Core.Domain.Entities;

internal interface IAggregateRoot
{
    void ClearEvents();
    IEnumerable<IDomainEvent> GetEvents();   
}
