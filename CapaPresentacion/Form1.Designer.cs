﻿namespace CapaPresentacion
{
    partial class SistemaVeterinara
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTratamiento_Id = new System.Windows.Forms.Label();
            this.lblMedicamento_id = new System.Windows.Forms.Label();
            this.lblTratamiento_dosis = new System.Windows.Forms.Label();
            this.lblTratamiento_observaiones = new System.Windows.Forms.Label();
            this.lblTratamiento_Estado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTratamiento_Id = new System.Windows.Forms.TextBox();
            this.txtMedicamento_id = new System.Windows.Forms.TextBox();
            this.txtTratamiento_dosis = new System.Windows.Forms.TextBox();
            this.txtTratamiento_observaciones = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datagritTratamientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagritTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTratamiento_Id
            // 
            this.lblTratamiento_Id.AutoSize = true;
            this.lblTratamiento_Id.Location = new System.Drawing.Point(59, 56);
            this.lblTratamiento_Id.Name = "lblTratamiento_Id";
            this.lblTratamiento_Id.Size = new System.Drawing.Size(75, 13);
            this.lblTratamiento_Id.TabIndex = 0;
            this.lblTratamiento_Id.Text = "Tratamiento Id";
            this.lblTratamiento_Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMedicamento_id
            // 
            this.lblMedicamento_id.AutoSize = true;
            this.lblMedicamento_id.Location = new System.Drawing.Point(59, 88);
            this.lblMedicamento_id.Name = "lblMedicamento_id";
            this.lblMedicamento_id.Size = new System.Drawing.Size(75, 13);
            this.lblMedicamento_id.TabIndex = 1;
            this.lblMedicamento_id.Text = "Medicaento Id";
            // 
            // lblTratamiento_dosis
            // 
            this.lblTratamiento_dosis.AutoSize = true;
            this.lblTratamiento_dosis.Location = new System.Drawing.Point(59, 113);
            this.lblTratamiento_dosis.Name = "lblTratamiento_dosis";
            this.lblTratamiento_dosis.Size = new System.Drawing.Size(88, 13);
            this.lblTratamiento_dosis.TabIndex = 2;
            this.lblTratamiento_dosis.Text = "Dosis tratamiento";
            // 
            // lblTratamiento_observaiones
            // 
            this.lblTratamiento_observaiones.AutoSize = true;
            this.lblTratamiento_observaiones.Location = new System.Drawing.Point(59, 139);
            this.lblTratamiento_observaiones.Name = "lblTratamiento_observaiones";
            this.lblTratamiento_observaiones.Size = new System.Drawing.Size(78, 13);
            this.lblTratamiento_observaiones.TabIndex = 3;
            this.lblTratamiento_observaiones.Text = "Observaciones";
            this.lblTratamiento_observaiones.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTratamiento_Estado
            // 
            this.lblTratamiento_Estado.AutoSize = true;
            this.lblTratamiento_Estado.Location = new System.Drawing.Point(59, 173);
            this.lblTratamiento_Estado.Name = "lblTratamiento_Estado";
            this.lblTratamiento_Estado.Size = new System.Drawing.Size(0, 13);
            this.lblTratamiento_Estado.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // txtTratamiento_Id
            // 
            this.txtTratamiento_Id.Location = new System.Drawing.Point(164, 56);
            this.txtTratamiento_Id.Name = "txtTratamiento_Id";
            this.txtTratamiento_Id.Size = new System.Drawing.Size(206, 20);
            this.txtTratamiento_Id.TabIndex = 7;
            // 
            // txtMedicamento_id
            // 
            this.txtMedicamento_id.Location = new System.Drawing.Point(164, 88);
            this.txtMedicamento_id.Name = "txtMedicamento_id";
            this.txtMedicamento_id.Size = new System.Drawing.Size(206, 20);
            this.txtMedicamento_id.TabIndex = 8;
            // 
            // txtTratamiento_dosis
            // 
            this.txtTratamiento_dosis.Location = new System.Drawing.Point(164, 115);
            this.txtTratamiento_dosis.Name = "txtTratamiento_dosis";
            this.txtTratamiento_dosis.Size = new System.Drawing.Size(206, 20);
            this.txtTratamiento_dosis.TabIndex = 9;
            // 
            // txtTratamiento_observaciones
            // 
            this.txtTratamiento_observaciones.Location = new System.Drawing.Point(164, 142);
            this.txtTratamiento_observaciones.Name = "txtTratamiento_observaciones";
            this.txtTratamiento_observaciones.Size = new System.Drawing.Size(206, 20);
            this.txtTratamiento_observaciones.TabIndex = 10;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(178, 223);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // datagritTratamientos
            // 
            this.datagritTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagritTratamientos.Location = new System.Drawing.Point(451, 56);
            this.datagritTratamientos.Name = "datagritTratamientos";
            this.datagritTratamientos.Size = new System.Drawing.Size(568, 301);
            this.datagritTratamientos.TabIndex = 14;
            // 
            // SistemaVeterinara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.datagritTratamientos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtTratamiento_observaciones);
            this.Controls.Add(this.txtTratamiento_dosis);
            this.Controls.Add(this.txtMedicamento_id);
            this.Controls.Add(this.txtTratamiento_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTratamiento_Estado);
            this.Controls.Add(this.lblTratamiento_observaiones);
            this.Controls.Add(this.lblTratamiento_dosis);
            this.Controls.Add(this.lblMedicamento_id);
            this.Controls.Add(this.lblTratamiento_Id);
            this.Name = "SistemaVeterinara";
            this.Text = "Sistema Veterinaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagritTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTratamiento_Id;
        private System.Windows.Forms.Label lblMedicamento_id;
        private System.Windows.Forms.Label lblTratamiento_dosis;
        private System.Windows.Forms.Label lblTratamiento_observaiones;
        private System.Windows.Forms.Label lblTratamiento_Estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTratamiento_Id;
        private System.Windows.Forms.TextBox txtMedicamento_id;
        private System.Windows.Forms.TextBox txtTratamiento_dosis;
        private System.Windows.Forms.TextBox txtTratamiento_observaciones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datagritTratamientos;
    }
}

