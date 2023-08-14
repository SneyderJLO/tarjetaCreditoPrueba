using Newtonsoft.Json;

namespace TarjetaCreditoApi.Model.Producto
{
    public class MProducto
    {
        public int id { get; set; }
        [JsonProperty("title")]
        public string? Titutlo { get; set; }
        [JsonProperty("description")]
        public string? Descripcion { get; set; }
        [JsonProperty("price")]
        public decimal Precio { get; set; }

    }
}
