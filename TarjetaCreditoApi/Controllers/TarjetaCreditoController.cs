using Microsoft.AspNetCore.Mvc;
using TarjetaCreditoApi.DatosTarjetaCredito;
using TarjetaCreditoApi.Model;

namespace TarjetaCreditoApi.Controllers
{
    [ApiController]

    public class TarjetaCreditoController
    {
        [HttpGet]
        [Route("api/tarjetas")]
        public async Task<ActionResult<List<MTarjeta>>> GetTarjetas([FromQuery] int id)
        {
            var funcion = new DTarjetaCredito();
            var lista = await funcion.mostrarTarjetaCliente(id);
            return lista;
        }

        //public async Task<ActionResult<List<MTarjeta>>> getTarjetas()
        //{
        //    var funcion = new DTarjetaCredito();
        //    var lista = await funcion.mostrarTarjetaCliente(funcion);
        //    return lista;


        //}
    }
}
