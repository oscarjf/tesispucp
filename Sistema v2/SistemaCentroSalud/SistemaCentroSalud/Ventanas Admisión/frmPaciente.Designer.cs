namespace SistemaCentroSalud
{
    partial class frmPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.tbcPacientes = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.colPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.gbxHistoriaClinica = new System.Windows.Forms.GroupBox();
            this.txtNumeroHistoriaClinica = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNumeroHistoriaClinica = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cboDistritoDomicilio = new System.Windows.Forms.ComboBox();
            this.cboProvinciaDomicilio = new System.Windows.Forms.ComboBox();
            this.cboDepartamentoDomicilio = new System.Windows.Forms.ComboBox();
            this.lblDistritoDomicilio = new System.Windows.Forms.Label();
            this.lblProvinciaDomicilio = new System.Windows.Forms.Label();
            this.lblDepartamentoDomicilio = new System.Windows.Forms.Label();
            this.gbxContacto = new System.Windows.Forms.GroupBox();
            this.txtCorreoElectronico = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtCelular = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTelefono = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
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
            this.txtNumeroDocumento = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombres = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtMaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboReligion = new System.Windows.Forms.ComboBox();
            this.lblReligion = new System.Windows.Forms.Label();
            this.cboRaza = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.cboOcupacion = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.tbcPacientes.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.tbpDetalle.SuspendLayout();
            this.gbxHistoriaClinica.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxContacto.SuspendLayout();
            this.gbxLugarNacimiento.SuspendLayout();
            this.gbxPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPacientes
            // 
            this.tbcPacientes.Controls.Add(this.tbpBuscar);
            this.tbcPacientes.Controls.Add(this.tbpDetalle);
            this.tbcPacientes.Location = new System.Drawing.Point(1, 0);
            this.tbcPacientes.Name = "tbcPacientes";
            this.tbcPacientes.SelectedIndex = 0;
            this.tbcPacientes.Size = new System.Drawing.Size(787, 384);
            this.tbcPacientes.TabIndex = 0;
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
            this.tbpBuscar.Size = new System.Drawing.Size(779, 358);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(694, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 326);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(190, 326);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 326);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeColumns = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaterno,
            this.colMaterno,
            this.colNombres,
            this.colTipoDocumento,
            this.colNumeroDocumento,
            this.colDepartamento,
            this.colProvincia,
            this.colDistrito});
            this.dgvPacientes.Location = new System.Drawing.Point(8, 138);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(761, 182);
            this.dgvPacientes.TabIndex = 1;
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
            // colDepartamento
            // 
            this.colDepartamento.HeaderText = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.ReadOnly = true;
            // 
            // colProvincia
            // 
            this.colProvincia.HeaderText = "Provincia";
            this.colProvincia.Name = "colProvincia";
            this.colProvincia.ReadOnly = true;
            // 
            // colDistrito
            // 
            this.colDistrito.HeaderText = "Distrito";
            this.colDistrito.Name = "colDistrito";
            this.colDistrito.ReadOnly = true;
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Location = new System.Drawing.Point(8, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(761, 126);
            this.gbxCriterios.TabIndex = 0;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.gbxHistoriaClinica);
            this.tbpDetalle.Controls.Add(this.btnGuardar);
            this.tbpDetalle.Controls.Add(this.btnCancelar);
            this.tbpDetalle.Controls.Add(this.gbxDomicilio);
            this.tbpDetalle.Controls.Add(this.gbxContacto);
            this.tbpDetalle.Controls.Add(this.gbxLugarNacimiento);
            this.tbpDetalle.Controls.Add(this.gbxPersonal);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(779, 358);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // gbxHistoriaClinica
            // 
            this.gbxHistoriaClinica.Controls.Add(this.txtNumeroHistoriaClinica);
            this.gbxHistoriaClinica.Controls.Add(this.lblNumeroHistoriaClinica);
            this.gbxHistoriaClinica.Location = new System.Drawing.Point(559, 160);
            this.gbxHistoriaClinica.Name = "gbxHistoriaClinica";
            this.gbxHistoriaClinica.Size = new System.Drawing.Size(214, 72);
            this.gbxHistoriaClinica.TabIndex = 23;
            this.gbxHistoriaClinica.TabStop = false;
            this.gbxHistoriaClinica.Text = "Historia Clínica";
            // 
            // txtNumeroHistoriaClinica
            // 
            this.txtNumeroHistoriaClinica.Location = new System.Drawing.Point(10, 33);
            this.txtNumeroHistoriaClinica.Name = "txtNumeroHistoriaClinica";
            this.txtNumeroHistoriaClinica.Size = new System.Drawing.Size(125, 20);
            this.txtNumeroHistoriaClinica.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroHistoriaClinica.TabIndex = 24;
            this.txtNumeroHistoriaClinica.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // lblNumeroHistoriaClinica
            // 
            this.lblNumeroHistoriaClinica.AutoSize = true;
            this.lblNumeroHistoriaClinica.Location = new System.Drawing.Point(7, 16);
            this.lblNumeroHistoriaClinica.Name = "lblNumeroHistoriaClinica";
            this.lblNumeroHistoriaClinica.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroHistoriaClinica.TabIndex = 0;
            this.lblNumeroHistoriaClinica.Text = "No. Historia Clínica";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(689, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(573, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.Controls.Add(this.txtDireccion);
            this.gbxDomicilio.Controls.Add(this.lblDireccion);
            this.gbxDomicilio.Controls.Add(this.cboDistritoDomicilio);
            this.gbxDomicilio.Controls.Add(this.cboProvinciaDomicilio);
            this.gbxDomicilio.Controls.Add(this.cboDepartamentoDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblDistritoDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblProvinciaDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblDepartamentoDomicilio);
            this.gbxDomicilio.Location = new System.Drawing.Point(8, 239);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(543, 116);
            this.gbxDomicilio.TabIndex = 17;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(10, 83);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(521, 20);
            this.txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
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
            this.cboDistritoDomicilio.Location = new System.Drawing.Point(269, 33);
            this.cboDistritoDomicilio.Name = "cboDistritoDomicilio";
            this.cboDistritoDomicilio.Size = new System.Drawing.Size(125, 21);
            this.cboDistritoDomicilio.TabIndex = 20;
            // 
            // cboProvinciaDomicilio
            // 
            this.cboProvinciaDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinciaDomicilio.FormattingEnabled = true;
            this.cboProvinciaDomicilio.Location = new System.Drawing.Point(138, 33);
            this.cboProvinciaDomicilio.Name = "cboProvinciaDomicilio";
            this.cboProvinciaDomicilio.Size = new System.Drawing.Size(122, 21);
            this.cboProvinciaDomicilio.TabIndex = 19;
            // 
            // cboDepartamentoDomicilio
            // 
            this.cboDepartamentoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentoDomicilio.FormattingEnabled = true;
            this.cboDepartamentoDomicilio.Location = new System.Drawing.Point(10, 33);
            this.cboDepartamentoDomicilio.Name = "cboDepartamentoDomicilio";
            this.cboDepartamentoDomicilio.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamentoDomicilio.TabIndex = 18;
            // 
            // lblDistritoDomicilio
            // 
            this.lblDistritoDomicilio.AutoSize = true;
            this.lblDistritoDomicilio.Location = new System.Drawing.Point(269, 15);
            this.lblDistritoDomicilio.Name = "lblDistritoDomicilio";
            this.lblDistritoDomicilio.Size = new System.Drawing.Size(42, 13);
            this.lblDistritoDomicilio.TabIndex = 32;
            this.lblDistritoDomicilio.Text = "Distrito:";
            // 
            // lblProvinciaDomicilio
            // 
            this.lblProvinciaDomicilio.AutoSize = true;
            this.lblProvinciaDomicilio.Location = new System.Drawing.Point(135, 17);
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
            // gbxContacto
            // 
            this.gbxContacto.Controls.Add(this.txtCorreoElectronico);
            this.gbxContacto.Controls.Add(this.txtCelular);
            this.gbxContacto.Controls.Add(this.txtTelefono);
            this.gbxContacto.Controls.Add(this.lblCorreoElectronico);
            this.gbxContacto.Controls.Add(this.lblCelular);
            this.gbxContacto.Controls.Add(this.lblTelefono);
            this.gbxContacto.Location = new System.Drawing.Point(559, 7);
            this.gbxContacto.Name = "gbxContacto";
            this.gbxContacto.Size = new System.Drawing.Size(213, 147);
            this.gbxContacto.TabIndex = 22;
            this.gbxContacto.TabStop = false;
            this.gbxContacto.Text = "Contacto";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(10, 114);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(195, 20);
            this.txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCorreoElectronico.TabIndex = 25;
            this.txtCorreoElectronico.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(10, 75);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(112, 20);
            this.txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCelular.TabIndex = 24;
            this.txtCelular.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(10, 35);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 20);
            this.txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(7, 98);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(97, 13);
            this.lblCorreoElectronico.TabIndex = 27;
            this.lblCorreoElectronico.Text = "Correo Electrónico:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(7, 59);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 25;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(7, 19);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // gbxLugarNacimiento
            // 
            this.gbxLugarNacimiento.Controls.Add(this.cboDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.cboProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.cboDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.lblDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.lblProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.lblDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.cboPais);
            this.gbxLugarNacimiento.Controls.Add(this.lblPais);
            this.gbxLugarNacimiento.Location = new System.Drawing.Point(8, 160);
            this.gbxLugarNacimiento.Name = "gbxLugarNacimiento";
            this.gbxLugarNacimiento.Size = new System.Drawing.Size(543, 72);
            this.gbxLugarNacimiento.TabIndex = 12;
            this.gbxLugarNacimiento.TabStop = false;
            this.gbxLugarNacimiento.Text = "Lugar de Nacimiento";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(406, 32);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(125, 21);
            this.cboDistrito.TabIndex = 16;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(275, 32);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(122, 21);
            this.cboProvincia.TabIndex = 15;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(147, 32);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamento.TabIndex = 14;
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(403, 16);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 26;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(272, 16);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 25;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(144, 15);
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
            this.gbxPersonal.Controls.Add(this.txtNumeroDocumento);
            this.gbxPersonal.Controls.Add(this.txtNombres);
            this.gbxPersonal.Controls.Add(this.txtMaterno);
            this.gbxPersonal.Controls.Add(this.txtPaterno);
            this.gbxPersonal.Controls.Add(this.cboEstadoCivil);
            this.gbxPersonal.Controls.Add(this.lblEstadoCivil);
            this.gbxPersonal.Controls.Add(this.dtpFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.lblFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.lblNumeroDocumento);
            this.gbxPersonal.Controls.Add(this.cboTipoDocumento);
            this.gbxPersonal.Controls.Add(this.lblTipoDocumento);
            this.gbxPersonal.Controls.Add(this.cboReligion);
            this.gbxPersonal.Controls.Add(this.lblReligion);
            this.gbxPersonal.Controls.Add(this.cboRaza);
            this.gbxPersonal.Controls.Add(this.lblRaza);
            this.gbxPersonal.Controls.Add(this.cboOcupacion);
            this.gbxPersonal.Controls.Add(this.lblOcupacion);
            this.gbxPersonal.Controls.Add(this.cboSexo);
            this.gbxPersonal.Controls.Add(this.lblSexo);
            this.gbxPersonal.Controls.Add(this.lblNombres);
            this.gbxPersonal.Controls.Add(this.lblMaterno);
            this.gbxPersonal.Controls.Add(this.lblPaterno);
            this.gbxPersonal.Location = new System.Drawing.Point(8, 7);
            this.gbxPersonal.Name = "gbxPersonal";
            this.gbxPersonal.Size = new System.Drawing.Size(545, 147);
            this.gbxPersonal.TabIndex = 0;
            this.gbxPersonal.TabStop = false;
            this.gbxPersonal.Text = "Información Personal";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(406, 114);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(125, 20);
            this.txtNumeroDocumento.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroDocumento.TabIndex = 11;
            this.txtNumeroDocumento.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(272, 35);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(259, 20);
            this.txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(141, 35);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(125, 20);
            this.txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtMaterno.TabIndex = 2;
            this.txtMaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(10, 35);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(125, 20);
            this.txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaterno.TabIndex = 1;
            this.txtPaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "SOLTERO(A)",
            "CASADO(A)",
            "VIUDO(A)",
            "DIVORCIADO(A)",
            "OTRO"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(144, 114);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(122, 21);
            this.cboEstadoCivil.TabIndex = 9;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(141, 99);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 20;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(406, 76);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(403, 60);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(403, 99);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroDocumento.TabIndex = 16;
            this.lblNumeroDocumento.Text = "No. Documento:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(272, 114);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(125, 21);
            this.cboTipoDocumento.TabIndex = 10;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(269, 99);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 14;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cboReligion
            // 
            this.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReligion.FormattingEnabled = true;
            this.cboReligion.Location = new System.Drawing.Point(272, 75);
            this.cboReligion.Name = "cboReligion";
            this.cboReligion.Size = new System.Drawing.Size(125, 21);
            this.cboReligion.TabIndex = 6;
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Location = new System.Drawing.Point(269, 59);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(48, 13);
            this.lblReligion.TabIndex = 12;
            this.lblReligion.Text = "Religión:";
            // 
            // cboRaza
            // 
            this.cboRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRaza.FormattingEnabled = true;
            this.cboRaza.Location = new System.Drawing.Point(141, 75);
            this.cboRaza.Name = "cboRaza";
            this.cboRaza.Size = new System.Drawing.Size(125, 21);
            this.cboRaza.TabIndex = 5;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(138, 59);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 10;
            this.lblRaza.Text = "Raza:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
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
            this.lblNombres.Location = new System.Drawing.Point(269, 20);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(138, 20);
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
            // cboOcupacion
            // 
            this.cboOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcupacion.FormattingEnabled = true;
            this.cboOcupacion.Location = new System.Drawing.Point(10, 114);
            this.cboOcupacion.Name = "cboOcupacion";
            this.cboOcupacion.Size = new System.Drawing.Size(125, 21);
            this.cboOcupacion.TabIndex = 8;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(7, 98);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(62, 13);
            this.lblOcupacion.TabIndex = 8;
            this.lblOcupacion.Text = "Ocupación:";
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 383);
            this.Controls.Add(this.tbcPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.tbcPacientes.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.tbpDetalle.ResumeLayout(false);
            this.gbxHistoriaClinica.ResumeLayout(false);
            this.gbxHistoriaClinica.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxContacto.ResumeLayout(false);
            this.gbxContacto.PerformLayout();
            this.gbxLugarNacimiento.ResumeLayout(false);
            this.gbxLugarNacimiento.PerformLayout();
            this.gbxPersonal.ResumeLayout(false);
            this.gbxPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPacientes;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.GroupBox gbxPersonal;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.ComboBox cboReligion;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.ComboBox cboRaza;
        private System.Windows.Forms.GroupBox gbxLugarNacimiento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.GroupBox gbxContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cboDistritoDomicilio;
        private System.Windows.Forms.ComboBox cboProvinciaDomicilio;
        private System.Windows.Forms.ComboBox cboDepartamentoDomicilio;
        private System.Windows.Forms.Label lblDistritoDomicilio;
        private System.Windows.Forms.Label lblProvinciaDomicilio;
        private System.Windows.Forms.Label lblDepartamentoDomicilio;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistrito;
        private SistemaCentroSalud.Controles.cuTextBox txtCorreoElectronico;
        private SistemaCentroSalud.Controles.cuTextBox txtCelular;
        private SistemaCentroSalud.Controles.cuTextBox txtTelefono;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroDocumento;
        private SistemaCentroSalud.Controles.cuTextBox txtNombres;
        private SistemaCentroSalud.Controles.cuTextBox txtMaterno;
        private SistemaCentroSalud.Controles.cuTextBox txtPaterno;
        private SistemaCentroSalud.Controles.cuTextBox txtDireccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxHistoriaClinica;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroHistoriaClinica;
        private System.Windows.Forms.Label lblNumeroHistoriaClinica;
        private System.Windows.Forms.ComboBox cboOcupacion;
        private System.Windows.Forms.Label lblOcupacion;
    }
}