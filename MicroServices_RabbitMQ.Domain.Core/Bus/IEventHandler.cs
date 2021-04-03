using MicroServices_RabbitMQ.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroServices_RabbitMQ.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : Event
    {
        Task Handle(TEvent @event);
    }
}
