namespace CapaPresentacion
{
    partial class FormCitas
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMacota_id = new System.Windows.Forms.TextBox();
            this.txtVeterinario_id = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.lblMascotaId = new System.Windows.Forms.Label();
            this.lblVeterinarioId = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dtCita = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCita)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblid.Location = new System.Drawing.Point(52, 122);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 18);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(166, 122);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(123, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtMacota_id
            // 
            this.txtMacota_id.Location = new System.Drawing.Point(166, 164);
            this.txtMacota_id.Name = "txtMacota_id";
            this.txtMacota_id.Size = new System.Drawing.Size(123, 20);
            this.txtMacota_id.TabIndex = 2;
            // 
            // txtVeterinario_id
            // 
            this.txtVeterinario_id.Location = new System.Drawing.Point(166, 205);
            this.txtVeterinario_id.Name = "txtVeterinario_id";
            this.txtVeterinario_id.Size = new System.Drawing.Size(123, 20);
            this.txtVeterinario_id.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(166, 315);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 20);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.WordWrap = false;
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy\'-\'MM\'-\'dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(166, 244);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(123, 20);
            this.dtFecha.TabIndex = 5;
            // 
            // dtHora
            // 
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(166, 280);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(123, 20);
            this.dtHora.TabIndex = 6;
            // 
            // lblMascotaId
            // 
            this.lblMascotaId.AutoSize = true;
            this.lblMascotaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMascotaId.Location = new System.Drawing.Point(52, 164);
            this.lblMascotaId.Name = "lblMascotaId";
            this.lblMascotaId.Size = new System.Drawing.Size(81, 18);
            this.lblMascotaId.TabIndex = 7;
            this.lblMascotaId.Text = "Mascota id";
            // 
            // lblVeterinarioId
            // 
            this.lblVeterinarioId.AutoSize = true;
            this.lblVeterinarioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVeterinarioId.Location = new System.Drawing.Point(52, 205);
            this.lblVeterinarioId.Name = "lblVeterinarioId";
            this.lblVeterinarioId.Size = new System.Drawing.Size(93, 18);
            this.lblVeterinarioId.TabIndex = 8;
            this.lblVeterinarioId.Text = "Veterinario id";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Fecha.Location = new System.Drawing.Point(52, 248);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(49, 18);
            this.Fecha.TabIndex = 9;
            this.Fecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(52, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(52, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInsertar.Location = new System.Drawing.Point(36, 369);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(65, 35);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnModificar.Location = new System.Drawing.Point(107, 369);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 35);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminar.Location = new System.Drawing.Point(193, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(654, 71);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(146, 20);
            this.txtBusqueda.TabIndex = 15;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(531, 70);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(107, 21);
            this.cmbBuscar.TabIndex = 16;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(819, 67);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 17;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // dtCita
            // 
            this.dtCita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCita.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCita.Location = new System.Drawing.Point(402, 111);
            this.dtCita.Name = "dtCita";
            this.dtCita.ReadOnly = true;
            this.dtCita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCita.Size = new System.Drawing.Size(527, 304);
            this.dtCita.TabIndex = 18;
            this.dtCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(287, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1015, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtCita);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.lblVeterinarioId);
            this.Controls.Add(this.lblMascotaId);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtVeterinario_id);
            this.Controls.Add(this.txtMacota_id);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblid);
            this.Name = "FormCitas";
            this.Text = "FormCitas";
            this.Load += new System.EventHandler(this.FormCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMacota_id;
        private System.Windows.Forms.TextBox txtVeterinario_id;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label lblMascotaId;
        private System.Windows.Forms.Label lblVeterinarioId;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.DataGridView dtCita;
        private System.Windows.Forms.Button button2;
    }
}