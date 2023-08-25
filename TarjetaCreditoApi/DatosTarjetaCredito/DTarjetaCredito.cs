using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        public async Task insertarTarjeta(MTarjeta parametros)
        {
            using (var sql = new SqlConnection(conexion.ConexionSQLSERVER()))
            {
                using (var cmd = new SqlCommand("sp_insertarTarjeta", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", parametros.idCliente);
                    //cmd.Parameters.AddWithValue("@idTarjeta", parametros.idTarjeta);
                    cmd.Parameters.AddWithValue("@numeroTarjeta", parametros.numeroTarjeta);
                    cmd.Parameters.AddWithValue("@fechaexpira", parametros.fechaexpira);
                    cmd.Parameters.AddWithValue("@cvv", parametros.cvv);
                    cmd.Parameters.AddWithValue("@cupoAutorizado", parametros.cupoAutorizado);
                    cmd.Parameters.AddWithValue("@cupoUtilizado", parametros.cupoUtilizado);
                    cmd.Parameters.AddWithValue("@cupoDisponible", parametros.cupoDisponible);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task UpdateCupoDisponible(int idTarjeta, decimal valorCompra)
        {
            using (var sql = new SqlConnection(conexion.ConexionSQLSERVER()))
            {
                using (SqlCommand command = new SqlCommand("UpdateCupoDisponible", sql))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agrega el parámetro @id al comando
                    command.Parameters.AddWithValue("@valorCompra", valorCompra);
                    command.Parameters.AddWithValue("@id", idTarjeta);

                    await sql.OpenAsync();
                    // Ejecuta el Stored Procedure
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

    }
}

