using Application2.Commands;
using Dominio2.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISender _sender;
        private HttpClient httpClient;
        public WeatherForecastController(ISender sender)
        {
            _sender = sender;
            httpClient = new HttpClient();
        }

        [HttpGet("Get1")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("PostReals")]
        public async Task<IActionResult> PostReal(RequestRegistro registro, CancellationToken cancellationToken)
        {
            var command = new AddRegistroCommand(registro.Apartamento, registro.Documento, registro.Nombre);
            var result = await _sender.Send(command, cancellationToken);
            return Ok(result);
        }

        [HttpGet("GetReals")]
        public async Task<IActionResult> GetReal(CancellationToken cancellationToken)
        {
            var command = new GetRegistroCommand();
            var result = await _sender.Send(command, cancellationToken);
            return Ok(result);
        }

        [HttpPut("PutReals")]
        public async Task<IActionResult> PutReal(int Id, RequestRegistro request, CancellationToken cancellationToken)
        {
            var command = new UpdateRegistroCommand(Id, request.Nombre, request.Apartamento, request.Documento);
            var result = await _sender.Send(command, cancellationToken);
            return Ok(result);
        }



        [HttpDelete("DeleteReals")]
        public async Task<IActionResult> DeleteReal(int Id, CancellationToken cancellationToken)
        {
            var command = new DeleteRegistroCommand(Id);
            await _sender.Send(command, cancellationToken);
            return Ok();
        }

        [HttpDelete("DeleteWithSelectReals")]
        public async Task<IActionResult> DeleteWithSelect(int Id, CancellationToken cancellationToken)
        {
            var ser = JsonConvert.SerializeObject(new RequestRegistro("1","1","1") );
            var dfdg = new StringContent(ser, Encoding.UTF8, "application/json");
            var post = await httpClient.PostAsync("https://localhost:7234/WeatherForecast/PostReals", dfdg, CancellationToken.None);
            //var put = await httpClient.PutAsync("https://localhost:7234/WeatherForecast/GetReals", new StringContent(ser));

            var get = await httpClient.GetAsync("https://localhost:7234/WeatherForecast/GetReals");
            var x = await get.Content.ReadAsStringAsync();
            var jj  = JsonConvert.DeserializeObject<List<Registro>>(x);
            return Ok(jj);
        }
    }
}
