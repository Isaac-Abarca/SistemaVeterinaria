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
    public partial class FormUsuario : Form
    {
        DataSet dsDatos = new DataSet();
        DataTable dtDatos = new DataTable();
        bool listoModificar = false;
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
            cargarComboTratamiento();
        }

        private void cargarComboTratamiento()
        {
            cbTipo.Items.Add("Administrador");
            cbTipo.Items.Add("Secretario");
            cbTipo.SelectedIndex = -1;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorUsuario usuario = new GestorUsuario())
            {
                if (listoModificar == false)
                {
                    if (txtNombre.Text != "" &&  txtContrasenna.Text != "" && cbTipo.SelectedIndex != -1)
                    {
                        alerta(cbTipo.Text);
                        usuario.insertarUsuario((txtNombre.Text), (txtContrasenna.Text),
                            cbTipo.Text,"A");
                        cargarCargarGrid();
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
            using (GestorUsuario usuario = new GestorUsuario())
            {
                dataGUsuario.DataSource = usuario.listarUsuario();
                dataGUsuario.Columns["Usuario_estado"].Visible = false;
            }

        }
        public void limpiarTxt()
        {
            listoModificar = false;
            txtId.Clear();
            txtNombre.Clear();
            txtContrasenna.Clear();
            cbTipo.SelectedIndex = 0;
            txtEstado.Clear();
        }

        private void cargarDatosTratamiento(string name, string contrasenaa, string tipo, string estado, int usuario_id)
        {
            listoModificar = true;
            txtId.Text = usuario_id+"";
            txtNombre.Text = name;
            txtContrasenna.Text = contrasenaa;
            if ("Administrador" == tipo ) 
            {
                cbTipo.SelectedIndex = 1;
            }
            else
            {
                cbTipo.SelectedIndex = 2;
            }
            txtEstado.Text = estado;
        }

        public void alerta(string mss)
        {
            MessageBox.Show(mss, "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorUsuario usuario = new GestorUsuario())
                {
                    Usuario usuario1 = new Usuario(int.Parse(txtId.Text), (txtNombre.Text), (txtContrasenna.Text),
                            cbTipo.Text, "A");
                    usuario.modificarUsuario(usuario1);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }
        
        private void dataGUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = dataGUsuario.CurrentCell.RowIndex;
                if (this.dataGUsuario[0, numFila].Value.ToString() != "")
                {
                    int tableid = int.Parse(this.dataGUsuario[0, numFila].Value.ToString());
                    string name = this.dataGUsuario[1, numFila].Value.ToString();
                    string contrasenaa = this.dataGUsuario[2, numFila].Value.ToString();
                    string tipo = this.dataGUsuario[3, numFila].Value.ToString();
                    string estado = this.dataGUsuario[4, numFila].Value.ToString();
                    using (GestorUsuario usuario = new GestorUsuario())
                    {
                        this.dsDatos = usuario.consultaUsuario(tableid);
                        this.dtDatos = this.dsDatos.Tables[0];
                    }
                    cargarDatosTratamiento(name, contrasenaa, tipo, estado, tableid);
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
                using (GestorUsuario usuario = new GestorUsuario())
                {
                    mss = usuario.inactivarUsuario(id);
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
