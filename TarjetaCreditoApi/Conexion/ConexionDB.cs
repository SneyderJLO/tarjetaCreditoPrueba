namespace TarjetaCreditoApi.Conexion
{
    public class ConexionDB
    {
        private string rutaConexion = string.Empty;

        public ConexionDB()
        {
            //para acceder al archivo de configuración appsettinsJSON
            var builderConexion = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            rutaConexion = builderConexion.GetSection("ConnectionStrings:conexionDB").Value;

        }

        public string ConexionMSQL()
        {
            return rutaConexion;
        }
    }
}
