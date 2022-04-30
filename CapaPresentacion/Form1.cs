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

namespace CapaPresentacion
{
    public partial class SistemaVeterinara : Form
    {
        public SistemaVeterinara()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorTratamiento tratamiento = new GestorTratamiento())
            {
                tratamiento.insertarTratamiento(Convert.ToInt32(txtMedicamento_id.Text), float.Parse( txtTratamiento_dosis.Text), txtTratamiento_observaciones.Text,
                    "A");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCargarGrid();
        }

        private void cargarCargarGrid()
        {
            using (GestorTratamiento gestorTratamiento = new GestorTratamiento())
            {
                datagritTratamientos.DataSource = gestorTratamiento.listarTratamientos();
            }
               
        }
    }
}
