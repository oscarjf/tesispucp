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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialClinica));
            this.tbcHistoriaClinica = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.colIdHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroHistoriaClinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactorSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAntecedentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tbpAnamnesis = new System.Windows.Forms.TabPage();
            this.tbcAnamnesisPartes = new System.Windows.Forms.TabControl();
            this.tbpFiliacion = new System.Windows.Forms.TabPage();
            this.btnCancelarFiliacion = new System.Windows.Forms.Button();
            this.lblNumeroHistoriaClinica = new System.Windows.Forms.Label();
            this.btnGuardarFiliacion = new System.Windows.Forms.Button();
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
            this.cboModoIngreso = new System.Windows.Forms.ComboBox();
            this.lblModoIngreso = new System.Windows.Forms.Label();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
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
            this.cboEtnia = new System.Windows.Forms.ComboBox();
            this.lblEtnia = new System.Windows.Forms.Label();
            this.cboOcupacion = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.tbpAntecedentes = new System.Windows.Forms.TabPage();
            this.gbxOtros = new System.Windows.Forms.GroupBox();
            this.btnGuardarAntecedentes = new System.Windows.Forms.Button();
            this.gbxPersonales = new System.Windows.Forms.GroupBox();
            this.cbxColagenopatia = new System.Windows.Forms.CheckBox();
            this.cbxFiebresProlongadas = new System.Windows.Forms.CheckBox();
            this.cbxEnfermedadesNeurologicas = new System.Windows.Forms.CheckBox();
            this.cbxHepatitis = new System.Windows.Forms.CheckBox();
            this.cbxColecistopatia = new System.Windows.Forms.CheckBox();
            this.cbxUlcera = new System.Windows.Forms.CheckBox();
            this.cbxETS = new System.Windows.Forms.CheckBox();
            this.cbxHemopatia = new System.Windows.Forms.CheckBox();
            this.cbxUropatia = new System.Windows.Forms.CheckBox();
            this.cbxNefropatia = new System.Windows.Forms.CheckBox();
            this.cbxEndocrinopatia = new System.Windows.Forms.CheckBox();
            this.cbxGota = new System.Windows.Forms.CheckBox();
            this.cbxAtipia = new System.Windows.Forms.CheckBox();
            this.cbxTuberculosis = new System.Windows.Forms.CheckBox();
            this.cbxAlergias = new System.Windows.Forms.CheckBox();
            this.cbxPsicopatia = new System.Windows.Forms.CheckBox();
            this.cbxAsma = new System.Windows.Forms.CheckBox();
            this.cbxDislipidemia = new System.Windows.Forms.CheckBox();
            this.cbxCoronariopatia = new System.Windows.Forms.CheckBox();
            this.cbxHipertensionArterial = new System.Windows.Forms.CheckBox();
            this.cbxDiabetes = new System.Windows.Forms.CheckBox();
            this.gbxHabitosNocivos = new System.Windows.Forms.GroupBox();
            this.cbxDrogas = new System.Windows.Forms.CheckBox();
            this.cbxTe = new System.Windows.Forms.CheckBox();
            this.cbxCafe = new System.Windows.Forms.CheckBox();
            this.cbxAlcohol = new System.Windows.Forms.CheckBox();
            this.cbxTabaco = new System.Windows.Forms.CheckBox();
            this.tbpEnfermedadActual = new System.Windows.Forms.TabPage();
            this.lblRelatoCronologico = new System.Windows.Forms.Label();
            this.lblSintomasEnfermedad = new System.Windows.Forms.Label();
            this.lblCursoEnfermedad = new System.Windows.Forms.Label();
            this.lblInicioEnfermedad = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTiempoEnfermedad = new System.Windows.Forms.Label();
            this.tbpEctoscopia = new System.Windows.Forms.TabPage();
            this.lblEctoscopiaActual = new System.Windows.Forms.Label();
            this.lblEctoscopiaAnterior = new System.Windows.Forms.Label();
            this.tbpExamenFisico = new System.Windows.Forms.TabPage();
            this.gbxFuncionesBiologicas = new System.Windows.Forms.GroupBox();
            this.lblDeposiciones = new System.Windows.Forms.Label();
            this.lblOrina = new System.Windows.Forms.Label();
            this.lblSed = new System.Windows.Forms.Label();
            this.lblApetito = new System.Windows.Forms.Label();
            this.lblOtrosExamenes = new System.Windows.Forms.Label();
            this.gbxOtrosDatos = new System.Windows.Forms.GroupBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.gbxSignosVitales = new System.Windows.Forms.GroupBox();
            this.lblPresionArterial = new System.Windows.Forms.Label();
            this.lblFrecuenciaRespiratoria = new System.Windows.Forms.Label();
            this.lblFrecuenciaCardiaca = new System.Windows.Forms.Label();
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
            this.ttpTips = new System.Windows.Forms.ToolTip(this.components);
            this.txtNumeroHistoriaClinicaBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNumeroDocumentoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtMaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombresBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNumeroHistoriaClinica = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtDireccion = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtEdad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombres = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtMaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaterno = new SistemaCentroSalud.Controles.cuTextBox();
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
            this.rtxtRelatoCronologico = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtSintomasEnfermedad = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtCursoEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtInicioEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTiempoEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtEctoscopiaActual = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtEctoscopiaAnterior = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtApetito = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtSed = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtOrina = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtDeposiciones = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtTalla = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPeso = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPresionArterial = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFrecuenciaRespiratoria = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFrecuenciaCardiaca = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTemperatura = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtOtrosExamenes = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.cboDiagnostico = new SistemaCentroSalud.Controles.cuComboBox();
            this.rtxtDiagnosticoActual = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.tbcHistoriaClinica.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodios)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.tbcHistoriaClinicaPartes.SuspendLayout();
            this.tbpAnamnesis.SuspendLayout();
            this.tbcAnamnesisPartes.SuspendLayout();
            this.tbpFiliacion.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxLugarNacimiento.SuspendLayout();
            this.gbxPersonal.SuspendLayout();
            this.tbpAntecedentes.SuspendLayout();
            this.gbxOtros.SuspendLayout();
            this.gbxPersonales.SuspendLayout();
            this.gbxHabitosNocivos.SuspendLayout();
            this.tbpEnfermedadActual.SuspendLayout();
            this.tbpEctoscopia.SuspendLayout();
            this.tbpExamenFisico.SuspendLayout();
            this.gbxFuncionesBiologicas.SuspendLayout();
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
            this.tbcHistoriaClinica.Size = new System.Drawing.Size(815, 509);
            this.tbcHistoriaClinica.TabIndex = 0;
            this.tbcHistoriaClinica.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcHistoriaClinica_Selecting);
            this.tbcHistoriaClinica.SelectedIndexChanged += new System.EventHandler(this.tbcHistoriaClinica_SelectedIndexChanged);
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
            this.tbpBuscar.Size = new System.Drawing.Size(807, 483);
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
            this.colPaterno,
            this.colMaterno,
            this.colNombres,
            this.colTipoDocumento,
            this.colNumeroDocumento,
            this.colGrupoSanguineo,
            this.colFactorSanguineo,
            this.Id,
            this.colIdAntecedentes});
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(8, 138);
            this.dgvHistoriasClinicas.MultiSelect = false;
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.ReadOnly = true;
            this.dgvHistoriasClinicas.RowHeadersVisible = false;
            this.dgvHistoriasClinicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(427, 308);
            this.dgvHistoriasClinicas.TabIndex = 47;
            this.dgvHistoriasClinicas.SelectionChanged += new System.EventHandler(this.dgvHistoriasClinicas_SelectionChanged);
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
            // colGrupoSanguineo
            // 
            this.colGrupoSanguineo.HeaderText = "GrupoSanguineo";
            this.colGrupoSanguineo.Name = "colGrupoSanguineo";
            this.colGrupoSanguineo.ReadOnly = true;
            this.colGrupoSanguineo.Visible = false;
            // 
            // colFactorSanguineo
            // 
            this.colFactorSanguineo.HeaderText = "FactorSanguineo";
            this.colFactorSanguineo.Name = "colFactorSanguineo";
            this.colFactorSanguineo.ReadOnly = true;
            this.colFactorSanguineo.Visible = false;
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
            // colIdAntecedentes
            // 
            this.colIdAntecedentes.HeaderText = "IdAntecedentes";
            this.colIdAntecedentes.Name = "colIdAntecedentes";
            this.colIdAntecedentes.ReadOnly = true;
            this.colIdAntecedentes.Visible = false;
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.Location = new System.Drawing.Point(441, 136);
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
            this.dgvEpisodios.Location = new System.Drawing.Point(441, 151);
            this.dgvEpisodios.MultiSelect = false;
            this.dgvEpisodios.Name = "dgvEpisodios";
            this.dgvEpisodios.RowHeadersVisible = false;
            this.dgvEpisodios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEpisodios.Size = new System.Drawing.Size(358, 295);
            this.dgvEpisodios.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEpisodio";
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
            this.gbxCriterios.Size = new System.Drawing.Size(791, 126);
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
            this.btnSalir.Location = new System.Drawing.Point(722, 452);
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
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(97, 452);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContinuar.Image = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Image")));
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Location = new System.Drawing.Point(188, 452);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(6, 452);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.tbcHistoriaClinicaPartes);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(807, 483);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // tbcHistoriaClinicaPartes
            // 
            this.tbcHistoriaClinicaPartes.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpAnamnesis);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpEctoscopia);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpExamenFisico);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpDiagnostico);
            this.tbcHistoriaClinicaPartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHistoriaClinicaPartes.Location = new System.Drawing.Point(3, 3);
            this.tbcHistoriaClinicaPartes.Multiline = true;
            this.tbcHistoriaClinicaPartes.Name = "tbcHistoriaClinicaPartes";
            this.tbcHistoriaClinicaPartes.SelectedIndex = 0;
            this.tbcHistoriaClinicaPartes.Size = new System.Drawing.Size(801, 477);
            this.tbcHistoriaClinicaPartes.TabIndex = 0;
            this.tbcHistoriaClinicaPartes.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcHistoriaClinicaPartes_Selecting);
            this.tbcHistoriaClinicaPartes.SelectedIndexChanged += new System.EventHandler(this.tbcHistoriaClinicaPartes_SelectedIndexChanged);
            // 
            // tbpAnamnesis
            // 
            this.tbpAnamnesis.Controls.Add(this.tbcAnamnesisPartes);
            this.tbpAnamnesis.Location = new System.Drawing.Point(4, 4);
            this.tbpAnamnesis.Name = "tbpAnamnesis";
            this.tbpAnamnesis.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAnamnesis.Size = new System.Drawing.Size(774, 469);
            this.tbpAnamnesis.TabIndex = 1;
            this.tbpAnamnesis.Text = "Anamnesis";
            this.tbpAnamnesis.UseVisualStyleBackColor = true;
            // 
            // tbcAnamnesisPartes
            // 
            this.tbcAnamnesisPartes.Controls.Add(this.tbpFiliacion);
            this.tbcAnamnesisPartes.Controls.Add(this.tbpAntecedentes);
            this.tbcAnamnesisPartes.Controls.Add(this.tbpEnfermedadActual);
            this.tbcAnamnesisPartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAnamnesisPartes.Location = new System.Drawing.Point(3, 3);
            this.tbcAnamnesisPartes.Name = "tbcAnamnesisPartes";
            this.tbcAnamnesisPartes.SelectedIndex = 0;
            this.tbcAnamnesisPartes.Size = new System.Drawing.Size(768, 463);
            this.tbcAnamnesisPartes.TabIndex = 0;
            this.tbcAnamnesisPartes.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcAnamnesisPartes_Selecting);
            this.tbcAnamnesisPartes.SelectedIndexChanged += new System.EventHandler(this.tbcAnamnesisPartes_SelectedIndexChanged);
            // 
            // tbpFiliacion
            // 
            this.tbpFiliacion.Controls.Add(this.btnCancelarFiliacion);
            this.tbpFiliacion.Controls.Add(this.txtNumeroHistoriaClinica);
            this.tbpFiliacion.Controls.Add(this.lblNumeroHistoriaClinica);
            this.tbpFiliacion.Controls.Add(this.btnGuardarFiliacion);
            this.tbpFiliacion.Controls.Add(this.gbxDomicilio);
            this.tbpFiliacion.Controls.Add(this.gbxLugarNacimiento);
            this.tbpFiliacion.Controls.Add(this.gbxPersonal);
            this.tbpFiliacion.Location = new System.Drawing.Point(4, 22);
            this.tbpFiliacion.Name = "tbpFiliacion";
            this.tbpFiliacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFiliacion.Size = new System.Drawing.Size(760, 437);
            this.tbpFiliacion.TabIndex = 0;
            this.tbpFiliacion.Text = "Filiación";
            this.tbpFiliacion.UseVisualStyleBackColor = true;
            // 
            // btnCancelarFiliacion
            // 
            this.btnCancelarFiliacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarFiliacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFiliacion.Image")));
            this.btnCancelarFiliacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFiliacion.Location = new System.Drawing.Point(87, 404);
            this.btnCancelarFiliacion.Name = "btnCancelarFiliacion";
            this.btnCancelarFiliacion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarFiliacion.TabIndex = 26;
            this.btnCancelarFiliacion.Text = "Cancelar";
            this.btnCancelarFiliacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarFiliacion.UseVisualStyleBackColor = true;
            this.btnCancelarFiliacion.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumeroHistoriaClinica
            // 
            this.lblNumeroHistoriaClinica.AutoSize = true;
            this.lblNumeroHistoriaClinica.Location = new System.Drawing.Point(8, 6);
            this.lblNumeroHistoriaClinica.Name = "lblNumeroHistoriaClinica";
            this.lblNumeroHistoriaClinica.Size = new System.Drawing.Size(101, 13);
            this.lblNumeroHistoriaClinica.TabIndex = 25;
            this.lblNumeroHistoriaClinica.Text = "No. Historia Clínica:";
            // 
            // btnGuardarFiliacion
            // 
            this.btnGuardarFiliacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarFiliacion.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarFiliacion.Image")));
            this.btnGuardarFiliacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarFiliacion.Location = new System.Drawing.Point(6, 404);
            this.btnGuardarFiliacion.Name = "btnGuardarFiliacion";
            this.btnGuardarFiliacion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarFiliacion.TabIndex = 24;
            this.btnGuardarFiliacion.Text = "Guardar";
            this.btnGuardarFiliacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarFiliacion.UseVisualStyleBackColor = true;
            this.btnGuardarFiliacion.Click += new System.EventHandler(this.btnGuardarFiliacion_Click);
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
            this.gbxDomicilio.Location = new System.Drawing.Point(6, 264);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(748, 116);
            this.gbxDomicilio.TabIndex = 19;
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
            this.cboDistritoDomicilio.TabIndex = 22;
            // 
            // cboProvinciaDomicilio
            // 
            this.cboProvinciaDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinciaDomicilio.FormattingEnabled = true;
            this.cboProvinciaDomicilio.Location = new System.Drawing.Point(161, 33);
            this.cboProvinciaDomicilio.Name = "cboProvinciaDomicilio";
            this.cboProvinciaDomicilio.Size = new System.Drawing.Size(122, 21);
            this.cboProvinciaDomicilio.TabIndex = 21;
            this.cboProvinciaDomicilio.SelectedIndexChanged += new System.EventHandler(this.cboProvinciaDomicilio_SelectedIndexChanged);
            // 
            // cboDepartamentoDomicilio
            // 
            this.cboDepartamentoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentoDomicilio.FormattingEnabled = true;
            this.cboDepartamentoDomicilio.Location = new System.Drawing.Point(10, 33);
            this.cboDepartamentoDomicilio.Name = "cboDepartamentoDomicilio";
            this.cboDepartamentoDomicilio.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamentoDomicilio.TabIndex = 20;
            this.cboDepartamentoDomicilio.SelectedIndexChanged += new System.EventHandler(this.cboDepartamentoDomicilio_SelectedIndexChanged);
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
            this.gbxLugarNacimiento.Location = new System.Drawing.Point(6, 185);
            this.gbxLugarNacimiento.Name = "gbxLugarNacimiento";
            this.gbxLugarNacimiento.Size = new System.Drawing.Size(748, 72);
            this.gbxLugarNacimiento.TabIndex = 15;
            this.gbxLugarNacimiento.TabStop = false;
            this.gbxLugarNacimiento.Text = "Lugar de Nacimiento";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.Enabled = false;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(463, 32);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(125, 21);
            this.cboDistrito.TabIndex = 18;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.Enabled = false;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(313, 32);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(125, 21);
            this.cboProvincia.TabIndex = 17;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Enabled = false;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(161, 32);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamento.TabIndex = 16;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
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
            this.cboPais.TabIndex = 15;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
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
            this.gbxPersonal.Controls.Add(this.cboModoIngreso);
            this.gbxPersonal.Controls.Add(this.lblModoIngreso);
            this.gbxPersonal.Controls.Add(this.cboIdioma);
            this.gbxPersonal.Controls.Add(this.lblIdioma);
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
            this.gbxPersonal.Controls.Add(this.cboEtnia);
            this.gbxPersonal.Controls.Add(this.lblEtnia);
            this.gbxPersonal.Controls.Add(this.cboOcupacion);
            this.gbxPersonal.Controls.Add(this.lblOcupacion);
            this.gbxPersonal.Controls.Add(this.cboSexo);
            this.gbxPersonal.Controls.Add(this.lblSexo);
            this.gbxPersonal.Controls.Add(this.lblNombres);
            this.gbxPersonal.Controls.Add(this.lblMaterno);
            this.gbxPersonal.Controls.Add(this.lblPaterno);
            this.gbxPersonal.Location = new System.Drawing.Point(6, 32);
            this.gbxPersonal.Name = "gbxPersonal";
            this.gbxPersonal.Size = new System.Drawing.Size(748, 147);
            this.gbxPersonal.TabIndex = 1;
            this.gbxPersonal.TabStop = false;
            this.gbxPersonal.Text = "Información Personal";
            // 
            // cboModoIngreso
            // 
            this.cboModoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModoIngreso.FormattingEnabled = true;
            this.cboModoIngreso.Location = new System.Drawing.Point(616, 36);
            this.cboModoIngreso.Name = "cboModoIngreso";
            this.cboModoIngreso.Size = new System.Drawing.Size(125, 21);
            this.cboModoIngreso.TabIndex = 4;
            // 
            // lblModoIngreso
            // 
            this.lblModoIngreso.AutoSize = true;
            this.lblModoIngreso.Location = new System.Drawing.Point(613, 20);
            this.lblModoIngreso.Name = "lblModoIngreso";
            this.lblModoIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblModoIngreso.TabIndex = 29;
            this.lblModoIngreso.Text = "Modo de Ingreso:";
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(616, 75);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(125, 21);
            this.cboIdioma.TabIndex = 9;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(613, 59);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(41, 13);
            this.lblIdioma.TabIndex = 27;
            this.lblIdioma.Text = "Idioma:";
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
            this.cboFactorSanguineo.TabIndex = 14;
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
            this.cboGrupoSanguineo.TabIndex = 13;
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
            this.cboEstadoCivil.TabIndex = 10;
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
            this.dtpFechaNacimiento.TabIndex = 11;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
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
            this.cboReligion.Location = new System.Drawing.Point(313, 75);
            this.cboReligion.Name = "cboReligion";
            this.cboReligion.Size = new System.Drawing.Size(125, 21);
            this.cboReligion.TabIndex = 7;
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
            // cboEtnia
            // 
            this.cboEtnia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtnia.FormattingEnabled = true;
            this.cboEtnia.Location = new System.Drawing.Point(161, 75);
            this.cboEtnia.Name = "cboEtnia";
            this.cboEtnia.Size = new System.Drawing.Size(125, 21);
            this.cboEtnia.TabIndex = 6;
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
            this.cboOcupacion.Location = new System.Drawing.Point(463, 75);
            this.cboOcupacion.Name = "cboOcupacion";
            this.cboOcupacion.Size = new System.Drawing.Size(125, 21);
            this.cboOcupacion.TabIndex = 8;
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
            this.cboSexo.TabIndex = 5;
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
            // tbpAntecedentes
            // 
            this.tbpAntecedentes.Controls.Add(this.gbxOtros);
            this.tbpAntecedentes.Controls.Add(this.gbxPersonales);
            this.tbpAntecedentes.Controls.Add(this.gbxHabitosNocivos);
            this.tbpAntecedentes.Location = new System.Drawing.Point(4, 22);
            this.tbpAntecedentes.Name = "tbpAntecedentes";
            this.tbpAntecedentes.Size = new System.Drawing.Size(760, 437);
            this.tbpAntecedentes.TabIndex = 2;
            this.tbpAntecedentes.Text = "Antecedentes";
            this.tbpAntecedentes.UseVisualStyleBackColor = true;
            // 
            // gbxOtros
            // 
            this.gbxOtros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOtros.Controls.Add(this.btnGuardarAntecedentes);
            this.gbxOtros.Controls.Add(this.rtxtOtrosAntecedentes);
            this.gbxOtros.Location = new System.Drawing.Point(3, 270);
            this.gbxOtros.Name = "gbxOtros";
            this.gbxOtros.Size = new System.Drawing.Size(754, 164);
            this.gbxOtros.TabIndex = 49;
            this.gbxOtros.TabStop = false;
            this.gbxOtros.Text = "Otros";
            // 
            // btnGuardarAntecedentes
            // 
            this.btnGuardarAntecedentes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarAntecedentes.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAntecedentes.Image")));
            this.btnGuardarAntecedentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarAntecedentes.Location = new System.Drawing.Point(3, 134);
            this.btnGuardarAntecedentes.Name = "btnGuardarAntecedentes";
            this.btnGuardarAntecedentes.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAntecedentes.TabIndex = 51;
            this.btnGuardarAntecedentes.Text = "Guardar";
            this.btnGuardarAntecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAntecedentes.UseVisualStyleBackColor = true;
            this.btnGuardarAntecedentes.Click += new System.EventHandler(this.btnGuardarAntecedentes_Click);
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
            this.gbxPersonales.Controls.Add(this.cbxColagenopatia);
            this.gbxPersonales.Controls.Add(this.cbxFiebresProlongadas);
            this.gbxPersonales.Controls.Add(this.cbxEnfermedadesNeurologicas);
            this.gbxPersonales.Controls.Add(this.cbxHepatitis);
            this.gbxPersonales.Controls.Add(this.cbxColecistopatia);
            this.gbxPersonales.Controls.Add(this.cbxUlcera);
            this.gbxPersonales.Controls.Add(this.cbxETS);
            this.gbxPersonales.Controls.Add(this.txtHemopatia);
            this.gbxPersonales.Controls.Add(this.txtUropatia);
            this.gbxPersonales.Controls.Add(this.txtNefropatia);
            this.gbxPersonales.Controls.Add(this.txtEndocrinopatia);
            this.gbxPersonales.Controls.Add(this.txtGota);
            this.gbxPersonales.Controls.Add(this.txtAtipia);
            this.gbxPersonales.Controls.Add(this.txtTuberculosis);
            this.gbxPersonales.Controls.Add(this.cbxHemopatia);
            this.gbxPersonales.Controls.Add(this.cbxUropatia);
            this.gbxPersonales.Controls.Add(this.cbxNefropatia);
            this.gbxPersonales.Controls.Add(this.cbxEndocrinopatia);
            this.gbxPersonales.Controls.Add(this.cbxGota);
            this.gbxPersonales.Controls.Add(this.cbxAtipia);
            this.gbxPersonales.Controls.Add(this.cbxTuberculosis);
            this.gbxPersonales.Controls.Add(this.txtAlergias);
            this.gbxPersonales.Controls.Add(this.txtPsicopatia);
            this.gbxPersonales.Controls.Add(this.txtAsma);
            this.gbxPersonales.Controls.Add(this.txtDislipidemia);
            this.gbxPersonales.Controls.Add(this.txtCoronariopatia);
            this.gbxPersonales.Controls.Add(this.txtHipertensionArterial);
            this.gbxPersonales.Controls.Add(this.txtDiabetes);
            this.gbxPersonales.Controls.Add(this.cbxAlergias);
            this.gbxPersonales.Controls.Add(this.cbxPsicopatia);
            this.gbxPersonales.Controls.Add(this.cbxAsma);
            this.gbxPersonales.Controls.Add(this.cbxDislipidemia);
            this.gbxPersonales.Controls.Add(this.cbxCoronariopatia);
            this.gbxPersonales.Controls.Add(this.cbxHipertensionArterial);
            this.gbxPersonales.Controls.Add(this.cbxDiabetes);
            this.gbxPersonales.Location = new System.Drawing.Point(4, 62);
            this.gbxPersonales.Name = "gbxPersonales";
            this.gbxPersonales.Size = new System.Drawing.Size(753, 204);
            this.gbxPersonales.TabIndex = 6;
            this.gbxPersonales.TabStop = false;
            this.gbxPersonales.Text = "Personales";
            // 
            // cbxColagenopatia
            // 
            this.cbxColagenopatia.AutoSize = true;
            this.cbxColagenopatia.Location = new System.Drawing.Point(499, 176);
            this.cbxColagenopatia.Name = "cbxColagenopatia";
            this.cbxColagenopatia.Size = new System.Drawing.Size(96, 17);
            this.cbxColagenopatia.TabIndex = 47;
            this.cbxColagenopatia.Text = "Colagenopatía";
            this.cbxColagenopatia.UseVisualStyleBackColor = true;
            this.cbxColagenopatia.CheckedChanged += new System.EventHandler(this.cbxColagenopatia_CheckedChanged);
            // 
            // cbxFiebresProlongadas
            // 
            this.cbxFiebresProlongadas.AutoSize = true;
            this.cbxFiebresProlongadas.Location = new System.Drawing.Point(499, 150);
            this.cbxFiebresProlongadas.Name = "cbxFiebresProlongadas";
            this.cbxFiebresProlongadas.Size = new System.Drawing.Size(102, 17);
            this.cbxFiebresProlongadas.TabIndex = 45;
            this.cbxFiebresProlongadas.Text = "Fiebres Prolong.";
            this.cbxFiebresProlongadas.UseVisualStyleBackColor = true;
            this.cbxFiebresProlongadas.CheckedChanged += new System.EventHandler(this.cbxFiebresProlongadas_CheckedChanged);
            // 
            // cbxEnfermedadesNeurologicas
            // 
            this.cbxEnfermedadesNeurologicas.AutoSize = true;
            this.cbxEnfermedadesNeurologicas.Location = new System.Drawing.Point(499, 124);
            this.cbxEnfermedadesNeurologicas.Name = "cbxEnfermedadesNeurologicas";
            this.cbxEnfermedadesNeurologicas.Size = new System.Drawing.Size(110, 17);
            this.cbxEnfermedadesNeurologicas.TabIndex = 43;
            this.cbxEnfermedadesNeurologicas.Text = "Enf. Neurológicas";
            this.cbxEnfermedadesNeurologicas.UseVisualStyleBackColor = true;
            this.cbxEnfermedadesNeurologicas.CheckedChanged += new System.EventHandler(this.cbxEnfermedadesNeurologicas_CheckedChanged);
            // 
            // cbxHepatitis
            // 
            this.cbxHepatitis.AutoSize = true;
            this.cbxHepatitis.Location = new System.Drawing.Point(499, 98);
            this.cbxHepatitis.Name = "cbxHepatitis";
            this.cbxHepatitis.Size = new System.Drawing.Size(67, 17);
            this.cbxHepatitis.TabIndex = 41;
            this.cbxHepatitis.Text = "Hepatitis";
            this.cbxHepatitis.UseVisualStyleBackColor = true;
            this.cbxHepatitis.CheckedChanged += new System.EventHandler(this.cbxHepatitis_CheckedChanged);
            // 
            // cbxColecistopatia
            // 
            this.cbxColecistopatia.AutoSize = true;
            this.cbxColecistopatia.Location = new System.Drawing.Point(499, 72);
            this.cbxColecistopatia.Name = "cbxColecistopatia";
            this.cbxColecistopatia.Size = new System.Drawing.Size(94, 17);
            this.cbxColecistopatia.TabIndex = 39;
            this.cbxColecistopatia.Text = "Colecistopatía";
            this.cbxColecistopatia.UseVisualStyleBackColor = true;
            this.cbxColecistopatia.CheckedChanged += new System.EventHandler(this.cbxColecistopatia_CheckedChanged);
            // 
            // cbxUlcera
            // 
            this.cbxUlcera.AutoSize = true;
            this.cbxUlcera.Location = new System.Drawing.Point(499, 46);
            this.cbxUlcera.Name = "cbxUlcera";
            this.cbxUlcera.Size = new System.Drawing.Size(57, 17);
            this.cbxUlcera.TabIndex = 37;
            this.cbxUlcera.Text = "Úlcera";
            this.cbxUlcera.UseVisualStyleBackColor = true;
            this.cbxUlcera.CheckedChanged += new System.EventHandler(this.cbxUlcera_CheckedChanged);
            // 
            // cbxETS
            // 
            this.cbxETS.AutoSize = true;
            this.cbxETS.Location = new System.Drawing.Point(499, 20);
            this.cbxETS.Name = "cbxETS";
            this.cbxETS.Size = new System.Drawing.Size(56, 17);
            this.cbxETS.TabIndex = 35;
            this.cbxETS.Text = "E.T.S.";
            this.cbxETS.UseVisualStyleBackColor = true;
            this.cbxETS.CheckedChanged += new System.EventHandler(this.cbxETS_CheckedChanged);
            // 
            // cbxHemopatia
            // 
            this.cbxHemopatia.AutoSize = true;
            this.cbxHemopatia.Location = new System.Drawing.Point(254, 177);
            this.cbxHemopatia.Name = "cbxHemopatia";
            this.cbxHemopatia.Size = new System.Drawing.Size(79, 17);
            this.cbxHemopatia.TabIndex = 33;
            this.cbxHemopatia.Text = "Hemopatía";
            this.cbxHemopatia.UseVisualStyleBackColor = true;
            this.cbxHemopatia.CheckedChanged += new System.EventHandler(this.cbxHemopatia_CheckedChanged);
            // 
            // cbxUropatia
            // 
            this.cbxUropatia.AutoSize = true;
            this.cbxUropatia.Location = new System.Drawing.Point(254, 151);
            this.cbxUropatia.Name = "cbxUropatia";
            this.cbxUropatia.Size = new System.Drawing.Size(68, 17);
            this.cbxUropatia.TabIndex = 31;
            this.cbxUropatia.Text = "Uropatía";
            this.cbxUropatia.UseVisualStyleBackColor = true;
            this.cbxUropatia.CheckedChanged += new System.EventHandler(this.cbxUropatia_CheckedChanged);
            // 
            // cbxNefropatia
            // 
            this.cbxNefropatia.AutoSize = true;
            this.cbxNefropatia.Location = new System.Drawing.Point(254, 125);
            this.cbxNefropatia.Name = "cbxNefropatia";
            this.cbxNefropatia.Size = new System.Drawing.Size(77, 17);
            this.cbxNefropatia.TabIndex = 29;
            this.cbxNefropatia.Text = "Nefropatía";
            this.cbxNefropatia.UseVisualStyleBackColor = true;
            this.cbxNefropatia.CheckedChanged += new System.EventHandler(this.cbxNefropatia_CheckedChanged);
            // 
            // cbxEndocrinopatia
            // 
            this.cbxEndocrinopatia.AutoSize = true;
            this.cbxEndocrinopatia.Location = new System.Drawing.Point(254, 99);
            this.cbxEndocrinopatia.Name = "cbxEndocrinopatia";
            this.cbxEndocrinopatia.Size = new System.Drawing.Size(99, 17);
            this.cbxEndocrinopatia.TabIndex = 27;
            this.cbxEndocrinopatia.Text = "Endocrinopatía";
            this.cbxEndocrinopatia.UseVisualStyleBackColor = true;
            this.cbxEndocrinopatia.CheckedChanged += new System.EventHandler(this.cbxEndocrinopatia_CheckedChanged);
            // 
            // cbxGota
            // 
            this.cbxGota.AutoSize = true;
            this.cbxGota.Location = new System.Drawing.Point(254, 73);
            this.cbxGota.Name = "cbxGota";
            this.cbxGota.Size = new System.Drawing.Size(49, 17);
            this.cbxGota.TabIndex = 25;
            this.cbxGota.Text = "Gota";
            this.cbxGota.UseVisualStyleBackColor = true;
            this.cbxGota.CheckedChanged += new System.EventHandler(this.cbxGota_CheckedChanged);
            // 
            // cbxAtipia
            // 
            this.cbxAtipia.AutoSize = true;
            this.cbxAtipia.Location = new System.Drawing.Point(254, 47);
            this.cbxAtipia.Name = "cbxAtipia";
            this.cbxAtipia.Size = new System.Drawing.Size(52, 17);
            this.cbxAtipia.TabIndex = 23;
            this.cbxAtipia.Text = "Atipia";
            this.cbxAtipia.UseVisualStyleBackColor = true;
            this.cbxAtipia.CheckedChanged += new System.EventHandler(this.cbxAtipia_TextChanged);
            // 
            // cbxTuberculosis
            // 
            this.cbxTuberculosis.AutoSize = true;
            this.cbxTuberculosis.Location = new System.Drawing.Point(254, 21);
            this.cbxTuberculosis.Name = "cbxTuberculosis";
            this.cbxTuberculosis.Size = new System.Drawing.Size(86, 17);
            this.cbxTuberculosis.TabIndex = 21;
            this.cbxTuberculosis.Text = "Tuberculosis";
            this.cbxTuberculosis.UseVisualStyleBackColor = true;
            this.cbxTuberculosis.CheckedChanged += new System.EventHandler(this.cbxTuberculosis_TextChanged);
            // 
            // cbxAlergias
            // 
            this.cbxAlergias.AutoSize = true;
            this.cbxAlergias.Location = new System.Drawing.Point(6, 177);
            this.cbxAlergias.Name = "cbxAlergias";
            this.cbxAlergias.Size = new System.Drawing.Size(63, 17);
            this.cbxAlergias.TabIndex = 19;
            this.cbxAlergias.Text = "Alergias";
            this.cbxAlergias.UseVisualStyleBackColor = true;
            this.cbxAlergias.CheckedChanged += new System.EventHandler(this.cbxAlergias_TextChanged);
            // 
            // cbxPsicopatia
            // 
            this.cbxPsicopatia.AutoSize = true;
            this.cbxPsicopatia.Location = new System.Drawing.Point(6, 151);
            this.cbxPsicopatia.Name = "cbxPsicopatia";
            this.cbxPsicopatia.Size = new System.Drawing.Size(77, 17);
            this.cbxPsicopatia.TabIndex = 17;
            this.cbxPsicopatia.Text = "Psicopatía";
            this.cbxPsicopatia.UseVisualStyleBackColor = true;
            this.cbxPsicopatia.CheckedChanged += new System.EventHandler(this.cbxPsicopatia_TextChanged);
            // 
            // cbxAsma
            // 
            this.cbxAsma.AutoSize = true;
            this.cbxAsma.Location = new System.Drawing.Point(6, 125);
            this.cbxAsma.Name = "cbxAsma";
            this.cbxAsma.Size = new System.Drawing.Size(99, 17);
            this.cbxAsma.TabIndex = 15;
            this.cbxAsma.Text = "Asma Bronquial";
            this.cbxAsma.UseVisualStyleBackColor = true;
            this.cbxAsma.CheckedChanged += new System.EventHandler(this.cbxAsma_TextChanged);
            // 
            // cbxDislipidemia
            // 
            this.cbxDislipidemia.AutoSize = true;
            this.cbxDislipidemia.Location = new System.Drawing.Point(6, 99);
            this.cbxDislipidemia.Name = "cbxDislipidemia";
            this.cbxDislipidemia.Size = new System.Drawing.Size(81, 17);
            this.cbxDislipidemia.TabIndex = 13;
            this.cbxDislipidemia.Text = "Dislipidemia";
            this.cbxDislipidemia.UseVisualStyleBackColor = true;
            this.cbxDislipidemia.CheckedChanged += new System.EventHandler(this.cbxDislipidemia_TextChanged);
            // 
            // cbxCoronariopatia
            // 
            this.cbxCoronariopatia.AutoSize = true;
            this.cbxCoronariopatia.Location = new System.Drawing.Point(6, 73);
            this.cbxCoronariopatia.Name = "cbxCoronariopatia";
            this.cbxCoronariopatia.Size = new System.Drawing.Size(96, 17);
            this.cbxCoronariopatia.TabIndex = 11;
            this.cbxCoronariopatia.Text = "Coronariopatía";
            this.cbxCoronariopatia.UseVisualStyleBackColor = true;
            this.cbxCoronariopatia.CheckedChanged += new System.EventHandler(this.cbxCoronariopatia_TextChanged);
            // 
            // cbxHipertensionArterial
            // 
            this.cbxHipertensionArterial.AutoSize = true;
            this.cbxHipertensionArterial.Location = new System.Drawing.Point(6, 47);
            this.cbxHipertensionArterial.Name = "cbxHipertensionArterial";
            this.cbxHipertensionArterial.Size = new System.Drawing.Size(92, 17);
            this.cbxHipertensionArterial.TabIndex = 9;
            this.cbxHipertensionArterial.Text = "Hipert. Arterial";
            this.cbxHipertensionArterial.UseVisualStyleBackColor = true;
            this.cbxHipertensionArterial.CheckedChanged += new System.EventHandler(this.cbxHipertensionArterial_CheckedChanged);
            // 
            // cbxDiabetes
            // 
            this.cbxDiabetes.AutoSize = true;
            this.cbxDiabetes.Location = new System.Drawing.Point(6, 21);
            this.cbxDiabetes.Name = "cbxDiabetes";
            this.cbxDiabetes.Size = new System.Drawing.Size(68, 17);
            this.cbxDiabetes.TabIndex = 7;
            this.cbxDiabetes.Text = "Diabetes";
            this.cbxDiabetes.UseVisualStyleBackColor = true;
            this.cbxDiabetes.CheckedChanged += new System.EventHandler(this.cbxDiabetes_CheckedChanged);
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
            this.cbxDrogas.TabIndex = 5;
            this.cbxDrogas.Text = "Drogas";
            this.cbxDrogas.UseVisualStyleBackColor = true;
            // 
            // cbxTe
            // 
            this.cbxTe.AutoSize = true;
            this.cbxTe.Location = new System.Drawing.Point(306, 19);
            this.cbxTe.Name = "cbxTe";
            this.cbxTe.Size = new System.Drawing.Size(39, 17);
            this.cbxTe.TabIndex = 4;
            this.cbxTe.Text = "Té";
            this.cbxTe.UseVisualStyleBackColor = true;
            // 
            // cbxCafe
            // 
            this.cbxCafe.AutoSize = true;
            this.cbxCafe.Location = new System.Drawing.Point(206, 19);
            this.cbxCafe.Name = "cbxCafe";
            this.cbxCafe.Size = new System.Drawing.Size(48, 17);
            this.cbxCafe.TabIndex = 3;
            this.cbxCafe.Text = "Café";
            this.cbxCafe.UseVisualStyleBackColor = true;
            // 
            // cbxAlcohol
            // 
            this.cbxAlcohol.AutoSize = true;
            this.cbxAlcohol.Location = new System.Drawing.Point(106, 19);
            this.cbxAlcohol.Name = "cbxAlcohol";
            this.cbxAlcohol.Size = new System.Drawing.Size(61, 17);
            this.cbxAlcohol.TabIndex = 2;
            this.cbxAlcohol.Text = "Alcohol";
            this.cbxAlcohol.UseVisualStyleBackColor = true;
            // 
            // cbxTabaco
            // 
            this.cbxTabaco.AutoSize = true;
            this.cbxTabaco.Location = new System.Drawing.Point(6, 19);
            this.cbxTabaco.Name = "cbxTabaco";
            this.cbxTabaco.Size = new System.Drawing.Size(63, 17);
            this.cbxTabaco.TabIndex = 1;
            this.cbxTabaco.Text = "Tabaco";
            this.cbxTabaco.UseVisualStyleBackColor = true;
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
            this.tbpEnfermedadActual.Size = new System.Drawing.Size(760, 437);
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
            // tbpEctoscopia
            // 
            this.tbpEctoscopia.Controls.Add(this.rtxtEctoscopiaActual);
            this.tbpEctoscopia.Controls.Add(this.lblEctoscopiaActual);
            this.tbpEctoscopia.Controls.Add(this.lblEctoscopiaAnterior);
            this.tbpEctoscopia.Controls.Add(this.rtxtEctoscopiaAnterior);
            this.tbpEctoscopia.Location = new System.Drawing.Point(4, 4);
            this.tbpEctoscopia.Name = "tbpEctoscopia";
            this.tbpEctoscopia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEctoscopia.Size = new System.Drawing.Size(774, 469);
            this.tbpEctoscopia.TabIndex = 0;
            this.tbpEctoscopia.Text = "Ectoscopia";
            this.tbpEctoscopia.UseVisualStyleBackColor = true;
            // 
            // lblEctoscopiaActual
            // 
            this.lblEctoscopiaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEctoscopiaActual.AutoSize = true;
            this.lblEctoscopiaActual.Location = new System.Drawing.Point(6, 274);
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
            // tbpExamenFisico
            // 
            this.tbpExamenFisico.Controls.Add(this.gbxFuncionesBiologicas);
            this.tbpExamenFisico.Controls.Add(this.lblOtrosExamenes);
            this.tbpExamenFisico.Controls.Add(this.gbxOtrosDatos);
            this.tbpExamenFisico.Controls.Add(this.gbxSignosVitales);
            this.tbpExamenFisico.Controls.Add(this.rtxtOtrosExamenes);
            this.tbpExamenFisico.Location = new System.Drawing.Point(4, 4);
            this.tbpExamenFisico.Name = "tbpExamenFisico";
            this.tbpExamenFisico.Size = new System.Drawing.Size(774, 469);
            this.tbpExamenFisico.TabIndex = 2;
            this.tbpExamenFisico.Text = "Examen Físico";
            this.tbpExamenFisico.UseVisualStyleBackColor = true;
            // 
            // gbxFuncionesBiologicas
            // 
            this.gbxFuncionesBiologicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFuncionesBiologicas.Controls.Add(this.rtxtApetito);
            this.gbxFuncionesBiologicas.Controls.Add(this.rtxtSed);
            this.gbxFuncionesBiologicas.Controls.Add(this.rtxtOrina);
            this.gbxFuncionesBiologicas.Controls.Add(this.rtxtDeposiciones);
            this.gbxFuncionesBiologicas.Controls.Add(this.lblDeposiciones);
            this.gbxFuncionesBiologicas.Controls.Add(this.lblOrina);
            this.gbxFuncionesBiologicas.Controls.Add(this.lblSed);
            this.gbxFuncionesBiologicas.Controls.Add(this.lblApetito);
            this.gbxFuncionesBiologicas.Location = new System.Drawing.Point(411, 7);
            this.gbxFuncionesBiologicas.Name = "gbxFuncionesBiologicas";
            this.gbxFuncionesBiologicas.Size = new System.Drawing.Size(360, 206);
            this.gbxFuncionesBiologicas.TabIndex = 8;
            this.gbxFuncionesBiologicas.TabStop = false;
            this.gbxFuncionesBiologicas.Text = "Funciones Biológicas";
            // 
            // lblDeposiciones
            // 
            this.lblDeposiciones.AutoSize = true;
            this.lblDeposiciones.Location = new System.Drawing.Point(6, 159);
            this.lblDeposiciones.Name = "lblDeposiciones";
            this.lblDeposiciones.Size = new System.Drawing.Size(74, 13);
            this.lblDeposiciones.TabIndex = 3;
            this.lblDeposiciones.Text = "Deposiciones:";
            // 
            // lblOrina
            // 
            this.lblOrina.AutoSize = true;
            this.lblOrina.Location = new System.Drawing.Point(6, 115);
            this.lblOrina.Name = "lblOrina";
            this.lblOrina.Size = new System.Drawing.Size(35, 13);
            this.lblOrina.TabIndex = 2;
            this.lblOrina.Text = "Orina:";
            // 
            // lblSed
            // 
            this.lblSed.AutoSize = true;
            this.lblSed.Location = new System.Drawing.Point(6, 71);
            this.lblSed.Name = "lblSed";
            this.lblSed.Size = new System.Drawing.Size(29, 13);
            this.lblSed.TabIndex = 1;
            this.lblSed.Text = "Sed:";
            // 
            // lblApetito
            // 
            this.lblApetito.AutoSize = true;
            this.lblApetito.Location = new System.Drawing.Point(6, 27);
            this.lblApetito.Name = "lblApetito";
            this.lblApetito.Size = new System.Drawing.Size(43, 13);
            this.lblApetito.TabIndex = 0;
            this.lblApetito.Text = "Apetito:";
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
            this.gbxOtrosDatos.Controls.Add(this.txtTalla);
            this.gbxOtrosDatos.Controls.Add(this.txtPeso);
            this.gbxOtrosDatos.Controls.Add(this.lblTalla);
            this.gbxOtrosDatos.Controls.Add(this.lblPeso);
            this.gbxOtrosDatos.Location = new System.Drawing.Point(6, 113);
            this.gbxOtrosDatos.Name = "gbxOtrosDatos";
            this.gbxOtrosDatos.Size = new System.Drawing.Size(399, 100);
            this.gbxOtrosDatos.TabIndex = 5;
            this.gbxOtrosDatos.TabStop = false;
            this.gbxOtrosDatos.Text = "Otros Datos";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(6, 53);
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
            this.gbxSignosVitales.Controls.Add(this.txtPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.lblPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.lblFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaCardiaca);
            this.gbxSignosVitales.Controls.Add(this.lblFrecuenciaCardiaca);
            this.gbxSignosVitales.Controls.Add(this.txtTemperatura);
            this.gbxSignosVitales.Controls.Add(this.lblTemperatura);
            this.gbxSignosVitales.Location = new System.Drawing.Point(6, 6);
            this.gbxSignosVitales.Name = "gbxSignosVitales";
            this.gbxSignosVitales.Size = new System.Drawing.Size(399, 101);
            this.gbxSignosVitales.TabIndex = 0;
            this.gbxSignosVitales.TabStop = false;
            this.gbxSignosVitales.Text = "Signos Vitales";
            // 
            // lblPresionArterial
            // 
            this.lblPresionArterial.AutoSize = true;
            this.lblPresionArterial.Location = new System.Drawing.Point(200, 56);
            this.lblPresionArterial.Name = "lblPresionArterial";
            this.lblPresionArterial.Size = new System.Drawing.Size(80, 13);
            this.lblPresionArterial.TabIndex = 7;
            this.lblPresionArterial.Text = "Presión Arterial:";
            // 
            // lblFrecuenciaRespiratoria
            // 
            this.lblFrecuenciaRespiratoria.AutoSize = true;
            this.lblFrecuenciaRespiratoria.Location = new System.Drawing.Point(200, 27);
            this.lblFrecuenciaRespiratoria.Name = "lblFrecuenciaRespiratoria";
            this.lblFrecuenciaRespiratoria.Size = new System.Drawing.Size(122, 13);
            this.lblFrecuenciaRespiratoria.TabIndex = 6;
            this.lblFrecuenciaRespiratoria.Text = "Frecuencia Respiratoria:";
            // 
            // lblFrecuenciaCardiaca
            // 
            this.lblFrecuenciaCardiaca.AutoSize = true;
            this.lblFrecuenciaCardiaca.Location = new System.Drawing.Point(6, 55);
            this.lblFrecuenciaCardiaca.Name = "lblFrecuenciaCardiaca";
            this.lblFrecuenciaCardiaca.Size = new System.Drawing.Size(108, 13);
            this.lblFrecuenciaCardiaca.TabIndex = 2;
            this.lblFrecuenciaCardiaca.Text = "Frecuencia Cardiaca:";
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
            this.tbpDiagnostico.Controls.Add(this.cboDiagnostico);
            this.tbpDiagnostico.Controls.Add(this.btnQuitar);
            this.tbpDiagnostico.Controls.Add(this.btnAgregar);
            this.tbpDiagnostico.Controls.Add(this.dgvDiagnosticos);
            this.tbpDiagnostico.Controls.Add(this.btnBuscar);
            this.tbpDiagnostico.Controls.Add(this.btnGuardar);
            this.tbpDiagnostico.Controls.Add(this.btnCancelar);
            this.tbpDiagnostico.Controls.Add(this.lblDescripcionActual);
            this.tbpDiagnostico.Controls.Add(this.lblDiagnostico);
            this.tbpDiagnostico.Controls.Add(this.rtxtDiagnosticoActual);
            this.tbpDiagnostico.Location = new System.Drawing.Point(4, 4);
            this.tbpDiagnostico.Name = "tbpDiagnostico";
            this.tbpDiagnostico.Size = new System.Drawing.Size(774, 469);
            this.tbpDiagnostico.TabIndex = 3;
            this.tbpDiagnostico.Text = "Diagnóstico";
            this.tbpDiagnostico.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(671, 387);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(671, 231);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.dgvDiagnosticos.Location = new System.Drawing.Point(13, 260);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(693, 436);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(577, 436);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.txtNumeroHistoriaClinicaBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
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
            this.txtNumeroDocumentoBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
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
            this.txtMaternoBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
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
            this.txtNombresBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
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
            this.txtPaternoBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // txtNumeroHistoriaClinica
            // 
            this.txtNumeroHistoriaClinica.BackColor = System.Drawing.Color.LightYellow;
            this.txtNumeroHistoriaClinica.Location = new System.Drawing.Point(115, 3);
            this.txtNumeroHistoriaClinica.MaxLength = 10;
            this.txtNumeroHistoriaClinica.Name = "txtNumeroHistoriaClinica";
            this.txtNumeroHistoriaClinica.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroHistoriaClinica.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroHistoriaClinica.TabIndex = 0;
            this.txtNumeroHistoriaClinica.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(10, 83);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(737, 20);
            this.txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDireccion.TabIndex = 23;
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
            this.txtEdad.TabIndex = 12;
            this.txtEdad.Text = "0";
            this.txtEdad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaterno.Location = new System.Drawing.Point(10, 35);
            this.txtPaterno.MaxLength = 30;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(125, 20);
            this.txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaterno.TabIndex = 1;
            this.txtPaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // rtxtOtrosAntecedentes
            // 
            this.rtxtOtrosAntecedentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOtrosAntecedentes.Location = new System.Drawing.Point(6, 19);
            this.rtxtOtrosAntecedentes.MaxLength = 4000;
            this.rtxtOtrosAntecedentes.Name = "rtxtOtrosAntecedentes";
            this.rtxtOtrosAntecedentes.Size = new System.Drawing.Size(742, 109);
            this.rtxtOtrosAntecedentes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtOtrosAntecedentes.TabIndex = 50;
            this.rtxtOtrosAntecedentes.Text = "";
            // 
            // txtColagenopatia
            // 
            this.txtColagenopatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColagenopatia.Location = new System.Drawing.Point(605, 173);
            this.txtColagenopatia.MaxLength = 300;
            this.txtColagenopatia.Name = "txtColagenopatia";
            this.txtColagenopatia.ReadOnly = true;
            this.txtColagenopatia.Size = new System.Drawing.Size(141, 20);
            this.txtColagenopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtColagenopatia.TabIndex = 48;
            this.txtColagenopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtFiebresProlongadas
            // 
            this.txtFiebresProlongadas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiebresProlongadas.Location = new System.Drawing.Point(605, 147);
            this.txtFiebresProlongadas.MaxLength = 300;
            this.txtFiebresProlongadas.Name = "txtFiebresProlongadas";
            this.txtFiebresProlongadas.ReadOnly = true;
            this.txtFiebresProlongadas.Size = new System.Drawing.Size(141, 20);
            this.txtFiebresProlongadas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtFiebresProlongadas.TabIndex = 46;
            this.txtFiebresProlongadas.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtEnfermedadesNeurologicas
            // 
            this.txtEnfermedadesNeurologicas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnfermedadesNeurologicas.Location = new System.Drawing.Point(605, 121);
            this.txtEnfermedadesNeurologicas.MaxLength = 300;
            this.txtEnfermedadesNeurologicas.Name = "txtEnfermedadesNeurologicas";
            this.txtEnfermedadesNeurologicas.ReadOnly = true;
            this.txtEnfermedadesNeurologicas.Size = new System.Drawing.Size(141, 20);
            this.txtEnfermedadesNeurologicas.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtEnfermedadesNeurologicas.TabIndex = 44;
            this.txtEnfermedadesNeurologicas.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtHepatitis
            // 
            this.txtHepatitis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHepatitis.Location = new System.Drawing.Point(605, 96);
            this.txtHepatitis.MaxLength = 300;
            this.txtHepatitis.Name = "txtHepatitis";
            this.txtHepatitis.ReadOnly = true;
            this.txtHepatitis.Size = new System.Drawing.Size(141, 20);
            this.txtHepatitis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtHepatitis.TabIndex = 42;
            this.txtHepatitis.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtColecistopatia
            // 
            this.txtColecistopatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColecistopatia.Location = new System.Drawing.Point(605, 69);
            this.txtColecistopatia.MaxLength = 300;
            this.txtColecistopatia.Name = "txtColecistopatia";
            this.txtColecistopatia.ReadOnly = true;
            this.txtColecistopatia.Size = new System.Drawing.Size(141, 20);
            this.txtColecistopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtColecistopatia.TabIndex = 40;
            this.txtColecistopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtUlcera
            // 
            this.txtUlcera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUlcera.Location = new System.Drawing.Point(605, 44);
            this.txtUlcera.MaxLength = 300;
            this.txtUlcera.Name = "txtUlcera";
            this.txtUlcera.ReadOnly = true;
            this.txtUlcera.Size = new System.Drawing.Size(141, 20);
            this.txtUlcera.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtUlcera.TabIndex = 38;
            this.txtUlcera.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtETS
            // 
            this.txtETS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtETS.Location = new System.Drawing.Point(605, 17);
            this.txtETS.MaxLength = 300;
            this.txtETS.Name = "txtETS";
            this.txtETS.ReadOnly = true;
            this.txtETS.Size = new System.Drawing.Size(141, 20);
            this.txtETS.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtETS.TabIndex = 36;
            this.txtETS.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtHemopatia
            // 
            this.txtHemopatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHemopatia.Location = new System.Drawing.Point(348, 174);
            this.txtHemopatia.MaxLength = 300;
            this.txtHemopatia.Name = "txtHemopatia";
            this.txtHemopatia.ReadOnly = true;
            this.txtHemopatia.Size = new System.Drawing.Size(141, 20);
            this.txtHemopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtHemopatia.TabIndex = 34;
            this.txtHemopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtUropatia
            // 
            this.txtUropatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUropatia.Location = new System.Drawing.Point(348, 148);
            this.txtUropatia.MaxLength = 300;
            this.txtUropatia.Name = "txtUropatia";
            this.txtUropatia.ReadOnly = true;
            this.txtUropatia.Size = new System.Drawing.Size(141, 20);
            this.txtUropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtUropatia.TabIndex = 32;
            this.txtUropatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtNefropatia
            // 
            this.txtNefropatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNefropatia.Location = new System.Drawing.Point(348, 122);
            this.txtNefropatia.MaxLength = 300;
            this.txtNefropatia.Name = "txtNefropatia";
            this.txtNefropatia.ReadOnly = true;
            this.txtNefropatia.Size = new System.Drawing.Size(141, 20);
            this.txtNefropatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtNefropatia.TabIndex = 30;
            this.txtNefropatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtEndocrinopatia
            // 
            this.txtEndocrinopatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndocrinopatia.Location = new System.Drawing.Point(348, 97);
            this.txtEndocrinopatia.MaxLength = 300;
            this.txtEndocrinopatia.Name = "txtEndocrinopatia";
            this.txtEndocrinopatia.ReadOnly = true;
            this.txtEndocrinopatia.Size = new System.Drawing.Size(141, 20);
            this.txtEndocrinopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtEndocrinopatia.TabIndex = 28;
            this.txtEndocrinopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtGota
            // 
            this.txtGota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGota.Location = new System.Drawing.Point(348, 71);
            this.txtGota.MaxLength = 300;
            this.txtGota.Name = "txtGota";
            this.txtGota.ReadOnly = true;
            this.txtGota.Size = new System.Drawing.Size(141, 20);
            this.txtGota.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtGota.TabIndex = 26;
            this.txtGota.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtAtipia
            // 
            this.txtAtipia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAtipia.Location = new System.Drawing.Point(348, 44);
            this.txtAtipia.MaxLength = 300;
            this.txtAtipia.Name = "txtAtipia";
            this.txtAtipia.ReadOnly = true;
            this.txtAtipia.Size = new System.Drawing.Size(141, 20);
            this.txtAtipia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtAtipia.TabIndex = 24;
            this.txtAtipia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtTuberculosis
            // 
            this.txtTuberculosis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTuberculosis.Location = new System.Drawing.Point(348, 18);
            this.txtTuberculosis.MaxLength = 300;
            this.txtTuberculosis.Name = "txtTuberculosis";
            this.txtTuberculosis.ReadOnly = true;
            this.txtTuberculosis.Size = new System.Drawing.Size(141, 20);
            this.txtTuberculosis.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtTuberculosis.TabIndex = 22;
            this.txtTuberculosis.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtAlergias
            // 
            this.txtAlergias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlergias.Location = new System.Drawing.Point(100, 176);
            this.txtAlergias.MaxLength = 300;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.ReadOnly = true;
            this.txtAlergias.Size = new System.Drawing.Size(141, 20);
            this.txtAlergias.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtAlergias.TabIndex = 20;
            this.txtAlergias.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtPsicopatia
            // 
            this.txtPsicopatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPsicopatia.Location = new System.Drawing.Point(100, 150);
            this.txtPsicopatia.MaxLength = 300;
            this.txtPsicopatia.Name = "txtPsicopatia";
            this.txtPsicopatia.ReadOnly = true;
            this.txtPsicopatia.Size = new System.Drawing.Size(141, 20);
            this.txtPsicopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtPsicopatia.TabIndex = 18;
            this.txtPsicopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtAsma
            // 
            this.txtAsma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsma.Location = new System.Drawing.Point(100, 123);
            this.txtAsma.MaxLength = 300;
            this.txtAsma.Name = "txtAsma";
            this.txtAsma.ReadOnly = true;
            this.txtAsma.Size = new System.Drawing.Size(141, 20);
            this.txtAsma.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtAsma.TabIndex = 16;
            this.txtAsma.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtDislipidemia
            // 
            this.txtDislipidemia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDislipidemia.Location = new System.Drawing.Point(100, 98);
            this.txtDislipidemia.MaxLength = 300;
            this.txtDislipidemia.Name = "txtDislipidemia";
            this.txtDislipidemia.ReadOnly = true;
            this.txtDislipidemia.Size = new System.Drawing.Size(141, 20);
            this.txtDislipidemia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtDislipidemia.TabIndex = 14;
            this.txtDislipidemia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtCoronariopatia
            // 
            this.txtCoronariopatia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCoronariopatia.Location = new System.Drawing.Point(100, 71);
            this.txtCoronariopatia.MaxLength = 300;
            this.txtCoronariopatia.Name = "txtCoronariopatia";
            this.txtCoronariopatia.ReadOnly = true;
            this.txtCoronariopatia.Size = new System.Drawing.Size(141, 20);
            this.txtCoronariopatia.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtCoronariopatia.TabIndex = 12;
            this.txtCoronariopatia.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtHipertensionArterial
            // 
            this.txtHipertensionArterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHipertensionArterial.Location = new System.Drawing.Point(100, 45);
            this.txtHipertensionArterial.MaxLength = 300;
            this.txtHipertensionArterial.Name = "txtHipertensionArterial";
            this.txtHipertensionArterial.ReadOnly = true;
            this.txtHipertensionArterial.Size = new System.Drawing.Size(141, 20);
            this.txtHipertensionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtHipertensionArterial.TabIndex = 10;
            this.txtHipertensionArterial.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtDiabetes
            // 
            this.txtDiabetes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDiabetes.Location = new System.Drawing.Point(100, 19);
            this.txtDiabetes.MaxLength = 300;
            this.txtDiabetes.Name = "txtDiabetes";
            this.txtDiabetes.ReadOnly = true;
            this.txtDiabetes.Size = new System.Drawing.Size(141, 20);
            this.txtDiabetes.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtDiabetes.TabIndex = 8;
            this.txtDiabetes.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // rtxtRelatoCronologico
            // 
            this.rtxtRelatoCronologico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtRelatoCronologico.Location = new System.Drawing.Point(201, 244);
            this.rtxtRelatoCronologico.MaxLength = 4000;
            this.rtxtRelatoCronologico.Name = "rtxtRelatoCronologico";
            this.rtxtRelatoCronologico.Size = new System.Drawing.Size(553, 187);
            this.rtxtRelatoCronologico.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtRelatoCronologico.TabIndex = 4;
            this.rtxtRelatoCronologico.Text = "";
            // 
            // rtxtSintomasEnfermedad
            // 
            this.rtxtSintomasEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtSintomasEnfermedad.Location = new System.Drawing.Point(201, 107);
            this.rtxtSintomasEnfermedad.MaxLength = 4000;
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
            this.txtCursoEnfermedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.txtInicioEnfermedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            // rtxtEctoscopiaActual
            // 
            this.rtxtEctoscopiaActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEctoscopiaActual.Location = new System.Drawing.Point(9, 290);
            this.rtxtEctoscopiaActual.MaxLength = 4000;
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
            this.rtxtEctoscopiaAnterior.Size = new System.Drawing.Size(759, 252);
            this.rtxtEctoscopiaAnterior.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
            this.rtxtEctoscopiaAnterior.TabIndex = 1;
            this.rtxtEctoscopiaAnterior.Text = "";
            // 
            // rtxtApetito
            // 
            this.rtxtApetito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtApetito.Location = new System.Drawing.Point(86, 27);
            this.rtxtApetito.MaxLength = 300;
            this.rtxtApetito.Name = "rtxtApetito";
            this.rtxtApetito.Size = new System.Drawing.Size(266, 38);
            this.rtxtApetito.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtApetito.TabIndex = 9;
            this.rtxtApetito.Text = "";
            // 
            // rtxtSed
            // 
            this.rtxtSed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtSed.Location = new System.Drawing.Point(86, 71);
            this.rtxtSed.MaxLength = 300;
            this.rtxtSed.Name = "rtxtSed";
            this.rtxtSed.Size = new System.Drawing.Size(266, 38);
            this.rtxtSed.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtSed.TabIndex = 10;
            this.rtxtSed.Text = "";
            // 
            // rtxtOrina
            // 
            this.rtxtOrina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOrina.Location = new System.Drawing.Point(86, 115);
            this.rtxtOrina.MaxLength = 300;
            this.rtxtOrina.Name = "rtxtOrina";
            this.rtxtOrina.Size = new System.Drawing.Size(266, 38);
            this.rtxtOrina.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtOrina.TabIndex = 11;
            this.rtxtOrina.Text = "";
            // 
            // rtxtDeposiciones
            // 
            this.rtxtDeposiciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDeposiciones.Location = new System.Drawing.Point(86, 159);
            this.rtxtDeposiciones.MaxLength = 300;
            this.rtxtDeposiciones.Name = "rtxtDeposiciones";
            this.rtxtDeposiciones.Size = new System.Drawing.Size(266, 38);
            this.rtxtDeposiciones.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtDeposiciones.TabIndex = 12;
            this.rtxtDeposiciones.Text = "";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(120, 50);
            this.txtTalla.MaxLength = 5;
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(64, 20);
            this.txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTalla.TabIndex = 7;
            this.txtTalla.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(120, 22);
            this.txtPeso.MaxLength = 6;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(64, 20);
            this.txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPeso.TabIndex = 6;
            this.txtPeso.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtPresionArterial
            // 
            this.txtPresionArterial.Location = new System.Drawing.Point(328, 52);
            this.txtPresionArterial.MaxLength = 10;
            this.txtPresionArterial.Name = "txtPresionArterial";
            this.txtPresionArterial.Size = new System.Drawing.Size(64, 20);
            this.txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPresionArterial.TabIndex = 4;
            this.txtPresionArterial.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtFrecuenciaRespiratoria
            // 
            this.txtFrecuenciaRespiratoria.Location = new System.Drawing.Point(328, 24);
            this.txtFrecuenciaRespiratoria.MaxLength = 10;
            this.txtFrecuenciaRespiratoria.Name = "txtFrecuenciaRespiratoria";
            this.txtFrecuenciaRespiratoria.Size = new System.Drawing.Size(64, 20);
            this.txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFrecuenciaRespiratoria.TabIndex = 2;
            this.txtFrecuenciaRespiratoria.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtFrecuenciaCardiaca
            // 
            this.txtFrecuenciaCardiaca.Location = new System.Drawing.Point(120, 52);
            this.txtFrecuenciaCardiaca.MaxLength = 10;
            this.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca";
            this.txtFrecuenciaCardiaca.Size = new System.Drawing.Size(64, 20);
            this.txtFrecuenciaCardiaca.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFrecuenciaCardiaca.TabIndex = 3;
            this.txtFrecuenciaCardiaca.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(120, 24);
            this.txtTemperatura.MaxLength = 4;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(64, 20);
            this.txtTemperatura.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTemperatura.TabIndex = 1;
            this.txtTemperatura.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // rtxtOtrosExamenes
            // 
            this.rtxtOtrosExamenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOtrosExamenes.BackColor = System.Drawing.Color.White;
            this.rtxtOtrosExamenes.Location = new System.Drawing.Point(6, 232);
            this.rtxtOtrosExamenes.MaxLength = 4000;
            this.rtxtOtrosExamenes.Name = "rtxtOtrosExamenes";
            this.rtxtOtrosExamenes.Size = new System.Drawing.Size(765, 234);
            this.rtxtOtrosExamenes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtOtrosExamenes.TabIndex = 13;
            this.rtxtOtrosExamenes.Text = "";
            // 
            // cboDiagnostico
            // 
            this.cboDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboDiagnostico.BackColor = System.Drawing.Color.LightYellow;
            this.cboDiagnostico.FormattingEnabled = true;
            this.cboDiagnostico.Location = new System.Drawing.Point(82, 12);
            this.cboDiagnostico.Name = "cboDiagnostico";
            this.cboDiagnostico.Size = new System.Drawing.Size(583, 21);
            this.cboDiagnostico.Solo_Lectura = SistemaCentroSalud.Controles.cuComboBox.SoloLectura.falso;
            this.cboDiagnostico.TabIndex = 1;
            this.cboDiagnostico.TipoCajaTexto = SistemaCentroSalud.Controles.cuComboBox.TipoTextBox.Mixto;
            this.ttpTips.SetToolTip(this.cboDiagnostico, "Para una mejor búsqueda pruebe tildar correctamente las palabras");
            // 
            // rtxtDiagnosticoActual
            // 
            this.rtxtDiagnosticoActual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDiagnosticoActual.BackColor = System.Drawing.Color.White;
            this.rtxtDiagnosticoActual.Location = new System.Drawing.Point(13, 56);
            this.rtxtDiagnosticoActual.MaxLength = 4000;
            this.rtxtDiagnosticoActual.Name = "rtxtDiagnosticoActual";
            this.rtxtDiagnosticoActual.Size = new System.Drawing.Size(652, 198);
            this.rtxtDiagnosticoActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtDiagnosticoActual.TabIndex = 3;
            this.rtxtDiagnosticoActual.Text = "";
            // 
            // frmHistorialClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 509);
            this.Controls.Add(this.tbcHistoriaClinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clínica";
            this.Load += new System.EventHandler(this.frmHistorialClinica_Load);
            this.tbcHistoriaClinica.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodios)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.tbcHistoriaClinicaPartes.ResumeLayout(false);
            this.tbpAnamnesis.ResumeLayout(false);
            this.tbcAnamnesisPartes.ResumeLayout(false);
            this.tbpFiliacion.ResumeLayout(false);
            this.tbpFiliacion.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxLugarNacimiento.ResumeLayout(false);
            this.gbxLugarNacimiento.PerformLayout();
            this.gbxPersonal.ResumeLayout(false);
            this.gbxPersonal.PerformLayout();
            this.tbpAntecedentes.ResumeLayout(false);
            this.gbxOtros.ResumeLayout(false);
            this.gbxPersonales.ResumeLayout(false);
            this.gbxPersonales.PerformLayout();
            this.gbxHabitosNocivos.ResumeLayout(false);
            this.gbxHabitosNocivos.PerformLayout();
            this.tbpEnfermedadActual.ResumeLayout(false);
            this.tbpEnfermedadActual.PerformLayout();
            this.tbpEctoscopia.ResumeLayout(false);
            this.tbpEctoscopia.PerformLayout();
            this.tbpExamenFisico.ResumeLayout(false);
            this.tbpExamenFisico.PerformLayout();
            this.gbxFuncionesBiologicas.ResumeLayout(false);
            this.gbxFuncionesBiologicas.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboEtnia;
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
        private System.Windows.Forms.Label lblFrecuenciaCardiaca;
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
        private System.Windows.Forms.GroupBox gbxOtros;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtOtrosAntecedentes;
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
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private SistemaCentroSalud.Controles.cuTextBox txtColagenopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtFiebresProlongadas;
        private SistemaCentroSalud.Controles.cuTextBox txtEnfermedadesNeurologicas;
        private SistemaCentroSalud.Controles.cuTextBox txtHepatitis;
        private SistemaCentroSalud.Controles.cuTextBox txtColecistopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtUlcera;
        private SistemaCentroSalud.Controles.cuTextBox txtETS;
        private System.Windows.Forms.CheckBox cbxColagenopatia;
        private System.Windows.Forms.CheckBox cbxFiebresProlongadas;
        private System.Windows.Forms.CheckBox cbxEnfermedadesNeurologicas;
        private System.Windows.Forms.CheckBox cbxHepatitis;
        private System.Windows.Forms.CheckBox cbxColecistopatia;
        private System.Windows.Forms.CheckBox cbxUlcera;
        private System.Windows.Forms.CheckBox cbxETS;
        private SistemaCentroSalud.Controles.cuTextBox txtHemopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtUropatia;
        private SistemaCentroSalud.Controles.cuTextBox txtNefropatia;
        private SistemaCentroSalud.Controles.cuTextBox txtEndocrinopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtGota;
        private SistemaCentroSalud.Controles.cuTextBox txtAtipia;
        private SistemaCentroSalud.Controles.cuTextBox txtTuberculosis;
        private System.Windows.Forms.CheckBox cbxHemopatia;
        private System.Windows.Forms.CheckBox cbxUropatia;
        private System.Windows.Forms.CheckBox cbxNefropatia;
        private System.Windows.Forms.CheckBox cbxEndocrinopatia;
        private System.Windows.Forms.CheckBox cbxGota;
        private System.Windows.Forms.CheckBox cbxAtipia;
        private System.Windows.Forms.CheckBox cbxTuberculosis;
        private SistemaCentroSalud.Controles.cuTextBox txtAlergias;
        private SistemaCentroSalud.Controles.cuTextBox txtPsicopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtAsma;
        private SistemaCentroSalud.Controles.cuTextBox txtDislipidemia;
        private SistemaCentroSalud.Controles.cuTextBox txtCoronariopatia;
        private SistemaCentroSalud.Controles.cuTextBox txtHipertensionArterial;
        private SistemaCentroSalud.Controles.cuTextBox txtDiabetes;
        private System.Windows.Forms.CheckBox cbxAlergias;
        private System.Windows.Forms.CheckBox cbxPsicopatia;
        private System.Windows.Forms.CheckBox cbxAsma;
        private System.Windows.Forms.CheckBox cbxDislipidemia;
        private System.Windows.Forms.CheckBox cbxCoronariopatia;
        private System.Windows.Forms.CheckBox cbxHipertensionArterial;
        private System.Windows.Forms.CheckBox cbxDiabetes;
        private System.Windows.Forms.ComboBox cboModoIngreso;
        private System.Windows.Forms.Label lblModoIngreso;
        private SistemaCentroSalud.Controles.cuComboBox cboDiagnostico;
        private System.Windows.Forms.ToolTip ttpTips;
        private System.Windows.Forms.GroupBox gbxFuncionesBiologicas;
        private System.Windows.Forms.Label lblDeposiciones;
        private System.Windows.Forms.Label lblOrina;
        private System.Windows.Forms.Label lblSed;
        private System.Windows.Forms.Label lblApetito;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtApetito;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtSed;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtOrina;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtDeposiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsable;
        private System.Windows.Forms.Button btnGuardarFiliacion;
        private System.Windows.Forms.Button btnGuardarAntecedentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroHistoriaClinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupoSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactorSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAntecedentes;
        private System.Windows.Forms.Label lblNumeroHistoriaClinica;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroHistoriaClinica;
        private System.Windows.Forms.Button btnCancelarFiliacion;
    }
}