using MediatR;
using Microsoft.Extensions.Logging;
using ModularMonolithModulesMessaging.Shared.DomainEvents;

namespace SomeModuleTwo.Consumers
{
    public class NotifyManyModulesDomainEventConsumer : INotificationHandler<NotifyManyModulesDomainEvent>
    {
        private readonly ILogger<NotifyManyModulesDomainEventConsumer> _logger;

        public NotifyManyModulesDomainEventConsumer(ILogger<NotifyManyModulesDomainEventConsumer> logger)
        {
            _logger = logger;
        }

        public Task Handle(NotifyManyModulesDomainEvent request, CancellationToken cancellationToken)
        {
            _logger.LogCritical($"{nameof(NotifyManyModulesDomainEventConsumer)} in module two had received message of {request.Message}");
            return Task.CompletedTask;
        }
    }
}
