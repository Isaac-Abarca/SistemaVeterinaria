using CapaLogica.LogiaNegocio;
using Microsoft.OData.Edm;
using SistemaVeterinaria.CapaConexion;
using SistemaVeterinaria.CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistememaVeterinaria.CapaIntegracion
{
    public class GestorCita : servicio, IDisposable
    {
        public GestorCita()
        {
        }

        public void Dispose()
        {
        }

        public string insertarCita(int mascota_id,
            int veterinario_id,
            string cita_fecha,
            string cita_hora,
            string cita_estado)
        {

            Cita nuevoCita = new Cita(mascota_id,veterinario_id, cita_fecha, cita_hora, cita_estado);
            using (ServicioCita elTratamiento = new ServicioCita())

                return elTratamiento.insetarCita(nuevoCita);
        }

        public DataTable listarCita()
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ListarCita();
        }


        public DataSet consultaCita(int cita_id)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ConsultarCita(cita_id);
        }

        public string modificarCita(Cita cita)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.modificarCita(cita);
        }

        public string inactivarCita(int id)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.InactivarCita(id);
        }
    }
}
