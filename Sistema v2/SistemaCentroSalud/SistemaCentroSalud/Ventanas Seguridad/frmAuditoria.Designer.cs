namespace SistemaCentroSalud
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.tbcAuditoria = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.colIdTablaAuditada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndAuditoria = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInsertar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colActualizar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.cboAuditadaBuscar = new System.Windows.Forms.ComboBox();
            this.txtAuditadaBuscar = new System.Windows.Forms.Label();
            this.cboTipoBuscar = new System.Windows.Forms.ComboBox();
            this.lblTipoBuscar = new System.Windows.Forms.Label();
            this.lblTablaBuscar = new System.Windows.Forms.Label();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxInformacion = new System.Windows.Forms.GroupBox();
            this.dgvColumnas = new System.Windows.Forms.DataGridView();
            this.gbxCriteriosDetalle = new System.Windows.Forms.GroupBox();
            this.dtpFechaFinDetalle = new System.Windows.Forms.DateTimePicker();
            this.cbxFechaFinDetalle = new System.Windows.Forms.CheckBox();
            this.dtpFechaInicioDetalle = new System.Windows.Forms.DateTimePicker();
            this.cbxFechaInicioDetalle = new System.Windows.Forms.CheckBox();
            this.cboTipoDetalle = new System.Windows.Forms.ComboBox();
            this.lblTipoDetalle = new System.Windows.Forms.Label();
            this.lblUsuarioDetalle = new System.Windows.Forms.Label();
            this.txtTablaBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtUsuarioDetalle = new SistemaCentroSalud.Controles.cuTextBox();
            this.colIdAuditoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAntiguoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNuevoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcAuditoria.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.gbxInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnas)).BeginInit();
            this.gbxCriteriosDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAuditoria
            // 
            this.tbcAuditoria.Controls.Add(this.tbpBuscar);
            this.tbcAuditoria.Controls.Add(this.tbpDetalle);
            this.tbcAuditoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAuditoria.Location = new System.Drawing.Point(0, 0);
            this.tbcAuditoria.Name = "tbcAuditoria";
            this.tbcAuditoria.SelectedIndex = 0;
            this.tbcAuditoria.Size = new System.Drawing.Size(722, 452);
            this.tbcAuditoria.TabIndex = 1;
            this.tbcAuditoria.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcAuditoria_Selecting);
            this.tbcAuditoria.SelectedIndexChanged += new System.EventHandler(this.tbcAuditoria_SelectedIndexChanged);
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.dgvTablas);
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(714, 426);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvTablas
            // 
            this.dgvTablas.AllowUserToAddRows = false;
            this.dgvTablas.AllowUserToDeleteRows = false;
            this.dgvTablas.AllowUserToResizeColumns = false;
            this.dgvTablas.AllowUserToResizeRows = false;
            this.dgvTablas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTablaAuditada,
            this.colTabla,
            this.colIndAuditoria,
            this.colInsertar,
            this.colActualizar,
            this.colEliminar});
            this.dgvTablas.Location = new System.Drawing.Point(6, 128);
            this.dgvTablas.MultiSelect = false;
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.RowHeadersVisible = false;
            this.dgvTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablas.Size = new System.Drawing.Size(700, 261);
            this.dgvTablas.TabIndex = 7;
            this.dgvTablas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablas_CellValueChanged);
            this.dgvTablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablas_CellContentClick);
            // 
            // colIdTablaAuditada
            // 
            this.colIdTablaAuditada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIdTablaAuditada.HeaderText = "IdTablaAuditada";
            this.colIdTablaAuditada.Name = "colIdTablaAuditada";
            this.colIdTablaAuditada.ReadOnly = true;
            this.colIdTablaAuditada.Visible = false;
            // 
            // colTabla
            // 
            this.colTabla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTabla.FillWeight = 300F;
            this.colTabla.HeaderText = "Tabla";
            this.colTabla.Name = "colTabla";
            this.colTabla.ReadOnly = true;
            // 
            // colIndAuditoria
            // 
            this.colIndAuditoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIndAuditoria.FillWeight = 50F;
            this.colIndAuditoria.HeaderText = "Auditada";
            this.colIndAuditoria.Name = "colIndAuditoria";
            this.colIndAuditoria.ReadOnly = true;
            // 
            // colInsertar
            // 
            this.colInsertar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInsertar.FillWeight = 50F;
            this.colInsertar.HeaderText = "Insertar";
            this.colInsertar.Name = "colInsertar";
            // 
            // colActualizar
            // 
            this.colActualizar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActualizar.FillWeight = 50F;
            this.colActualizar.HeaderText = "Actualizar";
            this.colActualizar.Name = "colActualizar";
            // 
            // colEliminar
            // 
            this.colEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEliminar.FillWeight = 50F;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(627, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
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
            this.btnVer.Location = new System.Drawing.Point(10, 395);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 5;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCriterios.Controls.Add(this.cboAuditadaBuscar);
            this.gbxCriterios.Controls.Add(this.txtAuditadaBuscar);
            this.gbxCriterios.Controls.Add(this.cboTipoBuscar);
            this.gbxCriterios.Controls.Add(this.lblTipoBuscar);
            this.gbxCriterios.Controls.Add(this.txtTablaBuscar);
            this.gbxCriterios.Controls.Add(this.lblTablaBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(6, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(700, 116);
            this.gbxCriterios.TabIndex = 0;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // cboAuditadaBuscar
            // 
            this.cboAuditadaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuditadaBuscar.FormattingEnabled = true;
            this.cboAuditadaBuscar.Items.AddRange(new object[] {
            "TODOS",
            "SI",
            "NO"});
            this.cboAuditadaBuscar.Location = new System.Drawing.Point(104, 61);
            this.cboAuditadaBuscar.Name = "cboAuditadaBuscar";
            this.cboAuditadaBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboAuditadaBuscar.TabIndex = 2;
            this.cboAuditadaBuscar.SelectedIndexChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // txtAuditadaBuscar
            // 
            this.txtAuditadaBuscar.AutoSize = true;
            this.txtAuditadaBuscar.Location = new System.Drawing.Point(7, 65);
            this.txtAuditadaBuscar.Name = "txtAuditadaBuscar";
            this.txtAuditadaBuscar.Size = new System.Drawing.Size(52, 13);
            this.txtAuditadaBuscar.TabIndex = 6;
            this.txtAuditadaBuscar.Text = "Auditada:";
            // 
            // cboTipoBuscar
            // 
            this.cboTipoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBuscar.FormattingEnabled = true;
            this.cboTipoBuscar.Items.AddRange(new object[] {
            "TODAS",
            "INSERTAR",
            "ELIMINAR",
            "ACTUALIZAR"});
            this.cboTipoBuscar.Location = new System.Drawing.Point(418, 61);
            this.cboTipoBuscar.Name = "cboTipoBuscar";
            this.cboTipoBuscar.Size = new System.Drawing.Size(145, 21);
            this.cboTipoBuscar.TabIndex = 3;
            this.cboTipoBuscar.SelectedIndexChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblTipoBuscar
            // 
            this.lblTipoBuscar.AutoSize = true;
            this.lblTipoBuscar.Location = new System.Drawing.Point(320, 65);
            this.lblTipoBuscar.Name = "lblTipoBuscar";
            this.lblTipoBuscar.Size = new System.Drawing.Size(92, 13);
            this.lblTipoBuscar.TabIndex = 2;
            this.lblTipoBuscar.Text = "Tipo de Auditoría:";
            // 
            // lblTablaBuscar
            // 
            this.lblTablaBuscar.AutoSize = true;
            this.lblTablaBuscar.Location = new System.Drawing.Point(6, 25);
            this.lblTablaBuscar.Name = "lblTablaBuscar";
            this.lblTablaBuscar.Size = new System.Drawing.Size(37, 13);
            this.lblTablaBuscar.TabIndex = 0;
            this.lblTablaBuscar.Text = "Tabla:";
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.btnVolver);
            this.tbpDetalle.Controls.Add(this.gbxInformacion);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(714, 426);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(631, 395);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbxInformacion
            // 
            this.gbxInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInformacion.Controls.Add(this.dgvColumnas);
            this.gbxInformacion.Controls.Add(this.gbxCriteriosDetalle);
            this.gbxInformacion.Location = new System.Drawing.Point(8, 6);
            this.gbxInformacion.Name = "gbxInformacion";
            this.gbxInformacion.Size = new System.Drawing.Size(698, 383);
            this.gbxInformacion.TabIndex = 0;
            this.gbxInformacion.TabStop = false;
            this.gbxInformacion.Text = "Información";
            // 
            // dgvColumnas
            // 
            this.dgvColumnas.AllowUserToAddRows = false;
            this.dgvColumnas.AllowUserToDeleteRows = false;
            this.dgvColumnas.AllowUserToResizeColumns = false;
            this.dgvColumnas.AllowUserToResizeRows = false;
            this.dgvColumnas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumnas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAuditoria,
            this.colFecha,
            this.colHora,
            this.colUsuario,
            this.colTipo,
            this.colColumna,
            this.colAntiguoValor,
            this.colNuevoValor});
            this.dgvColumnas.Location = new System.Drawing.Point(6, 141);
            this.dgvColumnas.MultiSelect = false;
            this.dgvColumnas.Name = "dgvColumnas";
            this.dgvColumnas.RowHeadersVisible = false;
            this.dgvColumnas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColumnas.Size = new System.Drawing.Size(686, 236);
            this.dgvColumnas.TabIndex = 2;
            // 
            // gbxCriteriosDetalle
            // 
            this.gbxCriteriosDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCriteriosDetalle.Controls.Add(this.dtpFechaFinDetalle);
            this.gbxCriteriosDetalle.Controls.Add(this.cbxFechaFinDetalle);
            this.gbxCriteriosDetalle.Controls.Add(this.dtpFechaInicioDetalle);
            this.gbxCriteriosDetalle.Controls.Add(this.cbxFechaInicioDetalle);
            this.gbxCriteriosDetalle.Controls.Add(this.cboTipoDetalle);
            this.gbxCriteriosDetalle.Controls.Add(this.lblTipoDetalle);
            this.gbxCriteriosDetalle.Controls.Add(this.txtUsuarioDetalle);
            this.gbxCriteriosDetalle.Controls.Add(this.lblUsuarioDetalle);
            this.gbxCriteriosDetalle.Location = new System.Drawing.Point(6, 19);
            this.gbxCriteriosDetalle.Name = "gbxCriteriosDetalle";
            this.gbxCriteriosDetalle.Size = new System.Drawing.Size(686, 116);
            this.gbxCriteriosDetalle.TabIndex = 1;
            this.gbxCriteriosDetalle.TabStop = false;
            this.gbxCriteriosDetalle.Text = "Criterios de Selección";
            // 
            // dtpFechaFinDetalle
            // 
            this.dtpFechaFinDetalle.Enabled = false;
            this.dtpFechaFinDetalle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinDetalle.Location = new System.Drawing.Point(437, 65);
            this.dtpFechaFinDetalle.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFinDetalle.Name = "dtpFechaFinDetalle";
            this.dtpFechaFinDetalle.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaFinDetalle.TabIndex = 7;
            this.dtpFechaFinDetalle.ValueChanged += new System.EventHandler(this.seleccionarCriterios);
            // 
            // cbxFechaFinDetalle
            // 
            this.cbxFechaFinDetalle.AutoSize = true;
            this.cbxFechaFinDetalle.Location = new System.Drawing.Point(342, 66);
            this.cbxFechaFinDetalle.Name = "cbxFechaFinDetalle";
            this.cbxFechaFinDetalle.Size = new System.Drawing.Size(76, 17);
            this.cbxFechaFinDetalle.TabIndex = 6;
            this.cbxFechaFinDetalle.Text = "Fecha Fin:";
            this.cbxFechaFinDetalle.UseVisualStyleBackColor = true;
            this.cbxFechaFinDetalle.CheckedChanged += new System.EventHandler(this.cbxFechaFinDetalle_CheckedChanged);
            // 
            // dtpFechaInicioDetalle
            // 
            this.dtpFechaInicioDetalle.Enabled = false;
            this.dtpFechaInicioDetalle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioDetalle.Location = new System.Drawing.Point(104, 66);
            this.dtpFechaInicioDetalle.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicioDetalle.Name = "dtpFechaInicioDetalle";
            this.dtpFechaInicioDetalle.Size = new System.Drawing.Size(110, 20);
            this.dtpFechaInicioDetalle.TabIndex = 5;
            this.dtpFechaInicioDetalle.ValueChanged += new System.EventHandler(this.seleccionarCriterios);
            // 
            // cbxFechaInicioDetalle
            // 
            this.cbxFechaInicioDetalle.AutoSize = true;
            this.cbxFechaInicioDetalle.Location = new System.Drawing.Point(9, 67);
            this.cbxFechaInicioDetalle.Name = "cbxFechaInicioDetalle";
            this.cbxFechaInicioDetalle.Size = new System.Drawing.Size(87, 17);
            this.cbxFechaInicioDetalle.TabIndex = 4;
            this.cbxFechaInicioDetalle.Text = "Fecha Inicio:";
            this.cbxFechaInicioDetalle.UseVisualStyleBackColor = true;
            this.cbxFechaInicioDetalle.CheckedChanged += new System.EventHandler(this.cbxFechaInicioDetalle_CheckedChanged);
            // 
            // cboTipoDetalle
            // 
            this.cboTipoDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDetalle.FormattingEnabled = true;
            this.cboTipoDetalle.Items.AddRange(new object[] {
            "TODAS",
            "INSERTAR",
            "ACTUALIZAR",
            "ELIMINAR"});
            this.cboTipoDetalle.Location = new System.Drawing.Point(437, 22);
            this.cboTipoDetalle.Name = "cboTipoDetalle";
            this.cboTipoDetalle.Size = new System.Drawing.Size(133, 21);
            this.cboTipoDetalle.TabIndex = 3;
            this.cboTipoDetalle.SelectedIndexChanged += new System.EventHandler(this.seleccionarCriterios);
            // 
            // lblTipoDetalle
            // 
            this.lblTipoDetalle.AutoSize = true;
            this.lblTipoDetalle.Location = new System.Drawing.Point(339, 25);
            this.lblTipoDetalle.Name = "lblTipoDetalle";
            this.lblTipoDetalle.Size = new System.Drawing.Size(92, 13);
            this.lblTipoDetalle.TabIndex = 2;
            this.lblTipoDetalle.Text = "Tipo de Auditoría:";
            // 
            // lblUsuarioDetalle
            // 
            this.lblUsuarioDetalle.AutoSize = true;
            this.lblUsuarioDetalle.Location = new System.Drawing.Point(6, 25);
            this.lblUsuarioDetalle.Name = "lblUsuarioDetalle";
            this.lblUsuarioDetalle.Size = new System.Drawing.Size(46, 13);
            this.lblUsuarioDetalle.TabIndex = 0;
            this.lblUsuarioDetalle.Text = "Usuario:";
            // 
            // txtTablaBuscar
            // 
            this.txtTablaBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTablaBuscar.Location = new System.Drawing.Point(104, 22);
            this.txtTablaBuscar.MaxLength = 50;
            this.txtTablaBuscar.Name = "txtTablaBuscar";
            this.txtTablaBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtTablaBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTablaBuscar.TabIndex = 1;
            this.txtTablaBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            this.txtTablaBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // txtUsuarioDetalle
            // 
            this.txtUsuarioDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuarioDetalle.Location = new System.Drawing.Point(104, 22);
            this.txtUsuarioDetalle.MaxLength = 50;
            this.txtUsuarioDetalle.Name = "txtUsuarioDetalle";
            this.txtUsuarioDetalle.Size = new System.Drawing.Size(192, 20);
            this.txtUsuarioDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtUsuarioDetalle.TabIndex = 1;
            this.txtUsuarioDetalle.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            this.txtUsuarioDetalle.TextChanged += new System.EventHandler(this.seleccionarCriterios);
            // 
            // colIdAuditoria
            // 
            this.colIdAuditoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIdAuditoria.HeaderText = "IdAuditoria";
            this.colIdAuditoria.Name = "colIdAuditoria";
            this.colIdAuditoria.ReadOnly = true;
            this.colIdAuditoria.Visible = false;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colHora
            // 
            this.colHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHora.FillWeight = 70F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUsuario.FillWeight = 280F;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.FillWeight = 80F;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colColumna
            // 
            this.colColumna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColumna.FillWeight = 150F;
            this.colColumna.HeaderText = "Columna";
            this.colColumna.Name = "colColumna";
            this.colColumna.ReadOnly = true;
            // 
            // colAntiguoValor
            // 
            this.colAntiguoValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAntiguoValor.FillWeight = 150F;
            this.colAntiguoValor.HeaderText = "Antiguo Valor";
            this.colAntiguoValor.Name = "colAntiguoValor";
            this.colAntiguoValor.ReadOnly = true;
            // 
            // colNuevoValor
            // 
            this.colNuevoValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNuevoValor.FillWeight = 150F;
            this.colNuevoValor.HeaderText = "Nuevo Valor";
            this.colNuevoValor.Name = "colNuevoValor";
            this.colNuevoValor.ReadOnly = true;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 452);
            this.Controls.Add(this.tbcAuditoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoría de Tablas";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            this.tbcAuditoria.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.gbxInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnas)).EndInit();
            this.gbxCriteriosDetalle.ResumeLayout(false);
            this.gbxCriteriosDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAuditoria;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.ComboBox cboTipoBuscar;
        private System.Windows.Forms.Label lblTipoBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtTablaBuscar;
        private System.Windows.Forms.Label lblTablaBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbxInformacion;
        private System.Windows.Forms.ComboBox cboAuditadaBuscar;
        private System.Windows.Forms.Label txtAuditadaBuscar;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTablaAuditada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTabla;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIndAuditoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInsertar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActualizar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEliminar;
        private System.Windows.Forms.DataGridView dgvColumnas;
        private System.Windows.Forms.GroupBox gbxCriteriosDetalle;
        private System.Windows.Forms.ComboBox cboTipoDetalle;
        private System.Windows.Forms.Label lblTipoDetalle;
        private SistemaCentroSalud.Controles.cuTextBox txtUsuarioDetalle;
        private System.Windows.Forms.Label lblUsuarioDetalle;
        private System.Windows.Forms.CheckBox cbxFechaInicioDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaFinDetalle;
        private System.Windows.Forms.CheckBox cbxFechaFinDetalle;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAntiguoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNuevoValor;
    }
}