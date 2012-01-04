namespace SistemaCentroSalud
{
    partial class frmTriaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriaje));
            this.tbcPaciente = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
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
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtObservaciones = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboFactorSanguineo = new System.Windows.Forms.ComboBox();
            this.cboGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxOtrosDatos = new System.Windows.Forms.GroupBox();
            this.txtTalla = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPeso = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gbxSignosVitales = new System.Windows.Forms.GroupBox();
            this.lblLPM = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.txtPresionArterial = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFrecuenciaRespiratoria = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblPresionArterial = new System.Windows.Forms.Label();
            this.lblFrecuenciaRespiratoria = new System.Windows.Forms.Label();
            this.txtFrecuenciaCardiaca = new SistemaCentroSalud.Controles.cuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperatura = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbcPaciente.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxOtrosDatos.SuspendLayout();
            this.gbxSignosVitales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPaciente
            // 
            this.tbcPaciente.Controls.Add(this.tbpBuscar);
            this.tbcPaciente.Controls.Add(this.tbpDetalle);
            this.tbcPaciente.Location = new System.Drawing.Point(1, 0);
            this.tbcPaciente.Name = "tbcPaciente";
            this.tbcPaciente.SelectedIndex = 0;
            this.tbcPaciente.Size = new System.Drawing.Size(787, 418);
            this.tbcPaciente.TabIndex = 1;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnModificar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Controls.Add(this.dgvPacientes);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(779, 392);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(694, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 359);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(190, 359);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 359);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.dgvPacientes.Location = new System.Drawing.Point(8, 138);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(761, 215);
            this.dgvPacientes.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "IdPaciente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // colPaterno
            // 
            this.colPaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaterno.HeaderText = "Ap. Paterno";
            this.colPaterno.Name = "colPaterno";
            this.colPaterno.ReadOnly = true;
            // 
            // colMaterno
            // 
            this.colMaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaterno.HeaderText = "Ap. Materno";
            this.colMaterno.Name = "colMaterno";
            this.colMaterno.ReadOnly = true;
            // 
            // colNombres
            // 
            this.colNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoDocumento.HeaderText = "TipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.ReadOnly = true;
            // 
            // colNumeroDocumento
            // 
            this.colNumeroDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumeroDocumento.HeaderText = "No. Documento";
            this.colNumeroDocumento.Name = "colNumeroDocumento";
            this.colNumeroDocumento.ReadOnly = true;
            // 
            // colNumeroHistoriaClinica
            // 
            this.colNumeroHistoriaClinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.gbxCriterios.Location = new System.Drawing.Point(8, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(761, 126);
            this.gbxCriterios.TabIndex = 0;
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
            this.cboTipoDocumentoBuscar.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumentoBuscar_SelectedIndexChanged);
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
            this.txtNumeroHistoriaClinicaBuscar.MaxLength = 10;
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
            this.txtMaternoBuscar.MaxLength = 30;
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
            this.txtNombresBuscar.MaxLength = 30;
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
            this.txtPaternoBuscar.MaxLength = 30;
            this.txtPaternoBuscar.Name = "txtPaternoBuscar";
            this.txtPaternoBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtPaternoBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaternoBuscar.TabIndex = 1;
            this.txtPaternoBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.label4);
            this.tbpDetalle.Controls.Add(this.rtxtObservaciones);
            this.tbpDetalle.Controls.Add(this.groupBox1);
            this.tbpDetalle.Controls.Add(this.gbxOtrosDatos);
            this.tbpDetalle.Controls.Add(this.gbxSignosVitales);
            this.tbpDetalle.Controls.Add(this.btnGuardar);
            this.tbpDetalle.Controls.Add(this.btnCancelar);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(779, 392);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Observaciones:";
            // 
            // rtxtObservaciones
            // 
            this.rtxtObservaciones.BackColor = System.Drawing.Color.LightYellow;
            this.rtxtObservaciones.Location = new System.Drawing.Point(9, 228);
            this.rtxtObservaciones.MaxLength = 1000;
            this.rtxtObservaciones.Name = "rtxtObservaciones";
            this.rtxtObservaciones.Size = new System.Drawing.Size(764, 117);
            this.rtxtObservaciones.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtObservaciones.TabIndex = 11;
            this.rtxtObservaciones.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboFactorSanguineo);
            this.groupBox1.Controls.Add(this.cboGrupoSanguineo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Sangre";
            // 
            // cboFactorSanguineo
            // 
            this.cboFactorSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactorSanguineo.FormattingEnabled = true;
            this.cboFactorSanguineo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "RH+",
            "RH-"});
            this.cboFactorSanguineo.Location = new System.Drawing.Point(130, 56);
            this.cboFactorSanguineo.Name = "cboFactorSanguineo";
            this.cboFactorSanguineo.Size = new System.Drawing.Size(125, 21);
            this.cboFactorSanguineo.TabIndex = 7;
            // 
            // cboGrupoSanguineo
            // 
            this.cboGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupoSanguineo.FormattingEnabled = true;
            this.cboGrupoSanguineo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "A",
            "B",
            "AB",
            "O"});
            this.cboGrupoSanguineo.Location = new System.Drawing.Point(130, 22);
            this.cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            this.cboGrupoSanguineo.Size = new System.Drawing.Size(125, 21);
            this.cboGrupoSanguineo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Factor Sanguíneo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Grupo Sanguíneo:";
            // 
            // gbxOtrosDatos
            // 
            this.gbxOtrosDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOtrosDatos.Controls.Add(this.txtTalla);
            this.gbxOtrosDatos.Controls.Add(this.txtPeso);
            this.gbxOtrosDatos.Controls.Add(this.lblTalla);
            this.gbxOtrosDatos.Controls.Add(this.lblPeso);
            this.gbxOtrosDatos.Location = new System.Drawing.Point(390, 106);
            this.gbxOtrosDatos.Name = "gbxOtrosDatos";
            this.gbxOtrosDatos.Size = new System.Drawing.Size(383, 100);
            this.gbxOtrosDatos.TabIndex = 8;
            this.gbxOtrosDatos.TabStop = false;
            this.gbxOtrosDatos.Text = "Otros Datos";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(147, 56);
            this.txtTalla.MaxLength = 5;
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(84, 20);
            this.txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTalla.TabIndex = 10;
            this.txtTalla.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(147, 22);
            this.txtPeso.MaxLength = 6;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(84, 20);
            this.txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPeso.TabIndex = 9;
            this.txtPeso.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(7, 59);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(33, 13);
            this.lblTalla.TabIndex = 7;
            this.lblTalla.Text = "Talla:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(6, 25);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // gbxSignosVitales
            // 
            this.gbxSignosVitales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSignosVitales.Controls.Add(this.lblLPM);
            this.gbxSignosVitales.Controls.Add(this.lblRPM);
            this.gbxSignosVitales.Controls.Add(this.txtPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.lblPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.lblFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaCardiaca);
            this.gbxSignosVitales.Controls.Add(this.label1);
            this.gbxSignosVitales.Controls.Add(this.txtTemperatura);
            this.gbxSignosVitales.Controls.Add(this.lblTemperatura);
            this.gbxSignosVitales.Location = new System.Drawing.Point(7, 6);
            this.gbxSignosVitales.Name = "gbxSignosVitales";
            this.gbxSignosVitales.Size = new System.Drawing.Size(766, 94);
            this.gbxSignosVitales.TabIndex = 0;
            this.gbxSignosVitales.TabStop = false;
            this.gbxSignosVitales.Text = "Signos Vitales";
            // 
            // lblLPM
            // 
            this.lblLPM.AutoSize = true;
            this.lblLPM.Location = new System.Drawing.Point(220, 55);
            this.lblLPM.Name = "lblLPM";
            this.lblLPM.Size = new System.Drawing.Size(29, 13);
            this.lblLPM.TabIndex = 11;
            this.lblLPM.Text = "LPM";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(620, 27);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(31, 13);
            this.lblRPM.TabIndex = 10;
            this.lblRPM.Text = "RPM";
            // 
            // txtPresionArterial
            // 
            this.txtPresionArterial.Location = new System.Drawing.Point(530, 52);
            this.txtPresionArterial.MaxLength = 10;
            this.txtPresionArterial.Name = "txtPresionArterial";
            this.txtPresionArterial.Size = new System.Drawing.Size(84, 20);
            this.txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPresionArterial.TabIndex = 4;
            this.txtPresionArterial.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtFrecuenciaRespiratoria
            // 
            this.txtFrecuenciaRespiratoria.Location = new System.Drawing.Point(530, 24);
            this.txtFrecuenciaRespiratoria.MaxLength = 10;
            this.txtFrecuenciaRespiratoria.Name = "txtFrecuenciaRespiratoria";
            this.txtFrecuenciaRespiratoria.Size = new System.Drawing.Size(84, 20);
            this.txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFrecuenciaRespiratoria.TabIndex = 3;
            this.txtFrecuenciaRespiratoria.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // lblPresionArterial
            // 
            this.lblPresionArterial.AutoSize = true;
            this.lblPresionArterial.Location = new System.Drawing.Point(389, 55);
            this.lblPresionArterial.Name = "lblPresionArterial";
            this.lblPresionArterial.Size = new System.Drawing.Size(80, 13);
            this.lblPresionArterial.TabIndex = 7;
            this.lblPresionArterial.Text = "Presión Arterial:";
            // 
            // lblFrecuenciaRespiratoria
            // 
            this.lblFrecuenciaRespiratoria.AutoSize = true;
            this.lblFrecuenciaRespiratoria.Location = new System.Drawing.Point(389, 27);
            this.lblFrecuenciaRespiratoria.Name = "lblFrecuenciaRespiratoria";
            this.lblFrecuenciaRespiratoria.Size = new System.Drawing.Size(122, 13);
            this.lblFrecuenciaRespiratoria.TabIndex = 6;
            this.lblFrecuenciaRespiratoria.Text = "Frecuencia Respiratoria:";
            // 
            // txtFrecuenciaCardiaca
            // 
            this.txtFrecuenciaCardiaca.Location = new System.Drawing.Point(130, 52);
            this.txtFrecuenciaCardiaca.MaxLength = 10;
            this.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca";
            this.txtFrecuenciaCardiaca.Size = new System.Drawing.Size(84, 20);
            this.txtFrecuenciaCardiaca.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFrecuenciaCardiaca.TabIndex = 2;
            this.txtFrecuenciaCardiaca.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frecuencia Cardiaca:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(130, 24);
            this.txtTemperatura.MaxLength = 4;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(84, 20);
            this.txtTemperatura.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTemperatura.TabIndex = 1;
            this.txtTemperatura.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(6, 27);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(689, 351);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(573, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmTriaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 416);
            this.Controls.Add(this.tbcPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTriaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triaje";
            this.Load += new System.EventHandler(this.frmTriaje_Load);
            this.tbcPaciente.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.tbpDetalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxOtrosDatos.ResumeLayout(false);
            this.gbxOtrosDatos.PerformLayout();
            this.gbxSignosVitales.ResumeLayout(false);
            this.gbxSignosVitales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPaciente;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
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
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxOtrosDatos;
        private SistemaCentroSalud.Controles.cuTextBox txtTalla;
        private SistemaCentroSalud.Controles.cuTextBox txtPeso;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.GroupBox gbxSignosVitales;
        private SistemaCentroSalud.Controles.cuTextBox txtPresionArterial;
        private SistemaCentroSalud.Controles.cuTextBox txtFrecuenciaRespiratoria;
        private System.Windows.Forms.Label lblPresionArterial;
        private System.Windows.Forms.Label lblFrecuenciaRespiratoria;
        private SistemaCentroSalud.Controles.cuTextBox txtFrecuenciaCardiaca;
        private System.Windows.Forms.Label label1;
        private SistemaCentroSalud.Controles.cuTextBox txtTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.ComboBox cboFactorSanguineo;
        private System.Windows.Forms.ComboBox cboGrupoSanguineo;
        private System.Windows.Forms.Label lblLPM;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label label4;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtObservaciones;
    }
}