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
    public partial class FormMascota : Form
    {

        DataSet dsDatos = new DataSet();
        DataTable dtDatos = new DataTable();
        bool listoModificar = false;
        int tableExpeId;

        public FormMascota()
        {
            InitializeComponent();
        }

        private void FormMascota_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorMascota mascota = new GestorMascota())
            {
                if (listoModificar == false)
                {
                    if (txtEspecieId.Text != "" && TxtDuenno_id.Text != ""
                        && txtNombre.Text != "" && txtGenero.Text != "" && txtColor.Text != ""
                        && txtPeso.Text != "")
                    {
                        mascota.insertarMascota(int.Parse(txtEspecieId.Text), int.Parse(TxtDuenno_id.Text),
                            txtNombre.Text, txtGenero.Text, txtColor.Text,dtFecha.Text,float.Parse( txtPeso.Text), "A");
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
            using (GestorMascota mascota = new GestorMascota())
            {
                dataGMascota.DataSource = mascota.listarMascota();
                dataGMascota.Columns["Mascota_estado"].Visible = false;
                this.dataGMascota.Columns["Mascota_fecha_nacimiento"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

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
                using (GestorMascota mascota = new GestorMascota())
                {
                    Mascota masco = new Mascota(tableExpeId, int.Parse(txtEspecieId.Text), int.Parse(TxtDuenno_id.Text),
                            txtNombre.Text, txtGenero.Text, txtColor.Text, dtFecha.Text, float.Parse(txtPeso.Text), "A");
                    mascota.modificarMascota(masco);
                    cargarCargarGrid();
                    limpiarTxt();
                }
            }
            else
            {
                alerta("Aun no a selecionado nada para modificar");
            }
        }

        private void dataGMascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int numFila = dataGMascota.CurrentCell.RowIndex;
                if (this.dataGMascota[0, numFila].Value.ToString() != "")
                {
                    this.tableExpeId = (int)dataGMascota.Rows[numFila].Cells[0].Value;
                    int mascota_id = int.Parse(this.dataGMascota[0, numFila].Value.ToString());
                    using (GestorMascota mascota = new GestorMascota())
                    {
                        this.dsDatos = mascota.consultaMascota(mascota_id);
                        this.dtDatos = this.dsDatos.Tables[0];
                    }
                    cargarDatosMascota();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarDatosMascota()
        {
            listoModificar = true;
            txtId.Text = this.tableExpeId+"";
            txtEspecieId.Text = this.dtDatos.Rows[0]["Especie_id"].ToString();
            TxtDuenno_id.Text = this.dtDatos.Rows[0]["Duenno_id"].ToString();
            txtNombre.Text = this.dtDatos.Rows[0]["Mascota_nombre"].ToString();
            txtGenero.Text = this.dtDatos.Rows[0]["Mascota_Genero"].ToString();
            txtColor.Text = this.dtDatos.Rows[0]["Mascota_Color"].ToString();
            txtPeso.Text = this.dtDatos.Rows[0]["Mascota_Peso"].ToString();
            dtFecha.Text = this.dtDatos.Rows[0]["Mascota_fecha_nacimiento"].ToString();
            txtEstado.Text = this.dtDatos.Rows[0]["Mascota_estado"].ToString();
        }

        public void limpiarTxt()
        {
            listoModificar = false;
            txtId.Clear();
            txtEspecieId.Clear();
            TxtDuenno_id.Clear();
            txtNombre.Clear();
            txtGenero.Clear();
            txtColor.Clear();
            txtPeso.Clear();
            txtEstado.Clear();
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
                using (GestorMascota mascota = new GestorMascota())
                {
                    mss = mascota.inactivarMascota(id);
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
