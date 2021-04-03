using MicroServices_RabbitMQ.Domain.Core.Bus;
using MicroServices_RabbitMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroServices_RabbitMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
