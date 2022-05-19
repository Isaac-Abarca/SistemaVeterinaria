using CapaLogica.LogiaNegocio;
using Microsoft.OData.Edm;
using SistememaVeterinaria.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormCitas : Form
    {

        DataSet dsCitas = new DataSet();
        DataTable dtCitas = new DataTable();
        bool listoModificar = false;
        int tableCitaId;

        public FormCitas()
        {
            InitializeComponent();
        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorCita cita = new GestorCita())
            {
                if (listoModificar == false)
                {
                    if (txtMacota_id.Text != "" && txtVeterinario_id.Text != "")
                    {
                        

                        cita.insertarCita(Convert.ToInt32(txtMacota_id.Text), Convert.ToInt32(txtVeterinario_id.Text),
                            dtFecha.Text, dtHora.Text, "A");
                        cargarCargarGrid();
                        //cargarComboTratamiento();
                        limpiarTxt();
                    }
                    else
                    {
                        alerta("Debes de completar todos los campos para poder registrar\nun nuevo tratamiento");
                    }
                }
                else
                {
                    alerta("Lo sentimos este valor ya se ingreso");
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorCita Cita = new GestorCita())
                {
                    Cita cita1 = new Cita(this.tableCitaId, Convert.ToInt32(txtMacota_id.Text), Convert.ToInt32(txtVeterinario_id.Text),
                            dtFecha.Text, dtHora.Text, "A");
                    Cita.modificarCita(cita1);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }

        public void limpiarTxt()
        {
            listoModificar = false;
            txtID.Clear();
            txtMacota_id.Clear();
            txtVeterinario_id.Clear();
            txtEstado.Clear();
        }
        private void cargarDatosTratamiento()
        {
            listoModificar = true;
            txtID.Text = this.tableCitaId+"";
            txtMacota_id.Text = this.dtCitas.Rows[0]["Mascota_id"].ToString();
            txtVeterinario_id.Text = this.dtCitas.Rows[0]["Veterinario_id"].ToString();
            dtFecha.Text = this.dtCitas.Rows[0]["Cita_fecha"].ToString();
            dtHora.Text = this.dtCitas.Rows[0]["Cita_hora"].ToString();
            txtEstado.Text = this.dtCitas.Rows[0]["Cita_estado"].ToString();
        }
        private void cargarCargarGrid()
        {
            using (GestorCita cita = new GestorCita())
            {

                dtCita.DataSource = cita.listarCita();
                dtCita.Columns["Cita_estado"].Visible = false;
                this.dtCita.Columns["Cita_fecha"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

        }

        public void alerta(string mss)
        {
            MessageBox.Show(mss, "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Cell_click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dtCita.CurrentCell.RowIndex;
                if (this.dtCita[0, numFila].Value.ToString() != "")
                {
                    this.tableCitaId = (int)dtCita.Rows[numFila].Cells[0].Value;

                    int cita_id = int.Parse(this.dtCita[0, numFila].Value.ToString());
                    using (GestorCita cita = new GestorCita())
                    {
                        this.dsCitas = cita.consultaCita(cita_id);
                        this.dtCitas = this.dsCitas.Tables[0];
                    }
                    cargarDatosTratamiento();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            desactivar();
            cargarCargarGrid();
        }

        public void desactivar()
        {
            string mss = "";
            int id = 0;
            if (txtID.Text != "")
            {
                id = int.Parse(txtID.Text);
                using (GestorCita cita = new GestorCita())
                {
                    mss = cita.inactivarCita(id);
                }
                limpiarTxt();
            }
            else
            {
                mss = "No has selecionado un tratamiento";
            }
            alerta(mss);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }
    }

}
