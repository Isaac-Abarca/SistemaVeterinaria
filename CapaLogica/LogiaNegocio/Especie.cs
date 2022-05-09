using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogiaNegocio
{
    internal class Especie
    {
        #region Atributos
        protected int especie_id;
        protected string especie_descripcion;
        protected string especie_estado;


        #endregion

        #region Constructores

        public Especie(string especie_descripcion, string especie_estado)
        {
            Especie_descripcion=especie_descripcion;
            Especie_estado=especie_estado;
        }

        public Especie(int especie_id, string especie_descripcion, string especie_estado)
        {
            Especie_id=especie_id;
            Especie_descripcion=especie_descripcion;
            Especie_estado=especie_estado;
        }
        #endregion

        #region Getter's and Setter's
        public int Especie_id { get => especie_id; set => especie_id=value; }
        public string Especie_descripcion { get => especie_descripcion; set => especie_descripcion=value; }
        public string Especie_estado { get => especie_estado; set => especie_estado=value; }
        #endregion
    }
}
