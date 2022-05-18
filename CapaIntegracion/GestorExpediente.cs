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
    public class GestorExpediente : servicio, IDisposable
    {
        public GestorExpediente()
        {
        }

        public void Dispose()
        {
        }

        public string insertarExpediente(int Mascota_id,
                                            int Veterinario_id,
                                            int Tratamiento_id,
                                            string Expediente_fecha,
                                            string Expediente_estado)
        {
            Expediente nuevoExpediente = new Expediente(Mascota_id, Veterinario_id, Tratamiento_id, Expediente_fecha,
               Expediente_estado);
            using (ServicioExpediente Expediente = new ServicioExpediente())
                return Expediente.insetarExpediente(nuevoExpediente);
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

        public string inactivarExpediente(int id)
        {
            using (ServicioExpediente Expediente = new ServicioExpediente())
                return Expediente.inactivarExpediente(id);
        }
    }
}
