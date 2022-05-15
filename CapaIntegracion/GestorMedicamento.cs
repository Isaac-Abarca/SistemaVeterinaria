using Microsoft.OData.Edm;
using SistemaVeterinaria.CapaConexion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;
using SistemaVeterinaria.CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    internal class GestorMedicamento : servicio, IDisposable
    {
        public GestorMedicamento()
        {
        }

        public void Dispose()
        {
        }

        public string insertarMedicamento( string medicamento_nombre,
                                        string medicamento_dosis,
                                        string medicamento_estado)
        {
            Medicamento nuevoMedicamento = new Medicamento(medicamento_nombre, medicamento_dosis, medicamento_estado);
            using (ServicioMedicamento Medicamento = new ServicioMedicamento())
                return Medicamento.insetarMedicamento(nuevoMedicamento);
        }

        public DataTable listarMedicamento()
        {
            using (ServicioMedicamento Medicamento = new ServicioMedicamento())
                return Medicamento.ListarMedicamentos();
        }


        public DataSet consultaMedicamento(int Medicamento_id)
        {
            using (ServicioMedicamento Medicamento = new ServicioMedicamento())
                return Medicamento.ConsultarMedicamento(Medicamento_id);
        }

        public string modificarMedicamento(Medicamento medicamento)
        {
            using (ServicioMedicamento Medicamento = new ServicioMedicamento())
                return Medicamento.modificarMedicamento(medicamento);
        }
    }
}
