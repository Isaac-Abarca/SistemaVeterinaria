using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.CapaLogica.LogiaNegocio
{
    public class Expediente
    {

        #region ATRIBUTOS
        protected int Expediente_id;
        protected int Mascota_id;
        protected int Veterinario_id;
        protected int Tratamiento_id;
        protected Date Expediente_fecha;
        protected string Expediente_estado;
        #endregion

        #region  GET's and Sett'sCONSTRUCTORES
        public int Expediente_id1 { get => Expediente_id; set => Expediente_id=value; }
        public int Mascota_id1 { get => Mascota_id; set => Mascota_id=value; }
        public int Veterinario_id1 { get => Veterinario_id; set => Veterinario_id=value; }
        public int Tratamiento_id1 { get => Tratamiento_id; set => Tratamiento_id=value; }
        public Date Expediente_fecha1 { get => Expediente_fecha; set => Expediente_fecha=value; }
        public string Expediente_estado1 { get => Expediente_estado; set => Expediente_estado=value; }
        #endregion

        #region CONSTRUCTORES
        public Expediente(int expediente_id, int mascota_id, int veterinario_id,
            int tratamiento_id, Date expediente_fecha, string expediente_estado)
        {
            Expediente_id1=expediente_id;
            Mascota_id1=mascota_id;
            Veterinario_id1=veterinario_id;
            Tratamiento_id1=tratamiento_id;
            Expediente_fecha1=expediente_fecha;
            Expediente_estado1=expediente_estado;
        }

        public Expediente(int mascota_id, int veterinario_id,
            int tratamiento_id, Date expediente_fecha, string expediente_estado)
        {
            Expediente_id1=0;
            Mascota_id1=mascota_id;
            Veterinario_id1=veterinario_id;
            Tratamiento_id1=tratamiento_id;
            Expediente_fecha1=expediente_fecha;
            Expediente_estado1=expediente_estado;
        }

        #endregion


    }
}
