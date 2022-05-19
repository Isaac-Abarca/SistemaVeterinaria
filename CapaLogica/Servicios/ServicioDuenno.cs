using CapaLogica.LogiaNegocio;
using SistemaVeterinaria.CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.CapaLogica.Servicios
{
    public class ServicioDuenno : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioDuenno()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarDuenno(Duenno duenno)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR Duenno");

            comando.CommandText ="InsertarDuenno";

            comando.Parameters.Add("Duenno_cedula", SqlDbType.VarChar);
            comando.Parameters["Duenno_cedula"].Value = duenno.Duenno_cedula;

            comando.Parameters.Add("Duenno_nombre", SqlDbType.VarChar);
            comando.Parameters["Duenno_nombre"].Value = duenno.Duenno_nombre;

            comando.Parameters.Add("Duenno_apellido", SqlDbType.VarChar);
            comando.Parameters["Duenno_apellido"].Value = duenno.Duenno_apellidos;

            comando.Parameters.Add("Duenno_telefono", SqlDbType.VarChar);
            comando.Parameters["Duenno_telefono"].Value = duenno.Duenno_telefono;

            comando.Parameters.Add("Duenno_direccion", SqlDbType.VarChar);
            comando.Parameters["Duenno_direccion"].Value = duenno.Duenno_direccion;

            comando.Parameters.Add("Duenno_estado", SqlDbType.VarChar);
            comando.Parameters["Duenno_estado"].Value = duenno.Duenno_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarDuenno(Duenno duenno)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR Duenno");

            comando.CommandText ="ModificarDuenno";

            comando.Parameters.Add("Duenno_id", SqlDbType.Int);
            comando.Parameters["Duenno_id"].Value = duenno.Duenno_id;

            comando.Parameters.Add("Duenno_cedula", SqlDbType.VarChar);
            comando.Parameters["Duenno_cedula"].Value = duenno.Duenno_cedula;

            comando.Parameters.Add("Duenno_nombre", SqlDbType.VarChar);
            comando.Parameters["Duenno_nombre"].Value = duenno.Duenno_nombre;

            comando.Parameters.Add("Duenno_apellido", SqlDbType.VarChar);
            comando.Parameters["Duenno_apellido"].Value = duenno.Duenno_apellidos;

            comando.Parameters.Add("Duenno_telefono", SqlDbType.VarChar);
            comando.Parameters["Duenno_telefono"].Value = duenno.Duenno_telefono;

            comando.Parameters.Add("Duenno_direccion", SqlDbType.VarChar);
            comando.Parameters["Duenno_direccion"].Value = duenno.Duenno_direccion;

            comando.Parameters.Add("Duenno_estado", SqlDbType.VarChar);
            comando.Parameters["Duenno_estado"].Value = duenno.Duenno_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION Duenno";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarDuenno(int Duenno_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Duenno");

            comando.CommandText ="ConsultarDuenno";

            comando.Parameters.Add("@Duenno_id", SqlDbType.Int);
            comando.Parameters["@Duenno_id"].Value = Duenno_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarDuenno()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar Duenno");

            comando.CommandText ="ListarDuenno";

            DataSet Duenno = new DataSet();

            Duenno = this.seleccionarInformacion(comando);
            DataTable miTabla = Duenno.Tables[0];
            return miTabla;

        }

        public string inactivarDuenno(int id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Inactivar Duenno");

            comando.CommandText ="InactivarDuenno";

            comando.Parameters.Add("@Duenno_id", SqlDbType.Int);
            comando.Parameters["@Duenno_id"].Value = id;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la inactivacion del Duenno";
            Console.WriteLine(respuesta);
            return respuesta;

        }
    }
}
