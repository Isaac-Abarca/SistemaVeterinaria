using CapaLogica.LogiaNegocio;
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
    public class GestorDuenno : servicio, IDisposable
    {
        public GestorDuenno()
        {
        }

        public void Dispose()
        {
        }

        public string insertarDuenno(string duenno_cedula,
                                   string duenno_nombre,
                                   string duenno_apellido,
                                   string duenno_telefono,
                                   string duenno_direccio,
                                   string duenno_estado)
        {

            Duenno nuevoDuenno = new Duenno(duenno_cedula, duenno_nombre, duenno_apellido, duenno_telefono, duenno_direccio, duenno_estado);
            using (ServicioDuenno elDuenno = new ServicioDuenno())

                return elDuenno.insetarDuenno(nuevoDuenno);
        }

        public DataTable listarDuenno()
        {
            using (ServicioDuenno duenno = new ServicioDuenno())
                return duenno.ListarDuenno();
        }


        public DataSet consultaDuenno(int duenno_id)
        {
            using (ServicioDuenno Duenno = new ServicioDuenno())
                return Duenno.ConsultarDuenno(duenno_id);
        }

        public string modificarDuenno(Duenno duenno)
        {
            using (ServicioDuenno Duenno = new ServicioDuenno())
                return Duenno.modificarDuenno(duenno);
        }

        public string inactivarDuenno(int duenno)
        {
            using (ServicioDuenno Duenno = new ServicioDuenno())
                return Duenno.inactivarDuenno(duenno);
        }
    }
}
