using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaVeterinaria.CapaLogica.LogiaNegocio
{
    public class Veterinario
    {
        #region ATRIBUTOS

        protected int    veterinario_id;
        protected string veterinario_cedula;
        protected string veterinario_nombre;
        protected string veterinario_telefono;
        protected string veterinario_direccion;
        protected string veterinario_estado;
        #endregion

        #region GET's and SETTER's
        public int Veterinario_id { get => veterinario_id; set => veterinario_id=value; }
        public string Veterinario_cedula { get => veterinario_cedula; set => veterinario_cedula=value; }
        public string Veterinario_nombre { get => veterinario_nombre; set => veterinario_nombre=value; }
        public string Veterinario_telefono { get => veterinario_telefono; set => veterinario_telefono=value; }
        public string Veterinario_direccion { get => veterinario_direccion; set => veterinario_direccion=value; }
        public string Veterinario_estado { get => veterinario_estado; set => veterinario_estado=value; }
        #endregion

        #region CONSTRUCTORES
        public Veterinario(int veterinario_id, string veterinario_cedula, 
                            string veterinario_nombre, string veterinario_telefono, 
                             string veterinario_direccion, string veterinario_estado)
        {
            Veterinario_id=veterinario_id;
            Veterinario_cedula=veterinario_cedula;
            Veterinario_nombre=veterinario_nombre;
            Veterinario_telefono=veterinario_telefono;
            Veterinario_direccion=veterinario_direccion;
            Veterinario_estado=veterinario_estado;
        }
        public Veterinario( string veterinario_cedula,
                            string veterinario_nombre, string veterinario_telefono,
                             string veterinario_direccion, string veterinario_estado)
        {
            Veterinario_id=0;
            Veterinario_cedula=veterinario_cedula;
            Veterinario_nombre=veterinario_nombre;
            Veterinario_telefono=veterinario_telefono;
            Veterinario_direccion=veterinario_direccion;
            Veterinario_estado=veterinario_estado;
        }
        #endregion


    }
}
