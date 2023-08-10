using Microsoft.AspNetCore.Mvc;
using TarjetaCreditoApi.DatosTarjetaCredito;
using TarjetaCreditoApi.Model;

namespace TarjetaCreditoApi.Controllers
{
    [ApiController]
    [Route("api/tarjetas")]
    public class TarjetaCreditoController
    {
        [HttpGet]
        public async Task<ActionResult<List<MTarjeta>>> GetTarjetas([FromQuery] int id)
        {
            var funcion = new DTarjetaCredito();
            var lista = await funcion.mostrarTarjetaCliente(id);
            return lista;
        }

        [HttpPost]
        public async Task InsertarTarjeta([FromBody] MTarjeta parametros)
        {

            var funcion = new DTarjetaCredito();
            await funcion.insertarTarjeta(parametros);

        }

        //public async Task<ActionResult<List<MTarjeta>>> getTarjetas()
        //{
        //    var funcion = new DTarjetaCredito();
        //    var lista = await funcion.mostrarTarjetaCliente(funcion);
        //    return lista;


        //}
    }
}
