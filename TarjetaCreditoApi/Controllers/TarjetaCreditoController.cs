using Microsoft.AspNetCore.Mvc;
using TarjetaCreditoApi.DatosTarjetaCredito;
using TarjetaCreditoApi.Model;
using TarjetaCreditoApi.Model.Transaccion;

namespace TarjetaCreditoApi.Controllers
{
    [ApiController]
    [Route("api/tarjetas")]
    public class TarjetaCreditoController
    {
        [HttpGet("tarjetas")]
        public async Task<ActionResult<List<MTarjeta>>> GetTarjetas([FromQuery] int id)
        {
            var funcion = new DTarjetaCredito();
            var lista = await funcion.mostrarTarjetaCliente(id);
            return lista;
        }

        [HttpPost("tarjeta")]
        public async Task InsertarTarjeta([FromBody] MTarjeta parametros)
        {

            var funcion = new DTarjetaCredito();
            await funcion.insertarTarjeta(parametros);

        }

        [HttpGet("transacciones")]
        public async Task<ActionResult<List<MTransaccion>>> GetTransacciones([FromQuery] int id)
        {

            var funcion = new DTransaccion();
            var lista = await funcion.mostrarTransaccionesCliente(id);
            return lista;
        }


        [HttpPost("transaccion")]

        public async Task InsertarTransaccion([FromBody] MTransaccion parametros)
        {

            var funcion = new DTransaccion();
            await funcion.insertarTransaccion(parametros);
        }


        //public async Task<ActionResult<List<MTarjeta>>> getTarjetas()
        //{
        //    var funcion = new DTarjetaCredito();
        //    var lista = await funcion.mostrarTarjetaCliente(funcion);
        //    return lista;


        //}
    }
}
