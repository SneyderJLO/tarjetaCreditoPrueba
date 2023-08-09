using System.Data;
using System.Data.SqlClient;
using TarjetaCreditoApi.Conexion;
using TarjetaCreditoApi.Model;
namespace TarjetaCreditoApi.DatosTarjetaCredito
{
    public class DTarjetaCredito
    {
        ConexionDB conexion = new ConexionDB();
        public async Task<List<MTarjeta>> mostrarTarjetaCliente(int id)
        {
            var listTarjetas = new List<MTarjeta>();
            using (var sql = new SqlConnection(conexion.ConexionSQLSERVER()))
            {

                //cambiar por el sp
                using (var cmd = new SqlCommand("sp_datosCliente", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", id);


                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var tarjetas = new MTarjeta();

                            tarjetas.idCliente = (int)item["idCliente"];
                            tarjetas.idTarjeta = (int)item["idTarjeta"];
                            tarjetas.numeroTarjeta = (string)item["numeroTarjeta"];
                            tarjetas.fechaexpira = (DateTime)item["fechaexpira"];
                            tarjetas.cvv = (int)item["cvv"];
                            tarjetas.cupoAutorizado = (decimal)item["cupoAutorizado"];
                            tarjetas.cupoUtilizado = (decimal)item["cupoUtilizado"];
                            tarjetas.cupoDisponible = (decimal)item["cupoDisponible"];
                            listTarjetas.Add(tarjetas);
                        }
                    }
                }



            }

            return listTarjetas;
        }
    }
}
