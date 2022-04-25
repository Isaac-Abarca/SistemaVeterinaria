﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVeterinaria.CapaConexion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;

namespace CapaLogica.Servicios
{
    internal class ServicioVeterinario : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioVeterinario()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarVeterinario(Veterinario veterinario)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR MEDICAMENTO");

            comando.CommandText ="InsertarVeterinario";

            comando.Parameters.Add("Veterinario_cedula", SqlDbType.VarChar);
            comando.Parameters["Veterinario_cedula"].Value = veterinario.Veterinario_cedula;

            comando.Parameters.Add("Veterinario_nombre", SqlDbType.VarChar);
            comando.Parameters["Veterinario_nombre"].Value = veterinario.Veterinario_nombre;

            comando.Parameters.Add("Veterinario_telefono", SqlDbType.VarChar);
            comando.Parameters["Veterinario_telefono"].Value = veterinario.Veterinario_telefono;

            comando.Parameters.Add("Veterinario_direccion", SqlDbType.VarChar);
            comando.Parameters["Veterinario_direccion"].Value = veterinario.Veterinario_direccion;

            comando.Parameters.Add("Veterinario_estado", SqlDbType.VarChar);
            comando.Parameters["Veterinario_estado"].Value = veterinario.Veterinario_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarVeterinario(Veterinario veterinario)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR MEDICAMENTO");

            comando.CommandText ="ModificarMedicamento";

            comando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            comando.Parameters["Veterinario_id"].Value = veterinario.Veterinario_id;

            comando.Parameters.Add("Veterinario_cedula", SqlDbType.VarChar);
            comando.Parameters["Veterinario_cedula"].Value = veterinario.Veterinario_cedula;

            comando.Parameters.Add("Veterinario_nombre", SqlDbType.VarChar);
            comando.Parameters["Veterinario_nombre"].Value = veterinario.Veterinario_nombre;

            comando.Parameters.Add("Veterinario_telefono", SqlDbType.VarChar);
            comando.Parameters["Veterinario_telefono"].Value = veterinario.Veterinario_telefono;

            comando.Parameters.Add("Veterinario_direccion", SqlDbType.VarChar);
            comando.Parameters["Veterinario_direccion"].Value = veterinario.Veterinario_direccion;

            comando.Parameters.Add("Veterinario_estado", SqlDbType.VarChar);
            comando.Parameters["Veterinario_estado"].Value = veterinario.Veterinario_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION mEDICAMENTO";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarVeterinario(int Veterinario_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Veterinario");

            comando.CommandText ="ConsultarVeterinario";

            comando.Parameters.Add("Veterinario_id", SqlDbType.Int);
            comando.Parameters["@Veterinario_id"].Value = Veterinario_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarMedicamentos()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar Veterinario");

            comando.CommandText ="ListarVeterinario";

            DataSet Veterinario = new DataSet();

            Veterinario = this.seleccionarInformacion(comando);
            DataTable miTabla = Veterinario.Tables[0];
            return miTabla;

        }
    }
}