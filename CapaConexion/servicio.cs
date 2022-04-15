using System.Data.SqlClient;

namespace SistemaVeterinaria.CapaConexion
{
    public class servicio
    {
        private SqlConnection conexion;

        public servicio()
        {
            conexion = new SqlConnection(@"user=DESKTOP-SHJTAP0\UCR; 
                                           pasword= validpassword;
                                           server = DESKTOP-SHJTAP0;
                                           Trusted_Connection =yes;
                                           database = SistemaVeterinaria;
                                           connection timeout 30");
        }
    }
}
