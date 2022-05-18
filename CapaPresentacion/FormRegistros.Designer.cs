namespace CapaPresentacion
{
    partial class FormRegistros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertarDuenno = new System.Windows.Forms.Button();
            this.btnInsertarMascota = new System.Windows.Forms.Button();
            this.btnInsertarEspecie = new System.Windows.Forms.Button();
            this.btnInsertarMedicamento = new System.Windows.Forms.Button();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.btnInsertarVeterinario = new System.Windows.Forms.Button();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertarDuenno
            // 
            this.btnInsertarDuenno.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertarDuenno.Location = new System.Drawing.Point(467, 0);
            this.btnInsertarDuenno.Name = "btnInsertarDuenno";
            this.btnInsertarDuenno.Size = new System.Drawing.Size(167, 66);
            this.btnInsertarDuenno.TabIndex = 0;
            this.btnInsertarDuenno.Text = "Dueño";
            this.btnInsertarDuenno.UseVisualStyleBackColor = true;
            this.btnInsertarDuenno.Click += new System.EventHandler(this.btnInsertarDuenno_Click);
            // 
            // btnInsertarMascota
            // 
            this.btnInsertarMascota.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertarMascota.Location = new System.Drawing.Point(634, 0);
            this.btnInsertarMascota.Name = "btnInsertarMascota";
            this.btnInsertarMascota.Size = new System.Drawing.Size(175, 66);
            this.btnInsertarMascota.TabIndex = 1;
            this.btnInsertarMascota.Text = "Mascota";
            this.btnInsertarMascota.UseVisualStyleBackColor = true;
            this.btnInsertarMascota.Click += new System.EventHandler(this.btnInsertarMascota_Click);
            // 
            // btnInsertarEspecie
            // 
            this.btnInsertarEspecie.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertarEspecie.Location = new System.Drawing.Point(301, 0);
            this.btnInsertarEspecie.Name = "btnInsertarEspecie";
            this.btnInsertarEspecie.Size = new System.Drawing.Size(166, 66);
            this.btnInsertarEspecie.TabIndex = 2;
            this.btnInsertarEspecie.Text = "Especie";
            this.btnInsertarEspecie.UseVisualStyleBackColor = true;
            this.btnInsertarEspecie.Click += new System.EventHandler(this.btnInsertarEspecie_Click);
            // 
            // btnInsertarMedicamento
            // 
            this.btnInsertarMedicamento.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertarMedicamento.Location = new System.Drawing.Point(-2, 0);
            this.btnInsertarMedicamento.Name = "btnInsertarMedicamento";
            this.btnInsertarMedicamento.Size = new System.Drawing.Size(156, 66);
            this.btnInsertarMedicamento.TabIndex = 3;
            this.btnInsertarMedicamento.Text = "Medicamento";
            this.btnInsertarMedicamento.UseVisualStyleBackColor = true;
            this.btnInsertarMedicamento.Click += new System.EventHandler(this.btnInsertarMedicamento_Click);
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertarUsuario.Location = new System.Drawing.Point(809, 0);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(161, 66);
            this.btnInsertarUsuario.TabIndex = 4;
            this.btnInsertarUsuario.Text = "Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // btnInsertarVeterinario
            // 
            this.btnInsertarVeterinario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsertarVeterinario.Location = new System.Drawing.Point(154, 0);
            this.btnInsertarVeterinario.Name = "btnInsertarVeterinario";
            this.btnInsertarVeterinario.Size = new System.Drawing.Size(147, 66);
            this.btnInsertarVeterinario.TabIndex = 5;
            this.btnInsertarVeterinario.Text = "Veterinario";
            this.btnInsertarVeterinario.UseVisualStyleBackColor = true;
            this.btnInsertarVeterinario.Click += new System.EventHandler(this.btnInsertarVeterinario_Click);
            // 
            // panelRegistro
            // 
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(970, 597);
            this.panelRegistro.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInsertarMedicamento);
            this.panel2.Controls.Add(this.btnInsertarVeterinario);
            this.panel2.Controls.Add(this.btnInsertarEspecie);
            this.panel2.Controls.Add(this.btnInsertarDuenno);
            this.panel2.Controls.Add(this.btnInsertarMascota);
            this.panel2.Controls.Add(this.btnInsertarUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 66);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FormRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelRegistro);
            this.Name = "FormRegistros";
            this.Text = "FormRegistros";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarDuenno;
        private System.Windows.Forms.Button btnInsertarMascota;
        private System.Windows.Forms.Button btnInsertarEspecie;
        private System.Windows.Forms.Button btnInsertarMedicamento;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.Button btnInsertarVeterinario;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Panel panel2;
    }
}