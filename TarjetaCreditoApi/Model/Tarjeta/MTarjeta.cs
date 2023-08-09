namespace TarjetaCreditoApi.Model
{
    public class MTarjeta
    {
        public int idCliente { get; set; }
        public int idTarjeta { get; set; }
        public string numeroTarjeta { get; set; }
        public DateTime fechaexpira { get; set; }
        public int cvv { get; set; }
        public decimal cupoAutorizado { get; set; }
        public decimal cupoUtilizado { get; set; }
        public decimal cupoDisponible { get; set; }
    }
}
