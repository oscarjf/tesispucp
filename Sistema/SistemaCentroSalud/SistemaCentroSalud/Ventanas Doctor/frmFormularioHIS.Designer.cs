namespace SistemaCentroSalud
{
    partial class frmFormularioHIS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormularioHIS));
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.gbxDatosFormulario = new System.Windows.Forms.GroupBox();
            this.gbxServicio = new System.Windows.Forms.GroupBox();
            this.rbtnServicioR = new System.Windows.Forms.RadioButton();
            this.rbtnServicioC = new System.Windows.Forms.RadioButton();
            this.rbtnServicioN = new System.Windows.Forms.RadioButton();
            this.gbxEstablecimiento = new System.Windows.Forms.GroupBox();
            this.rbtnEstablecimientoR = new System.Windows.Forms.RadioButton();
            this.rbtnEstablecimientoC = new System.Windows.Forms.RadioButton();
            this.rbtnEstablecimientoN = new System.Windows.Forms.RadioButton();
            this.gbxTipoDiagnostico = new System.Windows.Forms.GroupBox();
            this.rbtnDiagnosticoR = new System.Windows.Forms.RadioButton();
            this.rbtnDiagnosticoD = new System.Windows.Forms.RadioButton();
            this.rbtnDiagnosticoP = new System.Windows.Forms.RadioButton();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.cboDistritoProcedencia = new System.Windows.Forms.ComboBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDistritoProcedencia = new System.Windows.Forms.Label();
            this.lblNumeroHistoriaClinica = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.ttpInformacion = new System.Windows.Forms.ToolTip(this.components);
            this.txtDiagnostico = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtEdad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNumeroHistoriaClinica = new SistemaCentroSalud.Controles.cuTextBox();
            this.gbxDatosFormulario.SuspendLayout();
            this.gbxServicio.SuspendLayout();
            this.gbxEstablecimiento.SuspendLayout();
            this.gbxTipoDiagnostico.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrimero
            // 
            this.btnPrimero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Location = new System.Drawing.Point(251, 323);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(37, 35);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(294, 323);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(37, 35);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(380, 323);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(37, 35);
            this.btnUltimo.TabIndex = 2;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(337, 323);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(37, 35);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // gbxDatosFormulario
            // 
            this.gbxDatosFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatosFormulario.Controls.Add(this.gbxServicio);
            this.gbxDatosFormulario.Controls.Add(this.gbxEstablecimiento);
            this.gbxDatosFormulario.Controls.Add(this.gbxTipoDiagnostico);
            this.gbxDatosFormulario.Controls.Add(this.txtDiagnostico);
            this.gbxDatosFormulario.Controls.Add(this.cboSexo);
            this.gbxDatosFormulario.Controls.Add(this.txtEdad);
            this.gbxDatosFormulario.Controls.Add(this.cboDistritoProcedencia);
            this.gbxDatosFormulario.Controls.Add(this.txtNumeroHistoriaClinica);
            this.gbxDatosFormulario.Controls.Add(this.lblDiagnostico);
            this.gbxDatosFormulario.Controls.Add(this.lblSexo);
            this.gbxDatosFormulario.Controls.Add(this.lblEdad);
            this.gbxDatosFormulario.Controls.Add(this.lblDistritoProcedencia);
            this.gbxDatosFormulario.Controls.Add(this.lblNumeroHistoriaClinica);
            this.gbxDatosFormulario.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosFormulario.Name = "gbxDatosFormulario";
            this.gbxDatosFormulario.Size = new System.Drawing.Size(699, 305);
            this.gbxDatosFormulario.TabIndex = 4;
            this.gbxDatosFormulario.TabStop = false;
            this.gbxDatosFormulario.Text = "Datos Formulario";
            // 
            // gbxServicio
            // 
            this.gbxServicio.Controls.Add(this.rbtnServicioR);
            this.gbxServicio.Controls.Add(this.rbtnServicioC);
            this.gbxServicio.Controls.Add(this.rbtnServicioN);
            this.gbxServicio.Location = new System.Drawing.Point(459, 169);
            this.gbxServicio.Name = "gbxServicio";
            this.gbxServicio.Size = new System.Drawing.Size(200, 100);
            this.gbxServicio.TabIndex = 12;
            this.gbxServicio.TabStop = false;
            this.gbxServicio.Text = "Servicio";
            // 
            // rbtnServicioR
            // 
            this.rbtnServicioR.AutoSize = true;
            this.rbtnServicioR.Location = new System.Drawing.Point(17, 69);
            this.rbtnServicioR.Name = "rbtnServicioR";
            this.rbtnServicioR.Size = new System.Drawing.Size(90, 17);
            this.rbtnServicioR.TabIndex = 5;
            this.rbtnServicioR.TabStop = true;
            this.rbtnServicioR.Text = "R (Reingreso)";
            this.rbtnServicioR.UseVisualStyleBackColor = true;
            // 
            // rbtnServicioC
            // 
            this.rbtnServicioC.AutoSize = true;
            this.rbtnServicioC.Location = new System.Drawing.Point(17, 46);
            this.rbtnServicioC.Name = "rbtnServicioC";
            this.rbtnServicioC.Size = new System.Drawing.Size(98, 17);
            this.rbtnServicioC.TabIndex = 4;
            this.rbtnServicioC.TabStop = true;
            this.rbtnServicioC.Text = "C (Continuador)";
            this.rbtnServicioC.UseVisualStyleBackColor = true;
            // 
            // rbtnServicioN
            // 
            this.rbtnServicioN.AutoSize = true;
            this.rbtnServicioN.Location = new System.Drawing.Point(17, 23);
            this.rbtnServicioN.Name = "rbtnServicioN";
            this.rbtnServicioN.Size = new System.Drawing.Size(74, 17);
            this.rbtnServicioN.TabIndex = 3;
            this.rbtnServicioN.TabStop = true;
            this.rbtnServicioN.Text = "N (Nuevo)";
            this.rbtnServicioN.UseVisualStyleBackColor = true;
            // 
            // gbxEstablecimiento
            // 
            this.gbxEstablecimiento.Controls.Add(this.rbtnEstablecimientoR);
            this.gbxEstablecimiento.Controls.Add(this.rbtnEstablecimientoC);
            this.gbxEstablecimiento.Controls.Add(this.rbtnEstablecimientoN);
            this.gbxEstablecimiento.Location = new System.Drawing.Point(239, 169);
            this.gbxEstablecimiento.Name = "gbxEstablecimiento";
            this.gbxEstablecimiento.Size = new System.Drawing.Size(200, 100);
            this.gbxEstablecimiento.TabIndex = 11;
            this.gbxEstablecimiento.TabStop = false;
            this.gbxEstablecimiento.Text = "Establecimiento";
            // 
            // rbtnEstablecimientoR
            // 
            this.rbtnEstablecimientoR.AutoSize = true;
            this.rbtnEstablecimientoR.Location = new System.Drawing.Point(17, 69);
            this.rbtnEstablecimientoR.Name = "rbtnEstablecimientoR";
            this.rbtnEstablecimientoR.Size = new System.Drawing.Size(90, 17);
            this.rbtnEstablecimientoR.TabIndex = 5;
            this.rbtnEstablecimientoR.TabStop = true;
            this.rbtnEstablecimientoR.Text = "R (Reingreso)";
            this.rbtnEstablecimientoR.UseVisualStyleBackColor = true;
            // 
            // rbtnEstablecimientoC
            // 
            this.rbtnEstablecimientoC.AutoSize = true;
            this.rbtnEstablecimientoC.Location = new System.Drawing.Point(17, 46);
            this.rbtnEstablecimientoC.Name = "rbtnEstablecimientoC";
            this.rbtnEstablecimientoC.Size = new System.Drawing.Size(98, 17);
            this.rbtnEstablecimientoC.TabIndex = 4;
            this.rbtnEstablecimientoC.TabStop = true;
            this.rbtnEstablecimientoC.Text = "C (Continuador)";
            this.rbtnEstablecimientoC.UseVisualStyleBackColor = true;
            // 
            // rbtnEstablecimientoN
            // 
            this.rbtnEstablecimientoN.AutoSize = true;
            this.rbtnEstablecimientoN.Location = new System.Drawing.Point(17, 23);
            this.rbtnEstablecimientoN.Name = "rbtnEstablecimientoN";
            this.rbtnEstablecimientoN.Size = new System.Drawing.Size(74, 17);
            this.rbtnEstablecimientoN.TabIndex = 3;
            this.rbtnEstablecimientoN.TabStop = true;
            this.rbtnEstablecimientoN.Text = "N (Nuevo)";
            this.rbtnEstablecimientoN.UseVisualStyleBackColor = true;
            // 
            // gbxTipoDiagnostico
            // 
            this.gbxTipoDiagnostico.Controls.Add(this.rbtnDiagnosticoR);
            this.gbxTipoDiagnostico.Controls.Add(this.rbtnDiagnosticoD);
            this.gbxTipoDiagnostico.Controls.Add(this.rbtnDiagnosticoP);
            this.gbxTipoDiagnostico.Location = new System.Drawing.Point(19, 169);
            this.gbxTipoDiagnostico.Name = "gbxTipoDiagnostico";
            this.gbxTipoDiagnostico.Size = new System.Drawing.Size(200, 100);
            this.gbxTipoDiagnostico.TabIndex = 10;
            this.gbxTipoDiagnostico.TabStop = false;
            this.gbxTipoDiagnostico.Text = "Tipo de Diagnóstico";
            // 
            // rbtnDiagnosticoR
            // 
            this.rbtnDiagnosticoR.AutoSize = true;
            this.rbtnDiagnosticoR.Location = new System.Drawing.Point(17, 69);
            this.rbtnDiagnosticoR.Name = "rbtnDiagnosticoR";
            this.rbtnDiagnosticoR.Size = new System.Drawing.Size(85, 17);
            this.rbtnDiagnosticoR.TabIndex = 2;
            this.rbtnDiagnosticoR.TabStop = true;
            this.rbtnDiagnosticoR.Text = "R (Repetido)";
            this.rbtnDiagnosticoR.UseVisualStyleBackColor = true;
            // 
            // rbtnDiagnosticoD
            // 
            this.rbtnDiagnosticoD.AutoSize = true;
            this.rbtnDiagnosticoD.Location = new System.Drawing.Point(17, 46);
            this.rbtnDiagnosticoD.Name = "rbtnDiagnosticoD";
            this.rbtnDiagnosticoD.Size = new System.Drawing.Size(86, 17);
            this.rbtnDiagnosticoD.TabIndex = 1;
            this.rbtnDiagnosticoD.TabStop = true;
            this.rbtnDiagnosticoD.Text = "D (Definitivo)";
            this.rbtnDiagnosticoD.UseVisualStyleBackColor = true;
            // 
            // rbtnDiagnosticoP
            // 
            this.rbtnDiagnosticoP.AutoSize = true;
            this.rbtnDiagnosticoP.Location = new System.Drawing.Point(17, 23);
            this.rbtnDiagnosticoP.Name = "rbtnDiagnosticoP";
            this.rbtnDiagnosticoP.Size = new System.Drawing.Size(91, 17);
            this.rbtnDiagnosticoP.TabIndex = 0;
            this.rbtnDiagnosticoP.TabStop = true;
            this.rbtnDiagnosticoP.Text = "P (Presuntivo)";
            this.rbtnDiagnosticoP.UseVisualStyleBackColor = true;
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "MASCULINO",
            "FEMENINO"});
            this.cboSexo.Location = new System.Drawing.Point(158, 102);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(118, 21);
            this.cboSexo.TabIndex = 8;
            this.cboSexo.SelectedIndexChanged += new System.EventHandler(this.cboSexo_SelectedIndexChanged);
            // 
            // cboDistritoProcedencia
            // 
            this.cboDistritoProcedencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistritoProcedencia.FormattingEnabled = true;
            this.cboDistritoProcedencia.Location = new System.Drawing.Point(158, 49);
            this.cboDistritoProcedencia.Name = "cboDistritoProcedencia";
            this.cboDistritoProcedencia.Size = new System.Drawing.Size(161, 21);
            this.cboDistritoProcedencia.TabIndex = 6;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(16, 132);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblDiagnostico.TabIndex = 4;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(15, 105);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(15, 79);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDistritoProcedencia
            // 
            this.lblDistritoProcedencia.AutoSize = true;
            this.lblDistritoProcedencia.Location = new System.Drawing.Point(16, 52);
            this.lblDistritoProcedencia.Name = "lblDistritoProcedencia";
            this.lblDistritoProcedencia.Size = new System.Drawing.Size(120, 13);
            this.lblDistritoProcedencia.TabIndex = 1;
            this.lblDistritoProcedencia.Text = "Distrito de Procedencia:";
            // 
            // lblNumeroHistoriaClinica
            // 
            this.lblNumeroHistoriaClinica.AutoSize = true;
            this.lblNumeroHistoriaClinica.Location = new System.Drawing.Point(16, 25);
            this.lblNumeroHistoriaClinica.Name = "lblNumeroHistoriaClinica";
            this.lblNumeroHistoriaClinica.Size = new System.Drawing.Size(136, 13);
            this.lblNumeroHistoriaClinica.TabIndex = 0;
            this.lblNumeroHistoriaClinica.Text = "Número de Historia Clínica:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(636, 329);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 35;
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
            this.btnCancelar.Location = new System.Drawing.Point(520, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.Location = new System.Drawing.Point(12, 329);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 37;
            this.btnImportar.Text = "Importar";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiagnostico.Location = new System.Drawing.Point(158, 129);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(425, 20);
            this.txtDiagnostico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDiagnostico.TabIndex = 9;
            this.txtDiagnostico.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(158, 76);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(40, 20);
            this.txtEdad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtEdad.TabIndex = 7;
            this.txtEdad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // txtNumeroHistoriaClinica
            // 
            this.txtNumeroHistoriaClinica.Location = new System.Drawing.Point(158, 22);
            this.txtNumeroHistoriaClinica.Name = "txtNumeroHistoriaClinica";
            this.txtNumeroHistoriaClinica.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroHistoriaClinica.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNumeroHistoriaClinica.TabIndex = 5;
            this.txtNumeroHistoriaClinica.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // frmFormularioHIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 370);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxDatosFormulario);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFormularioHIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario HIS";
            this.Load += new System.EventHandler(this.frmFormularioHIS_Load);
            this.gbxDatosFormulario.ResumeLayout(false);
            this.gbxDatosFormulario.PerformLayout();
            this.gbxServicio.ResumeLayout(false);
            this.gbxServicio.PerformLayout();
            this.gbxEstablecimiento.ResumeLayout(false);
            this.gbxEstablecimiento.PerformLayout();
            this.gbxTipoDiagnostico.ResumeLayout(false);
            this.gbxTipoDiagnostico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox gbxDatosFormulario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImportar;
        private SistemaCentroSalud.Controles.cuTextBox txtDiagnostico;
        private System.Windows.Forms.ComboBox cboSexo;
        private SistemaCentroSalud.Controles.cuTextBox txtEdad;
        private System.Windows.Forms.ComboBox cboDistritoProcedencia;
        private SistemaCentroSalud.Controles.cuTextBox txtNumeroHistoriaClinica;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDistritoProcedencia;
        private System.Windows.Forms.Label lblNumeroHistoriaClinica;
        private System.Windows.Forms.GroupBox gbxServicio;
        private System.Windows.Forms.RadioButton rbtnServicioR;
        private System.Windows.Forms.RadioButton rbtnServicioC;
        private System.Windows.Forms.RadioButton rbtnServicioN;
        private System.Windows.Forms.GroupBox gbxEstablecimiento;
        private System.Windows.Forms.RadioButton rbtnEstablecimientoR;
        private System.Windows.Forms.RadioButton rbtnEstablecimientoC;
        private System.Windows.Forms.RadioButton rbtnEstablecimientoN;
        private System.Windows.Forms.GroupBox gbxTipoDiagnostico;
        private System.Windows.Forms.RadioButton rbtnDiagnosticoR;
        private System.Windows.Forms.RadioButton rbtnDiagnosticoD;
        private System.Windows.Forms.RadioButton rbtnDiagnosticoP;
        private System.Windows.Forms.ToolTip ttpInformacion;
    }
}