using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModeloApiRestFull.Controllers
{
    [Route("Monitoramento")]
    [ApiController]
    public class MonitoramentoController : ControllerBase
    {
        [HttpGet, Route("Auth"), Authorize]
        public IActionResult Auth()
        {
            return Ok("Ok");
        }

        [HttpGet]
        public IActionResult Monitoramento()
        {
            return Ok("MonitoramentoOK");
        }
    }
}