﻿namespace CapaPresentacion
{
    partial class FormExpediente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.lblVeterinarioId = new System.Windows.Forms.Label();
            this.lblMascotaId = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtVeterinario_id = new System.Windows.Forms.TextBox();
            this.txtMacota_id = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(375, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 304);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(792, 51);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 36;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(504, 54);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(107, 21);
            this.cmbBuscar.TabIndex = 35;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(627, 55);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(146, 20);
            this.txtBusqueda.TabIndex = 34;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminar.Location = new System.Drawing.Point(237, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 35);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnModificar.Location = new System.Drawing.Point(127, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 35);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInsertar.Location = new System.Drawing.Point(31, 354);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 35);
            this.btnInsertar.TabIndex = 31;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(41, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Estado";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Fecha.Location = new System.Drawing.Point(41, 276);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(49, 18);
            this.Fecha.TabIndex = 28;
            this.Fecha.Text = "Fecha";
            // 
            // lblVeterinarioId
            // 
            this.lblVeterinarioId.AutoSize = true;
            this.lblVeterinarioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVeterinarioId.Location = new System.Drawing.Point(41, 199);
            this.lblVeterinarioId.Name = "lblVeterinarioId";
            this.lblVeterinarioId.Size = new System.Drawing.Size(93, 18);
            this.lblVeterinarioId.TabIndex = 27;
            this.lblVeterinarioId.Text = "Veterinario id";
            // 
            // lblMascotaId
            // 
            this.lblMascotaId.AutoSize = true;
            this.lblMascotaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMascotaId.Location = new System.Drawing.Point(41, 158);
            this.lblMascotaId.Name = "lblMascotaId";
            this.lblMascotaId.Size = new System.Drawing.Size(81, 18);
            this.lblMascotaId.TabIndex = 26;
            this.lblMascotaId.Text = "Mascota id";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy\'-\'MM\'-\'dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(155, 272);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(123, 20);
            this.dtFecha.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 311);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.WordWrap = false;
            // 
            // txtVeterinario_id
            // 
            this.txtVeterinario_id.Location = new System.Drawing.Point(155, 199);
            this.txtVeterinario_id.Name = "txtVeterinario_id";
            this.txtVeterinario_id.Size = new System.Drawing.Size(123, 20);
            this.txtVeterinario_id.TabIndex = 22;
            // 
            // txtMacota_id
            // 
            this.txtMacota_id.Location = new System.Drawing.Point(155, 158);
            this.txtMacota_id.Name = "txtMacota_id";
            this.txtMacota_id.Size = new System.Drawing.Size(123, 20);
            this.txtMacota_id.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(155, 116);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(123, 20);
            this.txtID.TabIndex = 20;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblid.Location = new System.Drawing.Point(41, 116);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 18);
            this.lblid.TabIndex = 19;
            this.lblid.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(41, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tratamiento id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 38;
            // 
            // FormExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.lblVeterinarioId);
            this.Controls.Add(this.lblMascotaId);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtVeterinario_id);
            this.Controls.Add(this.txtMacota_id);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblid);
            this.Name = "FormExpediente";
            this.Text = "FormExpediente";
            this.Load += new System.EventHandler(this.FormExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label lblVeterinarioId;
        private System.Windows.Forms.Label lblMascotaId;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtVeterinario_id;
        private System.Windows.Forms.TextBox txtMacota_id;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}