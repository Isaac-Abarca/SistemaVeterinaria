using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//bibliotecas
using SistemaVeterinaria.CapaConexion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;

namespace SistemaVeterinaria.CapaLogica.Servicios
{
    public class ServicioTratamiento : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioTratamiento()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarTratamiento(Tratamiento tratamiento)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR Tratamiento");

            comando.CommandText ="InsertarTratamiento";

            comando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            comando.Parameters["Medicamento_id"].Value = tratamiento.Medicamento_id;

            comando.Parameters.Add("Tratamiento_dosis", SqlDbType.VarChar);
            comando.Parameters["Tratamiento_dosis"].Value = tratamiento.Tratamiento_dosis;

            comando.Parameters.Add("Tratamiento_observaciones", SqlDbType.VarChar);
            comando.Parameters["Tratamiento_observaciones"].Value = tratamiento.Tratamiento_observaciones;

            comando.Parameters.Add("Tratamiento_estado", SqlDbType.VarChar);
            comando.Parameters["Tratamiento_estado"].Value = tratamiento.Tratamiento_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarTratamiento(Tratamiento tratamiento)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR Tratamiento");

            comando.CommandText ="ModificarTratamiento";

            comando.Parameters.Add("Tratamiento_id", SqlDbType.Int);
            comando.Parameters["Tratamiento_id"].Value = tratamiento.Tratamiento_id;

            comando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            comando.Parameters["Medicamento_id"].Value = tratamiento.Medicamento_id;

            comando.Parameters.Add("Tratamiento_dosis", SqlDbType.VarChar);
            comando.Parameters["Tratamiento_dosis"].Value = tratamiento.Tratamiento_dosis;

            comando.Parameters.Add("Tratamiento_observaciones", SqlDbType.VarChar);
            comando.Parameters["Tratamiento_observaciones"].Value = tratamiento.Tratamiento_observaciones;

            comando.Parameters.Add("Tratamiento_estado", SqlDbType.VarChar);
            comando.Parameters["Tratamiento_estado"].Value = tratamiento.Tratamiento_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION mEDICAMENTO";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultaTratamiento(int Tratamiento_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar TRATAMIENTO");

            comando.CommandText ="ConsultarTratamiento";

            comando.Parameters.AddWithValue("@Tratamiento_id", SqlDbType.Int);
            comando.Parameters["@Tratamiento_id"].Value = Tratamiento_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarTratamiento()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar TRATAMIENTO");

            comando.CommandText ="ListarTratamientos";

            DataSet medicamento = new DataSet();

            medicamento = this.seleccionarInformacion(comando);
            DataTable miTabla = medicamento.Tables[0];
            return miTabla;

        }
    }
}
