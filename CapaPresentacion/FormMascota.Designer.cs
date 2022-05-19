namespace CapaPresentacion
{
    partial class FormMascota
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
            this.lbllid = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdMedicamento = new System.Windows.Forms.Label();
            this.dataGMascota = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspecieId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDuenno_id = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllid
            // 
            this.lbllid.AutoSize = true;
            this.lbllid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbllid.Location = new System.Drawing.Point(63, 56);
            this.lbllid.Name = "lbllid";
            this.lbllid.Size = new System.Drawing.Size(19, 18);
            this.lbllid.TabIndex = 75;
            this.lbllid.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(163, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(123, 20);
            this.txtId.TabIndex = 73;
            // 
            // lblIdMedicamento
            // 
            this.lblIdMedicamento.AutoSize = true;
            this.lblIdMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdMedicamento.Location = new System.Drawing.Point(63, 206);
            this.lblIdMedicamento.Name = "lblIdMedicamento";
            this.lblIdMedicamento.Size = new System.Drawing.Size(58, 18);
            this.lblIdMedicamento.TabIndex = 72;
            this.lblIdMedicamento.Text = "Genero";
            // 
            // dataGMascota
            // 
            this.dataGMascota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGMascota.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGMascota.Location = new System.Drawing.Point(335, 105);
            this.dataGMascota.Name = "dataGMascota";
            this.dataGMascota.ReadOnly = true;
            this.dataGMascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGMascota.Size = new System.Drawing.Size(585, 304);
            this.dataGMascota.TabIndex = 71;
            this.dataGMascota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGMascota_CellClick);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(815, 76);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 70;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(537, 75);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(107, 21);
            this.cmbBuscar.TabIndex = 69;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(650, 76);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(146, 20);
            this.txtBusqueda.TabIndex = 68;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminar.Location = new System.Drawing.Point(229, 390);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 35);
            this.btnEliminar.TabIndex = 67;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnModificar.Location = new System.Drawing.Point(119, 390);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 35);
            this.btnModificar.TabIndex = 66;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInsertar.Location = new System.Drawing.Point(23, 390);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 35);
            this.btnInsertar.TabIndex = 65;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(63, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Estado";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbldireccion.Location = new System.Drawing.Point(63, 243);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(45, 18);
            this.lbldireccion.TabIndex = 63;
            this.lbldireccion.Text = "Color";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(63, 170);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 62;
            this.lblNombre.Text = "Nombre";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(163, 350);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 20);
            this.txtEstado.TabIndex = 61;
            this.txtEstado.WordWrap = false;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(163, 241);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(123, 20);
            this.txtColor.TabIndex = 60;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(163, 204);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(123, 20);
            this.txtGenero.TabIndex = 59;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(63, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Especie id";
            // 
            // txtEspecieId
            // 
            this.txtEspecieId.Location = new System.Drawing.Point(163, 93);
            this.txtEspecieId.Name = "txtEspecieId";
            this.txtEspecieId.Size = new System.Drawing.Size(123, 20);
            this.txtEspecieId.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(63, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 80;
            this.label4.Text = "Dueño id";
            // 
            // TxtDuenno_id
            // 
            this.TxtDuenno_id.Location = new System.Drawing.Point(163, 133);
            this.TxtDuenno_id.Name = "TxtDuenno_id";
            this.TxtDuenno_id.Size = new System.Drawing.Size(123, 20);
            this.TxtDuenno_id.TabIndex = 79;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Fecha.Location = new System.Drawing.Point(63, 278);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(49, 18);
            this.Fecha.TabIndex = 82;
            this.Fecha.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy\'-\'MM\'-\'dd";
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(163, 276);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(123, 20);
            this.dtFecha.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(66, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 83;
            this.label1.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(163, 312);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(123, 20);
            this.txtPeso.TabIndex = 84;
            // 
            // FormMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(996, 497);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDuenno_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEspecieId);
            this.Controls.Add(this.lbllid);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdMedicamento);
            this.Controls.Add(this.dataGMascota);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormMascota";
            this.Text = "FormMascota";
            this.Load += new System.EventHandler(this.FormMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllid;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdMedicamento;
        private System.Windows.Forms.DataGridView dataGMascota;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEspecieId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDuenno_id;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
    }
}