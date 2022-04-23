using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.CapaLogica.LogiaNegocio
{
    public class Medicamento
    {
        #region Atributos
        protected int medicamento_id;
        protected string medicamento_nombre;
        protected string medicamento_dosis;
        protected string medicamento_estado;

        #endregion

        #region CONSTRUCTORES

        public  Medicamento()
        {
        }
        /// <summary>
        /// metodo para modificar
        /// </summary>
        /// <param name="medicamento_id"></param>
        /// <param name="medicamento_nombre"></param>
        /// <param name="medicamento_dosis"></param>
        /// <param name="medicamento_estado"></param>
        public Medicamento(int medicamento_id, string medicamento_nombre, 
                            string medicamento_dosis, string medicamento_estado)
        {
            this.medicamento_id=medicamento_id;
            this.medicamento_nombre=medicamento_nombre;
            this.medicamento_dosis=medicamento_dosis;
            this.medicamento_estado=medicamento_estado;
        }

        /// <summary>
        /// Metodo para insertar nuevo medicamento
        /// </summary>
        /// <param name="medicamento_nombre"></param>
        /// <param name="medicamento_dosis"></param>
        /// <param name="medicamento_estado"></param>
        public Medicamento(string medicamento_nombre,
                            string medicamento_dosis, string medicamento_estado)
        {
            this.medicamento_id=0;
            this.medicamento_nombre=medicamento_nombre;
            this.medicamento_dosis=medicamento_dosis;
            this.medicamento_estado=medicamento_estado;
        }

        #endregion


        #region GET's y SET'
        public int Medicamento_id { get => medicamento_id; set => medicamento_id=value; }
        public string Medicamento_nombre { get => medicamento_nombre; set => medicamento_nombre=value; }
        public string Medicamento_dosis { get => medicamento_dosis; set => medicamento_dosis=value; }
        public string Medicamento_estado { get => medicamento_estado; set => medicamento_estado=value; }
        #endregion
    }
}

