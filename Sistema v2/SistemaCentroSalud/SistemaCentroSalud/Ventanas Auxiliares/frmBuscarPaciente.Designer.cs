namespace SistemaCentroSalud
{
    partial class frmBuscarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPaciente));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.lblTipoDocumentoBuscar = new System.Windows.Forms.Label();
            this.cboTipoDocumentoBuscar = new System.Windows.Forms.ComboBox();
            this.lblNumeroHistoriaClinicaBuscar = new System.Windows.Forms.Label();
            this.txtNumeroHistoriaClinicaBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNumeroDocumentoBuscar = new System.Windows.Forms.Label();
            this.txtNumeroDocumentoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNombresBuscar = new System.Windows.Forms.Label();
            this.lblMaternoBuscar = new System.Windows.Forms.Label();
            this.lblPaternoBuscar = new System.Windows.Forms.Label();
            this.txtMaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombresBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(689, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(3, 355);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(89, 23);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeColumns = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colPaterno,
            this.colMaterno,
            this.colNombres,
            this.colTipoDocumento,
            this.colNumeroDocumento,
            this.colNumeroHistoriaClinica});
            this.dgvPacientes.Location = new System.Drawing.Point(3, 134);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(761, 215);
            this.dgvPacientes.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdPaciente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // colPaterno
            // 
            this.colPaterno.HeaderText = "Ap. Paterno";
            this.colPaterno.Name = "colPaterno";
            this.colPaterno.ReadOnly = true;
            // 
            // colMaterno
            // 
            this.colMaterno.HeaderText = "Ap. Materno";
            this.colMaterno.Name = "colMaterno";
            this.colMaterno.ReadOnly = true;
            // 
            // colNombres
            // 
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.HeaderText = "TipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.ReadOnly = true;
            // 
            // colNumeroDocumento
            // 
            this.colNumeroDocumento.HeaderText = "No. Documento";
            this.colNumeroDocumento.Name = "colNumeroDocumento";
            this.colNumeroDocumento.ReadOnly = true;
            // 
            // colNumeroHistoriaClinica
            // 
            this.colNumeroHistoriaClinica.HeaderText = "No. Historia Clínica";
            this.colNumeroHistoriaClinica.Name = "colNumeroHistoriaClinica";
            this.colNumeroHistoriaClinica.ReadOnly = true;
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Controls.Add(this.lblTipoDocumentoBuscar);
            this.gbxCriterios.Controls.Add(this.cboTipoDocumentoBuscar);
            this.gbxCriterios.Controls.Add(this.lblNumeroHistoriaClinicaBuscar);
            this.gbxCriterios.Controls.Add(this.txtNumeroHistoriaClinicaBuscar);
            this.gbxCriterios.Controls.Add(this.lblNumeroDocumentoBuscar);
            this.gbxCriterios.Controls.Add(this.txtNumeroDocumentoBuscar);
            this.gbxCriterios.Controls.Add(this.lblNombresBuscar);
            this.gbxCriterios.Controls.Add(this.lblMaternoBuscar);
            this.gbxCriterios.Controls.Add(this.lblPaternoBuscar);
            this.gbxCriterios.Controls.Add(this.txtMaternoBuscar);
            this.gbxCriterios.Controls.Add(this.txtNombresBuscar);
            this.gbxCriterios.Controls.Add(this.txtPaternoBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(3, 2);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(761, 126);
            this.gbxCriterios.TabIndex = 11;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // lblTipoDocumentoBuscar
            // 
            this.lblTipoDocumentoBuscar.AutoSize = true;
            this.lblTipoDocumentoBuscar.Location = new System.Drawing.Point(12, 64);
            this.lblTipoDocumentoBuscar.Name = "lblTipoDocumentoBuscar";
            this.lblTipoDocumentoBuscar.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumentoBuscar.TabIndex = 53;
            this.lblTipoDocumentoBuscar.Text = "Tipo Documento:";
            // 
            // cboTipoDocumentoBuscar
            // 
            this.cboTipoDocumentoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumentoBuscar.FormattingEnabled = true;
            this.cboTipoDocumentoBuscar.Location = new System.Drawing.Point(15, 79);
            this.cboTipoDocumentoBuscar.Name = "cboTipoDocumentoBuscar";
            this.cboTipoDocumentoBuscar.Size = new System.Drawing.Size(124, 21);
            this.cboTipoDocumentoBuscar.TabIndex = 5;
            // 
            // lblNumeroHistoriaClinicaBuscar
            // 
            this.lblNumeroHistoriaClinicaBuscar.AutoSize = true;
            this.lblNumeroHistoriaClinicaBuscar.Location = new System.Drawing.Point(554, 16);
            this.lblNumeroHistoriaClinicaBuscar.Name = "lblNumeroHistoriaClinicaBuscar";
            this.lblNumeroHistoriaClinicaBuscar.Size = new System.Drawing.Size(101, 13);
            this.lblNumeroHistoriaClinicaBuscar.TabIndex = 51;
            this.lblNumeroHistoriaClinicaBuscar.Text = "No. Historia Clínica:";
            // 
            // txtNumeroHistoriaClinicaBuscar
            // 
            this.txtNumeroHistoriaClinicaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroHistoriaClinicaBuscar.Location = new System.Drawing.Point(557, 32);
            this.txtNumeroHistoriaClinicaBuscar.Name = "txtNumeroHistoriaClinicaBuscar";
            this.txtNumeroHistoriaClinicaBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtNumeroHistoriaClinicaBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroHistoriaClinicaBuscar.TabIndex = 4;
            this.txtNumeroHistoriaClinicaBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // lblNumeroDocumentoBuscar
            // 
            this.lblNumeroDocumentoBuscar.AutoSize = true;
            this.lblNumeroDocumentoBuscar.Location = new System.Drawing.Point(149, 64);
            this.lblNumeroDocumentoBuscar.Name = "lblNumeroDocumentoBuscar";
            this.lblNumeroDocumentoBuscar.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroDocumentoBuscar.TabIndex = 49;
            this.lblNumeroDocumentoBuscar.Text = "No. Documento:";
            // 
            // txtNumeroDocumentoBuscar
            // 
            this.txtNumeroDocumentoBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroDocumentoBuscar.Enabled = false;
            this.txtNumeroDocumentoBuscar.Location = new System.Drawing.Point(152, 80);
            this.txtNumeroDocumentoBuscar.Name = "txtNumeroDocumentoBuscar";
            this.txtNumeroDocumentoBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtNumeroDocumentoBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroDocumentoBuscar.TabIndex = 6;
            this.txtNumeroDocumentoBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // lblNombresBuscar
            // 
            this.lblNombresBuscar.AutoSize = true;
            this.lblNombresBuscar.Location = new System.Drawing.Point(283, 16);
            this.lblNombresBuscar.Name = "lblNombresBuscar";
            this.lblNombresBuscar.Size = new System.Drawing.Size(52, 13);
            this.lblNombresBuscar.TabIndex = 47;
            this.lblNombresBuscar.Text = "Nombres:";
            // 
            // lblMaternoBuscar
            // 
            this.lblMaternoBuscar.AutoSize = true;
            this.lblMaternoBuscar.Location = new System.Drawing.Point(149, 16);
            this.lblMaternoBuscar.Name = "lblMaternoBuscar";
            this.lblMaternoBuscar.Size = new System.Drawing.Size(65, 13);
            this.lblMaternoBuscar.TabIndex = 46;
            this.lblMaternoBuscar.Text = "Ap.Materno:";
            // 
            // lblPaternoBuscar
            // 
            this.lblPaternoBuscar.AutoSize = true;
            this.lblPaternoBuscar.Location = new System.Drawing.Point(12, 16);
            this.lblPaternoBuscar.Name = "lblPaternoBuscar";
            this.lblPaternoBuscar.Size = new System.Drawing.Size(63, 13);
            this.lblPaternoBuscar.TabIndex = 45;
            this.lblPaternoBuscar.Text = "Ap.Paterno:";
            // 
            // txtMaternoBuscar
            // 
            this.txtMaternoBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaternoBuscar.Location = new System.Drawing.Point(152, 32);
            this.txtMaternoBuscar.Name = "txtMaternoBuscar";
            this.txtMaternoBuscar.Size = new System.Drawing.Size(124, 20);
            this.txtMaternoBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtMaternoBuscar.TabIndex = 2;
            this.txtMaternoBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtNombresBuscar
            // 
            this.txtNombresBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombresBuscar.Location = new System.Drawing.Point(286, 32);
            this.txtNombresBuscar.MaxLength = 5;
            this.txtNombresBuscar.Name = "txtNombresBuscar";
            this.txtNombresBuscar.Size = new System.Drawing.Size(259, 20);
            this.txtNombresBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombresBuscar.TabIndex = 3;
            this.txtNombresBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtPaternoBuscar
            // 
            this.txtPaternoBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaternoBuscar.Location = new System.Drawing.Point(15, 32);
            this.txtPaternoBuscar.Name = "txtPaternoBuscar";
            this.txtPaternoBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtPaternoBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaternoBuscar.TabIndex = 1;
            this.txtPaternoBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // frmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 382);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.gbxCriterios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroHistoriaClinica;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.Label lblTipoDocumentoBuscar;
        private System.Windows.Forms.ComboBox cboTipoDocumentoBuscar;
        private System.Windows.Forms.Label lblNumeroHistoriaClinicaBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroHistoriaClinicaBuscar;
        private System.Windows.Forms.Label lblNumeroDocumentoBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroDocumentoBuscar;
        private System.Windows.Forms.Label lblNombresBuscar;
        private System.Windows.Forms.Label lblMaternoBuscar;
        private System.Windows.Forms.Label lblPaternoBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtMaternoBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtNombresBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtPaternoBuscar;
    }
}