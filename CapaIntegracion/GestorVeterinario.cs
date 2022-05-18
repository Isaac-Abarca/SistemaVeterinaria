using CapaLogica.Servicios;
using SistemaVeterinaria.CapaConexion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorVeterinario : servicio, IDisposable
    {
        public GestorVeterinario()
        {
        }

        public void Dispose()
        {
        }

        public string insertarVeterinario(string veterinario_cedula,
                                            string veterinario_nombre,
                                            string veterinario_telefono,
                                            string veterinario_direccion,
                                            string veterinario_estado)
        {
            Veterinario nuevoVeterinario = new Veterinario(veterinario_cedula, veterinario_nombre, veterinario_telefono, veterinario_direccion,
               veterinario_estado);
            using (ServicioVeterinario Veterinario = new ServicioVeterinario())
                return Veterinario.insetarVeterinario(nuevoVeterinario);
        }

        public DataTable listarVeterinario()
        {
            using (ServicioVeterinario Veterinario = new ServicioVeterinario())
                return Veterinario.ListarVeterinario();
        }


        public DataSet consultaVeterinario(int Veterinario_id)
        {
            using (ServicioVeterinario Veterinario = new ServicioVeterinario())
                return Veterinario.ConsultarVeterinario(Veterinario_id);
        }

        public string modificarVeterinario(Veterinario veterinario)
        {
            using (ServicioVeterinario Veterinario = new ServicioVeterinario())
                return Veterinario.modificarVeterinario(veterinario);
        }
        public string inactivarVeterinario(int id)
        {
            using (ServicioVeterinario Veterinario = new ServicioVeterinario())
                return Veterinario.inactivarVeterinario(id);
        }

    }
}
