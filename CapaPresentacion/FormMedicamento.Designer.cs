﻿namespace CapaPresentacion
{
    partial class FormMedicamento
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
            this.lblMedicamento_dosis = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtVeterinario_id = new System.Windows.Forms.TextBox();
            this.txtMacota_id = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblIdMedicamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 304);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(783, 65);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 36;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(505, 64);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(107, 21);
            this.cmbBuscar.TabIndex = 35;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(618, 65);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(146, 20);
            this.txtBusqueda.TabIndex = 34;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminar.Location = new System.Drawing.Point(224, 307);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 35);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnModificar.Location = new System.Drawing.Point(114, 307);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 35);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInsertar.Location = new System.Drawing.Point(18, 307);
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
            this.label2.Location = new System.Drawing.Point(28, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Estado";
            // 
            // lblMedicamento_dosis
            // 
            this.lblMedicamento_dosis.AutoSize = true;
            this.lblMedicamento_dosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMedicamento_dosis.Location = new System.Drawing.Point(29, 208);
            this.lblMedicamento_dosis.Name = "lblMedicamento_dosis";
            this.lblMedicamento_dosis.Size = new System.Drawing.Size(51, 18);
            this.lblMedicamento_dosis.TabIndex = 27;
            this.lblMedicamento_dosis.Text = "Dosis:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(29, 167);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 23;
            this.textBox4.WordWrap = false;
            // 
            // txtVeterinario_id
            // 
            this.txtVeterinario_id.Location = new System.Drawing.Point(157, 209);
            this.txtVeterinario_id.Name = "txtVeterinario_id";
            this.txtVeterinario_id.Size = new System.Drawing.Size(123, 20);
            this.txtVeterinario_id.TabIndex = 22;
            // 
            // txtMacota_id
            // 
            this.txtMacota_id.Location = new System.Drawing.Point(157, 167);
            this.txtMacota_id.Name = "txtMacota_id";
            this.txtMacota_id.Size = new System.Drawing.Size(123, 20);
            this.txtMacota_id.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(157, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(123, 20);
            this.txtID.TabIndex = 20;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblid.Location = new System.Drawing.Point(-25, 107);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 18);
            this.lblid.TabIndex = 19;
            this.lblid.Text = "id";
            // 
            // lblIdMedicamento
            // 
            this.lblIdMedicamento.AutoSize = true;
            this.lblIdMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdMedicamento.Location = new System.Drawing.Point(29, 124);
            this.lblIdMedicamento.Name = "lblIdMedicamento";
            this.lblIdMedicamento.Size = new System.Drawing.Size(113, 18);
            this.lblIdMedicamento.TabIndex = 38;
            this.lblIdMedicamento.Text = "Medicamento id";
            this.lblIdMedicamento.Click += new System.EventHandler(this.lblIdMedicamento_Click);
            // 
            // FormMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 474);
            this.Controls.Add(this.lblIdMedicamento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMedicamento_dosis);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtVeterinario_id);
            this.Controls.Add(this.txtMacota_id);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblid);
            this.Name = "FormMedicamento";
            this.Text = "FormMedicamento";
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
        private System.Windows.Forms.Label lblMedicamento_dosis;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtVeterinario_id;
        private System.Windows.Forms.TextBox txtMacota_id;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblIdMedicamento;
    }
}