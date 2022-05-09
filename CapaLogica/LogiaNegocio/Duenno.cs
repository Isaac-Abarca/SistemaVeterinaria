using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogiaNegocio
{
    internal class Duenno
    {
        #region Atributos

        protected int    duenno_id;
        protected string duenno_cedula;
        protected string duenno_nombre;
        protected string duenno_apellidos;
        protected string duenno_telefono;
        protected string duenno_direccion;
        protected string duenno_estado;

        #endregion

        #region Constructores
        public Duenno(int duenno_id, string duenno_cedula, string duenno_nombre,
            string duenno_apellidos, string duenno_telefono, string duenno_direccion, string duenno_estado)
        {
            Duenno_id=duenno_id;
            Duenno_cedula=duenno_cedula;
            Duenno_nombre=duenno_nombre;
            Duenno_apellidos=duenno_apellidos;
            Duenno_telefono=duenno_telefono;
            Duenno_direccion=duenno_direccion;
            Duenno_estado=duenno_estado;
        }

        public Duenno(string duenno_cedula, string duenno_nombre,
            string duenno_apellidos, string duenno_telefono, string duenno_direccion, string duenno_estado)
        {
            Duenno_cedula=duenno_cedula;
            Duenno_nombre=duenno_nombre;
            Duenno_apellidos=duenno_apellidos;
            Duenno_telefono=duenno_telefono;
            Duenno_direccion=duenno_direccion;
            Duenno_estado=duenno_estado;
        }
        #endregion

        #region Get's and Setter's
        public int Duenno_id { get => duenno_id; set => duenno_id=value; }
        public string Duenno_cedula { get => duenno_cedula; set => duenno_cedula=value; }
        public string Duenno_nombre { get => duenno_nombre; set => duenno_nombre=value; }
        public string Duenno_apellidos { get => duenno_apellidos; set => duenno_apellidos=value; }
        public string Duenno_telefono { get => duenno_telefono; set => duenno_telefono=value; }
        public string Duenno_direccion { get => duenno_direccion; set => duenno_direccion=value; }
        public string Duenno_estado { get => duenno_estado; set => duenno_estado=value; }
        #endregion
    }
}
