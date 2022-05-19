using CapaComun.Cache;
using CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModerUi
{
    public partial class FormMainMenu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private const string Caption = "Warning";
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCerrarChildForm.Visible = false;
        }

        private Color SelectThemeColor()
        {
            try
            {
                int index = random.Next(ThemeColors.Colorlist.Count);
                while (tempIndex==index)
                {
                    index = random.Next(ThemeColors.Colorlist.Count);
                }
                tempIndex=index;
                string color = ThemeColors.Colorlist[index];
                return ColorTranslator.FromHtml(color);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string color2 = "#3F51B5";
            return ColorTranslator.FromHtml(color2);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    btnCerrarChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button)) { 
                    previousBtn.BackColor=Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor=Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm=childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text= childForm.Text;

        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCitas(),sender);
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            Console.Write("holaaaaaaaaaaaaaaaaaaaaaa");

            openChildForm(new FormExpediente(), sender);
        }

        private void btnConsumidor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTratamiento(), sender);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReportes(), sender);
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistros(), sender);
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            FormConfiguraciones form = new FormConfiguraciones();
            if (lblTipoUser.Text != "Administrador")
            {
                form.btnActivarUsuarios.Enabled = false;
            }
            openChildForm(form, sender);
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            LoadUserData();
            this.MaximizeBox = false;
            this.Text = "Menu Principal";
        }

        private void LoadUserData()
        {
            lblUser.Text = UserLoginCache.LoginName;
            lblTipoUser.Text = UserLoginCache.Position;

        }

        private void btnCerrarChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();

            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text ="HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCerrarChildForm.Visible = false;

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSecion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar la aplicacion?", Caption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            this.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
