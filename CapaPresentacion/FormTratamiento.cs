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

namespace CapaPresentacion
{
    public partial class FormTratamiento : Form
    {
        DataSet dsTratamiento = new DataSet();
        DataTable dtTratamiento = new DataTable();
        bool listoModificar = false;

        public FormTratamiento()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                if (listoModificar == false)
                {
                    if (txtTratamiento_dosis.Text != "" &&txtTratamiento_observaciones.Text != "")
                    {
                        tratamiento.insertarTratamiento(Convert.ToInt32(cbMedicamento_id.SelectedValue), (txtTratamiento_dosis.Text), 
                            txtTratamiento_observaciones.Text,"A");
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMedicamento_id.SelectedIndex = -1;
            cargarCargarGrid();
            cargarComboMedicamento();
        }

        private void cargarCargarGrid()
        {
            using (GestorTratamiento gestorTratamiento = new GestorTratamiento())
            {
                datagritTratamientos.DataSource = gestorTratamiento.listarTratamientos();
                datagritTratamientos.Columns["Tratamiento_estado"].Visible = false;
            }
               
        }

        private void cargarComboMedicamento()
        {
            using (GestorMedicamento medicamento = new GestorMedicamento()) 
            {
                cbMedicamento_id.DataSource = medicamento.listarMedicamento();
                cbMedicamento_id.ValueMember = "Medicamento_id";
                cbMedicamento_id.DisplayMember = "Medicamento_nombre";
                cbMedicamento_id.SelectedIndex = -1;
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
            limpiarTxt();
        }

        private void cargarDatosTratamiento()
        {
            listoModificar = true;
            txtTratamiento_Id.Text = this.dtTratamiento.Rows[0]["Tratamiento_id"].ToString();
            txtTratamiento_dosis.Text = this.dtTratamiento.Rows[0]["Tratamiento_dosis"].ToString();
            cbMedicamento_id.SelectedValue = this.dtTratamiento.Rows[0]["Medicamento_id"].ToString();
            txtTratamiento_observaciones.Text = this.dtTratamiento.Rows[0]["Tratamiento_observaciones"].ToString();
        }

        private void datagritTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 int numFila = datagritTratamientos.CurrentCell.RowIndex;
                 if (this.datagritTratamientos[0, numFila].Value.ToString() != "")
                 {
                     int tratamiento_id = int.Parse(this.datagritTratamientos[0, numFila].Value.ToString());
                     using (GestorTratamiento tratamiento = new GestorTratamiento())
                     {
                         this.dsTratamiento = tratamiento.consultaTratamientos(tratamiento_id);
                         this.dtTratamiento = this.dsTratamiento.Tables[0];
                     }
                     cargarDatosTratamiento();
                 }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos","Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listoModificar == true)
            {
                using (GestorTratamiento tratamiento = new GestorTratamiento())
                {
                    Tratamiento tratamiento1 = new Tratamiento(int.Parse(txtTratamiento_Id.Text), Convert.ToInt32(cbMedicamento_id.SelectedValue), (txtTratamiento_dosis.Text), txtTratamiento_observaciones.Text,
                         "A");
                    tratamiento.modificarTratamientos(tratamiento1);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
            
        }

        public void desactivar()
        {
            string mss = "";
            int id = 0;
            if (txtTratamiento_Id.Text != "")
            {
               id = int.Parse(txtTratamiento_Id.Text);
                using (GestorTratamiento tratamiento = new GestorTratamiento())
                {
                     mss = tratamiento.inactivarTratamientos(id);
                }
                limpiarTxt();
            }
            else
            {
                mss = "No has selecionado un tratamiento";
            }
            alerta(mss);

        }

        public void alerta(string mss)
        {
            MessageBox.Show(mss,"Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void limpiarTxt()
        {
            listoModificar = false;
            cbMedicamento_id.SelectedIndex = -1;
            txtTratamiento_dosis.Clear();
            txtTratamiento_Id.Clear();
            txtTratamiento_observaciones.Clear();
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
