using CapaIntegracion;
using CapaLogica.LogiaNegocio;
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
    public partial class FormDuenno : Form
    {

        DataSet dsExpediente = new DataSet();
        DataTable dtExpediente = new DataTable();
        bool listoModificar = false;
        int tableId;

        public FormDuenno()
        {
            InitializeComponent();
        }

        private void FormDuenno_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorDuenno duenno = new GestorDuenno())
            {
                if (listoModificar == false)
                {
                    if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "")
                    {
                        duenno.insertarDuenno(txtCedula.Text, txtNombre.Text,txtApellido.Text, txtTelefono.Text, txtDireccion.Text, "A");
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
            using (GestorDuenno duenno = new GestorDuenno())
            {
                dtGDuenno.DataSource = duenno.listarDuenno();
                dtGDuenno.Columns["Duenno_estado"].Visible = false;
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
            tableId = 0;
            txtId.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEstado.Clear();
        }
        private void cargarDatosDuenno()
        {
            listoModificar = true;
            txtId.Text = this.tableId+"";
            txtCedula.Text = this.dtExpediente.Rows[0]["Duenno_cedula"].ToString();
            txtNombre.Text = this.dtExpediente.Rows[0]["Duenno_nombre"].ToString();
            txtApellido.Text = this.dtExpediente.Rows[0]["Duenno_apellido"].ToString();
            txtTelefono.Text = this.dtExpediente.Rows[0]["Duenno_telefono"].ToString();
            txtDireccion.Text = this.dtExpediente.Rows[0]["Duenno_direccion"].ToString();
            txtEstado.Text = this.dtExpediente.Rows[0]["Duenno_estado"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarTxt();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorDuenno duenno = new GestorDuenno())
                {
                    Duenno duen = new Duenno(tableId, txtCedula.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, "A");
                    duenno.modificarDuenno(duen);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }

        private void dtGDuenno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dtGDuenno.CurrentCell.RowIndex;
                if (this.dtGDuenno[0, numFila].Value.ToString() != "")
                {
                    this.tableId = (int)dtGDuenno.Rows[numFila].Cells[0].Value;

                    int Vet_id = int.Parse(this.dtGDuenno[0, numFila].Value.ToString());
                    using (GestorDuenno duenno = new GestorDuenno())
                    {
                        this.dsExpediente = duenno.consultaDuenno(Vet_id);
                        this.dtExpediente = this.dsExpediente.Tables[0];
                    }
                    cargarDatosDuenno();
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
                using (GestorDuenno duenno = new GestorDuenno())
                {
                    mss = duenno.inactivarDuenno(id);
                }
                limpiarTxt();
            }
            else
            {
                mss = "No has selecionado un tratamiento";
            }
            alerta(mss);

        }
    }
}
