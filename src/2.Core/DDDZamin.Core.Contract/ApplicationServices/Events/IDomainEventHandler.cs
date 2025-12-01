using DDDZamin.Core.Domain.Events;

namespace DDDZamin.Core.Contract.ApplicationServices.Events;

public interface IDomainEventHandler<TDomainEvent> where TDomainEvent : IDomainEvent
{
    Task Handle(TDomainEvent Event);
}