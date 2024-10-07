using Agenda.Application.Commands.TelefonoCommands;
using Agenda.Application.TelefonoCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ISender _sender;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ISender sender)
        {
            _logger = logger;
            _sender = sender;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(RequestPersona persona, CancellationToken cancellationToken) 
        {
            var command = new CreatePersonaCommand(persona.name, persona.apellido, persona.fecha);
            var x = await _sender.Send(command, cancellationToken);
            return Ok(x);    
        }
    }

    public class RequestPersona
    {
        public string apellido { get; set; }
        public DateTime fecha{ get; set; }
        public string name { get; set; }

    }
}
