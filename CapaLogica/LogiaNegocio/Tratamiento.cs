using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.CapaLogica.LogiaNegocio
{
    public class Tratamiento
    {
        #region ATRIBUTOS

        protected int tratamiento_id;
        protected int medicamento_id;
        protected float tratamiento_dosis;
        protected string tratamiento_observaciones;
        protected string tratamiento_estado;


        #endregion

        #region Constructores

        public Tratamiento(int medicamento_id, float tratamiento_dosis, string tratamiento_observaciones, string tratamiento_estado)
        {
            Tratamiento_id=0;
            Medicamento_id=medicamento_id;
            Tratamiento_dosis=tratamiento_dosis;
            Tratamiento_observaciones=tratamiento_observaciones;
            Tratamiento_estado=tratamiento_estado;
        }

        public Tratamiento(int tratamiento_id, int medicamento_id, float tratamiento_dosis,
           string tratamiento_observaciones, string tratamiento_estado)
        {
            Tratamiento_id=tratamiento_id;
            Medicamento_id=medicamento_id;
            Tratamiento_dosis = tratamiento_dosis;
            Tratamiento_observaciones=tratamiento_observaciones;
            Tratamiento_estado=tratamiento_estado;
        }

        #endregion

        #region GET's and SET's


        public int Tratamiento_id { get => tratamiento_id; set => tratamiento_id=value; }
        public int Medicamento_id { get => medicamento_id; set => medicamento_id=value; }
        public float Tratamiento_dosis { get => tratamiento_dosis; set => tratamiento_dosis=value; }
        public string Tratamiento_observaciones { get => tratamiento_observaciones; set => tratamiento_observaciones=value; }
        public string Tratamiento_estado { get => tratamiento_estado; set => tratamiento_estado=value; }


        #endregion


    }
}
