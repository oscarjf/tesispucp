namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    partial class frmPabellon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPabellon));
            this.tbcPabellon = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvPabellones = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.cboEstadoBuscar = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxInformacion = new System.Windows.Forms.GroupBox();
            this.rtxtDescripcionDetalle = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.txtNombreDetalle = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.tbcPabellon.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPabellones)).BeginInit();
            this.gbxCriterios.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.gbxInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPabellon
            // 
            this.tbcPabellon.Controls.Add(this.tbpBuscar);
            this.tbcPabellon.Controls.Add(this.tbpDetalle);
            this.tbcPabellon.Location = new System.Drawing.Point(0, 0);
            this.tbcPabellon.Name = "tbcPabellon";
            this.tbcPabellon.SelectedIndex = 0;
            this.tbcPabellon.Size = new System.Drawing.Size(467, 263);
            this.tbcPabellon.TabIndex = 1;
            this.tbcPabellon.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcPabellon_Selecting);
            this.tbcPabellon.SelectedIndexChanged += new System.EventHandler(this.tbcPabellon_SelectedIndexChanged);
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnEliminar);
            this.tbpBuscar.Controls.Add(this.btnActivar);
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnModificar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Controls.Add(this.dgvPabellones);
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
            this.btnEliminar.TabIndex = 6;
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
            this.btnActivar.TabIndex = 6;
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
            this.btnSalir.TabIndex = 7;
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
            this.btnVer.TabIndex = 4;
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
            this.btnModificar.TabIndex = 5;
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
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvPabellones
            // 
            this.dgvPabellones.AllowUserToAddRows = false;
            this.dgvPabellones.AllowUserToDeleteRows = false;
            this.dgvPabellones.AllowUserToResizeRows = false;
            this.dgvPabellones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPabellones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNombre,
            this.colEstado});
            this.dgvPabellones.Location = new System.Drawing.Point(6, 99);
            this.dgvPabellones.MultiSelect = false;
            this.dgvPabellones.Name = "dgvPabellones";
            this.dgvPabellones.ReadOnly = true;
            this.dgvPabellones.RowHeadersVisible = false;
            this.dgvPabellones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPabellones.Size = new System.Drawing.Size(443, 101);
            this.dgvPabellones.TabIndex = 2;
            this.dgvPabellones.SelectionChanged += new System.EventHandler(this.dgvPabellones_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
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
            this.gbxCriterios.Controls.Add(this.lblEstado);
            this.gbxCriterios.Controls.Add(this.txtNombreBuscar);
            this.gbxCriterios.Controls.Add(this.lblNombreBuscar);
            this.gbxCriterios.Location = new System.Drawing.Point(6, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(443, 87);
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
            this.cboEstadoBuscar.Location = new System.Drawing.Point(298, 22);
            this.cboEstadoBuscar.Name = "cboEstadoBuscar";
            this.cboEstadoBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoBuscar.TabIndex = 2;
            this.cboEstadoBuscar.SelectedIndexChanged += new System.EventHandler(this.cboEstadoBuscar_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(249, 25);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreBuscar.Location = new System.Drawing.Point(84, 22);
            this.txtNombreBuscar.MaxLength = 30;
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(133, 20);
            this.txtNombreBuscar.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombreBuscar.TabIndex = 1;
            this.txtNombreBuscar.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.txtNombreBuscar_TextChanged);
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(6, 25);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(47, 13);
            this.lblNombreBuscar.TabIndex = 0;
            this.lblNombreBuscar.Text = "Nombre:";
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
            this.btnGuardar.TabIndex = 3;
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
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxInformacion
            // 
            this.gbxInformacion.Controls.Add(this.rtxtDescripcionDetalle);
            this.gbxInformacion.Controls.Add(this.lblDescripcionDetalle);
            this.gbxInformacion.Controls.Add(this.txtNombreDetalle);
            this.gbxInformacion.Controls.Add(this.lblNombreDetalle);
            this.gbxInformacion.Location = new System.Drawing.Point(8, 6);
            this.gbxInformacion.Name = "gbxInformacion";
            this.gbxInformacion.Size = new System.Drawing.Size(441, 187);
            this.gbxInformacion.TabIndex = 0;
            this.gbxInformacion.TabStop = false;
            this.gbxInformacion.Text = "Información";
            // 
            // rtxtDescripcionDetalle
            // 
            this.rtxtDescripcionDetalle.Location = new System.Drawing.Point(9, 81);
            this.rtxtDescripcionDetalle.MaxLength = 200;
            this.rtxtDescripcionDetalle.Name = "rtxtDescripcionDetalle";
            this.rtxtDescripcionDetalle.Size = new System.Drawing.Size(426, 96);
            this.rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtDescripcionDetalle.TabIndex = 2;
            this.rtxtDescripcionDetalle.Text = "";
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.AutoSize = true;
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(6, 65);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionDetalle.TabIndex = 4;
            this.lblDescripcionDetalle.Text = "Descripción:";
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDetalle.Location = new System.Drawing.Point(9, 32);
            this.txtNombreDetalle.MaxLength = 30;
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.Size = new System.Drawing.Size(139, 20);
            this.txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombreDetalle.TabIndex = 1;
            this.txtNombreDetalle.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.AutoSize = true;
            this.lblNombreDetalle.Location = new System.Drawing.Point(6, 16);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDetalle.TabIndex = 0;
            this.lblNombreDetalle.Text = "Nombre:";
            // 
            // frmPabellon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.tbcPabellon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPabellon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pabellón";
            this.Load += new System.EventHandler(this.frmPabellon_Load);
            this.tbcPabellon.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPabellones)).EndInit();
            this.gbxCriterios.ResumeLayout(false);
            this.gbxCriterios.PerformLayout();
            this.tbpDetalle.ResumeLayout(false);
            this.gbxInformacion.ResumeLayout(false);
            this.gbxInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPabellon;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvPabellones;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.ComboBox cboEstadoBuscar;
        private System.Windows.Forms.Label lblEstado;
        private SistemaCentroSalud.Controles.cuTextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxInformacion;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtDescripcionDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private SistemaCentroSalud.Controles.cuTextBox txtNombreDetalle;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}