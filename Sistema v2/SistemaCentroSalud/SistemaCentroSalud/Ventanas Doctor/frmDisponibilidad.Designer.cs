namespace SistemaCentroSalud
{
    partial class frmDisponibilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisponibilidad));
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.cmbMenues = new DevComponents.DotNetBar.ContextMenuBar();
            this.biEnBlanco = new DevComponents.DotNetBar.ButtonItem();
            this.biDisponible = new DevComponents.DotNetBar.ButtonItem();
            this.biRegistro = new DevComponents.DotNetBar.ButtonItem();
            this.biEliminar = new DevComponents.DotNetBar.ButtonItem();
            this.cvCalendario = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMenues)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.SystemColors.Window;
            this.pnlIzquierdo.Controls.Add(this.pnlInferior);
            this.pnlIzquierdo.Controls.Add(this.mcCalendario);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(228, 524);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnGuardar);
            this.pnlInferior.Controls.Add(this.btnSalir);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 465);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(228, 59);
            this.pnlInferior.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(138, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mcCalendario
            // 
            this.mcCalendario.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.mcCalendario.Location = new System.Drawing.Point(0, 0);
            this.mcCalendario.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.mcCalendario.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 0;
            this.mcCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendario_DateChanged);
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDerecho.Controls.Add(this.cmbMenues);
            this.pnlDerecho.Controls.Add(this.cvCalendario);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Location = new System.Drawing.Point(228, 0);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(617, 524);
            this.pnlDerecho.TabIndex = 1;
            // 
            // cmbMenues
            // 
            this.cmbMenues.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.cmbMenues.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biEnBlanco,
            this.biRegistro});
            this.cmbMenues.Location = new System.Drawing.Point(80, 482);
            this.cmbMenues.Name = "cmbMenues";
            this.cmbMenues.Size = new System.Drawing.Size(504, 25);
            this.cmbMenues.Stretch = true;
            this.cmbMenues.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbMenues.TabIndex = 10;
            this.cmbMenues.TabStop = false;
            this.cmbMenues.Text = "contextMenuBar1";
            // 
            // biEnBlanco
            // 
            this.biEnBlanco.AutoExpandOnClick = true;
            this.biEnBlanco.Name = "biEnBlanco";
            this.biEnBlanco.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biDisponible});
            this.biEnBlanco.Text = "En Blanco";
            // 
            // biDisponible
            // 
            this.biDisponible.Name = "biDisponible";
            this.biDisponible.Text = "Disponible";
            this.biDisponible.Click += new System.EventHandler(this.biDisponible_Click);
            // 
            // biRegistro
            // 
            this.biRegistro.AutoExpandOnClick = true;
            this.biRegistro.Name = "biRegistro";
            this.biRegistro.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.biEliminar});
            this.biRegistro.Text = "Registro";
            // 
            // biEliminar
            // 
            this.biEliminar.Name = "biEliminar";
            this.biEliminar.Text = "Eliminar";
            this.biEliminar.Click += new System.EventHandler(this.biEliminar_Click);
            // 
            // cvCalendario
            // 
            // 
            // 
            // 
            this.cvCalendario.BackgroundStyle.Class = "";
            this.cvCalendario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cvCalendario.ContainerControlProcessDialogKey = true;
            this.cvCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cvCalendario.Location = new System.Drawing.Point(0, 0);
            this.cvCalendario.Name = "cvCalendario";
            this.cvCalendario.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Week;
            this.cvCalendario.Size = new System.Drawing.Size(617, 524);
            this.cvCalendario.TabIndex = 0;
            this.cvCalendario.Text = "Horario";
            this.cvCalendario.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.cvCalendario.TimeIndicator.Tag = null;
            this.cvCalendario.TimeSlotDuration = 30;
            this.cvCalendario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cvCalendario_MouseUp);
            // 
            // frmDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 524);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDisponibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disponibilidad";
            this.Load += new System.EventHandler(this.frmDisponibilidad_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDisponibilidad_FormClosing);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlInferior.ResumeLayout(false);
            this.pnlDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMenues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.MonthCalendar mcCalendario;
        private System.Windows.Forms.Panel pnlDerecho;
        private DevComponents.DotNetBar.Schedule.CalendarView cvCalendario;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private DevComponents.DotNetBar.ContextMenuBar cmbMenues;
        private DevComponents.DotNetBar.ButtonItem biEnBlanco;
        private DevComponents.DotNetBar.ButtonItem biDisponible;
        private DevComponents.DotNetBar.ButtonItem biRegistro;
        private DevComponents.DotNetBar.ButtonItem biEliminar;

    }
}