using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaVeterinaria.CapaConexion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;

namespace SistemaVeterinaria.CapaLogica.Servicios
{ 
    public class ServicioMedicamento : servicio, IDisposable
    {
    
        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioMedicamento()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarMedicamento(Medicamento medicamento)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR MEDICAMENTO");

            comando.CommandText ="InsertarMedicamento";

            comando.Parameters.Add("Medicamento_nombre", SqlDbType.VarChar);
            comando.Parameters["Medicamento_nombre"].Value = medicamento.Medicamento_nombre;

            comando.Parameters.Add("Medicamento_dosis", SqlDbType.VarChar);
            comando.Parameters["Medicamento_dosis"].Value = medicamento.Medicamento_dosis;

            comando.Parameters.Add("Medicamento_estado", SqlDbType.VarChar);
            comando.Parameters["Medicamento_estado"].Value = medicamento.Medicamento_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarMedicamento(Medicamento medicamento)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR MEDICAMENTO");

            comando.CommandText ="ModificarMedicamento";

            comando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            comando.Parameters["Medicamento_id"].Value = medicamento.Medicamento_id;

            comando.Parameters.Add("Medicamento_nombre", SqlDbType.VarChar);
            comando.Parameters["Medicamento_nombre"].Value = medicamento.Medicamento_nombre;

            comando.Parameters.Add("Medicamento_dosis", SqlDbType.VarChar);
            comando.Parameters["Medicamento_dosis"].Value = medicamento.Medicamento_dosis;

            comando.Parameters.Add("Medicamento_estado", SqlDbType.VarChar);
            comando.Parameters["Medicamento_estado"].Value = medicamento.Medicamento_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION mEDICAMENTO";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarMedicamento(int Medicamento_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar MEDICAMENTO");

            comando.CommandText ="ConsultarMedicamento";

            comando.Parameters.Add("Medicamento_id", SqlDbType.Int);
            comando.Parameters["@Medicamento_id"].Value = Medicamento_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando); 
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarMedicamentos()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar MEDICAMENTO");

            comando.CommandText ="ListarMedicamento";

            DataSet medicamento = new DataSet();

            medicamento = this.seleccionarInformacion(comando);
            DataTable miTabla = medicamento.Tables[0];
            return miTabla;

        }
    }
}
