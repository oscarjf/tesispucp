namespace SistemaCentroSalud.Ventanas_Personal
{
    partial class frmDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            this.tbcDoctor = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvDoctores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.lblEstadoBuscar = new System.Windows.Forms.Label();
            this.lblEspecialidadBuscar = new System.Windows.Forms.Label();
            this.cboEspecialidadBuscar = new System.Windows.Forms.ComboBox();
            this.lblCMPBuscar = new System.Windows.Forms.Label();
            this.lblNombresBuscar = new System.Windows.Forms.Label();
            this.lblMaternoBuscar = new System.Windows.Forms.Label();
            this.lblPaternoBuscar = new System.Windows.Forms.Label();
            this.cboEstadoBuscar = new System.Windows.Forms.ComboBox();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxContacto = new System.Windows.Forms.GroupBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
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
            this.btnQuitarFoto = new System.Windows.Forms.Button();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.gbxProfesional = new System.Windows.Forms.GroupBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.clbxEspecialidades = new System.Windows.Forms.CheckedListBox();
            this.lblCMP = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.gbxPersonal = new System.Windows.Forms.GroupBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.txtMaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtCMPBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombresBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaternoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtCorreoElectronico = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtCelular = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTelefono = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtDireccion = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtCMP = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNumeroDocumento = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombres = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtMaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.tbcDoctor.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.gbxContacto.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxLugarNacimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.gbxProfesional.SuspendLayout();
            this.gbxPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDoctor
            // 
            this.tbcDoctor.Controls.Add(this.tbpBuscar);
            this.tbcDoctor.Controls.Add(this.tbpDetalle);
            this.tbcDoctor.Location = new System.Drawing.Point(1, 0);
            this.tbcDoctor.Name = "tbcDoctor";
            this.tbcDoctor.SelectedIndex = 0;
            this.tbcDoctor.Size = new System.Drawing.Size(788, 492);
            this.tbcDoctor.TabIndex = 0;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnActivar);
            this.tbpBuscar.Controls.Add(this.btnInactivar);
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnModificar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Controls.Add(this.dgvDoctores);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(780, 466);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // btnActivar
            // 
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.Location = new System.Drawing.Point(279, 361);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 10;
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Visible = false;
            // 
            // btnInactivar
            // 
            this.btnInactivar.Image = ((System.Drawing.Image)(resources.GetObject("btnInactivar.Image")));
            this.btnInactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInactivar.Location = new System.Drawing.Point(279, 361);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar.TabIndex = 10;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInactivar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(477, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 361);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(190, 361);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 361);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvDoctores
            // 
            this.dgvDoctores.AllowUserToAddRows = false;
            this.dgvDoctores.AllowUserToDeleteRows = false;
            this.dgvDoctores.AllowUserToResizeColumns = false;
            this.dgvDoctores.AllowUserToResizeRows = false;
            this.dgvDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colPaterno,
            this.colMaterno,
            this.colNombres,
            this.colCMP,
            this.colEspecialidad,
            this.colEstado});
            this.dgvDoctores.Location = new System.Drawing.Point(8, 144);
            this.dgvDoctores.MultiSelect = false;
            this.dgvDoctores.Name = "dgvDoctores";
            this.dgvDoctores.ReadOnly = true;
            this.dgvDoctores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctores.Size = new System.Drawing.Size(544, 211);
            this.dgvDoctores.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
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
            // colCMP
            // 
            this.colCMP.HeaderText = "CMP";
            this.colCMP.Name = "colCMP";
            this.colCMP.ReadOnly = true;
            this.colCMP.Width = 50;
            // 
            // colEspecialidad
            // 
            this.colEspecialidad.HeaderText = "Especialidad";
            this.colEspecialidad.Name = "colEspecialidad";
            this.colEspecialidad.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 50;
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Controls.Add(this.lblEstadoBuscar);
            this.gbxCriterios.Controls.Add(this.lblEspecialidadBuscar);
            this.gbxCriterios.Controls.Add(this.cboEspecialidadBuscar);
            this.gbxCriterios.Controls.Add(this.lblCMPBuscar);
            this.gbxCriterios.Controls.Add(this.lblNombresBuscar);
            this.gbxCriterios.Controls.Add(this.lblMaternoBuscar);
            this.gbxCriterios.Controls.Add(this.lblPaternoBuscar);
            this.gbxCriterios.Controls.Add(this.txtMaternoBuscar);
            this.gbxCriterios.Controls.Add(this.cboEstadoBuscar);
            this.gbxCriterios.Controls.Add(this.txtCMPBuscar);
            this.gbxCriterios.Controls.Add(this.txtNombresBuscar);
            this.gbxCriterios.Controls.Add(this.txtPaternoBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(8, 9);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(544, 128);
            this.gbxCriterios.TabIndex = 0;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // lblEstadoBuscar
            // 
            this.lblEstadoBuscar.AutoSize = true;
            this.lblEstadoBuscar.Location = new System.Drawing.Point(303, 76);
            this.lblEstadoBuscar.Name = "lblEstadoBuscar";
            this.lblEstadoBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoBuscar.TabIndex = 45;
            this.lblEstadoBuscar.Text = "Estado:";
            // 
            // lblEspecialidadBuscar
            // 
            this.lblEspecialidadBuscar.AutoSize = true;
            this.lblEspecialidadBuscar.Location = new System.Drawing.Point(157, 76);
            this.lblEspecialidadBuscar.Name = "lblEspecialidadBuscar";
            this.lblEspecialidadBuscar.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidadBuscar.TabIndex = 44;
            this.lblEspecialidadBuscar.Text = "Especialidad:";
            // 
            // cboEspecialidadBuscar
            // 
            this.cboEspecialidadBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidadBuscar.FormattingEnabled = true;
            this.cboEspecialidadBuscar.Location = new System.Drawing.Point(160, 92);
            this.cboEspecialidadBuscar.Name = "cboEspecialidadBuscar";
            this.cboEspecialidadBuscar.Size = new System.Drawing.Size(125, 21);
            this.cboEspecialidadBuscar.TabIndex = 4;
            // 
            // lblCMPBuscar
            // 
            this.lblCMPBuscar.AutoSize = true;
            this.lblCMPBuscar.Location = new System.Drawing.Point(7, 76);
            this.lblCMPBuscar.Name = "lblCMPBuscar";
            this.lblCMPBuscar.Size = new System.Drawing.Size(33, 13);
            this.lblCMPBuscar.TabIndex = 42;
            this.lblCMPBuscar.Text = "CMP:";
            // 
            // lblNombresBuscar
            // 
            this.lblNombresBuscar.AutoSize = true;
            this.lblNombresBuscar.Location = new System.Drawing.Point(303, 25);
            this.lblNombresBuscar.Name = "lblNombresBuscar";
            this.lblNombresBuscar.Size = new System.Drawing.Size(52, 13);
            this.lblNombresBuscar.TabIndex = 41;
            this.lblNombresBuscar.Text = "Nombres:";
            // 
            // lblMaternoBuscar
            // 
            this.lblMaternoBuscar.AutoSize = true;
            this.lblMaternoBuscar.Location = new System.Drawing.Point(157, 25);
            this.lblMaternoBuscar.Name = "lblMaternoBuscar";
            this.lblMaternoBuscar.Size = new System.Drawing.Size(65, 13);
            this.lblMaternoBuscar.TabIndex = 40;
            this.lblMaternoBuscar.Text = "Ap.Materno:";
            // 
            // lblPaternoBuscar
            // 
            this.lblPaternoBuscar.AutoSize = true;
            this.lblPaternoBuscar.Location = new System.Drawing.Point(7, 25);
            this.lblPaternoBuscar.Name = "lblPaternoBuscar";
            this.lblPaternoBuscar.Size = new System.Drawing.Size(63, 13);
            this.lblPaternoBuscar.TabIndex = 39;
            this.lblPaternoBuscar.Text = "Ap.Paterno:";
            // 
            // cboEstadoBuscar
            // 
            this.cboEstadoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoBuscar.FormattingEnabled = true;
            this.cboEstadoBuscar.Items.AddRange(new object[] {
            "TODOS",
            "ACTIVO",
            "INACTIVO"});
            this.cboEstadoBuscar.Location = new System.Drawing.Point(306, 92);
            this.cboEstadoBuscar.Name = "cboEstadoBuscar";
            this.cboEstadoBuscar.Size = new System.Drawing.Size(125, 21);
            this.cboEstadoBuscar.TabIndex = 5;
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.btnGuardar);
            this.tbpDetalle.Controls.Add(this.btnCancelar);
            this.tbpDetalle.Controls.Add(this.gbxContacto);
            this.tbpDetalle.Controls.Add(this.gbxDomicilio);
            this.tbpDetalle.Controls.Add(this.gbxLugarNacimiento);
            this.tbpDetalle.Controls.Add(this.btnQuitarFoto);
            this.tbpDetalle.Controls.Add(this.btnBuscarFoto);
            this.tbpDetalle.Controls.Add(this.btnTomarFoto);
            this.tbpDetalle.Controls.Add(this.lblFoto);
            this.tbpDetalle.Controls.Add(this.pbxFoto);
            this.tbpDetalle.Controls.Add(this.gbxProfesional);
            this.tbpDetalle.Controls.Add(this.gbxPersonal);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(780, 466);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(695, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(567, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbxContacto
            // 
            this.gbxContacto.Controls.Add(this.txtCorreoElectronico);
            this.gbxContacto.Controls.Add(this.lblCorreoElectronico);
            this.gbxContacto.Controls.Add(this.txtCelular);
            this.gbxContacto.Controls.Add(this.lblCelular);
            this.gbxContacto.Controls.Add(this.txtTelefono);
            this.gbxContacto.Controls.Add(this.lblTelefono);
            this.gbxContacto.Location = new System.Drawing.Point(557, 197);
            this.gbxContacto.Name = "gbxContacto";
            this.gbxContacto.Size = new System.Drawing.Size(213, 147);
            this.gbxContacto.TabIndex = 27;
            this.gbxContacto.TabStop = false;
            this.gbxContacto.Text = "Contacto";
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
            this.gbxDomicilio.Location = new System.Drawing.Point(8, 197);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(543, 119);
            this.gbxDomicilio.TabIndex = 14;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 36;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cboDistritoDomicilio
            // 
            this.cboDistritoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistritoDomicilio.FormattingEnabled = true;
            this.cboDistritoDomicilio.Location = new System.Drawing.Point(275, 33);
            this.cboDistritoDomicilio.Name = "cboDistritoDomicilio";
            this.cboDistritoDomicilio.Size = new System.Drawing.Size(122, 21);
            this.cboDistritoDomicilio.TabIndex = 17;
            // 
            // cboProvinciaDomicilio
            // 
            this.cboProvinciaDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinciaDomicilio.FormattingEnabled = true;
            this.cboProvinciaDomicilio.Location = new System.Drawing.Point(147, 33);
            this.cboProvinciaDomicilio.Name = "cboProvinciaDomicilio";
            this.cboProvinciaDomicilio.Size = new System.Drawing.Size(119, 21);
            this.cboProvinciaDomicilio.TabIndex = 16;
            // 
            // cboDepartamentoDomicilio
            // 
            this.cboDepartamentoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentoDomicilio.FormattingEnabled = true;
            this.cboDepartamentoDomicilio.Location = new System.Drawing.Point(10, 33);
            this.cboDepartamentoDomicilio.Name = "cboDepartamentoDomicilio";
            this.cboDepartamentoDomicilio.Size = new System.Drawing.Size(125, 21);
            this.cboDepartamentoDomicilio.TabIndex = 15;
            // 
            // lblDistritoDomicilio
            // 
            this.lblDistritoDomicilio.AutoSize = true;
            this.lblDistritoDomicilio.Location = new System.Drawing.Point(272, 15);
            this.lblDistritoDomicilio.Name = "lblDistritoDomicilio";
            this.lblDistritoDomicilio.Size = new System.Drawing.Size(42, 13);
            this.lblDistritoDomicilio.TabIndex = 32;
            this.lblDistritoDomicilio.Text = "Distrito:";
            // 
            // lblProvinciaDomicilio
            // 
            this.lblProvinciaDomicilio.AutoSize = true;
            this.lblProvinciaDomicilio.Location = new System.Drawing.Point(144, 17);
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
            this.gbxLugarNacimiento.Controls.Add(this.cboDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.cboProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.cboDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.lblDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.lblProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.lblDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.cboPais);
            this.gbxLugarNacimiento.Controls.Add(this.lblPais);
            this.gbxLugarNacimiento.Location = new System.Drawing.Point(8, 119);
            this.gbxLugarNacimiento.Name = "gbxLugarNacimiento";
            this.gbxLugarNacimiento.Size = new System.Drawing.Size(543, 72);
            this.gbxLugarNacimiento.TabIndex = 9;
            this.gbxLugarNacimiento.TabStop = false;
            this.gbxLugarNacimiento.Text = "Lugar de Nacimiento";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.Enabled = false;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(406, 33);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(125, 21);
            this.cboDistrito.TabIndex = 13;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.Enabled = false;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(275, 33);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(122, 21);
            this.cboProvincia.TabIndex = 12;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Enabled = false;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(147, 33);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamento.TabIndex = 11;
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(403, 17);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 26;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(272, 17);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 25;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(144, 16);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 24;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(10, 33);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(125, 21);
            this.cboPais.TabIndex = 10;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(7, 17);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 22;
            this.lblPais.Text = "Pais:";
            // 
            // btnQuitarFoto
            // 
            this.btnQuitarFoto.Location = new System.Drawing.Point(695, 150);
            this.btnQuitarFoto.Name = "btnQuitarFoto";
            this.btnQuitarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFoto.TabIndex = 26;
            this.btnQuitarFoto.Text = "Quitar";
            this.btnQuitarFoto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(695, 65);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarFoto.TabIndex = 25;
            this.btnBuscarFoto.Text = "Buscar";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.Location = new System.Drawing.Point(695, 26);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnTomarFoto.TabIndex = 24;
            this.btnTomarFoto.Text = "Tomar";
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(558, 7);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(31, 13);
            this.lblFoto.TabIndex = 4;
            this.lblFoto.Text = "Foto:";
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Image = global::SistemaCentroSalud.Properties.Resources.FotoPredeterminado;
            this.pbxFoto.Location = new System.Drawing.Point(557, 26);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(132, 147);
            this.pbxFoto.TabIndex = 3;
            this.pbxFoto.TabStop = false;
            // 
            // gbxProfesional
            // 
            this.gbxProfesional.Controls.Add(this.cboPerfil);
            this.gbxProfesional.Controls.Add(this.label1);
            this.gbxProfesional.Controls.Add(this.lblEspecialidades);
            this.gbxProfesional.Controls.Add(this.clbxEspecialidades);
            this.gbxProfesional.Controls.Add(this.txtCMP);
            this.gbxProfesional.Controls.Add(this.lblCMP);
            this.gbxProfesional.Controls.Add(this.cboArea);
            this.gbxProfesional.Controls.Add(this.lblArea);
            this.gbxProfesional.Location = new System.Drawing.Point(8, 322);
            this.gbxProfesional.Name = "gbxProfesional";
            this.gbxProfesional.Size = new System.Drawing.Size(543, 137);
            this.gbxProfesional.TabIndex = 19;
            this.gbxProfesional.TabStop = false;
            this.gbxProfesional.Text = "Información Profesional";
            // 
            // cboPerfil
            // 
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(147, 83);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(153, 21);
            this.cboPerfil.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Perfil:";
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Location = new System.Drawing.Point(316, 16);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(81, 13);
            this.lblEspecialidades.TabIndex = 35;
            this.lblEspecialidades.Text = "Especialidades:";
            // 
            // clbxEspecialidades
            // 
            this.clbxEspecialidades.FormattingEnabled = true;
            this.clbxEspecialidades.Location = new System.Drawing.Point(318, 33);
            this.clbxEspecialidades.Name = "clbxEspecialidades";
            this.clbxEspecialidades.Size = new System.Drawing.Size(213, 94);
            this.clbxEspecialidades.TabIndex = 23;
            // 
            // lblCMP
            // 
            this.lblCMP.AutoSize = true;
            this.lblCMP.Location = new System.Drawing.Point(9, 16);
            this.lblCMP.Name = "lblCMP";
            this.lblCMP.Size = new System.Drawing.Size(33, 13);
            this.lblCMP.TabIndex = 8;
            this.lblCMP.Text = "CMP:";
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(147, 33);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(153, 21);
            this.cboArea.TabIndex = 21;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(144, 16);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Área:";
            // 
            // gbxPersonal
            // 
            this.gbxPersonal.Controls.Add(this.txtNumeroDocumento);
            this.gbxPersonal.Controls.Add(this.txtNombres);
            this.gbxPersonal.Controls.Add(this.txtMaterno);
            this.gbxPersonal.Controls.Add(this.txtPaterno);
            this.gbxPersonal.Controls.Add(this.cboEstadoCivil);
            this.gbxPersonal.Controls.Add(this.dtpFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.lblFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.lblEstadoCivil);
            this.gbxPersonal.Controls.Add(this.lblNumeroDocumento);
            this.gbxPersonal.Controls.Add(this.cboTipoDocumento);
            this.gbxPersonal.Controls.Add(this.lblTipoDocumento);
            this.gbxPersonal.Controls.Add(this.cboSexo);
            this.gbxPersonal.Controls.Add(this.lblSexo);
            this.gbxPersonal.Controls.Add(this.lblNombres);
            this.gbxPersonal.Controls.Add(this.lblMaterno);
            this.gbxPersonal.Controls.Add(this.lblPaterno);
            this.gbxPersonal.Location = new System.Drawing.Point(6, 6);
            this.gbxPersonal.Name = "gbxPersonal";
            this.gbxPersonal.Size = new System.Drawing.Size(545, 107);
            this.gbxPersonal.TabIndex = 0;
            this.gbxPersonal.TabStop = false;
            this.gbxPersonal.Text = "Información Personal";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "SELECCIONAR",
            "SOLTERO",
            "CASADO",
            "VIUDO",
            "DIVORCIADO"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(10, 73);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(125, 21);
            this.cboEstadoCivil.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(141, 75);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(138, 58);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 58);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 20;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(403, 59);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroDocumento.TabIndex = 16;
            this.lblNumeroDocumento.Text = "No. Documento:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(272, 74);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(125, 21);
            this.cboTipoDocumento.TabIndex = 7;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(269, 58);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 14;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "MASCULINO",
            "FEMENINO"});
            this.cboSexo.Location = new System.Drawing.Point(405, 32);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(125, 21);
            this.cboSexo.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(402, 16);
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
            // txtMaternoBuscar
            // 
            this.txtMaternoBuscar.Location = new System.Drawing.Point(160, 41);
            this.txtMaternoBuscar.Name = "txtMaternoBuscar";
            this.txtMaternoBuscar.Size = new System.Drawing.Size(124, 20);
            this.txtMaternoBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtMaternoBuscar.TabIndex = 1;
            this.txtMaternoBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtCMPBuscar
            // 
            this.txtCMPBuscar.Location = new System.Drawing.Point(10, 92);
            this.txtCMPBuscar.MaxLength = 5;
            this.txtCMPBuscar.Name = "txtCMPBuscar";
            this.txtCMPBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtCMPBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCMPBuscar.TabIndex = 3;
            this.txtCMPBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtNombresBuscar
            // 
            this.txtNombresBuscar.Location = new System.Drawing.Point(306, 41);
            this.txtNombresBuscar.MaxLength = 5;
            this.txtNombresBuscar.Name = "txtNombresBuscar";
            this.txtNombresBuscar.Size = new System.Drawing.Size(220, 20);
            this.txtNombresBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombresBuscar.TabIndex = 2;
            this.txtNombresBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtPaternoBuscar
            // 
            this.txtPaternoBuscar.Location = new System.Drawing.Point(10, 41);
            this.txtPaternoBuscar.Name = "txtPaternoBuscar";
            this.txtPaternoBuscar.Size = new System.Drawing.Size(125, 20);
            this.txtPaternoBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaternoBuscar.TabIndex = 0;
            this.txtPaternoBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(10, 115);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(195, 20);
            this.txtCorreoElectronico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCorreoElectronico.TabIndex = 30;
            this.txtCorreoElectronico.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(10, 76);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(112, 20);
            this.txtCelular.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCelular.TabIndex = 29;
            this.txtCelular.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(10, 36);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 20);
            this.txtTelefono.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(12, 83);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(521, 20);
            this.txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDireccion.TabIndex = 18;
            this.txtDireccion.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtCMP
            // 
            this.txtCMP.Location = new System.Drawing.Point(12, 33);
            this.txtCMP.MaxLength = 5;
            this.txtCMP.Name = "txtCMP";
            this.txtCMP.Size = new System.Drawing.Size(100, 20);
            this.txtCMP.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCMP.TabIndex = 20;
            this.txtCMP.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(406, 74);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(125, 20);
            this.txtNumeroDocumento.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroDocumento.TabIndex = 8;
            this.txtNumeroDocumento.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(271, 34);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(124, 20);
            this.txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtMaterno
            // 
            this.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterno.Location = new System.Drawing.Point(141, 35);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(125, 20);
            this.txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtMaterno.TabIndex = 2;
            this.txtMaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtPaterno
            // 
            this.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaterno.Location = new System.Drawing.Point(10, 36);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(125, 20);
            this.txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaterno.TabIndex = 1;
            this.txtPaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 491);
            this.Controls.Add(this.tbcDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.tbcDoctor.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctores)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.tbpDetalle.PerformLayout();
            this.gbxContacto.ResumeLayout(false);
            this.gbxContacto.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxLugarNacimiento.ResumeLayout(false);
            this.gbxLugarNacimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.gbxProfesional.ResumeLayout(false);
            this.gbxProfesional.PerformLayout();
            this.gbxPersonal.ResumeLayout(false);
            this.gbxPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDoctor;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.GroupBox gbxPersonal;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.GroupBox gbxProfesional;
        private System.Windows.Forms.Label lblCMP;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnQuitarFoto;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cboDistritoDomicilio;
        private System.Windows.Forms.ComboBox cboProvinciaDomicilio;
        private System.Windows.Forms.ComboBox cboDepartamentoDomicilio;
        private System.Windows.Forms.Label lblDistritoDomicilio;
        private System.Windows.Forms.Label lblProvinciaDomicilio;
        private System.Windows.Forms.Label lblDepartamentoDomicilio;
        private System.Windows.Forms.GroupBox gbxContacto;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvDoctores;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.GroupBox gbxLugarNacimiento;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private SistemaCentroSalud.Controles.cuTextBox txtPaterno;
        private SistemaCentroSalud.Controles.cuTextBox txtMaterno;
        private SistemaCentroSalud.Controles.cuTextBox txtNombres;
        private SistemaCentroSalud.Controles.cuTextBox txtCorreoElectronico;
        private SistemaCentroSalud.Controles.cuTextBox txtCelular;
        private SistemaCentroSalud.Controles.cuTextBox txtTelefono;
        private SistemaCentroSalud.Controles.cuTextBox txtDireccion;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroDocumento;
        private SistemaCentroSalud.Controles.cuTextBox txtCMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private SistemaCentroSalud.Controles.cuTextBox txtMaternoBuscar;
        private System.Windows.Forms.ComboBox cboEstadoBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtCMPBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtNombresBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtPaternoBuscar;
        private System.Windows.Forms.Label lblPaternoBuscar;
        private System.Windows.Forms.Label lblNombresBuscar;
        private System.Windows.Forms.Label lblMaternoBuscar;
        private System.Windows.Forms.Label lblCMPBuscar;
        private System.Windows.Forms.Label lblEspecialidadBuscar;
        private System.Windows.Forms.ComboBox cboEspecialidadBuscar;
        private System.Windows.Forms.Label lblEstadoBuscar;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.CheckedListBox clbxEspecialidades;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label label1;
    }
}