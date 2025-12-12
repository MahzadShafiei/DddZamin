using DDDZamin.Core.Domain.Entities;
using DDDZamin.Core.Domain.Exceptions;
using MiniBlog.Core.Domain.People.DomainEvents;
using MiniBlog.Core.Domain.People.ValueObjects;
using MiniBlog.Core.Domain.Resources;

namespace MiniBlog.Core.Domain.People.Entities;

public class Person : AggregateRoot<int>
{
    #region Properties
    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    #endregion

    private Person()
    {
        
    }

    public Person(int id,  string firstName, string lastName)
    {
        if (id < 0)
        {
            throw new InvalidEntityStateException(MessagePattern.IdValidationMessage);
        }        
        FirstName = firstName;
        LastName = lastName;

        AddEvent(new PersonCreated(id, BusinessId.Value, firstName, lastName));
    }

    public void ChangeFirstName(string firstName)
    { 
        this.FirstName = firstName;
        AddEvent(new PersonNameChanged(Id, firstName));
    }
}
