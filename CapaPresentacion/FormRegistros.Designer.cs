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
            this.SuspendLayout();
            // 
            // btnInsertarDuenno
            // 
            this.btnInsertarDuenno.Location = new System.Drawing.Point(61, 59);
            this.btnInsertarDuenno.Name = "btnInsertarDuenno";
            this.btnInsertarDuenno.Size = new System.Drawing.Size(84, 83);
            this.btnInsertarDuenno.TabIndex = 0;
            this.btnInsertarDuenno.Text = "Dueño";
            this.btnInsertarDuenno.UseVisualStyleBackColor = true;
            // 
            // btnInsertarMascota
            // 
            this.btnInsertarMascota.Location = new System.Drawing.Point(173, 174);
            this.btnInsertarMascota.Name = "btnInsertarMascota";
            this.btnInsertarMascota.Size = new System.Drawing.Size(84, 83);
            this.btnInsertarMascota.TabIndex = 1;
            this.btnInsertarMascota.Text = "Mascota";
            this.btnInsertarMascota.UseVisualStyleBackColor = true;
            // 
            // btnInsertarEspecie
            // 
            this.btnInsertarEspecie.Location = new System.Drawing.Point(173, 59);
            this.btnInsertarEspecie.Name = "btnInsertarEspecie";
            this.btnInsertarEspecie.Size = new System.Drawing.Size(84, 83);
            this.btnInsertarEspecie.TabIndex = 2;
            this.btnInsertarEspecie.Text = "Especie";
            this.btnInsertarEspecie.UseVisualStyleBackColor = true;
            // 
            // btnInsertarMedicamento
            // 
            this.btnInsertarMedicamento.Location = new System.Drawing.Point(61, 288);
            this.btnInsertarMedicamento.Name = "btnInsertarMedicamento";
            this.btnInsertarMedicamento.Size = new System.Drawing.Size(84, 83);
            this.btnInsertarMedicamento.TabIndex = 3;
            this.btnInsertarMedicamento.Text = "Medicamento";
            this.btnInsertarMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Location = new System.Drawing.Point(173, 288);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(84, 83);
            this.btnInsertarUsuario.TabIndex = 4;
            this.btnInsertarUsuario.Text = "Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnInsertarVeterinario
            // 
            this.btnInsertarVeterinario.Location = new System.Drawing.Point(61, 174);
            this.btnInsertarVeterinario.Name = "btnInsertarVeterinario";
            this.btnInsertarVeterinario.Size = new System.Drawing.Size(84, 83);
            this.btnInsertarVeterinario.TabIndex = 5;
            this.btnInsertarVeterinario.Text = "Veterinario";
            this.btnInsertarVeterinario.UseVisualStyleBackColor = true;
            // 
            // FormRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.btnInsertarVeterinario);
            this.Controls.Add(this.btnInsertarUsuario);
            this.Controls.Add(this.btnInsertarMedicamento);
            this.Controls.Add(this.btnInsertarEspecie);
            this.Controls.Add(this.btnInsertarMascota);
            this.Controls.Add(this.btnInsertarDuenno);
            this.Name = "FormRegistros";
            this.Text = "FormRegistros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarDuenno;
        private System.Windows.Forms.Button btnInsertarMascota;
        private System.Windows.Forms.Button btnInsertarEspecie;
        private System.Windows.Forms.Button btnInsertarMedicamento;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.Button btnInsertarVeterinario;
    }
}