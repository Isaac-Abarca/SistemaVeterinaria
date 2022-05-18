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
    public partial class FormVeterinario : Form
    {

        DataSet dsVeterinario = new DataSet();
        DataTable dtVeterinario = new DataTable();
        bool listoModificar = false;
        int tableVetId;
        public FormVeterinario()
        {
            InitializeComponent();
        }


        private void FormVeterinario_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorVeterinario vet = new GestorVeterinario())
            {
                if (listoModificar == false)
                {
                    if (txtCedula.Text != "" && txtNombre.Text != "" && txtTelefono.Text != ""  && txtDireccion.Text != "")
                    {


                        vet.insertarVeterinario(txtCedula.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, "A");
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

        private void cargarCargarGrid()
        {
            using (GestorVeterinario vet = new GestorVeterinario())
            {
                dataGVet.DataSource = vet.listarVeterinario();
                dataGVet.Columns["Veterinario_estado"].Visible = false;
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
            txtId.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEstado.Clear();
        }

        private void cargarDatosExpendiente()
        {
            listoModificar = true;
            txtId.Text = this.tableVetId+"";
            txtCedula.Text = this.dtVeterinario.Rows[0]["Veterinario_cedula"].ToString();
            txtNombre.Text = this.dtVeterinario.Rows[0]["Veterinario_nombre"].ToString();
            txtTelefono.Text = this.dtVeterinario.Rows[0]["Veterinario_telefono"].ToString();
            txtDireccion.Text = this.dtVeterinario.Rows[0]["Veterinario_direccion"].ToString();
            txtEstado.Text = this.dtVeterinario.Rows[0]["Veterinario_estado"].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorVeterinario vet = new GestorVeterinario())
                {
                    Veterinario expediente = new Veterinario(tableVetId,txtCedula.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, "A");
                    vet.modificarVeterinario(expediente);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }

        private void dataGVet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dataGVet.CurrentCell.RowIndex;
                if (this.dataGVet[0, numFila].Value.ToString() != "")
                {
                    this.tableVetId = (int)dataGVet.Rows[numFila].Cells[0].Value;

                    int Vet_id = int.Parse(this.dataGVet[0, numFila].Value.ToString());
                    using (GestorVeterinario vet = new GestorVeterinario())
                    {
                        this.dsVeterinario = vet.consultaVeterinario(Vet_id);
                        this.dtVeterinario = this.dsVeterinario.Tables[0];
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
            if (txtId.Text != "")
            {
                id = int.Parse(txtId.Text);
                using (GestorVeterinario vet = new GestorVeterinario())
                {
                    mss = vet.inactivarVeterinario(id);
                }
                limpiarTxt();
            }
            else
            {
                mss = "No has selecionado un tratamiento";
            }
            alerta(mss);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }
    }
}
