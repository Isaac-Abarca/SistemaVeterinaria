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
    internal class GestorExpediente : servicio, IDisposable
    {
        public GestorExpediente()
        {
        }

        public void Dispose()
        {
        }

        public string insertarVeterinario(int Mascota_id,
                                            int Veterinario_id,
                                            int Tratamiento_id,
                                            Date Expediente_fecha,
                                            string Expediente_estado)
        {
            Expediente nuevoVeterinario = new Expediente(Mascota_id, Veterinario_id, Tratamiento_id, Expediente_fecha,
               Expediente_estado);
            using (ServicioExpediente Expediente = new ServicioExpediente())
                return Expediente.insetarExpediente(nuevoVeterinario);
        }

        public DataTable listarExpediente()
        {
            using (ServicioExpediente Expediente = new ServicioExpediente())
                return Expediente.ListarExpediente();
        }


        public DataSet consultaExpediente(int Expediente_id)
        {
            using (ServicioExpediente Expediente = new ServicioExpediente())
                return Expediente.ConsultarExpediente(Expediente_id);
        }

        public string modificarExpediente(Expediente expediente)
        {
            using (ServicioExpediente Expediente = new ServicioExpediente())
                return Expediente.modificarExpediente(expediente);
        }
    }
}
