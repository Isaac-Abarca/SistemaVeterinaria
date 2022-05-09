using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogiaNegocio
{
    internal class Usuario
    {
        protected int    usuario_id;
        protected string usuario_nombre;
        protected string usuario_contrasenna;
        protected string usuario_tipo;
        protected string usuario_estado;

        public int    Usuario_id { get => usuario_id; set => usuario_id=value; }
        public string Usuario_nombre { get => usuario_nombre; set => usuario_nombre=value; }
        public string Usuario_contrasenna { get => usuario_contrasenna; set => usuario_contrasenna=value; }
        public string Usuario_tipo { get => usuario_tipo; set => usuario_tipo=value; }
        public string Usuario_estado { get => usuario_estado; set => usuario_estado=value; }

        public Usuario(int usuario_id, string usuario_nombre, string usuario_contrasenna, string usuario_tipo, string usuario_estado)
        {
            this.Usuario_id=usuario_id;
            this.Usuario_nombre=usuario_nombre;
            this.Usuario_contrasenna=usuario_contrasenna;
            this.Usuario_tipo=usuario_tipo;
            this.Usuario_estado=usuario_estado;
        }

        public Usuario(string usuario_nombre, string usuario_contrasenna, string usuario_tipo, string usuario_estado)
        {
            this.Usuario_nombre=usuario_nombre;
            this.Usuario_contrasenna=usuario_contrasenna;
            this.Usuario_tipo=usuario_tipo;
            this.Usuario_estado=usuario_estado;
        }
    }
}
