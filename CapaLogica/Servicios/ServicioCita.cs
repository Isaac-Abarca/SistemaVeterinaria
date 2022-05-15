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
    public class ServicioCita : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioCita()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarCita(Cita cita)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR Cita");

            comando.CommandText ="InsertarCita";

            comando.Parameters.Add("Mascota_id", SqlDbType.Int);
            comando.Parameters["Mascota_id"].Value = cita.Mascota_id;

            comando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            comando.Parameters["Veterinario_id"].Value = cita.Veterinario_id;

            comando.Parameters.Add("Cita_fecha", SqlDbType.Date);
            comando.Parameters["Cita_fecha"].Value = cita.Cita_fecha;

            comando.Parameters.Add("Cita_estado", SqlDbType.VarChar);
            comando.Parameters["Cita_estado"].Value = cita.Cita_estado;

            comando.Parameters.Add("Cita_hora", SqlDbType.DateTime);
            comando.Parameters["Cita_hora"].Value = cita.Cita_hora;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarCita(Cita cita)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR Cita");

            comando.CommandText ="ModificarCita";

            comando.Parameters.Add("Cita_id", SqlDbType.Int);
            comando.Parameters["Cita_id"].Value = cita.Cita_id;

            comando.Parameters.Add("Mascota_id", SqlDbType.Int);
            comando.Parameters["Mascota_id"].Value = cita.Mascota_id;

            comando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            comando.Parameters["Veterinario_id"].Value = cita.Veterinario_id;

            comando.Parameters.Add("Cita_fecha", SqlDbType.Date);
            comando.Parameters["Cita_fecha"].Value = cita.Cita_fecha;

            comando.Parameters.Add("Cita_estado", SqlDbType.VarChar);
            comando.Parameters["Cita_estado"].Value = cita.Cita_estado;

            comando.Parameters.Add("Cita_hora", SqlDbType.DateTime);
            comando.Parameters["Cita_hora"].Value = cita.Cita_hora;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION mEDICAMENTO";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarCita(int Cita_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Cita");

            comando.CommandText ="ConsultarCita";

            comando.Parameters.Add("Cita_id", SqlDbType.Int);
            comando.Parameters["@Cita_id"].Value = Cita_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarCita()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar Cita");

            comando.CommandText ="ListarCita";

            DataSet cita = new DataSet();

            cita = this.seleccionarInformacion(comando);
            DataTable miTabla = cita.Tables[0];
            return miTabla;

        }
    }
}
