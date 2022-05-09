using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.LogiaNegocio;

//Bibliotecas
using SistemaVeterinaria.CapaConexion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;

namespace SistemaVeterinaria.CapaLogica.Servicios
{
    internal class ServicioUsuario : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioUsuario()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarCita(Usuario usuario)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR Usuario");

            comando.CommandText ="InsertarUsuario";

            comando.Parameters.Add("Usuario_nombre", SqlDbType.Int);
            comando.Parameters["Usuario_nombre"].Value = usuario.Usuario_nombre;

            comando.Parameters.Add("Usuario_contrasenna", SqlDbType.Int);
            comando.Parameters["Usuario_contrasenna"].Value = usuario.Usuario_contrasenna;

            comando.Parameters.Add("Usuario_tipo", SqlDbType.Date);
            comando.Parameters["Usuario_tipo"].Value = usuario.Usuario_tipo;

            comando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            comando.Parameters["Usuario_estado"].Value = usuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarCita(Usuario usuario)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR usuario");

            comando.CommandText ="ModificarUsuario";

            comando.Parameters.Add("Usuario_id", SqlDbType.Int);
            comando.Parameters["Usuario_id"].Value = usuario.Usuario_id;

            comando.Parameters.Add("Usuario_nombre", SqlDbType.Int);
            comando.Parameters["Usuario_nombre"].Value = usuario.Usuario_nombre;

            comando.Parameters.Add("Usuario_contrasenna", SqlDbType.Int);
            comando.Parameters["Usuario_contrasenna"].Value = usuario.Usuario_contrasenna;

            comando.Parameters.Add("Usuario_tipo", SqlDbType.Date);
            comando.Parameters["Usuario_tipo"].Value = usuario.Usuario_tipo;

            comando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            comando.Parameters["Usuario_estado"].Value = usuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION usuario";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarCita(int Usuario_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Usuario");

            comando.CommandText ="ConsultarUsuario";

            comando.Parameters.Add("Usuario_id", SqlDbType.Int);
            comando.Parameters["@Usuario_id"].Value = Usuario_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarCita()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar Usuario");

            comando.CommandText ="ListarUsuario";

            DataSet Usuario = new DataSet();
            Usuario = this.seleccionarInformacion(comando);

            DataTable miTabla = Usuario.Tables[0];
            return miTabla;

        }


    }
}
