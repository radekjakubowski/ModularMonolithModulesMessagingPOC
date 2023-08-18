using MediatR;
using Microsoft.AspNetCore.Mvc;
using ModularMonolithModulesMessaging.Shared.DomainEvents;

namespace ModularMonolithModulesMessagingPOC.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TriggerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TriggerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> TriggerIntermodularMessage()
        {
            await _mediator.Publish(new NotifyManyModulesDomainEvent("Lol"));
            return Ok();
        }
    }
}