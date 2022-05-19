using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaIntegracion;
using SistemaVeterinaria.CapaIntegracion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;
using SistememaVeterinaria.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class FormExpediente : Form
    {

        DataSet dsExpediente = new DataSet();
        DataTable dtExpediente = new DataTable();
        bool listoModificar = false;
        int tableExpeId;

        public FormExpediente()
        {
            InitializeComponent();
        }

        private void FormExpediente_Load(object sender, EventArgs e)
        {
            cargarComboTratamiento();
            cargarComboVeterinario();
            cargarComboMascota();
            cargarCargarGrid();
        }

        private void cargarComboVeterinario()
        {
            using (GestorVeterinario Veterinario = new GestorVeterinario())
            {
                cbVeterinario.DataSource = Veterinario.listarVeterinario();
                cbVeterinario.ValueMember = "Veterinario_id";
                cbVeterinario.DisplayMember = "Veterinario_nombre";
                cbVeterinario.SelectedIndex = -1;
            }
        }

        private void cargarComboTratamiento()
        {
            using (GestorTratamiento Tratamiento = new GestorTratamiento())
            {
                cbTrtamiento.DataSource = Tratamiento.listarTratamientos();
                cbTrtamiento.ValueMember = "Tratamiento_id";
                cbTrtamiento.DisplayMember = "Tratamiento_id";
                cbTrtamiento.SelectedIndex = -1;
            }
        }

        private void cargarComboMascota()
        {
            using (GestorMascota Mascota = new GestorMascota())
            {
                cbMascota.DataSource = Mascota.listarMascota();
                cbMascota.ValueMember = "Mascota_id";
                cbMascota.DisplayMember = "Mascota_nombre";
                cbMascota.SelectedIndex = -1;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorExpediente expe = new GestorExpediente())
            {
                if (listoModificar == false)
                {
                    if (cbMascota.SelectedIndex  != -1 && cbTrtamiento.SelectedIndex != -1  && cbVeterinario .SelectedIndex != -1)
                    {
                        expe.insertarExpediente(Convert.ToInt32(cbMascota.SelectedValue), Convert.ToInt32(cbVeterinario.SelectedValue),
                            Convert.ToInt32(cbTrtamiento.SelectedValue),dtFecha.Text,"A");
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

        private void cargarDatosExpendiente()
        {
            listoModificar = true;
            txtID.Text = this.tableExpeId+"";
            cbMascota.SelectedValue  = this.dtExpediente.Rows[0]["Mascota_id"].ToString();
            cbVeterinario.SelectedValue = this.dtExpediente.Rows[0]["Veterinario_id"].ToString();
            cbTrtamiento.SelectedValue = this.dtExpediente.Rows[0]["Tratamiento_id"].ToString();
            dtFecha.Text = this.dtExpediente.Rows[0]["Expediente_fecha"].ToString();
            txtEstado.Text = this.dtExpediente.Rows[0]["Expediente_estado"].ToString();
        }

        private void cargarCargarGrid()
        {
            using (GestorExpediente expe = new GestorExpediente())
            {
                dataGExpediente.DataSource = expe.listarExpediente();
                dataGExpediente.Columns["Expediente_estado"].Visible = false;
            }

        }
        public void alerta(string mss)
        {
            MessageBox.Show(mss, "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void limpiarTxt()
        {
            listoModificar = false;
            txtID.Clear();
            cbMascota.SelectedIndex = -1;
            cbTrtamiento.SelectedIndex = -1;
            cbVeterinario.SelectedIndex = -1;
            txtEstado.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorExpediente expe = new GestorExpediente())
                {
                    Expediente expediente = new Expediente(this.tableExpeId, Convert.ToInt32(cbMascota.SelectedValue), Convert.ToInt32(cbVeterinario.SelectedValue),
                            Convert.ToInt32(cbTrtamiento.SelectedValue), dtFecha.Text, "A");
                    expe.modificarExpediente(expediente);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }

        private void dataGExpediente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dataGExpediente.CurrentCell.RowIndex;
                if (this.dataGExpediente[0, numFila].Value.ToString() != "")
                {
                    this.tableExpeId = (int)dataGExpediente.Rows[numFila].Cells[0].Value;

                    int Expe_id = int.Parse(this.dataGExpediente[0, numFila].Value.ToString());
                    using (GestorExpediente expe = new GestorExpediente())
                    {
                        this.dsExpediente = expe.consultaExpediente(Expe_id);
                        this.dtExpediente = this.dsExpediente.Tables[0];
                    }
                    cargarDatosExpendiente();
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
            int id;
            if (txtID.Text != "")
            {
                id = int.Parse(txtID.Text);
                using (GestorExpediente expe = new GestorExpediente())
                {
                    mss = expe.inactivarExpediente(id);
                }
                limpiarTxt();
            }
            else
            {
                mss = "No has selecionado un tratamiento";
            }
            alerta(mss);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }
    }
}
