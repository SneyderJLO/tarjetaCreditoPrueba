namespace TarjetaCreditoApi.Model
{
    public class MTarjeta
    {

        public int idTarjeta { get; set; }
        public int idCliente { get; set; }
        public decimal cupoAutorizado { get; set; }
        public decimal cupoUtilizado { get; set; }
        public decimal cupoDisponible { get; set; }
    }
}
