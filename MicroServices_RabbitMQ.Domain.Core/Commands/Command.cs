using MicroServices_RabbitMQ.Domain.Core.Events;
using System;

namespace MicroServices_RabbitMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }
        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
