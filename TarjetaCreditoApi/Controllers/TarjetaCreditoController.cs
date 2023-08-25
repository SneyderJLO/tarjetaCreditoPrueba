using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using TarjetaCreditoApi.DatosTarjetaCredito;
using TarjetaCreditoApi.Model;
using TarjetaCreditoApi.Model.Transaccion;

namespace TarjetaCreditoApi.Controllers
{
    [ApiController]
    [Route("api/tarjetas")]
    public class TarjetaCreditoController : ControllerBase
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


        [HttpPut("actualizarCupo")]
        public async Task ActualizarCupo([FromQuery] int idTarjeta, decimal valorCompra)
        {
            var funcion = new DTarjetaCredito();
            await funcion.UpdateCupoDisponible(idTarjeta, valorCompra);

        }


        /*
         * 
         * -------- REFACTORING API --------
         * 
         */
        //[HttpGet]
        //[Route("/listarTarjetas")]
        //public async Task<ActionResult<List<MTarjeta>>> GetTarjetas([FromQuery] int id)
        //{
        //    var tarjetas = await _tarjetaService.MostrarTarjetaCliente(id);

        //    if (tarjetas == null || tarjetas.Count == 0)
        //    {
        //        return NotFound(); // Devuelve un HTTP 404 si no se encuentran tarjetas
        //    }

        //    return Ok(tarjetas); // Devuelve un HTTP 200 OK con la lista de tarjetas
        //}


    }
}
