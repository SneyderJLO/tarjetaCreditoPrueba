using System.Data.SqlClient;
using System.Data;
using TarjetaCreditoApi.Conexion;
using TarjetaCreditoApi.Model;
using TarjetaCreditoApi.Model.Transaccion;

namespace TarjetaCreditoApi.DatosTarjetaCredito
{
    public class DTransaccion
    {
        ConexionDB conexion = new ConexionDB();

        public async Task<List<MTransaccion>> mostrarTransaccionesCliente(int id)
        {

            var listaTransaccion = new List<MTransaccion>();
            using (var sql = new SqlConnection(conexion.ConexionSQLSERVER()))
            {

                //cambiar por el sp
                using (var cmd = new SqlCommand("sp_datosTransaccion", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", id);


                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var tarjetas = new MTransaccion();
                            tarjetas.idTransaccion = (int)item["idTransaccion"];
                            tarjetas.idProducto = (int)item["idProducto"];
                            tarjetas.idTarjeta = (int)item["idTarjeta"];
                            tarjetas.fecha = (DateTime)item["fecha"];
                            tarjetas.producto = (string)item["producto"];
                            tarjetas.valor = (decimal)item["valor"];

                            listaTransaccion.Add(tarjetas);
                        }
                    }
                }



            }
            return listaTransaccion;
        }

        public async Task insertarTransaccion(MTransaccion parametros)
        {
            using (var sql = new SqlConnection(conexion.ConexionSQLSERVER()))
            {
                using (var cmd = new SqlCommand("sp_insertarTransaccion", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idTarjeta", parametros.idTarjeta);
                    cmd.Parameters.AddWithValue("@idProducto", parametros.idProducto);
                    cmd.Parameters.AddWithValue("@fecha", parametros.fecha);
                    cmd.Parameters.AddWithValue("@producto", parametros.producto);
                    cmd.Parameters.AddWithValue("@valor", parametros.valor);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


    }
}
