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
    public class ServicioExpediente : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioExpediente()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarExpediente(Expediente expediente)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR Expediente");

            comando.CommandText ="InsertarExpediente";

            comando.Parameters.Add("Mascota_id", SqlDbType.Int);
            comando.Parameters["Mascota_id"].Value = expediente.Mascota_id1;

            comando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            comando.Parameters["Veterinario_id"].Value = expediente.Veterinario_id1;

            comando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            comando.Parameters["Tratamiento_id"].Value = expediente.Tratamiento_id1;

            comando.Parameters.Add("Expediente_fecha", SqlDbType.Date);
            comando.Parameters["Expediente_fecha"].Value = expediente.Expediente_fecha1;

            comando.Parameters.Add("Expediente_estado", SqlDbType.VarChar);
            comando.Parameters["Expediente_estado"].Value = expediente.Expediente_estado1;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarExpediente(Expediente expediente)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR Cita");

            comando.CommandText ="ModificarExpediente";

            comando.Parameters.Add("Expediente_id", SqlDbType.Int);
            comando.Parameters["Expediente_id"].Value = expediente.Expediente_id1;

            comando.Parameters.Add("Mascota_id", SqlDbType.Int);
            comando.Parameters["Mascota_id"].Value = expediente.Mascota_id1;

            comando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            comando.Parameters["Veterinario_id"].Value = expediente.Veterinario_id1;

            comando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            comando.Parameters["Tratamiento_id"].Value = expediente.Tratamiento_id1;

            comando.Parameters.Add("Expediente_fecha", SqlDbType.Date);
            comando.Parameters["Expediente_fecha"].Value = expediente.Expediente_fecha1;

            comando.Parameters.Add("Expediente_estado", SqlDbType.VarChar);
            comando.Parameters["Expediente_estado"].Value = expediente.Expediente_estado1;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION mEDICAMENTO";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarExpediente(int Expediente_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Expediente");

            comando.CommandText ="ConsultarExpediente";

            comando.Parameters.Add("@Expediente_id", SqlDbType.Int);
            comando.Parameters["@Expediente_id"].Value = Expediente_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarExpediente()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar Expediente");

            comando.CommandText ="ListarExpediente";

            DataSet expediente = new DataSet();

            expediente = this.seleccionarInformacion(comando);
            DataTable miTabla = expediente.Tables[0];
            return miTabla;

        }


        public string inactivarExpediente(int Expediente_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Inactivar Expediente");

            comando.CommandText ="InactivarExpediente";

            comando.Parameters.Add("@Expediente_id", SqlDbType.Int);
            comando.Parameters["@Expediente_id"].Value = Expediente_id;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la inactivacion de la Cita";
            Console.WriteLine(respuesta);
            return respuesta;

        }


    }
}
