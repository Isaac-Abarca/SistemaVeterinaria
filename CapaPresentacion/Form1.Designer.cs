using System.Windows.Forms;

namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccederr = new System.Windows.Forms.Button();
            this.linkRecupererContra = new System.Windows.Forms.LinkLabel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrrar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 286);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(276, 72);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(331, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPasword
            // 
            this.txtPasword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPasword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasword.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txtPasword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPasword.Location = new System.Drawing.Point(276, 127);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(331, 22);
            this.txtPasword.TabIndex = 2;
            this.txtPasword.Text = "Contraseña";
            this.txtPasword.Enter += new System.EventHandler(this.txtPasword_Enter);
            this.txtPasword.Leave += new System.EventHandler(this.txtPasword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(399, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // btnAccederr
            // 
            this.btnAccederr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccederr.FlatAppearance.BorderSize = 0;
            this.btnAccederr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAccederr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccederr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccederr.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.btnAccederr.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAccederr.Location = new System.Drawing.Point(276, 201);
            this.btnAccederr.Name = "btnAccederr";
            this.btnAccederr.Size = new System.Drawing.Size(331, 35);
            this.btnAccederr.TabIndex = 3;
            this.btnAccederr.Text = "Acceder";
            this.btnAccederr.UseVisualStyleBackColor = false;
            this.btnAccederr.Click += new System.EventHandler(this.btnAccederr_Click);
            // 
            // linkRecupererContra
            // 
            this.linkRecupererContra.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkRecupererContra.AutoSize = true;
            this.linkRecupererContra.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.linkRecupererContra.LinkColor = System.Drawing.Color.DimGray;
            this.linkRecupererContra.Location = new System.Drawing.Point(367, 248);
            this.linkRecupererContra.Name = "linkRecupererContra";
            this.linkRecupererContra.Size = new System.Drawing.Size(169, 17);
            this.linkRecupererContra.TabIndex = 0;
            this.linkRecupererContra.TabStop = true;
            this.linkRecupererContra.Text = "¿Ha olvidado su contrseña?";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Image = global::CapaPresentacion.Properties.Resources.icons8_box_important_15;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(276, 170);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(58, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "                 ";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.ErrorImage = global::CapaPresentacion.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(620, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 12);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrrar
            // 
            this.btnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrrar.Image")));
            this.btnCerrrar.Location = new System.Drawing.Point(654, 0);
            this.btnCerrrar.Name = "btnCerrrar";
            this.btnCerrrar.Size = new System.Drawing.Size(13, 12);
            this.btnCerrrar.TabIndex = 6;
            this.btnCerrrar.TabStop = false;
            this.btnCerrrar.Click += new System.EventHandler(this.btnCerrrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-13, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 166);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(669, 286);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCerrrar);
            this.Controls.Add(this.linkRecupererContra);
            this.Controls.Add(this.btnAccederr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox txtUser;
        private TextBox txtPasword;
        private Label label1;
        private Button btnAccederr;
        private LinkLabel linkRecupererContra;
        private PictureBox btnCerrrar;
        private PictureBox btnMinimizar;
        private PictureBox pictureBox3;
        private Label lblError;
    }
}