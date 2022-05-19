using CapaPresentacion;
using MultiColoredModerUi;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPasword_Enter(object sender, EventArgs e)
        {
            if (txtPasword.Text == "Contraseña")
            {
                txtPasword.Text = "";
                txtPasword.ForeColor = Color.LightGray;
                txtPasword.UseSystemPasswordChar = true;
            }
        }

        private void txtPasword_Leave(object sender, EventArgs e)
        {
            if (txtPasword.Text == "")
            {
                txtPasword.Text = "Contraseña";
                txtPasword.ForeColor = Color.Silver;
                txtPasword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAccederr_Click(object sender, EventArgs e)
        {
           
            if (txtUser.Text != "Usuario")
            {
                if(txtPasword.Text != "Contraseña")
                {
                    using (CapaIntegracion.GestorUsuario user = new CapaIntegracion.GestorUsuario())
                    {
                        var validPassword = user.Login(txtUser.Text, txtPasword.Text);
                        if (validPassword == true)
                        {
                            FormMainMenu meniPrincipal = new FormMainMenu();
                            meniPrincipal.Show();
                            meniPrincipal.FormClosed += Logout;
                            this.Hide();
                        }
                        else
                        {
                            msError("Usuario o contraseña incorrectos \n    Por favor intente de nuevo");
                            txtPasword.Clear();
                            txtPasword.Text = "Contraseña";
                            txtPasword.Focus();

                        }
                    }
                    
                    
                }
                else msError("Favor ingrese su contraseña");
            }
            else
                msError("Favor ingrese su nombre de usuario");
        }

        public void msError(string msg)
        {
            lblError.Text = "      "+msg;
            lblError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPasword.Clear();
            txtPasword.UseSystemPasswordChar = false;
            txtPasword.Text = "Contraseña";
            txtUser.Clear();
            txtUser.Text = "Usuario";
            lblError.Visible = false;
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}