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

namespace CapaIntegracion
{
    public class GestorMascota : servicio, IDisposable
    {
        public GestorMascota()
        {
        }

        public void Dispose()
        {
        }

        public string insertarMascota( int especie_id,
                                       int duenno_id,
                                       string mascota_nombre,
                                       string mascota_genero,
                                       string mascota_color,
                                       string mascota_fecha_nacimiento,
                                       float mascota_peso,
                                       string mascota_estado)
        {
            Mascota nuevoMascota = new Mascota(especie_id, duenno_id, mascota_nombre, mascota_genero, mascota_color, mascota_fecha_nacimiento,
                mascota_peso, mascota_estado);
            using (ServicioMascota Mascota = new ServicioMascota())
                return Mascota.insetarMascota(nuevoMascota);
        }

        public DataTable listarMascota()
        {
            using (ServicioMascota Mascota = new ServicioMascota())
                return Mascota.ListarMascota();
        }


        public DataSet consultaMascota(int Mascota_id)
        {
            using (ServicioMascota Mascota = new ServicioMascota())
                return Mascota.ConsultarMascota(Mascota_id);
        }

        public string modificarMascota(Mascota Mascota)
        {
            using (ServicioMascota mascota = new ServicioMascota())
                return mascota.modificarMascota(Mascota);
        }

        public string inactivarMascota(int id)
        {
            using (ServicioMascota mascota = new ServicioMascota())
                return mascota.inactivarMascota(id);
        }
    }
}
