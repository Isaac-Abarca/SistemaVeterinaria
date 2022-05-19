namespace CapaPresentacion
{
    partial class FormUsuario
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
            this.dataGUsuario = new System.Windows.Forms.DataGridView();
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
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllid
            // 
            this.lbllid.AutoSize = true;
            this.lbllid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbllid.Location = new System.Drawing.Point(66, 123);
            this.lbllid.Name = "lbllid";
            this.lbllid.Size = new System.Drawing.Size(19, 18);
            this.lbllid.TabIndex = 75;
            this.lbllid.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(166, 124);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(123, 20);
            this.txtId.TabIndex = 73;
            // 
            // lblIdMedicamento
            // 
            this.lblIdMedicamento.AutoSize = true;
            this.lblIdMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdMedicamento.Location = new System.Drawing.Point(66, 200);
            this.lblIdMedicamento.Name = "lblIdMedicamento";
            this.lblIdMedicamento.Size = new System.Drawing.Size(85, 18);
            this.lblIdMedicamento.TabIndex = 72;
            this.lblIdMedicamento.Text = "Contraseña";
            // 
            // dataGUsuario
            // 
            this.dataGUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGUsuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGUsuario.Location = new System.Drawing.Point(342, 87);
            this.dataGUsuario.Name = "dataGUsuario";
            this.dataGUsuario.ReadOnly = true;
            this.dataGUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGUsuario.Size = new System.Drawing.Size(527, 304);
            this.dataGUsuario.TabIndex = 71;
            this.dataGUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGUsuario_CellClick);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(783, 58);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 70;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(505, 57);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(107, 21);
            this.cmbBuscar.TabIndex = 69;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(618, 58);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(146, 20);
            this.txtBusqueda.TabIndex = 68;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminar.Location = new System.Drawing.Point(243, 323);
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
            this.btnModificar.Location = new System.Drawing.Point(133, 323);
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
            this.btnInsertar.Location = new System.Drawing.Point(37, 323);
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
            this.label2.Location = new System.Drawing.Point(66, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Estado";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbldireccion.Location = new System.Drawing.Point(66, 234);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(37, 18);
            this.lbldireccion.TabIndex = 63;
            this.lbldireccion.Text = "Tipo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(66, 162);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 62;
            this.lblNombre.Text = "Nombre";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(166, 274);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 20);
            this.txtEstado.TabIndex = 61;
            this.txtEstado.WordWrap = false;
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Location = new System.Drawing.Point(166, 198);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(123, 20);
            this.txtContrasenna.TabIndex = 59;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 58;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(166, 235);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(123, 21);
            this.cbTipo.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(146, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 78;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbllid);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIdMedicamento);
            this.Controls.Add(this.dataGUsuario);
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
            this.Controls.Add(this.txtContrasenna);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllid;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdMedicamento;
        private System.Windows.Forms.DataGridView dataGUsuario;
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
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button button1;
    }
}