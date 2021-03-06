using SistemaVeterinaria.CapaConexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bibliotecas
using SistemaVeterinaria.CapaLogica.LogiaNegocio;
using System.Data;
using CapaLogica.LogiaNegocio;

namespace CapaLogica.Servicios
{
    public class ServicioEspecie : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioEspecie()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarEspecie(Especie especie)
        {
            comando = new SqlCommand();

            Console.WriteLine("GESTOR INSERTAR Especie");

            comando.CommandText ="InsertarEspecie";

            comando.Parameters.Add("Especie_descripcion", SqlDbType.VarChar);
            comando.Parameters["Especie_descripcion"].Value = especie.Especie_descripcion;

            comando.Parameters.Add("Especie_estado", SqlDbType.VarChar);
            comando.Parameters["Especie_estado"].Value = especie.Especie_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarEspecie(Especie especie)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR Especie");

            comando.CommandText ="ModificarEspecie";

            comando.Parameters.Add("Especie_id", SqlDbType.Int);
            comando.Parameters["Especie_id"].Value = especie.Especie_id;

            comando.Parameters.Add("Especie_descripcion", SqlDbType.VarChar);
            comando.Parameters["Especie_descripcion"].Value = especie.Especie_descripcion;

            comando.Parameters.Add("Especie_estado", SqlDbType.VarChar);
            comando.Parameters["Especie_estado"].Value = especie.Especie_estado;

            

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION Especie";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarEspecie(int Especie_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Duenno");

            comando.CommandText ="ConsultarEspecie";

            comando.Parameters.Add("@Especie_id", SqlDbType.Int);
            comando.Parameters["@Especie_id"].Value = Especie_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public string inactivarEspecie(int id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Inactivar Especie");

            comando.CommandText ="InactivarEspecie";

            comando.Parameters.Add("@Especie_id", SqlDbType.Int);
            comando.Parameters["@Especie_id"].Value = id;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la inactivacion de la Especie";
            Console.WriteLine(respuesta);

            return respuesta;

        }

        public DataTable ListarEspecie()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar Especie");

            comando.CommandText ="ListarEspecie";

            DataSet Especie = new DataSet();

            Especie = this.seleccionarInformacion(comando);
            DataTable miTabla = Especie.Tables[0];
            return miTabla;

        }
    }
}
