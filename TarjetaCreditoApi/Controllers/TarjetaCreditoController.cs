using Microsoft.AspNetCore.Mvc;
using TarjetaCreditoApi.Model;

namespace TarjetaCreditoApi.Controllers
{
    [ApiController]
    [Route("api/tarjetas")]
    public class TarjetaCreditoController
    {
        [HttpGet]
        public async Task<ActionResult<List<MTarjeta>>> getTarjetas()
        {


        }
    }
}
