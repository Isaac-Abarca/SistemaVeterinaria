using CapaComun.Cache;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVeterinaria.CapaConexion
{
    public class servicio
    {
        private SqlConnection conexion;

        public servicio()
        {
           //conexion = new SqlConnection(@"user=DESKTOP-SHJTAP0\UCR;password= validpassword;server = DESKTOP-SHJTAP0;Trusted_Connection =yes;database = SistemaVeterinaria");
           
            conexion = new SqlConnection(@"user=MAMALONA\\abarc; 
                                           password= validpassword;
                                           server = MAMALONA;
                                           Trusted_Connection = yes;
                                           database = Sistema_veterinaria");
        }

        protected void cerrarConexion()
        {
            conexion.Close();
        }

        protected void abrirConexion()
        {
            conexion.Open();
        }

        protected string ejecutarSentencia(string sentencia)
        {
            SqlCommand comando  = new SqlCommand(sentencia, conexion);
            try
            {
                this.conexion.Open(); 
                comando.ExecuteScalar();

            }
            catch(Exception error)
            {
                this.cerrarConexion();
                return error.Message;
            }

            this.cerrarConexion();
            return "";
        }

        protected string ejecutaSentencia(SqlCommand miComando)
        {
            miComando.Connection = conexion;
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.CommandTimeout =6000;

            try
            {
                this.abrirConexion();
                miComando.ExecuteScalar();
            }
            catch(SqlException error)
            {
                this.cerrarConexion();
                return error.Message;
            }

            this.cerrarConexion();
            return "";
        }

        protected DataSet seleccionarInformacion(string sentencia)
        {
            DataSet dataSet = new DataSet();
            SqlCommand sqlCommand = conexion.CreateCommand();
            sqlCommand.CommandText = sentencia;

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            adapter.SelectCommand = sqlCommand;

            adapter.Fill(dataSet);

            return dataSet;
        }

        protected DataSet seleccionarInformacion(SqlCommand miCommand)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            miCommand.CommandTimeout = 2000;
            miCommand.Connection = conexion;

            miCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = miCommand;
            adapter.Fill(dataSet);

            return dataSet;
        }

        public bool Logins(string user, string pass)
        {
            try
            {
                using (var command = new SqlCommand())
                {
                    this.abrirConexion();
                    command.Connection = conexion;
                    command.CommandText = "select * from TUsuario where @usuario_nombre=usuario_nombre  and @usuario_contrasenna=usuario_contrasenna ";
                    command.Parameters.AddWithValue("@usuario_nombre", user);
                    command.Parameters.AddWithValue("@usuario_contrasenna", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.LoginName = reader.GetString(1);
                            UserLoginCache.Password = reader.GetString(2);
                            UserLoginCache.Position = reader.GetString(3);
                            UserLoginCache.Estado = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (SqlException error)
            {
                Console.WriteLine(error.Message);
                this.cerrarConexion();
                return false;
            }
               
        }

    }
}
