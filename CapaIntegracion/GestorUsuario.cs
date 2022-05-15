﻿using CapaLogica.LogiaNegocio;
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
    internal class GestorUsuario : servicio, IDisposable
    {
        public GestorUsuario()
        {
        }

        public void Dispose()
        {
        }

        public string insertarUsuario(string usuario_nombre,
        string usuario_contrasenna,
        string usuario_tipo,
        string usuario_estado)
        {
            Usuario nuevoUsuario = new Usuario(usuario_nombre, usuario_contrasenna, usuario_tipo, usuario_estado);
            using (ServicioUsuario Usuario = new ServicioUsuario())
                return Usuario.insetarUsuario(nuevoUsuario);
        }

        public DataTable listarUsuario()
        {
            using (ServicioUsuario Usuario = new ServicioUsuario())
                return Usuario.ListarUsuario();
        }


        public DataSet consultaUsuario(int Usuario_id)
        {
            using (ServicioMedicamento Medicamento = new ServicioMedicamento())
                return Medicamento.ConsultarMedicamento(Usuario_id);
        }

        public string modificarMascota(Usuario usuario)
        {
            using (ServicioUsuario Usuario = new ServicioUsuario())
                return Usuario.modificarUsuario(usuario);
        }
    }
}
