using MediatR;

namespace ModularMonolithModulesMessaging.Shared.DomainEvents
{
    public class NotifyManyModulesDomainEvent : INotification
    {
        public string Message { get; set; } = string.Empty;

        public NotifyManyModulesDomainEvent(string message)
        {
            Message = message;
        }
    }
}
