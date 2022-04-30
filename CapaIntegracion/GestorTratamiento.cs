using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVeterinaria.CapaLogica.LogiaNegocio;
using SistemaVeterinaria.CapaLogica.Servicios;
using SistemaVeterinaria.CapaConexion;
using System.Data;

namespace SistemaVeterinaria.CapaIntegracion
{
    public class GestorTratamiento: servicio, IDisposable
    {
        public GestorTratamiento()
        {
        }

        public void Dispose()
        {
        }

        public string insertarTratamiento(int medicamento_id,
                                            float tratamiento_dosis,
                                           string tratamiento_observaciones,
                                           string tratamiento_estado)
        {

            Tratamiento nuevoTratamieto = new Tratamiento(medicamento_id, tratamiento_dosis, 
                                                        tratamiento_observaciones, tratamiento_estado);
            using(ServicioTratamiento elTratamiento = new ServicioTratamiento())

            return elTratamiento.insetarTratamiento(nuevoTratamieto);
        }

        public DataTable listarTratamientos()
        {
            using (ServicioTratamiento elTratamiento = new ServicioTratamiento())
                return elTratamiento.ListarTratamiento();
        }

    }
}
