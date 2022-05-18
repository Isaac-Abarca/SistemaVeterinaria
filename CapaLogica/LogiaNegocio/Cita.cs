using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogiaNegocio
{
    public class Cita
    {
        #region Atributos
        protected int cita_id;
        protected int mascota_id;
        protected int veterinario_id;
        protected string cita_fecha;
        protected string cita_hora;
        protected string cita_estado;
        #endregion

        #region Constructores
        public int Cita_id { get => cita_id; set => cita_id=value; }
        public int Mascota_id { get => mascota_id; set => mascota_id=value; }
        public int Veterinario_id { get => veterinario_id; set => veterinario_id=value; }
        public string Cita_fecha { get => cita_fecha; set => cita_fecha=value; }
        public string Cita_hora { get => cita_hora; set => cita_hora=value; }
        public string Cita_estado { get => cita_estado; set => cita_estado=value; }
        #endregion

        #region GETs and SETTER's

        public Cita(int cita_id, int mascota_id, int veterinario_id, string cita_fecha, string cita_hora, string cita_estado)
        {
            Cita_id=cita_id;
            Mascota_id=mascota_id;
            Veterinario_id=veterinario_id;
            Cita_fecha=cita_fecha;
            Cita_hora=cita_hora;
            Cita_estado=cita_estado;
        }

        public Cita(int mascota_id, int veterinario_id, string cita_fecha, string cita_hora, string cita_estado)
        {
            Cita_id=0;
            Mascota_id=mascota_id;
            Veterinario_id=veterinario_id;
            Cita_fecha=cita_fecha;
            Cita_hora=cita_hora;
            Cita_estado=cita_estado;
        }
        #endregion





    }
}
