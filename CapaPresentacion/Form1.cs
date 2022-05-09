using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVeterinaria.CapaIntegracion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;

namespace CapaPresentacion
{
    public partial class SistemaVeterinara : Form
    {
        DataSet dsTratamiento = new DataSet();
        DataTable dtTratamiento = new DataTable();

        public SistemaVeterinara()
        {
            InitializeComponent();
        }



        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                tratamiento.insertarTratamiento(Convert.ToInt32(txtMedicamento_id.Text), ( txtTratamiento_dosis.Text), txtTratamiento_observaciones.Text,
                    "A");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
            cargarComboTratamiento();
        }

        private void cargarCargarGrid()
        {
            using (GestorTratamiento gestorTratamiento = new GestorTratamiento())
            {
                datagritTratamientos.DataSource = gestorTratamiento.listarTratamientos();
                datagritTratamientos.Columns["Tratamiento_id"].Visible = false;
                datagritTratamientos.Columns["Tratamiento_estado"].Visible = false;
            }
               
        }

        private void cargarComboTratamiento()
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento()) 
            {
                cbxTratamiento.DataSource = tratamiento.listarTratamientos();
                cbxTratamiento.ValueMember = "Tratamiento_id";
                cbxTratamiento.DisplayMember = "Tratamiento_dosis";
            }
        }

        private void buscarTratamiento()
        {
            int tratamiento_id = int.Parse(cbxTratamiento.SelectedValue.ToString());
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                this.dsTratamiento = tratamiento.consultaTratamientos(tratamiento_id);
                this.dtTratamiento = this.dsTratamiento.Tables[0];
            }
            cargarDatosTratamiento();
        }

        private void cargarDatosTratamiento()
        {
            txtTratamiento_Id .Text = this.dtTratamiento.Rows[0]["Tratamiento_id"].ToString();
            txtMedicamento_id.Text = this.dtTratamiento.Rows[0]["Medicamento_id"].ToString();
            txtTratamiento_dosis.Text = this.dtTratamiento.Rows[0]["Tratamiento_dosis"].ToString();
            txtTratamiento_observaciones.Text = this.dtTratamiento.Rows[0]["Tratamiento_observaciones"].ToString();
        }

        private void datagritTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = datagritTratamientos.CurrentCell.RowIndex;
                int tratamiento_id = int.Parse(this.datagritTratamientos[0, numFila].Value.ToString());

                using (GestorTratamiento tratamiento = new GestorTratamiento())
                {
                    this.dsTratamiento = tratamiento.consultaTratamientos(tratamiento_id);
                    this.dtTratamiento = this.dsTratamiento.Tables[0];
                }
                cargarDatosTratamiento();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos","Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                Tratamiento tratamiento1 = new Tratamiento(int.Parse(txtTratamiento_Id.Text), int.Parse(txtMedicamento_id.Text), (txtTratamiento_dosis.Text), txtTratamiento_observaciones.Text,
                     "A");
                tratamiento.modificarTratamientos(tratamiento1);
            }
        }
    }
}
