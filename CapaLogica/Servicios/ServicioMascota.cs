using CapaLogica.LogiaNegocio;
using SistemaVeterinaria.CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.CapaLogica.Servicios
{
    public class ServicioMascota : servicio, IDisposable
    {

        private SqlCommand comando;
        private string respuesta;

        public void Dispose()
        {
        }
        public ServicioMascota()
        {
            respuesta ="";
            comando = new SqlCommand();
        }

        public string insetarMascota(Mascota mascota)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR INSERTAR Mascota");

            comando.CommandText ="InsertarMascota";

            comando.Parameters.Add("Especie_id", SqlDbType.Int);
            comando.Parameters["Especie_id"].Value = mascota.Especie_id;

            comando.Parameters.Add("Duenno_id", SqlDbType.Int);
            comando.Parameters["Duenno_id"].Value = mascota.Duenno_id;

            comando.Parameters.Add("Mascota_nombre", SqlDbType.VarChar);
            comando.Parameters["Mascota_nombre"].Value = mascota.Mascota_nombre;

            comando.Parameters.Add("Mascota_genero", SqlDbType.VarChar);
            comando.Parameters["Mascota_genero"].Value = mascota.Mascota_genero;

            comando.Parameters.Add("Mascota_color", SqlDbType.VarChar);
            comando.Parameters["Mascota_color"].Value = mascota.Mascota_color;

            comando.Parameters.Add("Mascota_fecha_nacimiento", SqlDbType.Date);
            comando.Parameters["Mascota_fecha_nacimiento"].Value = mascota.Mascota_fecha_nacimiento;

            comando.Parameters.Add("Mascota_peso", SqlDbType.Float);
            comando.Parameters["Mascota_peso"].Value = mascota.Mascota_peso;

            comando.Parameters.Add("Mascota_estado", SqlDbType.VarChar);
            comando.Parameters["Mascota_estado"].Value = mascota.Mascota_estado;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la insercion";
            Console.WriteLine(respuesta);
            return respuesta;
        }

        public string modificarMascota(Mascota mascota)
        {

            comando = new SqlCommand();
            Console.WriteLine("GESTOR MODIFICAR Mascota");

            comando.CommandText ="ModificarMascota";

            comando.Parameters.Add("Mascota_id", SqlDbType.Int);
            comando.Parameters["Mascota_id"].Value = mascota.Mascota_id;

            comando.Parameters.Add("Especie_id", SqlDbType.Int);
            comando.Parameters["Especie_id"].Value = mascota.Especie_id;

            comando.Parameters.Add("Duenno_id", SqlDbType.Int);
            comando.Parameters["Duenno_id"].Value = mascota.Duenno_id;

            comando.Parameters.Add("Mascota_nombre", SqlDbType.VarChar);
            comando.Parameters["Mascota_nombre"].Value = mascota.Mascota_nombre;

            comando.Parameters.Add("Mascota_genero", SqlDbType.VarChar);
            comando.Parameters["Mascota_genero"].Value = mascota.Mascota_genero;

            comando.Parameters.Add("Mascota_color", SqlDbType.VarChar);
            comando.Parameters["Mascota_color"].Value = mascota.Mascota_color;

            comando.Parameters.Add("Mascota_fecha_nacimiento", SqlDbType.Date);
            comando.Parameters["Mascota_fecha_nacimiento"].Value = mascota.Mascota_fecha_nacimiento;

            comando.Parameters.Add("Mascota_peso", SqlDbType.Float);
            comando.Parameters["Mascota_peso"].Value = mascota.Mascota_peso;

            comando.Parameters.Add("Mascota_estado", SqlDbType.VarChar);
            comando.Parameters["Mascota_estado"].Value = mascota.Mascota_estado;


            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION mascota";
            Console.WriteLine(respuesta);

            return respuesta;
        }

        public DataSet ConsultarMascota(int Mascota_id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Consultar Mascota");

            comando.CommandText ="ConsultarMascota";

            comando.Parameters.Add("@Mascota_id", SqlDbType.Int);
            comando.Parameters["@Mascota_id"].Value = Mascota_id;

            DataSet dataSet = new DataSet();
            this.abrirConexion();
            dataSet = this.seleccionarInformacion(comando);
            this.cerrarConexion();
            return dataSet;

        }

        public DataTable ListarMascota()
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Listar Mascota");

            comando.CommandText ="ListarMascota";

            DataSet Mascota = new DataSet();

            Mascota = this.seleccionarInformacion(comando);
            DataTable miTabla = Mascota.Tables[0];
            return miTabla;

        }

        public string inactivarMascota(int id)
        {
            comando = new SqlCommand();
            Console.WriteLine("GESTOR Inactivar Mascota");

            comando.CommandText ="InactivarMascota";

            comando.Parameters.Add("@Mascota_id", SqlDbType.Int);
            comando.Parameters["@Mascota_id"].Value = id;

            respuesta = this.ejecutaSentencia(comando);
            if (respuesta == "")
                respuesta += "Se a realizado correctamente la MODIFICACION usuario";
            Console.WriteLine(respuesta);

            return respuesta;
        }
    }
}
