namespace TarjetaCreditoApi.Conexion
{
    public class ConexionDB
    {
        private string rutaConexion = string.Empty;

        public ConexionDB()
        {
            try
            {
                //para acceder al archivo de configuración appsettinsJSON
                var builderConexion = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

                rutaConexion = builderConexion.GetSection("ConnectionStrings:conexionDB").Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        public string ConexionSQLSERVER()
        {
            return rutaConexion;
        }
    }
}
