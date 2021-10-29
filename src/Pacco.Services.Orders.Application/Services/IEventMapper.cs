using System.Collections.Generic;
using Convey.CQRS.Events;
using Pacco.Services.Orders.Core;

namespace Pacco.Services.Orders.Application.Services
{
    public interface IEventMapper
    {
        IEvent Map(IDomainEvent @event);
        IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events);
    }
}