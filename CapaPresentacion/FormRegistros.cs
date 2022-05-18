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
    public partial class FormRegistros : Form
    {
        private Form activeForm;
        public FormRegistros()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsertarMedicamento_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMedicamento(), sender);
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //ActivateButton(btnSender);
            activeForm=childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            this.panelRegistro.Controls.Add(childForm);
            this.panelRegistro.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnInsertarVeterinario_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVeterinario(), sender);
        }

        private void btnInsertarEspecie_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEspecie(), sender);
        }

        private void btnInsertarDuenno_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDuenno(), sender);
        }

        private void btnInsertarMascota_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMascota(), sender);
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUsuario(), sender);
        }
    }
}
