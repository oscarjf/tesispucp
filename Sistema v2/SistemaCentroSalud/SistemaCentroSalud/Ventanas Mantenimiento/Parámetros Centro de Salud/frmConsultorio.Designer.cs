namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    partial class frmConsultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultorio));
            this.tbcConsultorio = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvConsultorios = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPabellon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.txtNumeroBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNumeroBuscar = new System.Windows.Forms.Label();
            this.cboEstadoBuscar = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboPabellonBuscar = new System.Windows.Forms.ComboBox();
            this.lblPabellonBuscar = new System.Windows.Forms.Label();
            this.txtPisoBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblPisoBuscar = new System.Windows.Forms.Label();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxInformacion = new System.Windows.Forms.GroupBox();
            this.txtNumeroDetalle = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNumeroDetalle = new System.Windows.Forms.Label();
            this.cboPabellonDetalle = new System.Windows.Forms.ComboBox();
            this.lblPabellonDetalle = new System.Windows.Forms.Label();
            this.txtPisoDetalle = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblPisoDetalle = new System.Windows.Forms.Label();
            this.tbcConsultorio.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorios)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.gbxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcConsultorio
            // 
            this.tbcConsultorio.Controls.Add(this.tbpBuscar);
            this.tbcConsultorio.Controls.Add(this.tbpDetalle);
            this.tbcConsultorio.Location = new System.Drawing.Point(0, 0);
            this.tbcConsultorio.Name = "tbcConsultorio";
            this.tbcConsultorio.SelectedIndex = 0;
            this.tbcConsultorio.Size = new System.Drawing.Size(467, 263);
            this.tbcConsultorio.TabIndex = 1;
            this.tbcConsultorio.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcConsultorio_Selecting);
            this.tbcConsultorio.SelectedIndexChanged += new System.EventHandler(this.tbcConsultorio_SelectedIndexChanged);
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnEliminar);
            this.tbpBuscar.Controls.Add(this.btnActivar);
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnModificar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Controls.Add(this.dgvConsultorios);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(459, 237);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(279, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.Location = new System.Drawing.Point(279, 206);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 8;
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Visible = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(376, 206);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 206);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(190, 206);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 206);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvConsultorios
            // 
            this.dgvConsultorios.AllowUserToAddRows = false;
            this.dgvConsultorios.AllowUserToDeleteRows = false;
            this.dgvConsultorios.AllowUserToResizeRows = false;
            this.dgvConsultorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.colPabellon,
            this.ColPiso,
            this.ColNumero,
            this.colEstado});
            this.dgvConsultorios.Location = new System.Drawing.Point(6, 99);
            this.dgvConsultorios.MultiSelect = false;
            this.dgvConsultorios.Name = "dgvConsultorios";
            this.dgvConsultorios.ReadOnly = true;
            this.dgvConsultorios.RowHeadersVisible = false;
            this.dgvConsultorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultorios.Size = new System.Drawing.Size(443, 101);
            this.dgvConsultorios.TabIndex = 2;
            this.dgvConsultorios.SelectionChanged += new System.EventHandler(this.dgvConsultorios_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // colPabellon
            // 
            this.colPabellon.HeaderText = "Pabellón";
            this.colPabellon.Name = "colPabellon";
            this.colPabellon.ReadOnly = true;
            // 
            // ColPiso
            // 
            this.ColPiso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPiso.HeaderText = "Piso";
            this.ColPiso.Name = "ColPiso";
            this.ColPiso.ReadOnly = true;
            // 
            // ColNumero
            // 
            this.ColNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNumero.HeaderText = "Número";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
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
            this.gbxCriterios.Controls.Add(this.txtNumeroBuscar);
            this.gbxCriterios.Controls.Add(this.lblNumeroBuscar);
            this.gbxCriterios.Controls.Add(this.cboEstadoBuscar);
            this.gbxCriterios.Controls.Add(this.lblEstado);
            this.gbxCriterios.Controls.Add(this.cboPabellonBuscar);
            this.gbxCriterios.Controls.Add(this.lblPabellonBuscar);
            this.gbxCriterios.Controls.Add(this.txtPisoBuscar);
            this.gbxCriterios.Controls.Add(this.lblPisoBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(6, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(443, 87);
            this.gbxCriterios.TabIndex = 0;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // txtNumeroBuscar
            // 
            this.txtNumeroBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroBuscar.Location = new System.Drawing.Point(84, 52);
            this.txtNumeroBuscar.MaxLength = 10;
            this.txtNumeroBuscar.Name = "txtNumeroBuscar";
            this.txtNumeroBuscar.Size = new System.Drawing.Size(133, 20);
            this.txtNumeroBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroBuscar.TabIndex = 2;
            this.txtNumeroBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            this.txtNumeroBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblNumeroBuscar
            // 
            this.lblNumeroBuscar.AutoSize = true;
            this.lblNumeroBuscar.Location = new System.Drawing.Point(10, 55);
            this.lblNumeroBuscar.Name = "lblNumeroBuscar";
            this.lblNumeroBuscar.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroBuscar.TabIndex = 5;
            this.lblNumeroBuscar.Text = "Número:";
            // 
            // cboEstadoBuscar
            // 
            this.cboEstadoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoBuscar.FormattingEnabled = true;
            this.cboEstadoBuscar.Items.AddRange(new object[] {
            "TODOS",
            "ACTIVO",
            "INACTIVO"});
            this.cboEstadoBuscar.Location = new System.Drawing.Point(298, 52);
            this.cboEstadoBuscar.Name = "cboEstadoBuscar";
            this.cboEstadoBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoBuscar.TabIndex = 4;
            this.cboEstadoBuscar.SelectedIndexChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(249, 55);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // cboPabellonBuscar
            // 
            this.cboPabellonBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPabellonBuscar.FormattingEnabled = true;
            this.cboPabellonBuscar.Location = new System.Drawing.Point(84, 22);
            this.cboPabellonBuscar.Name = "cboPabellonBuscar";
            this.cboPabellonBuscar.Size = new System.Drawing.Size(133, 21);
            this.cboPabellonBuscar.TabIndex = 3;
            this.cboPabellonBuscar.SelectedIndexChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblPabellonBuscar
            // 
            this.lblPabellonBuscar.AutoSize = true;
            this.lblPabellonBuscar.Location = new System.Drawing.Point(6, 25);
            this.lblPabellonBuscar.Name = "lblPabellonBuscar";
            this.lblPabellonBuscar.Size = new System.Drawing.Size(51, 13);
            this.lblPabellonBuscar.TabIndex = 2;
            this.lblPabellonBuscar.Text = "Pabellón:";
            // 
            // txtPisoBuscar
            // 
            this.txtPisoBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPisoBuscar.Location = new System.Drawing.Point(298, 22);
            this.txtPisoBuscar.MaxLength = 4;
            this.txtPisoBuscar.Name = "txtPisoBuscar";
            this.txtPisoBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtPisoBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPisoBuscar.TabIndex = 1;
            this.txtPisoBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            this.txtPisoBuscar.TextChanged += new System.EventHandler(this.buscarCriterios);
            // 
            // lblPisoBuscar
            // 
            this.lblPisoBuscar.AutoSize = true;
            this.lblPisoBuscar.Location = new System.Drawing.Point(249, 25);
            this.lblPisoBuscar.Name = "lblPisoBuscar";
            this.lblPisoBuscar.Size = new System.Drawing.Size(30, 13);
            this.lblPisoBuscar.TabIndex = 0;
            this.lblPisoBuscar.Text = "Piso:";
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.btnGuardar);
            this.tbpDetalle.Controls.Add(this.btnCancelar);
            this.tbpDetalle.Controls.Add(this.gbxInformacion);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(459, 237);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(374, 203);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(287, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxInformacion
            // 
            this.gbxInformacion.Controls.Add(this.txtNumeroDetalle);
            this.gbxInformacion.Controls.Add(this.lblNumeroDetalle);
            this.gbxInformacion.Controls.Add(this.cboPabellonDetalle);
            this.gbxInformacion.Controls.Add(this.lblPabellonDetalle);
            this.gbxInformacion.Controls.Add(this.txtPisoDetalle);
            this.gbxInformacion.Controls.Add(this.lblPisoDetalle);
            this.gbxInformacion.Location = new System.Drawing.Point(8, 6);
            this.gbxInformacion.Name = "gbxInformacion";
            this.gbxInformacion.Size = new System.Drawing.Size(441, 187);
            this.gbxInformacion.TabIndex = 0;
            this.gbxInformacion.TabStop = false;
            this.gbxInformacion.Text = "Información";
            // 
            // txtNumeroDetalle
            // 
            this.txtNumeroDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroDetalle.Location = new System.Drawing.Point(13, 90);
            this.txtNumeroDetalle.MaxLength = 10;
            this.txtNumeroDetalle.Name = "txtNumeroDetalle";
            this.txtNumeroDetalle.Size = new System.Drawing.Size(139, 20);
            this.txtNumeroDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroDetalle.TabIndex = 2;
            this.txtNumeroDetalle.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // lblNumeroDetalle
            // 
            this.lblNumeroDetalle.AutoSize = true;
            this.lblNumeroDetalle.Location = new System.Drawing.Point(10, 74);
            this.lblNumeroDetalle.Name = "lblNumeroDetalle";
            this.lblNumeroDetalle.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroDetalle.TabIndex = 4;
            this.lblNumeroDetalle.Text = "Número:";
            // 
            // cboPabellonDetalle
            // 
            this.cboPabellonDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPabellonDetalle.FormattingEnabled = true;
            this.cboPabellonDetalle.Location = new System.Drawing.Point(9, 32);
            this.cboPabellonDetalle.Name = "cboPabellonDetalle";
            this.cboPabellonDetalle.Size = new System.Drawing.Size(156, 21);
            this.cboPabellonDetalle.TabIndex = 3;
            // 
            // lblPabellonDetalle
            // 
            this.lblPabellonDetalle.AutoSize = true;
            this.lblPabellonDetalle.Location = new System.Drawing.Point(6, 16);
            this.lblPabellonDetalle.Name = "lblPabellonDetalle";
            this.lblPabellonDetalle.Size = new System.Drawing.Size(51, 13);
            this.lblPabellonDetalle.TabIndex = 2;
            this.lblPabellonDetalle.Text = "Pabellón:";
            // 
            // txtPisoDetalle
            // 
            this.txtPisoDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPisoDetalle.Location = new System.Drawing.Point(217, 32);
            this.txtPisoDetalle.MaxLength = 4;
            this.txtPisoDetalle.Name = "txtPisoDetalle";
            this.txtPisoDetalle.Size = new System.Drawing.Size(156, 20);
            this.txtPisoDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPisoDetalle.TabIndex = 1;
            this.txtPisoDetalle.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // lblPisoDetalle
            // 
            this.lblPisoDetalle.AutoSize = true;
            this.lblPisoDetalle.Location = new System.Drawing.Point(214, 16);
            this.lblPisoDetalle.Name = "lblPisoDetalle";
            this.lblPisoDetalle.Size = new System.Drawing.Size(30, 13);
            this.lblPisoDetalle.TabIndex = 0;
            this.lblPisoDetalle.Text = "Piso:";
            // 
            // frmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 262);
            this.Controls.Add(this.tbcConsultorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio";
            this.Load += new System.EventHandler(this.frmConsultorio_Load);
            this.tbcConsultorio.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultorios)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.gbxInformacion.ResumeLayout(false);
            this.gbxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcConsultorio;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvConsultorios;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.ComboBox cboEstadoBuscar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboPabellonBuscar;
        private System.Windows.Forms.Label lblPabellonBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtPisoBuscar;
        private System.Windows.Forms.Label lblPisoBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxInformacion;
        private System.Windows.Forms.Label lblNumeroDetalle;
        private System.Windows.Forms.ComboBox cboPabellonDetalle;
        private System.Windows.Forms.Label lblPabellonDetalle;
        private SistemaCentroSalud.Controles.cuTextBox txtPisoDetalle;
        private System.Windows.Forms.Label lblPisoDetalle;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroBuscar;
        private System.Windows.Forms.Label lblNumeroBuscar;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPabellon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}