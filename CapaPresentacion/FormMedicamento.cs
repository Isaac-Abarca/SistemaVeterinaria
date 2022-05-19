using CapaIntegracion;
using SistemaVeterinaria.CapaLogica.LogiaNegocio;
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
    public partial class FormMedicamento : Form
    {

        DataSet dsMed = new DataSet();
        DataTable dtMed = new DataTable();
        bool listoModificar = false;
        int tableMedId;
        public FormMedicamento()
        {
            InitializeComponent();
        }

        private void lblIdMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using ( GestorMedicamento med = new GestorMedicamento())
            {
                if (listoModificar == false)
                {
                    if (txtNombre.Text != "" && txtDosis.Text != "" && txtDosis.Text != "")
                    {
                        med.insertarMedicamento(txtNombre.Text,txtDosis.Text, "A");
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

        private void FormMedicamento_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
        }

        private void cargarCargarGrid()
        {
            using (GestorMedicamento med = new GestorMedicamento())
            {
                dataGMedicamento.DataSource = med.listarMedicamento();
                dataGMedicamento.Columns["Medicamento_estado"].Visible = false;
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
            txtNombre.Clear();
            txtDosis.Clear();
            txtEstado.Clear();
        }




        public void desactivar()
        {
            string mss = "";
            int id;
            if (txtID.Text != "")
            {
                id = int.Parse(txtID.Text);
                using (GestorMedicamento med = new GestorMedicamento())
                {
                    mss = med.inactivarMedicamento(id);
                }
                limpiarTxt();
            }
            else
            {
                mss = "No has selecionado un tratamiento";
            }
            alerta(mss);

        }

        private void dataGMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dataGMedicamento.CurrentCell.RowIndex;
                if (this.dataGMedicamento[0, numFila].Value.ToString() != "")
                {
                    this.tableMedId = (int)dataGMedicamento.Rows[numFila].Cells[0].Value;

                    int Expe_id = int.Parse(this.dataGMedicamento[0, numFila].Value.ToString());
                    using (GestorMedicamento med = new GestorMedicamento())
                    {
                        this.dsMed = med.consultaMedicamento(Expe_id);
                        this.dtMed = this.dsMed.Tables[0];
                    }
                    cargarDatosMedicamento();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void cargarDatosMedicamento()
        {
            listoModificar = true;
            txtID.Text = this.tableMedId+"";
            txtNombre.Text = this.dtMed.Rows[0]["Medicamento_nombre"].ToString();
            txtDosis.Text = this.dtMed.Rows[0]["Medicamento_dosis"].ToString();
            txtEstado.Text = this.dtMed.Rows[0]["Medicamento_estado"].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorMedicamento med = new GestorMedicamento())
                {
                    Medicamento medicamento = new Medicamento(this.tableMedId, txtNombre.Text, txtDosis.Text, "A");
                    med.modificarMedicamento(medicamento);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            desactivar();
            cargarCargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }
    }
}
