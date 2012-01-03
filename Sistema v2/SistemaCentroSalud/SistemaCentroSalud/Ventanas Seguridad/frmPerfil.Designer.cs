namespace SistemaCentroSalud.Ventanas_Seguridad
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Paciente");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cita");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Admisión", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Doctor(a)");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Enfermero(a)");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Técnico(a)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Administrativo");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Personal", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Historia Clínica Completa");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Historia Clínica");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Formulario HIS");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Disponibilidad");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Doctor", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Área");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Especialidad Médica");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Pabellón");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Consultorio");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Modo de Ingreso");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Parámetros Centro de Salud", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Tipo de Documento");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Ocupación");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Religión");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Idioma");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Etnia");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("País");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Parámetros Paciente", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("CPT");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Laboratorio");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Financiador de Salud");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Unidad Productora de Servicios");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Parámetros Formulario HIS", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Horarios");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Mantenimiento", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode26,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Reportes");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Perfil");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Auditoría");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Respaldar");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Restaurar");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Seguridad", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38});
            this.tbcPerfil = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.cboEstadoBuscar = new System.Windows.Forms.ComboBox();
            this.lblEstadoBuscar = new System.Windows.Forms.Label();
            this.cboTipoEmpleadoBuscar = new System.Windows.Forms.ComboBox();
            this.lblAreaBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxPermisos = new System.Windows.Forms.GroupBox();
            this.btnTodoIzquierda = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnTodoDerecha = new System.Windows.Forms.Button();
            this.lbxAccesosPermitidos = new System.Windows.Forms.ListBox();
            this.tvAccesos = new System.Windows.Forms.TreeView();
            this.gbxInformacion = new System.Windows.Forms.GroupBox();
            this.cboTipoEmpleadoDetalle = new System.Windows.Forms.ComboBox();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.txtNombreDetalle = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.tbcPerfil.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.gbxPermisos.SuspendLayout();
            this.gbxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPerfil
            // 
            this.tbcPerfil.Controls.Add(this.tbpBuscar);
            this.tbcPerfil.Controls.Add(this.tbpDetalle);
            this.tbcPerfil.Location = new System.Drawing.Point(0, 0);
            this.tbcPerfil.Name = "tbcPerfil";
            this.tbcPerfil.SelectedIndex = 0;
            this.tbcPerfil.Size = new System.Drawing.Size(459, 318);
            this.tbcPerfil.TabIndex = 0;
            this.tbcPerfil.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcPerfil_Selecting);
            this.tbcPerfil.SelectedIndexChanged += new System.EventHandler(this.tbcPerfil_SelectedIndexChanged);
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnEliminar);
            this.tbpBuscar.Controls.Add(this.btnActivar);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnModificar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Controls.Add(this.dgvPerfiles);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(451, 292);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(368, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(279, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.Location = new System.Drawing.Point(279, 262);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 17;
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Visible = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 262);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 16;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(190, 262);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 262);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.AllowUserToResizeColumns = false;
            this.dgvPerfiles.AllowUserToResizeRows = false;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colNombre,
            this.colArea,
            this.colEstado});
            this.dgvPerfiles.Location = new System.Drawing.Point(8, 112);
            this.dgvPerfiles.MultiSelect = false;
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.RowHeadersVisible = false;
            this.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfiles.Size = new System.Drawing.Size(435, 144);
            this.dgvPerfiles.TabIndex = 1;
            this.dgvPerfiles.SelectionChanged += new System.EventHandler(this.dgvPerfiles_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colArea.HeaderText = "Área";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Controls.Add(this.cboEstadoBuscar);
            this.gbxCriterios.Controls.Add(this.lblEstadoBuscar);
            this.gbxCriterios.Controls.Add(this.cboTipoEmpleadoBuscar);
            this.gbxCriterios.Controls.Add(this.lblAreaBuscar);
            this.gbxCriterios.Controls.Add(this.txtNombreBuscar);
            this.gbxCriterios.Controls.Add(this.lblNombreBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(8, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(435, 100);
            this.gbxCriterios.TabIndex = 0;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // cboEstadoBuscar
            // 
            this.cboEstadoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoBuscar.FormattingEnabled = true;
            this.cboEstadoBuscar.Items.AddRange(new object[] {
            "TODOS",
            "ACTIVO",
            "INACTIVO"});
            this.cboEstadoBuscar.Location = new System.Drawing.Point(318, 56);
            this.cboEstadoBuscar.Name = "cboEstadoBuscar";
            this.cboEstadoBuscar.Size = new System.Drawing.Size(111, 21);
            this.cboEstadoBuscar.TabIndex = 5;
            this.cboEstadoBuscar.SelectedIndexChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblEstadoBuscar
            // 
            this.lblEstadoBuscar.AutoSize = true;
            this.lblEstadoBuscar.Location = new System.Drawing.Point(271, 59);
            this.lblEstadoBuscar.Name = "lblEstadoBuscar";
            this.lblEstadoBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoBuscar.TabIndex = 4;
            this.lblEstadoBuscar.Text = "Estado:";
            // 
            // cboTipoEmpleadoBuscar
            // 
            this.cboTipoEmpleadoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEmpleadoBuscar.FormattingEnabled = true;
            this.cboTipoEmpleadoBuscar.Items.AddRange(new object[] {
            "TODOS",
            "ADMINISTRATIVO",
            "DOCTOR",
            "ENFERMERO",
            "TÉCNICO"});
            this.cboTipoEmpleadoBuscar.Location = new System.Drawing.Point(108, 56);
            this.cboTipoEmpleadoBuscar.Name = "cboTipoEmpleadoBuscar";
            this.cboTipoEmpleadoBuscar.Size = new System.Drawing.Size(157, 21);
            this.cboTipoEmpleadoBuscar.TabIndex = 3;
            this.cboTipoEmpleadoBuscar.SelectedIndexChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblAreaBuscar
            // 
            this.lblAreaBuscar.AutoSize = true;
            this.lblAreaBuscar.Location = new System.Drawing.Point(6, 59);
            this.lblAreaBuscar.Name = "lblAreaBuscar";
            this.lblAreaBuscar.Size = new System.Drawing.Size(96, 13);
            this.lblAreaBuscar.TabIndex = 2;
            this.lblAreaBuscar.Text = "Tipo de Empleado:";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBuscar.Location = new System.Drawing.Point(108, 23);
            this.txtNombreBuscar.MaxLength = 50;
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(157, 20);
            this.txtNombreBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombreBuscar.TabIndex = 1;
            this.txtNombreBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(6, 26);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBuscar.TabIndex = 0;
            this.lblNombreBuscar.Text = "Nombre:";
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.btnGuardar);
            this.tbpDetalle.Controls.Add(this.btnCancelar);
            this.tbpDetalle.Controls.Add(this.gbxPermisos);
            this.tbpDetalle.Controls.Add(this.gbxInformacion);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(451, 292);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(467, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(351, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxPermisos
            // 
            this.gbxPermisos.Controls.Add(this.btnTodoIzquierda);
            this.gbxPermisos.Controls.Add(this.btnIzquierda);
            this.gbxPermisos.Controls.Add(this.btnDerecha);
            this.gbxPermisos.Controls.Add(this.btnTodoDerecha);
            this.gbxPermisos.Controls.Add(this.lbxAccesosPermitidos);
            this.gbxPermisos.Controls.Add(this.tvAccesos);
            this.gbxPermisos.Location = new System.Drawing.Point(8, 81);
            this.gbxPermisos.Name = "gbxPermisos";
            this.gbxPermisos.Size = new System.Drawing.Size(545, 171);
            this.gbxPermisos.TabIndex = 3;
            this.gbxPermisos.TabStop = false;
            this.gbxPermisos.Text = "Permisos";
            // 
            // btnTodoIzquierda
            // 
            this.btnTodoIzquierda.Location = new System.Drawing.Point(234, 123);
            this.btnTodoIzquierda.Name = "btnTodoIzquierda";
            this.btnTodoIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnTodoIzquierda.TabIndex = 8;
            this.btnTodoIzquierda.Text = "<<";
            this.btnTodoIzquierda.UseVisualStyleBackColor = true;
            this.btnTodoIzquierda.Click += new System.EventHandler(this.btnTodoIzquierda_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(234, 90);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(234, 57);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 6;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnTodoDerecha
            // 
            this.btnTodoDerecha.Location = new System.Drawing.Point(234, 24);
            this.btnTodoDerecha.Name = "btnTodoDerecha";
            this.btnTodoDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnTodoDerecha.TabIndex = 5;
            this.btnTodoDerecha.Text = ">>";
            this.btnTodoDerecha.UseVisualStyleBackColor = true;
            this.btnTodoDerecha.Click += new System.EventHandler(this.btnTodoDerecha_Click);
            // 
            // lbxAccesosPermitidos
            // 
            this.lbxAccesosPermitidos.FormattingEnabled = true;
            this.lbxAccesosPermitidos.Location = new System.Drawing.Point(322, 19);
            this.lbxAccesosPermitidos.Name = "lbxAccesosPermitidos";
            this.lbxAccesosPermitidos.Size = new System.Drawing.Size(212, 134);
            this.lbxAccesosPermitidos.TabIndex = 9;
            // 
            // tvAccesos
            // 
            this.tvAccesos.Location = new System.Drawing.Point(9, 19);
            this.tvAccesos.Name = "tvAccesos";
            treeNode1.Name = "smnuPaciente";
            treeNode1.Text = "Paciente";
            treeNode2.Name = "smnuCita";
            treeNode2.Text = "Cita";
            treeNode3.Name = "nodAdmision";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode3.Text = "Admisión";
            treeNode4.Name = "smnuDoctor";
            treeNode4.Text = "Doctor(a)";
            treeNode5.Name = "smnuEnfermero";
            treeNode5.Text = "Enfermero(a)";
            treeNode6.Name = "smnuTecnico";
            treeNode6.Text = "Técnico(a)";
            treeNode7.Name = "smnuAdministrativo";
            treeNode7.Text = "Administrativo";
            treeNode8.Name = "nodPersonal";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode8.Text = "Personal";
            treeNode9.Name = "smnuHistoriaClinicaCompleta";
            treeNode9.Text = "Historia Clínica Completa";
            treeNode10.Name = "smnuHistoriaClinica";
            treeNode10.Text = "Historia Clínica";
            treeNode11.Name = "smnuFormularioHIS";
            treeNode11.Text = "Formulario HIS";
            treeNode12.Name = "smnuDisponibilidad";
            treeNode12.Text = "Disponibilidad";
            treeNode13.Name = "nodDoctor";
            treeNode13.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode13.Text = "Doctor";
            treeNode14.Name = "smnuArea";
            treeNode14.Text = "Área";
            treeNode15.Name = "smnuEspecialidad";
            treeNode15.Text = "Especialidad Médica";
            treeNode16.Name = "smnuPabellon";
            treeNode16.Text = "Pabellón";
            treeNode17.Name = "smnuConsultorio";
            treeNode17.Text = "Consultorio";
            treeNode18.Name = "smnuModoIngreso";
            treeNode18.Text = "Modo de Ingreso";
            treeNode19.Name = "nodParametrosCentroSalud";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            treeNode19.Text = "Parámetros Centro de Salud";
            treeNode20.Name = "smnuTipoDocumento";
            treeNode20.Text = "Tipo de Documento";
            treeNode21.Name = "smnuOcupacion";
            treeNode21.Text = "Ocupación";
            treeNode22.Name = "smnuReligion";
            treeNode22.Text = "Religión";
            treeNode23.Name = "smnuIdioma";
            treeNode23.Text = "Idioma";
            treeNode24.Name = "smnuEtnia";
            treeNode24.Text = "Etnia";
            treeNode25.Name = "smnuPais";
            treeNode25.Text = "País";
            treeNode26.Name = "nodParametrosPaciente";
            treeNode26.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            treeNode26.Text = "Parámetros Paciente";
            treeNode27.Name = "smnuCPT";
            treeNode27.Text = "CPT";
            treeNode28.Name = "smnuLaboratorio";
            treeNode28.Text = "Laboratorio";
            treeNode29.Name = "smnuFinanciadorSalud";
            treeNode29.Text = "Financiador de Salud";
            treeNode30.Name = "smnuUnidadProductoraServicios";
            treeNode30.Text = "Unidad Productora de Servicios";
            treeNode31.Name = "nodParametrosFormularioHIS";
            treeNode31.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            treeNode31.Text = "Parámetros Formulario HIS";
            treeNode32.Name = "smnuHorarios";
            treeNode32.Text = "Horarios";
            treeNode33.Name = "nodMantenimiento";
            treeNode33.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode33.Text = "Mantenimiento";
            treeNode34.Name = "nodReportes";
            treeNode34.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode34.Text = "Reportes";
            treeNode35.Name = "smnuPerfil";
            treeNode35.Text = "Perfil";
            treeNode36.Name = "smnuAuditoria";
            treeNode36.Text = "Auditoría";
            treeNode37.Name = "smnuRespaldar";
            treeNode37.Text = "Respaldar";
            treeNode38.Name = "smnuRestaurar";
            treeNode38.Text = "Restaurar";
            treeNode39.Name = "nodSeguridad";
            treeNode39.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode39.Text = "Seguridad";
            this.tvAccesos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode13,
            treeNode33,
            treeNode34,
            treeNode39});
            this.tvAccesos.Size = new System.Drawing.Size(212, 134);
            this.tvAccesos.TabIndex = 4;
            // 
            // gbxInformacion
            // 
            this.gbxInformacion.Controls.Add(this.cboTipoEmpleadoDetalle);
            this.gbxInformacion.Controls.Add(this.lblTipoEmpleado);
            this.gbxInformacion.Controls.Add(this.txtNombreDetalle);
            this.gbxInformacion.Controls.Add(this.lblNombreDetalle);
            this.gbxInformacion.Location = new System.Drawing.Point(8, 6);
            this.gbxInformacion.Name = "gbxInformacion";
            this.gbxInformacion.Size = new System.Drawing.Size(545, 69);
            this.gbxInformacion.TabIndex = 0;
            this.gbxInformacion.TabStop = false;
            this.gbxInformacion.Text = "Información";
            // 
            // cboTipoEmpleadoDetalle
            // 
            this.cboTipoEmpleadoDetalle.AutoCompleteCustomSource.AddRange(new string[] {
            "SELECCIONAR",
            "ADMINISTRATIVO",
            "DOCTOR",
            "ENFERMERO",
            "TÉCNICO"});
            this.cboTipoEmpleadoDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEmpleadoDetalle.Enabled = false;
            this.cboTipoEmpleadoDetalle.FormattingEnabled = true;
            this.cboTipoEmpleadoDetalle.Items.AddRange(new object[] {
            "SELECCIONAR",
            "ADMINISTRATIVO",
            "DOCTOR",
            "ENFERMERO",
            "TÉCNICO"});
            this.cboTipoEmpleadoDetalle.Location = new System.Drawing.Point(322, 32);
            this.cboTipoEmpleadoDetalle.Name = "cboTipoEmpleadoDetalle";
            this.cboTipoEmpleadoDetalle.Size = new System.Drawing.Size(157, 21);
            this.cboTipoEmpleadoDetalle.TabIndex = 4;
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(319, 16);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(81, 13);
            this.lblTipoEmpleado.TabIndex = 3;
            this.lblTipoEmpleado.Text = "Tipo Empleado:";
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDetalle.Location = new System.Drawing.Point(9, 32);
            this.txtNombreDetalle.MaxLength = 50;
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.Size = new System.Drawing.Size(212, 20);
            this.txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombreDetalle.TabIndex = 2;
            this.txtNombreDetalle.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.AutoSize = true;
            this.lblNombreDetalle.Location = new System.Drawing.Point(6, 16);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDetalle.TabIndex = 2;
            this.lblNombreDetalle.Text = "Nombre:";
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 317);
            this.Controls.Add(this.tbcPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.tbcPerfil.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.gbxPermisos.ResumeLayout(false);
            this.gbxInformacion.ResumeLayout(false);
            this.gbxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPerfil;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.GroupBox gbxPermisos;
        private System.Windows.Forms.GroupBox gbxInformacion;
        private System.Windows.Forms.Button btnTodoIzquierda;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnTodoDerecha;
        private System.Windows.Forms.ListBox lbxAccesosPermitidos;
        private System.Windows.Forms.TreeView tvAccesos;
        private SistemaCentroSalud.Controles.cuTextBox txtNombreDetalle;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboEstadoBuscar;
        private System.Windows.Forms.Label lblEstadoBuscar;
        private System.Windows.Forms.ComboBox cboTipoEmpleadoBuscar;
        private System.Windows.Forms.Label lblAreaBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.ComboBox cboTipoEmpleadoDetalle;
        private System.Windows.Forms.Label lblTipoEmpleado;
    }
}