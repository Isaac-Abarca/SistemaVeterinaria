using CapaLogica.LogiaNegocio;
using CapaLogica.Servicios;
using SistemaVeterinaria.CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorEspecie : servicio, IDisposable
    {
        public GestorEspecie()
        {
        }

        public void Dispose()
        {
        }

        public string insertarEspecie( string especie_descripcion,
                                       string especie_estado)
        {
            Especie nuevoEspecie = new Especie(especie_descripcion, especie_estado);
            using (ServicioEspecie Especie = new ServicioEspecie())
                return Especie.insetarEspecie(nuevoEspecie);
        }

        public DataTable listarEspecie()
        {
            using (ServicioEspecie Especie = new ServicioEspecie())
                return Especie.ListarEspecie();
        }


        public DataSet consultaEspecie(int Especie_id)
        {
            using (ServicioEspecie Especie = new ServicioEspecie())
                return Especie.ConsultarEspecie(Especie_id);
        }

        public string modificarEspecie(Especie especie)
        {
            using (ServicioEspecie Especie = new ServicioEspecie())
                return Especie.modificarEspecie(especie);
        }

        public string inactivarEspecie(int id)
        {
            using (ServicioEspecie Especie = new ServicioEspecie())
                return Especie.inactivarEspecie(id);
        }
    }
}
