using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogiaNegocio
{
    public class Mascota
    {
        #region atributos

        protected int    mascota_id;
        protected int    especie_id;
        protected int    duenno_id;
        protected string mascota_nombre;
        protected string mascota_genero;
        protected string mascota_color;
        protected string   mascota_fecha_nacimiento;
        protected float  mascota_peso;
        protected string   mascota_estado;

        #endregion

        #region Constructores
        public Mascota(int mascota_id, int especie_id, int duenno_id, string mascota_nombre,
           string mascota_genero, string mascota_color, string mascota_fecha_nacimiento, float mascota_peso, string mascota_estado)
        {
            this.mascota_id=mascota_id;
            this.especie_id=especie_id;
            this.duenno_id=duenno_id;
            this.mascota_nombre=mascota_nombre;
            this.mascota_genero=mascota_genero;
            this.mascota_color=mascota_color;
            this.mascota_fecha_nacimiento=mascota_fecha_nacimiento;
            this.mascota_peso=mascota_peso;
            this.mascota_estado=mascota_estado;
        }

        public Mascota(int especie_id, int duenno_id, string mascota_nombre,
           string mascota_genero, string mascota_color, string mascota_fecha_nacimiento, float mascota_peso, string mascota_estado)
        {
            this.especie_id=especie_id;
            this.duenno_id=duenno_id;
            this.mascota_nombre=mascota_nombre;
            this.mascota_genero=mascota_genero;
            this.mascota_color=mascota_color;
            this.mascota_fecha_nacimiento=mascota_fecha_nacimiento;
            this.mascota_peso=mascota_peso;
            this.mascota_estado=mascota_estado;
        }

        #endregion

        #region Get's and setter's
        public int Mascota_id { get => mascota_id; set => mascota_id=value; }
        public int Especie_id { get => especie_id; set => especie_id=value; }
        public int Duenno_id { get => duenno_id; set => duenno_id=value; }
        public string Mascota_nombre { get => mascota_nombre; set => mascota_nombre=value; }
        public string Mascota_genero { get => mascota_genero; set => mascota_genero=value; }
        public string Mascota_color { get => mascota_color; set => mascota_color=value; }
        public string Mascota_fecha_nacimiento { get => mascota_fecha_nacimiento; set => mascota_fecha_nacimiento=value; }
        public float Mascota_peso { get => mascota_peso; set => mascota_peso=value; }
        public string Mascota_estado { get => mascota_estado; set => mascota_estado=value; }
        #endregion
    }
}
