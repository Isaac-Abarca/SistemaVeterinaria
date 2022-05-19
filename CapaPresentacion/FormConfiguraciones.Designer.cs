namespace CapaPresentacion
{
    partial class FormConfiguraciones
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
            this.btnActivarUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActivarUsuarios
            // 
            this.btnActivarUsuarios.Location = new System.Drawing.Point(42, 33);
            this.btnActivarUsuarios.Name = "btnActivarUsuarios";
            this.btnActivarUsuarios.Size = new System.Drawing.Size(127, 43);
            this.btnActivarUsuarios.TabIndex = 0;
            this.btnActivarUsuarios.Text = "Activar Usuarios";
            this.btnActivarUsuarios.UseVisualStyleBackColor = true;
            this.btnActivarUsuarios.Click += new System.EventHandler(this.btnActivarUsuarios_Click);
            // 
            // FormConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActivarUsuarios);
            this.Name = "FormConfiguraciones";
            this.Text = "FormConfiguraciones";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnActivarUsuarios;
    }
}