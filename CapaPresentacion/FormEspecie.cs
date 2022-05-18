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
    public partial class FormEspecie : Form
    {

        DataSet dsEspecie = new DataSet();
        DataTable dtEspecie = new DataTable();
        bool listoModificar = false;
        int tableEspeId;
        public FormEspecie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEspecie_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
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
            txtDescripcion.Clear();
            txtEstado.Clear();
        }

        private void cargarDatosExpendiente()
        {
            listoModificar = true;
            txtId.Text = this.tableEspeId+"";
            txtDescripcion.Text = this.dtEspecie.Rows[0]["Especie_descripcion"].ToString();
            txtEstado.Text = this.dtEspecie.Rows[0]["Especie_estado"].ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorEspecie espe = new GestorEspecie())
            {
                if (listoModificar == false)
                {
                    if (txtDescripcion.Text != "" )
                    {
                        espe.insertarEspecie(txtDescripcion.Text, "A");
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
            using (GestorEspecie espe = new GestorEspecie())
            {
                datagEspe.DataSource = espe.listarEspecie();
                datagEspe.Columns["Especie_estado"].Visible = false;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorEspecie espe = new GestorEspecie())
                {
                    Especie expediente = new Especie(tableEspeId,txtDescripcion.Text, "A");
                    espe.modificarEspecie(expediente);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }

        private void datagEspe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numFila = datagEspe.CurrentCell.RowIndex;
                if (this.datagEspe[0, numFila].Value.ToString() != "")
                {
                    this.tableEspeId = (int)datagEspe.Rows[numFila].Cells[0].Value;

                    int Espe_id = int.Parse(this.datagEspe[0, numFila].Value.ToString());
                    using (GestorEspecie espe = new GestorEspecie())
                    {
                        this.dsEspecie = espe.consultaEspecie(Espe_id);
                        this.dtEspecie = this.dsEspecie.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarTxt();
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
                using (GestorEspecie espe = new GestorEspecie())
                {
                    mss = espe.inactivarEspecie(id);
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
