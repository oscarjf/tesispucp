namespace SistemaCentroSalud.Ventanas_Doctor
{
    partial class frmHistorialClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialClinica));
            this.tbcHistoriaClinica = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.colIdHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEpisodios = new System.Windows.Forms.Label();
            this.dgvEpisodios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.lblTipoDocumentoBuscar = new System.Windows.Forms.Label();
            this.cboTipoDocumentoBuscar = new System.Windows.Forms.ComboBox();
            this.lblNumeroHistoriaClinicaBuscar = new System.Windows.Forms.Label();
            this.lblNumeroDocumentoBuscar = new System.Windows.Forms.Label();
            this.lblNombresBuscar = new System.Windows.Forms.Label();
            this.lblMaternoBuscar = new System.Windows.Forms.Label();
            this.lblPaternoBuscar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.tbcHistoriaClinicaPartes = new System.Windows.Forms.TabControl();
            this.tbpEctoscopia = new System.Windows.Forms.TabPage();
            this.lblEctoscopiaActual = new System.Windows.Forms.Label();
            this.lblEctoscopiaAnterior = new System.Windows.Forms.Label();
            this.tbpAnamnesis = new System.Windows.Forms.TabPage();
            this.tbcAnamnesisPartes = new System.Windows.Forms.TabControl();
            this.tbpFiliacion = new System.Windows.Forms.TabPage();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cboDistritoDomicilio = new System.Windows.Forms.ComboBox();
            this.cboProvinciaDomicilio = new System.Windows.Forms.ComboBox();
            this.cboDepartamentoDomicilio = new System.Windows.Forms.ComboBox();
            this.lblDistritoDomicilio = new System.Windows.Forms.Label();
            this.lblProvinciaDomicilio = new System.Windows.Forms.Label();
            this.lblDepartamentoDomicilio = new System.Windows.Forms.Label();
            this.gbxLugarNacimiento = new System.Windows.Forms.GroupBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.gbxPersonal = new System.Windows.Forms.GroupBox();
            this.cboFactorSanguineo = new System.Windows.Forms.ComboBox();
            this.lblFactorSanguineo = new System.Windows.Forms.Label();
            this.cboGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cboReligion = new System.Windows.Forms.ComboBox();
            this.lblReligion = new System.Windows.Forms.Label();
            this.cboRaza = new System.Windows.Forms.ComboBox();
            this.lblEtnia = new System.Windows.Forms.Label();
            this.cboOcupacion = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.tbpEnfermedadActual = new System.Windows.Forms.TabPage();
            this.lblRelatoCronologico = new System.Windows.Forms.Label();
            this.lblSintomasEnfermedad = new System.Windows.Forms.Label();
            this.lblCursoEnfermedad = new System.Windows.Forms.Label();
            this.lblInicioEnfermedad = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTiempoEnfermedad = new System.Windows.Forms.Label();
            this.tbpAntecedentes = new System.Windows.Forms.TabPage();
            this.gbxOtros = new System.Windows.Forms.GroupBox();
            this.gbxPersonales = new System.Windows.Forms.GroupBox();
            this.cbxColagenopatia = new System.Windows.Forms.CheckBox();
            this.cbxFiebresProlongadas = new System.Windows.Forms.CheckBox();
            this.cbxEnfermedadesNeurologicas = new System.Windows.Forms.CheckBox();
            this.cbxHepatitis = new System.Windows.Forms.CheckBox();
            this.cbxColecistopatia = new System.Windows.Forms.CheckBox();
            this.cbxUlcera = new System.Windows.Forms.CheckBox();
            this.cbxETS = new System.Windows.Forms.CheckBox();
            this.cbxHemopatia = new System.Windows.Forms.CheckBox();
            this.cbxAlergias = new System.Windows.Forms.CheckBox();
            this.cbxUropatia = new System.Windows.Forms.CheckBox();
            this.cbxPsicopatia = new System.Windows.Forms.CheckBox();
            this.cbxNefropatia = new System.Windows.Forms.CheckBox();
            this.cbxAsma = new System.Windows.Forms.CheckBox();
            this.cbxEndocrinopatia = new System.Windows.Forms.CheckBox();
            this.cbxDislipidemia = new System.Windows.Forms.CheckBox();
            this.cbxGota = new System.Windows.Forms.CheckBox();
            this.cbxCoronariopatia = new System.Windows.Forms.CheckBox();
            this.cbxAtipia = new System.Windows.Forms.CheckBox();
            this.cbxHipertensionArterial = new System.Windows.Forms.CheckBox();
            this.cbxTuberculosis = new System.Windows.Forms.CheckBox();
            this.cbxDiabetes = new System.Windows.Forms.CheckBox();
            this.gbxHabitosNocivos = new System.Windows.Forms.GroupBox();
            this.cbxDrogas = new System.Windows.Forms.CheckBox();
            this.cbxTe = new System.Windows.Forms.CheckBox();
            this.cbxCafe = new System.Windows.Forms.CheckBox();
            this.cbxAlcohol = new System.Windows.Forms.CheckBox();
            this.cbxTabaco = new System.Windows.Forms.CheckBox();
            this.tbpExamenFisico = new System.Windows.Forms.TabPage();
            this.lblOtrosExamenes = new System.Windows.Forms.Label();
            this.gbxOtrosDatos = new System.Windows.Forms.GroupBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gbxSignosVitales = new System.Windows.Forms.GroupBox();
            this.lblPresionArterial = new System.Windows.Forms.Label();
            this.lblFrecuenciaRespiratoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.tbpDiagnostico = new System.Windows.Forms.TabPage();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDiagnosticos = new System.Windows.Forms.DataGridView();
            this.colIdCie10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDescripcionActual = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.txtNumeroHistoriaClinicaBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNumeroDocumentoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtMaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombresBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtEctoscopiaActual = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtEctoscopiaAnterior = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtDireccion = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtEdad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombres = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtMaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtRelatoCronologico = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtSintomasEnfermedad = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtCursoEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtInicioEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTiempoEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtOtrosAntecedentes = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtColagenopatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFiebresProlongadas = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtEnfermedadesNeurologicas = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtHepatitis = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtColecistopatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtUlcera = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtETS = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtHemopatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtUropatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNefropatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtEndocrinopatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtGota = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtAtipia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTuberculosis = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtAlergias = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPsicopatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtAsma = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtDislipidemia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtCoronariopatia = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtHipertensionArterial = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtDiabetes = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtOtrosExamenes = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtTalla = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPeso = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPresionArterial = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFrecuenciaRespiratoria = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFrecuenciaCardiaca = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTemperatura = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtDiagnosticoActual = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtDiagnostico = new SistemaCentroSalud.Controles.cuTextBox();
            this.tbcHistoriaClinica.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodios)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.tbcHistoriaClinicaPartes.SuspendLayout();
            this.tbpEctoscopia.SuspendLayout();
            this.tbpAnamnesis.SuspendLayout();
            this.tbcAnamnesisPartes.SuspendLayout();
            this.tbpFiliacion.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxLugarNacimiento.SuspendLayout();
            this.gbxPersonal.SuspendLayout();
            this.tbpEnfermedadActual.SuspendLayout();
            this.tbpAntecedentes.SuspendLayout();
            this.gbxOtros.SuspendLayout();
            this.gbxPersonales.SuspendLayout();
            this.gbxHabitosNocivos.SuspendLayout();
            this.tbpExamenFisico.SuspendLayout();
            this.gbxOtrosDatos.SuspendLayout();
            this.gbxSignosVitales.SuspendLayout();
            this.tbpDiagnostico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcHistoriaClinica
            // 
            this.tbcHistoriaClinica.Controls.Add(this.tbpBuscar);
            this.tbcHistoriaClinica.Controls.Add(this.tbpDetalle);
            this.tbcHistoriaClinica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHistoriaClinica.Location = new System.Drawing.Point(0, 0);
            this.tbcHistoriaClinica.Name = "tbcHistoriaClinica";
            this.tbcHistoriaClinica.SelectedIndex = 0;
            this.tbcHistoriaClinica.Size = new System.Drawing.Size(815, 444);
            this.tbcHistoriaClinica.TabIndex = 0;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.dgvHistoriasClinicas);
            this.tbpBuscar.Controls.Add(this.lblEpisodios);
            this.tbpBuscar.Controls.Add(this.dgvEpisodios);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnContinuar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(807, 418);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvHistoriasClinicas
            // 
            this.dgvHistoriasClinicas.AllowUserToAddRows = false;
            this.dgvHistoriasClinicas.AllowUserToDeleteRows = false;
            this.dgvHistoriasClinicas.AllowUserToResizeColumns = false;
            this.dgvHistoriasClinicas.AllowUserToResizeRows = false;
            this.dgvHistoriasClinicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriasClinicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdHistoriaClinica,
            this.colNumeroHistoriaClinica,
            this.Id,
            this.colPaterno,
            this.colMaterno,
            this.colNombres,
            this.colTipoDocumento,
            this.colNumeroDocumento});
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(8, 138);
            this.dgvHistoriasClinicas.MultiSelect = false;
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.ReadOnly = true;
            this.dgvHistoriasClinicas.RowHeadersVisible = false;
            this.dgvHistoriasClinicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(432, 243);
            this.dgvHistoriasClinicas.TabIndex = 47;
            // 
            // colIdHistoriaClinica
            // 
            this.colIdHistoriaClinica.HeaderText = "IdHistoriaClinica";
            this.colIdHistoriaClinica.Name = "colIdHistoriaClinica";
            this.colIdHistoriaClinica.ReadOnly = true;
            this.colIdHistoriaClinica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIdHistoriaClinica.Visible = false;
            // 
            // colNumeroHistoriaClinica
            // 
            this.colNumeroHistoriaClinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumeroHistoriaClinica.HeaderText = "No. Historia Clínica";
            this.colNumeroHistoriaClinica.Name = "colNumeroHistoriaClinica";
            this.colNumeroHistoriaClinica.ReadOnly = true;
            this.colNumeroHistoriaClinica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "IdPaciente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // colPaterno
            // 
            this.colPaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaterno.HeaderText = "Ap. Paterno";
            this.colPaterno.Name = "colPaterno";
            this.colPaterno.ReadOnly = true;
            this.colPaterno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMaterno
            // 
            this.colMaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaterno.HeaderText = "Ap. Materno";
            this.colMaterno.Name = "colMaterno";
            this.colMaterno.ReadOnly = true;
            this.colMaterno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNombres
            // 
            this.colNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            this.colNombres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoDocumento.HeaderText = "TipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.ReadOnly = true;
            this.colTipoDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNumeroDocumento
            // 
            this.colNumeroDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumeroDocumento.HeaderText = "No. Documento";
            this.colNumeroDocumento.Name = "colNumeroDocumento";
            this.colNumeroDocumento.ReadOnly = true;
            this.colNumeroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.Location = new System.Drawing.Point(446, 136);
            this.lblEpisodios.Name = "lblEpisodios";
            this.lblEpisodios.Size = new System.Drawing.Size(55, 13);
            this.lblEpisodios.TabIndex = 46;
            this.lblEpisodios.Text = "Episodios:";
            // 
            // dgvEpisodios
            // 
            this.dgvEpisodios.AllowUserToAddRows = false;
            this.dgvEpisodios.AllowUserToDeleteRows = false;
            this.dgvEpisodios.AllowUserToResizeColumns = false;
            this.dgvEpisodios.AllowUserToResizeRows = false;
            this.dgvEpisodios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEpisodios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpisodios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colFecha,
            this.colHora,
            this.colResponsable});
            this.dgvEpisodios.Location = new System.Drawing.Point(446, 151);
            this.dgvEpisodios.MultiSelect = false;
            this.dgvEpisodios.Name = "dgvEpisodios";
            this.dgvEpisodios.RowHeadersVisible = false;
            this.dgvEpisodios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEpisodios.Size = new System.Drawing.Size(358, 230);
            this.dgvEpisodios.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPaciente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 121.8274F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFecha.Width = 90;
            // 
            // colHora
            // 
            this.colHora.FillWeight = 89.0863F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            this.colHora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHora.Width = 90;
            // 
            // colResponsable
            // 
            this.colResponsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colResponsable.FillWeight = 89.0863F;
            this.colResponsable.HeaderText = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.ReadOnly = true;
            this.colResponsable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbxCriterios.Size = new System.Drawing.Size(796, 126);
            this.gbxCriterios.TabIndex = 16;
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
            // lblNumeroDocumentoBuscar
            // 
            this.lblNumeroDocumentoBuscar.AutoSize = true;
            this.lblNumeroDocumentoBuscar.Location = new System.Drawing.Point(149, 64);
            this.lblNumeroDocumentoBuscar.Name = "lblNumeroDocumentoBuscar";
            this.lblNumeroDocumentoBuscar.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroDocumentoBuscar.TabIndex = 49;
            this.lblNumeroDocumentoBuscar.Text = "No. Documento:";
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
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(724, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 387);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContinuar.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Image")));
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Location = new System.Drawing.Point(190, 387);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 387);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.tbcHistoriaClinicaPartes);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(807, 418);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // tbcHistoriaClinicaPartes
            // 
            this.tbcHistoriaClinicaPartes.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpEctoscopia);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpAnamnesis);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpExamenFisico);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpDiagnostico);
            this.tbcHistoriaClinicaPartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHistoriaClinicaPartes.Location = new System.Drawing.Point(3, 3);
            this.tbcHistoriaClinicaPartes.Multiline = true;
            this.tbcHistoriaClinicaPartes.Name = "tbcHistoriaClinicaPartes";
            this.tbcHistoriaClinicaPartes.SelectedIndex = 0;
            this.tbcHistoriaClinicaPartes.Size = new System.Drawing.Size(801, 412);
            this.tbcHistoriaClinicaPartes.TabIndex = 0;
            // 
            // tbpEctoscopia
            // 
            this.tbpEctoscopia.Controls.Add(this.rtxtEctoscopiaActual);
            this.tbpEctoscopia.Controls.Add(this.lblEctoscopiaActual);
            this.tbpEctoscopia.Controls.Add(this.rtxtEctoscopiaAnterior);
            this.tbpEctoscopia.Controls.Add(this.lblEctoscopiaAnterior);
            this.tbpEctoscopia.Location = new System.Drawing.Point(4, 4);
            this.tbpEctoscopia.Name = "tbpEctoscopia";
            this.tbpEctoscopia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEctoscopia.Size = new System.Drawing.Size(774, 404);
            this.tbpEctoscopia.TabIndex = 0;
            this.tbpEctoscopia.Text = "Ectoscopia";
            this.tbpEctoscopia.UseVisualStyleBackColor = true;
            // 
            // lblEctoscopiaActual
            // 
            this.lblEctoscopiaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEctoscopiaActual.AutoSize = true;
            this.lblEctoscopiaActual.Location = new System.Drawing.Point(6, 209);
            this.lblEctoscopiaActual.Name = "lblEctoscopiaActual";
            this.lblEctoscopiaActual.Size = new System.Drawing.Size(40, 13);
            this.lblEctoscopiaActual.TabIndex = 2;
            this.lblEctoscopiaActual.Text = "Actual:";
            // 
            // lblEctoscopiaAnterior
            // 
            this.lblEctoscopiaAnterior.AutoSize = true;
            this.lblEctoscopiaAnterior.Location = new System.Drawing.Point(6, 3);
            this.lblEctoscopiaAnterior.Name = "lblEctoscopiaAnterior";
            this.lblEctoscopiaAnterior.Size = new System.Drawing.Size(46, 13);
            this.lblEctoscopiaAnterior.TabIndex = 0;
            this.lblEctoscopiaAnterior.Text = "Anterior:";
            // 
            // tbpAnamnesis
            // 
            this.tbpAnamnesis.Controls.Add(this.tbcAnamnesisPartes);
            this.tbpAnamnesis.Location = new System.Drawing.Point(4, 4);
            this.tbpAnamnesis.Name = "tbpAnamnesis";
            this.tbpAnamnesis.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAnamnesis.Size = new System.Drawing.Size(774, 404);
            this.tbpAnamnesis.TabIndex = 1;
            this.tbpAnamnesis.Text = "Anamnesis";
            this.tbpAnamnesis.UseVisualStyleBackColor = true;
            // 
            // tbcAnamnesisPartes
            // 
            this.tbcAnamnesisPartes.Controls.Add(this.tbpFiliacion);
            this.tbcAnamnesisPartes.Controls.Add(this.tbpEnfermedadActual);
            this.tbcAnamnesisPartes.Controls.Add(this.tbpAntecedentes);
            this.tbcAnamnesisPartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAnamnesisPartes.Location = new System.Drawing.Point(3, 3);
            this.tbcAnamnesisPartes.Name = "tbcAnamnesisPartes";
            this.tbcAnamnesisPartes.SelectedIndex = 0;
            this.tbcAnamnesisPartes.Size = new System.Drawing.Size(768, 398);
            this.tbcAnamnesisPartes.TabIndex = 0;
            // 
            // tbpFiliacion
            // 
            this.tbpFiliacion.Controls.Add(this.gbxDomicilio);
            this.tbpFiliacion.Controls.Add(this.gbxLugarNacimiento);
            this.tbpFiliacion.Controls.Add(this.gbxPersonal);
            this.tbpFiliacion.Location = new System.Drawing.Point(4, 22);
            this.tbpFiliacion.Name = "tbpFiliacion";
            this.tbpFiliacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFiliacion.Size = new System.Drawing.Size(760, 372);
            this.tbpFiliacion.TabIndex = 0;
            this.tbpFiliacion.Text = "Filiación";
            this.tbpFiliacion.UseVisualStyleBackColor = true;
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDomicilio.Controls.Add(this.txtDireccion);
            this.gbxDomicilio.Controls.Add(this.lblDireccion);
            this.gbxDomicilio.Controls.Add(this.cboDistritoDomicilio);
            this.gbxDomicilio.Controls.Add(this.cboProvinciaDomicilio);
            this.gbxDomicilio.Controls.Add(this.cboDepartamentoDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblDistritoDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblProvinciaDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblDepartamentoDomicilio);
            this.gbxDomicilio.Location = new System.Drawing.Point(6, 238);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(748, 116);
            this.gbxDomicilio.TabIndex = 17;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 36;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cboDistritoDomicilio
            // 
            this.cboDistritoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistritoDomicilio.FormattingEnabled = true;
            this.cboDistritoDomicilio.Location = new System.Drawing.Point(313, 33);
            this.cboDistritoDomicilio.Name = "cboDistritoDomicilio";
            this.cboDistritoDomicilio.Size = new System.Drawing.Size(125, 21);
            this.cboDistritoDomicilio.TabIndex = 19;
            // 
            // cboProvinciaDomicilio
            // 
            this.cboProvinciaDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinciaDomicilio.FormattingEnabled = true;
            this.cboProvinciaDomicilio.Location = new System.Drawing.Point(161, 33);
            this.cboProvinciaDomicilio.Name = "cboProvinciaDomicilio";
            this.cboProvinciaDomicilio.Size = new System.Drawing.Size(122, 21);
            this.cboProvinciaDomicilio.TabIndex = 18;
            // 
            // cboDepartamentoDomicilio
            // 
            this.cboDepartamentoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentoDomicilio.FormattingEnabled = true;
            this.cboDepartamentoDomicilio.Location = new System.Drawing.Point(10, 33);
            this.cboDepartamentoDomicilio.Name = "cboDepartamentoDomicilio";
            this.cboDepartamentoDomicilio.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamentoDomicilio.TabIndex = 17;
            // 
            // lblDistritoDomicilio
            // 
            this.lblDistritoDomicilio.AutoSize = true;
            this.lblDistritoDomicilio.Location = new System.Drawing.Point(310, 17);
            this.lblDistritoDomicilio.Name = "lblDistritoDomicilio";
            this.lblDistritoDomicilio.Size = new System.Drawing.Size(42, 13);
            this.lblDistritoDomicilio.TabIndex = 32;
            this.lblDistritoDomicilio.Text = "Distrito:";
            // 
            // lblProvinciaDomicilio
            // 
            this.lblProvinciaDomicilio.AutoSize = true;
            this.lblProvinciaDomicilio.Location = new System.Drawing.Point(158, 17);
            this.lblProvinciaDomicilio.Name = "lblProvinciaDomicilio";
            this.lblProvinciaDomicilio.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaDomicilio.TabIndex = 31;
            this.lblProvinciaDomicilio.Text = "Provincia:";
            // 
            // lblDepartamentoDomicilio
            // 
            this.lblDepartamentoDomicilio.AutoSize = true;
            this.lblDepartamentoDomicilio.Location = new System.Drawing.Point(7, 16);
            this.lblDepartamentoDomicilio.Name = "lblDepartamentoDomicilio";
            this.lblDepartamentoDomicilio.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamentoDomicilio.TabIndex = 30;
            this.lblDepartamentoDomicilio.Text = "Departamento:";
            // 
            // gbxLugarNacimiento
            // 
            this.gbxLugarNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLugarNacimiento.Controls.Add(this.cboDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.cboProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.cboDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.lblDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.lblProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.lblDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.cboPais);
            this.gbxLugarNacimiento.Controls.Add(this.lblPais);
            this.gbxLugarNacimiento.Location = new System.Drawing.Point(6, 159);
            this.gbxLugarNacimiento.Name = "gbxLugarNacimiento";
            this.gbxLugarNacimiento.Size = new System.Drawing.Size(748, 72);
            this.gbxLugarNacimiento.TabIndex = 13;
            this.gbxLugarNacimiento.TabStop = false;
            this.gbxLugarNacimiento.Text = "Lugar de Nacimiento";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(463, 32);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(125, 21);
            this.cboDistrito.TabIndex = 16;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(313, 32);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(125, 21);
            this.cboProvincia.TabIndex = 15;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(161, 32);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamento.TabIndex = 14;
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(460, 16);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 26;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(310, 16);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 25;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(158, 16);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 24;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(10, 32);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(125, 21);
            this.cboPais.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(7, 16);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 22;
            this.lblPais.Text = "Pais:";
            // 
            // gbxPersonal
            // 
            this.gbxPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPersonal.Controls.Add(this.cboFactorSanguineo);
            this.gbxPersonal.Controls.Add(this.lblFactorSanguineo);
            this.gbxPersonal.Controls.Add(this.cboGrupoSanguineo);
            this.gbxPersonal.Controls.Add(this.lblGrupoSanguineo);
            this.gbxPersonal.Controls.Add(this.txtEdad);
            this.gbxPersonal.Controls.Add(this.lblEdad);
            this.gbxPersonal.Controls.Add(this.txtNombres);
            this.gbxPersonal.Controls.Add(this.txtMaterno);
            this.gbxPersonal.Controls.Add(this.txtPaterno);
            this.gbxPersonal.Controls.Add(this.cboEstadoCivil);
            this.gbxPersonal.Controls.Add(this.lblEstadoCivil);
            this.gbxPersonal.Controls.Add(this.dtpFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.lblFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.cboReligion);
            this.gbxPersonal.Controls.Add(this.lblReligion);
            this.gbxPersonal.Controls.Add(this.cboRaza);
            this.gbxPersonal.Controls.Add(this.lblEtnia);
            this.gbxPersonal.Controls.Add(this.cboOcupacion);
            this.gbxPersonal.Controls.Add(this.lblOcupacion);
            this.gbxPersonal.Controls.Add(this.cboSexo);
            this.gbxPersonal.Controls.Add(this.lblSexo);
            this.gbxPersonal.Controls.Add(this.lblNombres);
            this.gbxPersonal.Controls.Add(this.lblMaterno);
            this.gbxPersonal.Controls.Add(this.lblPaterno);
            this.gbxPersonal.Location = new System.Drawing.Point(6, 6);
            this.gbxPersonal.Name = "gbxPersonal";
            this.gbxPersonal.Size = new System.Drawing.Size(748, 147);
            this.gbxPersonal.TabIndex = 1;
            this.gbxPersonal.TabStop = false;
            this.gbxPersonal.Text = "Información Personal";
            // 
            // cboFactorSanguineo
            // 
            this.cboFactorSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactorSanguineo.FormattingEnabled = true;
            this.cboFactorSanguineo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "RH+",
            "RH-"});
            this.cboFactorSanguineo.Location = new System.Drawing.Point(616, 114);
            this.cboFactorSanguineo.Name = "cboFactorSanguineo";
            this.cboFactorSanguineo.Size = new System.Drawing.Size(125, 21);
            this.cboFactorSanguineo.TabIndex = 12;
            // 
            // lblFactorSanguineo
            // 
            this.lblFactorSanguineo.AutoSize = true;
            this.lblFactorSanguineo.Location = new System.Drawing.Point(613, 99);
            this.lblFactorSanguineo.Name = "lblFactorSanguineo";
            this.lblFactorSanguineo.Size = new System.Drawing.Size(96, 13);
            this.lblFactorSanguineo.TabIndex = 25;
            this.lblFactorSanguineo.Text = "Factor Sanguíneo:";
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
            this.cboGrupoSanguineo.Location = new System.Drawing.Point(463, 114);
            this.cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            this.cboGrupoSanguineo.Size = new System.Drawing.Size(125, 21);
            this.cboGrupoSanguineo.TabIndex = 11;
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(460, 99);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(95, 13);
            this.lblGrupoSanguineo.TabIndex = 23;
            this.lblGrupoSanguineo.Text = "Grupo Sanguíneo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(310, 99);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 21;
            this.lblEdad.Text = "Edad:";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "SELECCIONAR",
            "SOLTERO(A)",
            "CASADO(A)",
            "VIUDO(A)",
            "DIVORCIADO(A)",
            "OTRO"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(10, 114);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(122, 21);
            this.cboEstadoCivil.TabIndex = 8;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 99);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 20;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(161, 115);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(158, 99);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // cboReligion
            // 
            this.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReligion.FormattingEnabled = true;
            this.cboReligion.Items.AddRange(new object[] {
            "SELECCIONAR",
            "CATÓLICA"});
            this.cboReligion.Location = new System.Drawing.Point(313, 75);
            this.cboReligion.Name = "cboReligion";
            this.cboReligion.Size = new System.Drawing.Size(125, 21);
            this.cboReligion.TabIndex = 6;
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Location = new System.Drawing.Point(310, 59);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(48, 13);
            this.lblReligion.TabIndex = 12;
            this.lblReligion.Text = "Religión:";
            // 
            // cboRaza
            // 
            this.cboRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRaza.FormattingEnabled = true;
            this.cboRaza.Items.AddRange(new object[] {
            "SELECCIONAR",
            "BLANCA",
            "MESTIZA",
            "NEGRA"});
            this.cboRaza.Location = new System.Drawing.Point(161, 75);
            this.cboRaza.Name = "cboRaza";
            this.cboRaza.Size = new System.Drawing.Size(125, 21);
            this.cboRaza.TabIndex = 5;
            // 
            // lblEtnia
            // 
            this.lblEtnia.AutoSize = true;
            this.lblEtnia.Location = new System.Drawing.Point(158, 59);
            this.lblEtnia.Name = "lblEtnia";
            this.lblEtnia.Size = new System.Drawing.Size(34, 13);
            this.lblEtnia.TabIndex = 10;
            this.lblEtnia.Text = "Etnia:";
            // 
            // cboOcupacion
            // 
            this.cboOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcupacion.FormattingEnabled = true;
            this.cboOcupacion.Items.AddRange(new object[] {
            "SELECCIONAR",
            "ESTUDIANTE"});
            this.cboOcupacion.Location = new System.Drawing.Point(463, 75);
            this.cboOcupacion.Name = "cboOcupacion";
            this.cboOcupacion.Size = new System.Drawing.Size(125, 21);
            this.cboOcupacion.TabIndex = 7;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(460, 59);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(62, 13);
            this.lblOcupacion.TabIndex = 8;
            this.lblOcupacion.Text = "Ocupación:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "MASCULINO",
            "FEMENINO"});
            this.cboSexo.Location = new System.Drawing.Point(10, 75);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(125, 21);
            this.cboSexo.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(7, 59);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(310, 20);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(158, 20);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblMaterno.TabIndex = 2;
            this.lblMaterno.Text = "Apellido Materno:";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(7, 20);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblPaterno.TabIndex = 0;
            this.lblPaterno.Text = "Apellido Paterno:";
            // 
            // tbpEnfermedadActual
            // 
            this.tbpEnfermedadActual.Controls.Add(this.lblRelatoCronologico);
            this.tbpEnfermedadActual.Controls.Add(this.lblSintomasEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.lblCursoEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.lblInicioEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.lblDias);
            this.tbpEnfermedadActual.Controls.Add(this.lblTiempoEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.rtxtRelatoCronologico);
            this.tbpEnfermedadActual.Controls.Add(this.rtxtSintomasEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.txtCursoEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.txtInicioEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.txtTiempoEnfermedad);
            this.tbpEnfermedadActual.Location = new System.Drawing.Point(4, 22);
            this.tbpEnfermedadActual.Name = "tbpEnfermedadActual";
            this.tbpEnfermedadActual.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEnfermedadActual.Size = new System.Drawing.Size(760, 372);
            this.tbpEnfermedadActual.TabIndex = 1;
            this.tbpEnfermedadActual.Text = "Enfermedad Actual";
            this.tbpEnfermedadActual.UseVisualStyleBackColor = true;
            // 
            // lblRelatoCronologico
            // 
            this.lblRelatoCronologico.AutoSize = true;
            this.lblRelatoCronologico.Location = new System.Drawing.Point(6, 247);
            this.lblRelatoCronologico.Name = "lblRelatoCronologico";
            this.lblRelatoCronologico.Size = new System.Drawing.Size(100, 13);
            this.lblRelatoCronologico.TabIndex = 10;
            this.lblRelatoCronologico.Text = "Relato Cronológico:";
            // 
            // lblSintomasEnfermedad
            // 
            this.lblSintomasEnfermedad.AutoSize = true;
            this.lblSintomasEnfermedad.Location = new System.Drawing.Point(7, 110);
            this.lblSintomasEnfermedad.Name = "lblSintomasEnfermedad";
            this.lblSintomasEnfermedad.Size = new System.Drawing.Size(184, 13);
            this.lblSintomasEnfermedad.TabIndex = 7;
            this.lblSintomasEnfermedad.Text = "Signos y Síntomas de la Enfermedad:";
            // 
            // lblCursoEnfermedad
            // 
            this.lblCursoEnfermedad.AutoSize = true;
            this.lblCursoEnfermedad.Location = new System.Drawing.Point(7, 75);
            this.lblCursoEnfermedad.Name = "lblCursoEnfermedad";
            this.lblCursoEnfermedad.Size = new System.Drawing.Size(123, 13);
            this.lblCursoEnfermedad.TabIndex = 6;
            this.lblCursoEnfermedad.Text = "Curso de la Enfermedad:";
            // 
            // lblInicioEnfermedad
            // 
            this.lblInicioEnfermedad.AutoSize = true;
            this.lblInicioEnfermedad.Location = new System.Drawing.Point(7, 40);
            this.lblInicioEnfermedad.Name = "lblInicioEnfermedad";
            this.lblInicioEnfermedad.Size = new System.Drawing.Size(121, 13);
            this.lblInicioEnfermedad.TabIndex = 3;
            this.lblInicioEnfermedad.Text = "Inicio de la Enfermedad:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(256, 6);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "días";
            // 
            // lblTiempoEnfermedad
            // 
            this.lblTiempoEnfermedad.AutoSize = true;
            this.lblTiempoEnfermedad.Location = new System.Drawing.Point(7, 6);
            this.lblTiempoEnfermedad.Name = "lblTiempoEnfermedad";
            this.lblTiempoEnfermedad.Size = new System.Drawing.Size(120, 13);
            this.lblTiempoEnfermedad.TabIndex = 0;
            this.lblTiempoEnfermedad.Text = "Tiempo de Enfermedad:";
            // 
            // tbpAntecedentes
            // 
            this.tbpAntecedentes.Controls.Add(this.gbxOtros);
            this.tbpAntecedentes.Controls.Add(this.gbxPersonales);
            this.tbpAntecedentes.Controls.Add(this.gbxHabitosNocivos);
            this.tbpAntecedentes.Location = new System.Drawing.Point(4, 22);
            this.tbpAntecedentes.Name = "tbpAntecedentes";
            this.tbpAntecedentes.Size = new System.Drawing.Size(760, 372);
            this.tbpAntecedentes.TabIndex = 2;
            this.tbpAntecedentes.Text = "Antecedentes";
            this.tbpAntecedentes.UseVisualStyleBackColor = true;
            // 
            // gbxOtros
            // 
            this.gbxOtros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOtros.Controls.Add(this.rtxtOtrosAntecedentes);
            this.gbxOtros.Location = new System.Drawing.Point(3, 270);
            this.gbxOtros.Name = "gbxOtros";
            this.gbxOtros.Size = new System.Drawing.Size(754, 99);
            this.gbxOtros.TabIndex = 2;
            this.gbxOtros.TabStop = false;
            this.gbxOtros.Text = "Otros";
            // 
            // gbxPersonales
            // 
            this.gbxPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPersonales.Controls.Add(this.txtColagenopatia);
            this.gbxPersonales.Controls.Add(this.txtFiebresProlongadas);
            this.gbxPersonales.Controls.Add(this.txtEnfermedadesNeurologicas);
            this.gbxPersonales.Controls.Add(this.txtHepatitis);
            this.gbxPersonales.Controls.Add(this.txtColecistopatia);
            this.gbxPersonales.Controls.Add(this.txtUlcera);
            this.gbxPersonales.Controls.Add(this.txtETS);
            this.gbxPersonales.Controls.Add(this.txtHemopatia);
            this.gbxPersonales.Controls.Add(this.txtUropatia);
            this.gbxPersonales.Controls.Add(this.txtNefropatia);
            this.gbxPersonales.Controls.Add(this.txtEndocrinopatia);
            this.gbxPersonales.Controls.Add(this.txtGota);
            this.gbxPersonales.Controls.Add(this.txtAtipia);
            this.gbxPersonales.Controls.Add(this.txtTuberculosis);
            this.gbxPersonales.Controls.Add(this.txtAlergias);
            this.gbxPersonales.Controls.Add(this.txtPsicopatia);
            this.gbxPersonales.Controls.Add(this.txtAsma);
            this.gbxPersonales.Controls.Add(this.txtDislipidemia);
            this.gbxPersonales.Controls.Add(this.txtCoronariopatia);
            this.gbxPersonales.Controls.Add(this.txtHipertensionArterial);
            this.gbxPersonales.Controls.Add(this.txtDiabetes);
            this.gbxPersonales.Controls.Add(this.cbxColagenopatia);
            this.gbxPersonales.Controls.Add(this.cbxFiebresProlongadas);
            this.gbxPersonales.Controls.Add(this.cbxEnfermedadesNeurologicas);
            this.gbxPersonales.Controls.Add(this.cbxHepatitis);
            this.gbxPersonales.Controls.Add(this.cbxColecistopatia);
            this.gbxPersonales.Controls.Add(this.cbxUlcera);
            this.gbxPersonales.Controls.Add(this.cbxETS);
            this.gbxPersonales.Controls.Add(this.cbxHemopatia);
            this.gbxPersonales.Controls.Add(this.cbxAlergias);
            this.gbxPersonales.Controls.Add(this.cbxUropatia);
            this.gbxPersonales.Controls.Add(this.cbxPsicopatia);
            this.gbxPersonales.Controls.Add(this.cbxNefropatia);
            this.gbxPersonales.Controls.Add(this.cbxAsma);
            this.gbxPersonales.Controls.Add(this.cbxEndocrinopatia);
            this.gbxPersonales.Controls.Add(this.cbxDislipidemia);
            this.gbxPersonales.Controls.Add(this.cbxGota);
            this.gbxPersonales.Controls.Add(this.cbxCoronariopatia);
            this.gbxPersonales.Controls.Add(this.cbxAtipia);
            this.gbxPersonales.Controls.Add(this.cbxHipertensionArterial);
            this.gbxPersonales.Controls.Add(this.cbxTuberculosis);
            this.gbxPersonales.Controls.Add(this.cbxDiabetes);
            this.gbxPersonales.Location = new System.Drawing.Point(3, 62);
            this.gbxPersonales.Name = "gbxPersonales";
            this.gbxPersonales.Size = new System.Drawing.Size(754, 204);
            this.gbxPersonales.TabIndex = 1;
            this.gbxPersonales.TabStop = false;
            this.gbxPersonales.Text = "Personales";
            // 
            // cbxColagenopatia
            // 
            this.cbxColagenopatia.AutoSize = true;
            this.cbxColagenopatia.Location = new System.Drawing.Point(499, 176);
            this.cbxColagenopatia.Name = "cbxColagenopatia";
            this.cbxColagenopatia.Size = new System.Drawing.Size(96, 17);
            this.cbxColagenopatia.TabIndex = 41;
            this.cbxColagenopatia.Text = "Colagenopatía";
            this.cbxColagenopatia.UseVisualStyleBackColor = true;
            // 
            // cbxFiebresProlongadas
            // 
            this.cbxFiebresProlongadas.AutoSize = true;
            this.cbxFiebresProlongadas.Location = new System.Drawing.Point(499, 150);
            this.cbxFiebresProlongadas.Name = "cbxFiebresProlongadas";
            this.cbxFiebresProlongadas.Size = new System.Drawing.Size(102, 17);
            this.cbxFiebresProlongadas.TabIndex = 35;
            this.cbxFiebresProlongadas.Text = "Fiebres Prolong.";
            this.cbxFiebresProlongadas.UseVisualStyleBackColor = true;
            // 
            // cbxEnfermedadesNeurologicas
            // 
            this.cbxEnfermedadesNeurologicas.AutoSize = true;
            this.cbxEnfermedadesNeurologicas.Location = new System.Drawing.Point(499, 124);
            this.cbxEnfermedadesNeurologicas.Name = "cbxEnfermedadesNeurologicas";
            this.cbxEnfermedadesNeurologicas.Size = new System.Drawing.Size(110, 17);
            this.cbxEnfermedadesNeurologicas.TabIndex = 29;
            this.cbxEnfermedadesNeurologicas.Text = "Enf. Neurológicas";
            this.cbxEnfermedadesNeurologicas.UseVisualStyleBackColor = true;
            // 
            // cbxHepatitis
            // 
            this.cbxHepatitis.AutoSize = true;
            this.cbxHepatitis.Location = new System.Drawing.Point(499, 98);
            this.cbxHepatitis.Name = "cbxHepatitis";
            this.cbxHepatitis.Size = new System.Drawing.Size(67, 17);
            this.cbxHepatitis.TabIndex = 23;
            this.cbxHepatitis.Text = "Hepatitis";
            this.cbxHepatitis.UseVisualStyleBackColor = true;
            // 
            // cbxColecistopatia
            // 
            this.cbxColecistopatia.AutoSize = true;
            this.cbxColecistopatia.Location = new System.Drawing.Point(499, 72);
            this.cbxColecistopatia.Name = "cbxColecistopatia";
            this.cbxColecistopatia.Size = new System.Drawing.Size(94, 17);
            this.cbxColecistopatia.TabIndex = 17;
            this.cbxColecistopatia.Text = "Colecistopatía";
            this.cbxColecistopatia.UseVisualStyleBackColor = true;
            // 
            // cbxUlcera
            // 
            this.cbxUlcera.AutoSize = true;
            this.cbxUlcera.Location = new System.Drawing.Point(499, 46);
            this.cbxUlcera.Name = "cbxUlcera";
            this.cbxUlcera.Size = new System.Drawing.Size(57, 17);
            this.cbxUlcera.TabIndex = 11;
            this.cbxUlcera.Text = "Úlcera";
            this.cbxUlcera.UseVisualStyleBackColor = true;
            // 
            // cbxETS
            // 
            this.cbxETS.AutoSize = true;
            this.cbxETS.Location = new System.Drawing.Point(499, 20);
            this.cbxETS.Name = "cbxETS";
            this.cbxETS.Size = new System.Drawing.Size(56, 17);
            this.cbxETS.TabIndex = 5;
            this.cbxETS.Text = "E.T.S.";
            this.cbxETS.UseVisualStyleBackColor = true;
            // 
            // cbxHemopatia
            // 
            this.cbxHemopatia.AutoSize = true;
            this.cbxHemopatia.Location = new System.Drawing.Point(247, 176);
            this.cbxHemopatia.Name = "cbxHemopatia";
            this.cbxHemopatia.Size = new System.Drawing.Size(79, 17);
            this.cbxHemopatia.TabIndex = 39;
            this.cbxHemopatia.Text = "Hemopatía";
            this.cbxHemopatia.UseVisualStyleBackColor = true;
            // 
            // cbxAlergias
            // 
            this.cbxAlergias.AutoSize = true;
            this.cbxAlergias.Location = new System.Drawing.Point(6, 175);
            this.cbxAlergias.Name = "cbxAlergias";
            this.cbxAlergias.Size = new System.Drawing.Size(63, 17);
            this.cbxAlergias.TabIndex = 37;
            this.cbxAlergias.Text = "Alergias";
            this.cbxAlergias.UseVisualStyleBackColor = true;
            // 
            // cbxUropatia
            // 
            this.cbxUropatia.AutoSize = true;
            this.cbxUropatia.Location = new System.Drawing.Point(247, 150);
            this.cbxUropatia.Name = "cbxUropatia";
            this.cbxUropatia.Size = new System.Drawing.Size(68, 17);
            this.cbxUropatia.TabIndex = 33;
            this.cbxUropatia.Text = "Uropatía";
            this.cbxUropatia.UseVisualStyleBackColor = true;
            // 
            // cbxPsicopatia
            // 
            this.cbxPsicopatia.AutoSize = true;
            this.cbxPsicopatia.Location = new System.Drawing.Point(6, 149);
            this.cbxPsicopatia.Name = "cbxPsicopatia";
            this.cbxPsicopatia.Size = new System.Drawing.Size(77, 17);
            this.cbxPsicopatia.TabIndex = 31;
            this.cbxPsicopatia.Text = "Psicopatía";
            this.cbxPsicopatia.UseVisualStyleBackColor = true;
            // 
            // cbxNefropatia
            // 
            this.cbxNefropatia.AutoSize = true;
            this.cbxNefropatia.Location = new System.Drawing.Point(247, 124);
            this.cbxNefropatia.Name = "cbxNefropatia";
            this.cbxNefropatia.Size = new System.Drawing.Size(77, 17);
            this.cbxNefropatia.TabIndex = 27;
            this.cbxNefropatia.Text = "Nefropatía";
            this.cbxNefropatia.UseVisualStyleBackColor = true;
            // 
            // cbxAsma
            // 
            this.cbxAsma.AutoSize = true;
            this.cbxAsma.Location = new System.Drawing.Point(6, 123);
            this.cbxAsma.Name = "cbxAsma";
            this.cbxAsma.Size = new System.Drawing.Size(99, 17);
            this.cbxAsma.TabIndex = 25;
            this.cbxAsma.Text = "Asma Bronquial";
            this.cbxAsma.UseVisualStyleBackColor = true;
            // 
            // cbxEndocrinopatia
            // 
            this.cbxEndocrinopatia.AutoSize = true;
            this.cbxEndocrinopatia.Location = new System.Drawing.Point(247, 98);
            this.cbxEndocrinopatia.Name = "cbxEndocrinopatia";
            this.cbxEndocrinopatia.Size = new System.Drawing.Size(99, 17);
            this.cbxEndocrinopatia.TabIndex = 21;
            this.cbxEndocrinopatia.Text = "Endocrinopatía";
            this.cbxEndocrinopatia.UseVisualStyleBackColor = true;
            // 
            // cbxDislipidemia
            // 
            this.cbxDislipidemia.AutoSize = true;
            this.cbxDislipidemia.Location = new System.Drawing.Point(6, 97);
            this.cbxDislipidemia.Name = "cbxDislipidemia";
            this.cbxDislipidemia.Size = new System.Drawing.Size(81, 17);
            this.cbxDislipidemia.TabIndex = 19;
            this.cbxDislipidemia.Text = "Dislipidemia";
            this.cbxDislipidemia.UseVisualStyleBackColor = true;
            // 
            // cbxGota
            // 
            this.cbxGota.AutoSize = true;
            this.cbxGota.Location = new System.Drawing.Point(247, 72);
            this.cbxGota.Name = "cbxGota";
            this.cbxGota.Size = new System.Drawing.Size(49, 17);
            this.cbxGota.TabIndex = 15;
            this.cbxGota.Text = "Gota";
            this.cbxGota.UseVisualStyleBackColor = true;
            // 
            // cbxCoronariopatia
            // 
            this.cbxCoronariopatia.AutoSize = true;
            this.cbxCoronariopatia.Location = new System.Drawing.Point(6, 71);
            this.cbxCoronariopatia.Name = "cbxCoronariopatia";
            this.cbxCoronariopatia.Size = new System.Drawing.Size(96, 17);
            this.cbxCoronariopatia.TabIndex = 13;
            this.cbxCoronariopatia.Text = "Coronariopatía";
            this.cbxCoronariopatia.UseVisualStyleBackColor = true;
            // 
            // cbxAtipia
            // 
            this.cbxAtipia.AutoSize = true;
            this.cbxAtipia.Location = new System.Drawing.Point(247, 46);
            this.cbxAtipia.Name = "cbxAtipia";
            this.cbxAtipia.Size = new System.Drawing.Size(52, 17);
            this.cbxAtipia.TabIndex = 9;
            this.cbxAtipia.Text = "Atipia";
            this.cbxAtipia.UseVisualStyleBackColor = true;
            // 
            // cbxHipertensionArterial
            // 
            this.cbxHipertensionArterial.AutoSize = true;
            this.cbxHipertensionArterial.Location = new System.Drawing.Point(6, 45);
            this.cbxHipertensionArterial.Name = "cbxHipertensionArterial";
            this.cbxHipertensionArterial.Size = new System.Drawing.Size(92, 17);
            this.cbxHipertensionArterial.TabIndex = 7;
            this.cbxHipertensionArterial.Text = "Hipert. Arterial";
            this.cbxHipertensionArterial.UseVisualStyleBackColor = true;
            // 
            // cbxTuberculosis
            // 
            this.cbxTuberculosis.AutoSize = true;
            this.cbxTuberculosis.Location = new System.Drawing.Point(247, 20);
            this.cbxTuberculosis.Name = "cbxTuberculosis";
            this.cbxTuberculosis.Size = new System.Drawing.Size(86, 17);
            this.cbxTuberculosis.TabIndex = 3;
            this.cbxTuberculosis.Text = "Tuberculosis";
            this.cbxTuberculosis.UseVisualStyleBackColor = true;
            // 
            // cbxDiabetes
            // 
            this.cbxDiabetes.AutoSize = true;
            this.cbxDiabetes.Location = new System.Drawing.Point(6, 19);
            this.cbxDiabetes.Name = "cbxDiabetes";
            this.cbxDiabetes.Size = new System.Drawing.Size(68, 17);
            this.cbxDiabetes.TabIndex = 1;
            this.cbxDiabetes.Text = "Diabetes";
            this.cbxDiabetes.UseVisualStyleBackColor = true;
            // 
            // gbxHabitosNocivos
            // 
            this.gbxHabitosNocivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHabitosNocivos.Controls.Add(this.cbxDrogas);
            this.gbxHabitosNocivos.Controls.Add(this.cbxTe);
            this.gbxHabitosNocivos.Controls.Add(this.cbxCafe);
            this.gbxHabitosNocivos.Controls.Add(this.cbxAlcohol);
            this.gbxHabitosNocivos.Controls.Add(this.cbxTabaco);
            this.gbxHabitosNocivos.Location = new System.Drawing.Point(3, 3);
            this.gbxHabitosNocivos.Name = "gbxHabitosNocivos";
            this.gbxHabitosNocivos.Size = new System.Drawing.Size(754, 53);
            this.gbxHabitosNocivos.TabIndex = 0;
            this.gbxHabitosNocivos.TabStop = false;
            this.gbxHabitosNocivos.Text = "Hábitos Nocivos";
            // 
            // cbxDrogas
            // 
            this.cbxDrogas.AutoSize = true;
            this.cbxDrogas.Location = new System.Drawing.Point(406, 19);
            this.cbxDrogas.Name = "cbxDrogas";
            this.cbxDrogas.Size = new System.Drawing.Size(60, 17);
            this.cbxDrogas.TabIndex = 4;
            this.cbxDrogas.Text = "Drogas";
            this.cbxDrogas.UseVisualStyleBackColor = true;
            // 
            // cbxTe
            // 
            this.cbxTe.AutoSize = true;
            this.cbxTe.Location = new System.Drawing.Point(306, 19);
            this.cbxTe.Name = "cbxTe";
            this.cbxTe.Size = new System.Drawing.Size(39, 17);
            this.cbxTe.TabIndex = 3;
            this.cbxTe.Text = "Té";
            this.cbxTe.UseVisualStyleBackColor = true;
            // 
            // cbxCafe
            // 
            this.cbxCafe.AutoSize = true;
            this.cbxCafe.Location = new System.Drawing.Point(206, 19);
            this.cbxCafe.Name = "cbxCafe";
            this.cbxCafe.Size = new System.Drawing.Size(48, 17);
            this.cbxCafe.TabIndex = 2;
            this.cbxCafe.Text = "Café";
            this.cbxCafe.UseVisualStyleBackColor = true;
            // 
            // cbxAlcohol
            // 
            this.cbxAlcohol.AutoSize = true;
            this.cbxAlcohol.Location = new System.Drawing.Point(106, 19);
            this.cbxAlcohol.Name = "cbxAlcohol";
            this.cbxAlcohol.Size = new System.Drawing.Size(61, 17);
            this.cbxAlcohol.TabIndex = 1;
            this.cbxAlcohol.Text = "Alcohol";
            this.cbxAlcohol.UseVisualStyleBackColor = true;
            // 
            // cbxTabaco
            // 
            this.cbxTabaco.AutoSize = true;
            this.cbxTabaco.Location = new System.Drawing.Point(6, 19);
            this.cbxTabaco.Name = "cbxTabaco";
            this.cbxTabaco.Size = new System.Drawing.Size(63, 17);
            this.cbxTabaco.TabIndex = 0;
            this.cbxTabaco.Text = "Tabaco";
            this.cbxTabaco.UseVisualStyleBackColor = true;
            // 
            // tbpExamenFisico
            // 
            this.tbpExamenFisico.Controls.Add(this.rtxtOtrosExamenes);
            this.tbpExamenFisico.Controls.Add(this.lblOtrosExamenes);
            this.tbpExamenFisico.Controls.Add(this.gbxOtrosDatos);
            this.tbpExamenFisico.Controls.Add(this.gbxSignosVitales);
            this.tbpExamenFisico.Location = new System.Drawing.Point(4, 4);
            this.tbpExamenFisico.Name = "tbpExamenFisico";
            this.tbpExamenFisico.Size = new System.Drawing.Size(774, 404);
            this.tbpExamenFisico.TabIndex = 2;
            this.tbpExamenFisico.Text = "Examen Físico";
            this.tbpExamenFisico.UseVisualStyleBackColor = true;
            // 
            // lblOtrosExamenes
            // 
            this.lblOtrosExamenes.AutoSize = true;
            this.lblOtrosExamenes.Location = new System.Drawing.Point(3, 216);
            this.lblOtrosExamenes.Name = "lblOtrosExamenes";
            this.lblOtrosExamenes.Size = new System.Drawing.Size(87, 13);
            this.lblOtrosExamenes.TabIndex = 3;
            this.lblOtrosExamenes.Text = "Otros Exámenes:";
            // 
            // gbxOtrosDatos
            // 
            this.gbxOtrosDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOtrosDatos.Controls.Add(this.txtTalla);
            this.gbxOtrosDatos.Controls.Add(this.txtPeso);
            this.gbxOtrosDatos.Controls.Add(this.lblTalla);
            this.gbxOtrosDatos.Controls.Add(this.lblPeso);
            this.gbxOtrosDatos.Location = new System.Drawing.Point(6, 113);
            this.gbxOtrosDatos.Name = "gbxOtrosDatos";
            this.gbxOtrosDatos.Size = new System.Drawing.Size(765, 100);
            this.gbxOtrosDatos.TabIndex = 1;
            this.gbxOtrosDatos.TabStop = false;
            this.gbxOtrosDatos.Text = "Otros Datos";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(6, 59);
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
            this.gbxSignosVitales.Controls.Add(this.txtPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.lblPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.lblFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaCardiaca);
            this.gbxSignosVitales.Controls.Add(this.label1);
            this.gbxSignosVitales.Controls.Add(this.txtTemperatura);
            this.gbxSignosVitales.Controls.Add(this.lblTemperatura);
            this.gbxSignosVitales.Location = new System.Drawing.Point(6, 6);
            this.gbxSignosVitales.Name = "gbxSignosVitales";
            this.gbxSignosVitales.Size = new System.Drawing.Size(765, 101);
            this.gbxSignosVitales.TabIndex = 0;
            this.gbxSignosVitales.TabStop = false;
            this.gbxSignosVitales.Text = "Signos Vitales";
            // 
            // lblPresionArterial
            // 
            this.lblPresionArterial.AutoSize = true;
            this.lblPresionArterial.Location = new System.Drawing.Point(292, 56);
            this.lblPresionArterial.Name = "lblPresionArterial";
            this.lblPresionArterial.Size = new System.Drawing.Size(80, 13);
            this.lblPresionArterial.TabIndex = 7;
            this.lblPresionArterial.Text = "Presión Arterial:";
            // 
            // lblFrecuenciaRespiratoria
            // 
            this.lblFrecuenciaRespiratoria.AutoSize = true;
            this.lblFrecuenciaRespiratoria.Location = new System.Drawing.Point(292, 27);
            this.lblFrecuenciaRespiratoria.Name = "lblFrecuenciaRespiratoria";
            this.lblFrecuenciaRespiratoria.Size = new System.Drawing.Size(122, 13);
            this.lblFrecuenciaRespiratoria.TabIndex = 6;
            this.lblFrecuenciaRespiratoria.Text = "Frecuencia Respiratoria:";
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
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(6, 27);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // tbpDiagnostico
            // 
            this.tbpDiagnostico.Controls.Add(this.btnQuitar);
            this.tbpDiagnostico.Controls.Add(this.btnAgregar);
            this.tbpDiagnostico.Controls.Add(this.dgvDiagnosticos);
            this.tbpDiagnostico.Controls.Add(this.btnBuscar);
            this.tbpDiagnostico.Controls.Add(this.btnGuardar);
            this.tbpDiagnostico.Controls.Add(this.btnCancelar);
            this.tbpDiagnostico.Controls.Add(this.lblDescripcionActual);
            this.tbpDiagnostico.Controls.Add(this.lblDiagnostico);
            this.tbpDiagnostico.Controls.Add(this.rtxtDiagnosticoActual);
            this.tbpDiagnostico.Controls.Add(this.txtDiagnostico);
            this.tbpDiagnostico.Location = new System.Drawing.Point(4, 4);
            this.tbpDiagnostico.Name = "tbpDiagnostico";
            this.tbpDiagnostico.Size = new System.Drawing.Size(774, 404);
            this.tbpDiagnostico.TabIndex = 3;
            this.tbpDiagnostico.Text = "Diagnóstico";
            this.tbpDiagnostico.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(671, 322);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(671, 166);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvDiagnosticos
            // 
            this.dgvDiagnosticos.AllowUserToAddRows = false;
            this.dgvDiagnosticos.AllowUserToDeleteRows = false;
            this.dgvDiagnosticos.AllowUserToResizeColumns = false;
            this.dgvDiagnosticos.AllowUserToResizeRows = false;
            this.dgvDiagnosticos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCie10,
            this.colCodigo,
            this.colDescripcion});
            this.dgvDiagnosticos.Location = new System.Drawing.Point(13, 195);
            this.dgvDiagnosticos.MultiSelect = false;
            this.dgvDiagnosticos.Name = "dgvDiagnosticos";
            this.dgvDiagnosticos.RowHeadersVisible = false;
            this.dgvDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosticos.Size = new System.Drawing.Size(652, 150);
            this.dgvDiagnosticos.TabIndex = 36;
            // 
            // colIdCie10
            // 
            this.colIdCie10.HeaderText = "ID";
            this.colIdCie10.Name = "colIdCie10";
            this.colIdCie10.ReadOnly = true;
            this.colIdCie10.Visible = false;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(671, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(693, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(577, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcionActual
            // 
            this.lblDescripcionActual.AutoSize = true;
            this.lblDescripcionActual.Location = new System.Drawing.Point(10, 40);
            this.lblDescripcionActual.Name = "lblDescripcionActual";
            this.lblDescripcionActual.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionActual.TabIndex = 4;
            this.lblDescripcionActual.Text = "Descripción:";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(10, 15);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblDiagnostico.TabIndex = 2;
            this.lblDiagnostico.Text = "Diagnóstico:";
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
            // rtxtEctoscopiaActual
            // 
            this.rtxtEctoscopiaActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEctoscopiaActual.Location = new System.Drawing.Point(9, 225);
            this.rtxtEctoscopiaActual.MaxLength = 1000;
            this.rtxtEctoscopiaActual.Name = "rtxtEctoscopiaActual";
            this.rtxtEctoscopiaActual.Size = new System.Drawing.Size(759, 160);
            this.rtxtEctoscopiaActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtEctoscopiaActual.TabIndex = 2;
            this.rtxtEctoscopiaActual.Text = "";
            // 
            // rtxtEctoscopiaAnterior
            // 
            this.rtxtEctoscopiaAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEctoscopiaAnterior.BackColor = System.Drawing.Color.White;
            this.rtxtEctoscopiaAnterior.Location = new System.Drawing.Point(9, 19);
            this.rtxtEctoscopiaAnterior.Name = "rtxtEctoscopiaAnterior";
            this.rtxtEctoscopiaAnterior.ReadOnly = true;
            this.rtxtEctoscopiaAnterior.Size = new System.Drawing.Size(759, 187);
            this.rtxtEctoscopiaAnterior.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
            this.rtxtEctoscopiaAnterior.TabIndex = 1;
            this.rtxtEctoscopiaAnterior.Text = "";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(10, 83);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(737, 20);
            this.txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDireccion.TabIndex = 20;
            this.txtDireccion.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.White;
            this.txtEdad.Location = new System.Drawing.Point(313, 115);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(65, 20);
            this.txtEdad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtEdad.TabIndex = 10;
            this.txtEdad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(313, 36);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(275, 20);
            this.txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(161, 36);
            this.txtMaterno.MaxLength = 30;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(125, 20);
            this.txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtMaterno.TabIndex = 2;
            this.txtMaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(10, 35);
            this.txtPaterno.MaxLength = 30;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(125, 20);
            this.txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaterno.TabIndex = 1;
            this.txtPaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // rtxtRelatoCronologico
            // 
            this.rtxtRelatoCronologico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtRelatoCronologico.Location = new System.Drawing.Point(201, 244);
            this.rtxtRelatoCronologico.MaxLength = 1000;
            this.rtxtRelatoCronologico.Name = "rtxtRelatoCronologico";
            this.rtxtRelatoCronologico.Size = new System.Drawing.Size(553, 122);
            this.rtxtRelatoCronologico.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtRelatoCronologico.TabIndex = 4;
            this.rtxtRelatoCronologico.Text = "";
            // 
            // rtxtSintomasEnfermedad
            // 
            this.rtxtSintomasEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtSintomasEnfermedad.Location = new System.Drawing.Point(201, 107);
            this.rtxtSintomasEnfermedad.MaxLength = 1000;
            this.rtxtSintomasEnfermedad.Name = "rtxtSintomasEnfermedad";
            this.rtxtSintomasEnfermedad.Size = new System.Drawing.Size(553, 131);
            this.rtxtSintomasEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtSintomasEnfermedad.TabIndex = 3;
            this.rtxtSintomasEnfermedad.Text = "";
            // 
            // txtCursoEnfermedad
            // 
            this.txtCursoEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCursoEnfermedad.Location = new System.Drawing.Point(201, 72);
            this.txtCursoEnfermedad.MaxLength = 300;
            this.txtCursoEnfermedad.Name = "txtCursoEnfermedad";
            this.txtCursoEnfermedad.Size = new System.Drawing.Size(553, 20);
            this.txtCursoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCursoEnfermedad.TabIndex = 2;
            this.txtCursoEnfermedad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtInicioEnfermedad
            // 
            this.txtInicioEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInicioEnfermedad.Location = new System.Drawing.Point(201, 37);
            this.txtInicioEnfermedad.MaxLength = 300;
            this.txtInicioEnfermedad.Name = "txtInicioEnfermedad";
            this.txtInicioEnfermedad.Size = new System.Drawing.Size(553, 20);
            this.txtInicioEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtInicioEnfermedad.TabIndex = 1;
            this.txtInicioEnfermedad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtTiempoEnfermedad
            // 
            this.txtTiempoEnfermedad.BackColor = System.Drawing.Color.White;
            this.txtTiempoEnfermedad.Location = new System.Drawing.Point(201, 3);
            this.txtTiempoEnfermedad.MaxLength = 3;
            this.txtTiempoEnfermedad.Name = "txtTiempoEnfermedad";
            this.txtTiempoEnfermedad.Size = new System.Drawing.Size(49, 20);
            this.txtTiempoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTiempoEnfermedad.TabIndex = 0;
            this.txtTiempoEnfermedad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // rtxtOtrosAntecedentes
            // 
            this.rtxtOtrosAntecedentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOtrosAntecedentes.Location = new System.Drawing.Point(6, 19);
            this.rtxtOtrosAntecedentes.Name = "rtxtOtrosAntecedentes";
            this.rtxtOtrosAntecedentes.Size = new System.Drawing.Size(742, 74);
            this.rtxtOtrosAntecedentes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtOtrosAntecedentes.TabIndex = 0;
            this.rtxtOtrosAntecedentes.Text = "";
            // 
            // txtColagenopatia
            // 
            this.txtColagenopatia.Location = new System.Drawing.Point(612, 173);
            this.txtColagenopatia.Name = "txtColagenopatia";
            this.txtColagenopatia.Size = new System.Drawing.Size(141, 20);
            this.txtColagenopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtColagenopatia.TabIndex = 42;
            this.txtColagenopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtFiebresProlongadas
            // 
            this.txtFiebresProlongadas.Location = new System.Drawing.Point(612, 147);
            this.txtFiebresProlongadas.Name = "txtFiebresProlongadas";
            this.txtFiebresProlongadas.Size = new System.Drawing.Size(141, 20);
            this.txtFiebresProlongadas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFiebresProlongadas.TabIndex = 36;
            this.txtFiebresProlongadas.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtEnfermedadesNeurologicas
            // 
            this.txtEnfermedadesNeurologicas.Location = new System.Drawing.Point(612, 121);
            this.txtEnfermedadesNeurologicas.Name = "txtEnfermedadesNeurologicas";
            this.txtEnfermedadesNeurologicas.Size = new System.Drawing.Size(141, 20);
            this.txtEnfermedadesNeurologicas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtEnfermedadesNeurologicas.TabIndex = 30;
            this.txtEnfermedadesNeurologicas.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtHepatitis
            // 
            this.txtHepatitis.Location = new System.Drawing.Point(612, 96);
            this.txtHepatitis.Name = "txtHepatitis";
            this.txtHepatitis.Size = new System.Drawing.Size(141, 20);
            this.txtHepatitis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtHepatitis.TabIndex = 24;
            this.txtHepatitis.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtColecistopatia
            // 
            this.txtColecistopatia.Location = new System.Drawing.Point(612, 69);
            this.txtColecistopatia.Name = "txtColecistopatia";
            this.txtColecistopatia.Size = new System.Drawing.Size(141, 20);
            this.txtColecistopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtColecistopatia.TabIndex = 18;
            this.txtColecistopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtUlcera
            // 
            this.txtUlcera.Location = new System.Drawing.Point(612, 44);
            this.txtUlcera.Name = "txtUlcera";
            this.txtUlcera.Size = new System.Drawing.Size(141, 20);
            this.txtUlcera.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtUlcera.TabIndex = 12;
            this.txtUlcera.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtETS
            // 
            this.txtETS.Location = new System.Drawing.Point(612, 17);
            this.txtETS.Name = "txtETS";
            this.txtETS.Size = new System.Drawing.Size(141, 20);
            this.txtETS.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtETS.TabIndex = 6;
            this.txtETS.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtHemopatia
            // 
            this.txtHemopatia.Location = new System.Drawing.Point(352, 173);
            this.txtHemopatia.Name = "txtHemopatia";
            this.txtHemopatia.Size = new System.Drawing.Size(141, 20);
            this.txtHemopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtHemopatia.TabIndex = 40;
            this.txtHemopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtUropatia
            // 
            this.txtUropatia.Location = new System.Drawing.Point(352, 147);
            this.txtUropatia.Name = "txtUropatia";
            this.txtUropatia.Size = new System.Drawing.Size(141, 20);
            this.txtUropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtUropatia.TabIndex = 34;
            this.txtUropatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtNefropatia
            // 
            this.txtNefropatia.Location = new System.Drawing.Point(352, 121);
            this.txtNefropatia.Name = "txtNefropatia";
            this.txtNefropatia.Size = new System.Drawing.Size(141, 20);
            this.txtNefropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNefropatia.TabIndex = 28;
            this.txtNefropatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtEndocrinopatia
            // 
            this.txtEndocrinopatia.Location = new System.Drawing.Point(352, 96);
            this.txtEndocrinopatia.Name = "txtEndocrinopatia";
            this.txtEndocrinopatia.Size = new System.Drawing.Size(141, 20);
            this.txtEndocrinopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtEndocrinopatia.TabIndex = 22;
            this.txtEndocrinopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtGota
            // 
            this.txtGota.Location = new System.Drawing.Point(352, 70);
            this.txtGota.Name = "txtGota";
            this.txtGota.Size = new System.Drawing.Size(141, 20);
            this.txtGota.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtGota.TabIndex = 16;
            this.txtGota.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtAtipia
            // 
            this.txtAtipia.Location = new System.Drawing.Point(352, 43);
            this.txtAtipia.Name = "txtAtipia";
            this.txtAtipia.Size = new System.Drawing.Size(141, 20);
            this.txtAtipia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtAtipia.TabIndex = 10;
            this.txtAtipia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtTuberculosis
            // 
            this.txtTuberculosis.Location = new System.Drawing.Point(352, 17);
            this.txtTuberculosis.Name = "txtTuberculosis";
            this.txtTuberculosis.Size = new System.Drawing.Size(141, 20);
            this.txtTuberculosis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTuberculosis.TabIndex = 4;
            this.txtTuberculosis.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtAlergias
            // 
            this.txtAlergias.Location = new System.Drawing.Point(100, 174);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(141, 20);
            this.txtAlergias.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtAlergias.TabIndex = 38;
            this.txtAlergias.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtPsicopatia
            // 
            this.txtPsicopatia.Location = new System.Drawing.Point(100, 148);
            this.txtPsicopatia.Name = "txtPsicopatia";
            this.txtPsicopatia.Size = new System.Drawing.Size(141, 20);
            this.txtPsicopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPsicopatia.TabIndex = 32;
            this.txtPsicopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtAsma
            // 
            this.txtAsma.Location = new System.Drawing.Point(100, 121);
            this.txtAsma.Name = "txtAsma";
            this.txtAsma.Size = new System.Drawing.Size(141, 20);
            this.txtAsma.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtAsma.TabIndex = 26;
            this.txtAsma.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtDislipidemia
            // 
            this.txtDislipidemia.Location = new System.Drawing.Point(100, 96);
            this.txtDislipidemia.Name = "txtDislipidemia";
            this.txtDislipidemia.Size = new System.Drawing.Size(141, 20);
            this.txtDislipidemia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDislipidemia.TabIndex = 20;
            this.txtDislipidemia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtCoronariopatia
            // 
            this.txtCoronariopatia.Location = new System.Drawing.Point(100, 69);
            this.txtCoronariopatia.Name = "txtCoronariopatia";
            this.txtCoronariopatia.Size = new System.Drawing.Size(141, 20);
            this.txtCoronariopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCoronariopatia.TabIndex = 14;
            this.txtCoronariopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtHipertensionArterial
            // 
            this.txtHipertensionArterial.Location = new System.Drawing.Point(100, 43);
            this.txtHipertensionArterial.Name = "txtHipertensionArterial";
            this.txtHipertensionArterial.Size = new System.Drawing.Size(141, 20);
            this.txtHipertensionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtHipertensionArterial.TabIndex = 8;
            this.txtHipertensionArterial.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtDiabetes
            // 
            this.txtDiabetes.Location = new System.Drawing.Point(100, 17);
            this.txtDiabetes.Name = "txtDiabetes";
            this.txtDiabetes.Size = new System.Drawing.Size(141, 20);
            this.txtDiabetes.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDiabetes.TabIndex = 2;
            this.txtDiabetes.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // rtxtOtrosExamenes
            // 
            this.rtxtOtrosExamenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOtrosExamenes.BackColor = System.Drawing.Color.White;
            this.rtxtOtrosExamenes.Location = new System.Drawing.Point(6, 232);
            this.rtxtOtrosExamenes.Name = "rtxtOtrosExamenes";
            this.rtxtOtrosExamenes.Size = new System.Drawing.Size(765, 169);
            this.rtxtOtrosExamenes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtOtrosExamenes.TabIndex = 7;
            this.rtxtOtrosExamenes.Text = "";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(130, 51);
            this.txtTalla.MaxLength = 5;
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(84, 20);
            this.txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTalla.TabIndex = 6;
            this.txtTalla.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(130, 22);
            this.txtPeso.MaxLength = 6;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(84, 20);
            this.txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPeso.TabIndex = 5;
            this.txtPeso.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtPresionArterial
            // 
            this.txtPresionArterial.Location = new System.Drawing.Point(433, 53);
            this.txtPresionArterial.MaxLength = 10;
            this.txtPresionArterial.Name = "txtPresionArterial";
            this.txtPresionArterial.Size = new System.Drawing.Size(84, 20);
            this.txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPresionArterial.TabIndex = 4;
            this.txtPresionArterial.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtFrecuenciaRespiratoria
            // 
            this.txtFrecuenciaRespiratoria.Location = new System.Drawing.Point(433, 24);
            this.txtFrecuenciaRespiratoria.MaxLength = 10;
            this.txtFrecuenciaRespiratoria.Name = "txtFrecuenciaRespiratoria";
            this.txtFrecuenciaRespiratoria.Size = new System.Drawing.Size(84, 20);
            this.txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFrecuenciaRespiratoria.TabIndex = 3;
            this.txtFrecuenciaRespiratoria.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
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
            // rtxtDiagnosticoActual
            // 
            this.rtxtDiagnosticoActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDiagnosticoActual.BackColor = System.Drawing.Color.White;
            this.rtxtDiagnosticoActual.Location = new System.Drawing.Point(13, 56);
            this.rtxtDiagnosticoActual.Name = "rtxtDiagnosticoActual";
            this.rtxtDiagnosticoActual.Size = new System.Drawing.Size(652, 133);
            this.rtxtDiagnosticoActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtDiagnosticoActual.TabIndex = 3;
            this.rtxtDiagnosticoActual.Text = "";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiagnostico.BackColor = System.Drawing.Color.LightYellow;
            this.txtDiagnostico.Location = new System.Drawing.Point(82, 12);
            this.txtDiagnostico.MaxLength = 400;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(583, 20);
            this.txtDiagnostico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDiagnostico.TabIndex = 1;
            this.txtDiagnostico.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // frmHistorialClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 444);
            this.Controls.Add(this.tbcHistoriaClinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clínica";
            this.tbcHistoriaClinica.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodios)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.tbcHistoriaClinicaPartes.ResumeLayout(false);
            this.tbpEctoscopia.ResumeLayout(false);
            this.tbpEctoscopia.PerformLayout();
            this.tbpAnamnesis.ResumeLayout(false);
            this.tbcAnamnesisPartes.ResumeLayout(false);
            this.tbpFiliacion.ResumeLayout(false);
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxLugarNacimiento.ResumeLayout(false);
            this.gbxLugarNacimiento.PerformLayout();
            this.gbxPersonal.ResumeLayout(false);
            this.gbxPersonal.PerformLayout();
            this.tbpEnfermedadActual.ResumeLayout(false);
            this.tbpEnfermedadActual.PerformLayout();
            this.tbpAntecedentes.ResumeLayout(false);
            this.gbxOtros.ResumeLayout(false);
            this.gbxPersonales.ResumeLayout(false);
            this.gbxPersonales.PerformLayout();
            this.gbxHabitosNocivos.ResumeLayout(false);
            this.gbxHabitosNocivos.PerformLayout();
            this.tbpExamenFisico.ResumeLayout(false);
            this.tbpExamenFisico.PerformLayout();
            this.gbxOtrosDatos.ResumeLayout(false);
            this.gbxOtrosDatos.PerformLayout();
            this.gbxSignosVitales.ResumeLayout(false);
            this.gbxSignosVitales.PerformLayout();
            this.tbpDiagnostico.ResumeLayout(false);
            this.tbpDiagnostico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcHistoriaClinica;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.TabControl tbcHistoriaClinicaPartes;
        private System.Windows.Forms.TabPage tbpEctoscopia;
        private System.Windows.Forms.TabPage tbpAnamnesis;
        private System.Windows.Forms.TabPage tbpExamenFisico;
        private System.Windows.Forms.TabPage tbpDiagnostico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnNuevo;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtEctoscopiaActual;
        private System.Windows.Forms.Label lblEctoscopiaActual;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtEctoscopiaAnterior;
        private System.Windows.Forms.Label lblEctoscopiaAnterior;
        private System.Windows.Forms.TabControl tbcAnamnesisPartes;
        private System.Windows.Forms.TabPage tbpEnfermedadActual;
        private System.Windows.Forms.TabPage tbpAntecedentes;
        private System.Windows.Forms.TabPage tbpFiliacion;
        private System.Windows.Forms.Label lblDescripcionActual;
        private SistemaCentroSalud.Controles.cuTextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtDiagnosticoActual;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblInicioEnfermedad;
        private System.Windows.Forms.Label lblDias;
        private SistemaCentroSalud.Controles.cuTextBox txtTiempoEnfermedad;
        private System.Windows.Forms.Label lblTiempoEnfermedad;
        private System.Windows.Forms.Label lblRelatoCronologico;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtRelatoCronologico;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtSintomasEnfermedad;
        private System.Windows.Forms.Label lblSintomasEnfermedad;
        private System.Windows.Forms.Label lblCursoEnfermedad;
        private SistemaCentroSalud.Controles.cuTextBox txtCursoEnfermedad;
        private SistemaCentroSalud.Controles.cuTextBox txtInicioEnfermedad;
        private System.Windows.Forms.GroupBox gbxPersonal;
        private SistemaCentroSalud.Controles.cuTextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private SistemaCentroSalud.Controles.cuTextBox txtNombres;
        private SistemaCentroSalud.Controles.cuTextBox txtMaterno;
        private SistemaCentroSalud.Controles.cuTextBox txtPaterno;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cboReligion;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.ComboBox cboRaza;
        private System.Windows.Forms.Label lblEtnia;
        private System.Windows.Forms.ComboBox cboOcupacion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private SistemaCentroSalud.Controles.cuTextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cboDistritoDomicilio;
        private System.Windows.Forms.ComboBox cboProvinciaDomicilio;
        private System.Windows.Forms.ComboBox cboDepartamentoDomicilio;
        private System.Windows.Forms.Label lblDistritoDomicilio;
        private System.Windows.Forms.Label lblProvinciaDomicilio;
        private System.Windows.Forms.Label lblDepartamentoDomicilio;
        private System.Windows.Forms.GroupBox gbxLugarNacimiento;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cboFactorSanguineo;
        private System.Windows.Forms.Label lblFactorSanguineo;
        private System.Windows.Forms.ComboBox cboGrupoSanguineo;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.Label lblOtrosExamenes;
        private System.Windows.Forms.GroupBox gbxOtrosDatos;
        private System.Windows.Forms.GroupBox gbxSignosVitales;
        private SistemaCentroSalud.Controles.cuTextBox txtFrecuenciaCardiaca;
        private System.Windows.Forms.Label label1;
        private SistemaCentroSalud.Controles.cuTextBox txtTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private SistemaCentroSalud.Controles.cuTextBox txtPresionArterial;
        private SistemaCentroSalud.Controles.cuTextBox txtFrecuenciaRespiratoria;
        private System.Windows.Forms.Label lblPresionArterial;
        private System.Windows.Forms.Label lblFrecuenciaRespiratoria;
        private SistemaCentroSalud.Controles.cuTextBox txtTalla;
        private SistemaCentroSalud.Controles.cuTextBox txtPeso;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblPeso;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtOtrosExamenes;
        private System.Windows.Forms.GroupBox gbxHabitosNocivos;
        private System.Windows.Forms.CheckBox cbxDrogas;
        private System.Windows.Forms.CheckBox cbxTe;
        private System.Windows.Forms.CheckBox cbxCafe;
        private System.Windows.Forms.CheckBox cbxAlcohol;
        private System.Windows.Forms.CheckBox cbxTabaco;
        private System.Windows.Forms.GroupBox gbxPersonales;
        private System.Windows.Forms.CheckBox cbxTuberculosis;
        private System.Windows.Forms.CheckBox cbxDiabetes;
        private System.Windows.Forms.CheckBox cbxAtipia;
        private System.Windows.Forms.CheckBox cbxHipertensionArterial;
        private System.Windows.Forms.CheckBox cbxGota;
        private System.Windows.Forms.CheckBox cbxCoronariopatia;
        private System.Windows.Forms.CheckBox cbxEndocrinopatia;
        private System.Windows.Forms.CheckBox cbxDislipidemia;
        private System.Windows.Forms.CheckBox cbxNefropatia;
        private System.Windows.Forms.CheckBox cbxAsma;
        private System.Windows.Forms.GroupBox gbxOtros;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtOtrosAntecedentes;
        private System.Windows.Forms.CheckBox cbxHemopatia;
        private System.Windows.Forms.CheckBox cbxAlergias;
        private System.Windows.Forms.CheckBox cbxUropatia;
        private System.Windows.Forms.CheckBox cbxPsicopatia;
        private System.Windows.Forms.CheckBox cbxColagenopatia;
        private System.Windows.Forms.CheckBox cbxFiebresProlongadas;
        private System.Windows.Forms.CheckBox cbxEnfermedadesNeurologicas;
        private System.Windows.Forms.CheckBox cbxHepatitis;
        private System.Windows.Forms.CheckBox cbxColecistopatia;
        private System.Windows.Forms.CheckBox cbxUlcera;
        private System.Windows.Forms.CheckBox cbxETS;
        private SistemaCentroSalud.Controles.cuTextBox txtDiabetes;
        private SistemaCentroSalud.Controles.cuTextBox txtPsicopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtAsma;
        private SistemaCentroSalud.Controles.cuTextBox txtDislipidemia;
        private SistemaCentroSalud.Controles.cuTextBox txtCoronariopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtHipertensionArterial;
        private SistemaCentroSalud.Controles.cuTextBox txtAlergias;
        private SistemaCentroSalud.Controles.cuTextBox txtETS;
        private SistemaCentroSalud.Controles.cuTextBox txtHemopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtUropatia;
        private SistemaCentroSalud.Controles.cuTextBox txtNefropatia;
        private SistemaCentroSalud.Controles.cuTextBox txtEndocrinopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtGota;
        private SistemaCentroSalud.Controles.cuTextBox txtAtipia;
        private SistemaCentroSalud.Controles.cuTextBox txtTuberculosis;
        private SistemaCentroSalud.Controles.cuTextBox txtColagenopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtFiebresProlongadas;
        private SistemaCentroSalud.Controles.cuTextBox txtEnfermedadesNeurologicas;
        private SistemaCentroSalud.Controles.cuTextBox txtHepatitis;
        private SistemaCentroSalud.Controles.cuTextBox txtColecistopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtUlcera;
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
        private System.Windows.Forms.DataGridView dgvEpisodios;
        private System.Windows.Forms.Label lblEpisodios;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDiagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCie10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridView dgvHistoriasClinicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsable;
    }
}