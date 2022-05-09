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
    internal class ServicioEspecie : servicio, IDisposable
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

        public string insetarCita(Especie especie)
        {
            comando = new SqlCommand();

            Console.WriteLine("GESTOR INSERTAR Especie");

            comando.CommandText ="InsertarEspecie";

            comando.Parameters.Add("Especie_descripcion", SqlDbType.VarChar);
            comando.Parameters["Especie_descripcion"].Value = especie.Especie_descripcion;

            comando.Parameters.Add("Especie_estado", SqlDbType.Int);
            comando.Parameters["Especie_estado"].Value = especie.Especie_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarCita(Especie especie)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR Especie");

            comando.CommandText ="ModificarEspecie";

            comando.Parameters.Add("Especie_id", SqlDbType.Int);
            comando.Parameters["Especie_id"].Value = especie.Especie_id;

            comando.Parameters.Add("Especie_descripcion", SqlDbType.VarChar);
            comando.Parameters["Especie_descripcion"].Value = especie.Especie_descripcion;

            comando.Parameters.Add("Especie_estado", SqlDbType.Int);
            comando.Parameters["Especie_estado"].Value = especie.Especie_estado;

            

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION Especie";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarCita(int Especie_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Duenno");

            comando.CommandText ="ConsultarDuenno";

            comando.Parameters.Add("Especie_id", SqlDbType.Int);
            comando.Parameters["@Especie_id"].Value = Especie_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarCita()
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
