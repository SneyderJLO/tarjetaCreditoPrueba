namespace TarjetaCreditoApi.Model.Transaccion
{
    public class MTransaccion
    {
        public int idTransaccion { get; set; }
        public int idTarjeta { get; set; }
        public int idProducto { get; set; }
        public DateTime fecha { get; set; }
        public string producto { get; set; }
        public decimal valor { get; set; }
    }
}
