namespace SistemaCentroSalud
{
    partial class frmCambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContrasena));
            this.lblIngresarContrasena = new System.Windows.Forms.Label();
            this.gbxAcceso = new System.Windows.Forms.GroupBox();
            this.pbxIncorrecto = new System.Windows.Forms.PictureBox();
            this.pbxCorrecto = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtRepetirContrasena = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNuevaContrasena = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblRepetirContrasena = new System.Windows.Forms.Label();
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIngresarContrasena = new SistemaCentroSalud.Controles.cuTextBox();
            this.gbxAcceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIncorrecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorrecto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngresarContrasena
            // 
            this.lblIngresarContrasena.AutoSize = true;
            this.lblIngresarContrasena.Location = new System.Drawing.Point(42, 13);
            this.lblIngresarContrasena.Name = "lblIngresarContrasena";
            this.lblIngresarContrasena.Size = new System.Drawing.Size(101, 13);
            this.lblIngresarContrasena.TabIndex = 0;
            this.lblIngresarContrasena.Text = "Ingrese contraseña:";
            // 
            // gbxAcceso
            // 
            this.gbxAcceso.Controls.Add(this.pbxIncorrecto);
            this.gbxAcceso.Controls.Add(this.pbxCorrecto);
            this.gbxAcceso.Controls.Add(this.txtUsuario);
            this.gbxAcceso.Controls.Add(this.lblUsuario);
            this.gbxAcceso.Controls.Add(this.txtRepetirContrasena);
            this.gbxAcceso.Controls.Add(this.txtNuevaContrasena);
            this.gbxAcceso.Controls.Add(this.lblRepetirContrasena);
            this.gbxAcceso.Controls.Add(this.lblNuevaContrasena);
            this.gbxAcceso.Enabled = false;
            this.gbxAcceso.Location = new System.Drawing.Point(12, 36);
            this.gbxAcceso.Name = "gbxAcceso";
            this.gbxAcceso.Size = new System.Drawing.Size(322, 161);
            this.gbxAcceso.TabIndex = 2;
            this.gbxAcceso.TabStop = false;
            this.gbxAcceso.Text = "Acceso";
            // 
            // pbxIncorrecto
            // 
            this.pbxIncorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbxIncorrecto.Image")));
            this.pbxIncorrecto.Location = new System.Drawing.Point(273, 31);
            this.pbxIncorrecto.Name = "pbxIncorrecto";
            this.pbxIncorrecto.Size = new System.Drawing.Size(16, 18);
            this.pbxIncorrecto.TabIndex = 17;
            this.pbxIncorrecto.TabStop = false;
            this.pbxIncorrecto.Tag = "";
            this.pbxIncorrecto.Visible = false;
            // 
            // pbxCorrecto
            // 
            this.pbxCorrecto.Image = ((System.Drawing.Image)(resources.GetObject("pbxCorrecto.Image")));
            this.pbxCorrecto.Location = new System.Drawing.Point(273, 29);
            this.pbxCorrecto.Name = "pbxCorrecto";
            this.pbxCorrecto.Size = new System.Drawing.Size(16, 18);
            this.pbxCorrecto.TabIndex = 16;
            this.pbxCorrecto.TabStop = false;
            this.pbxCorrecto.Tag = "";
            this.pbxCorrecto.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(137, 28);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 20);
            this.txtUsuario.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Nombre de Usuario:";
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.Location = new System.Drawing.Point(137, 116);
            this.txtRepetirContrasena.MaxLength = 60;
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.PasswordChar = '*';
            this.txtRepetirContrasena.Size = new System.Drawing.Size(130, 20);
            this.txtRepetirContrasena.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtRepetirContrasena.TabIndex = 5;
            this.txtRepetirContrasena.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(137, 71);
            this.txtNuevaContrasena.MaxLength = 60;
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(130, 20);
            this.txtNuevaContrasena.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNuevaContrasena.TabIndex = 4;
            this.txtNuevaContrasena.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // lblRepetirContrasena
            // 
            this.lblRepetirContrasena.AutoSize = true;
            this.lblRepetirContrasena.Location = new System.Drawing.Point(32, 119);
            this.lblRepetirContrasena.Name = "lblRepetirContrasena";
            this.lblRepetirContrasena.Size = new System.Drawing.Size(98, 13);
            this.lblRepetirContrasena.TabIndex = 1;
            this.lblRepetirContrasena.Text = "Repita Contraseña:";
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Location = new System.Drawing.Point(32, 74);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(99, 13);
            this.lblNuevaContrasena.TabIndex = 0;
            this.lblNuevaContrasena.Text = "Nueva Contraseña:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(246, 203);
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
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(130, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIngresarContrasena
            // 
            this.txtIngresarContrasena.Location = new System.Drawing.Point(149, 10);
            this.txtIngresarContrasena.MaxLength = 60;
            this.txtIngresarContrasena.Name = "txtIngresarContrasena";
            this.txtIngresarContrasena.PasswordChar = '*';
            this.txtIngresarContrasena.Size = new System.Drawing.Size(130, 20);
            this.txtIngresarContrasena.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtIngresarContrasena.TabIndex = 1;
            this.txtIngresarContrasena.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            this.txtIngresarContrasena.TextChanged += new System.EventHandler(this.txtIngresarContrasena_TextChanged);
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 232);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxAcceso);
            this.Controls.Add(this.txtIngresarContrasena);
            this.Controls.Add(this.lblIngresarContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contrasena";
            this.gbxAcceso.ResumeLayout(false);
            this.gbxAcceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIncorrecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorrecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarContrasena;
        private SistemaCentroSalud.Controles.cuTextBox txtIngresarContrasena;
        private System.Windows.Forms.GroupBox gbxAcceso;
        private System.Windows.Forms.Label lblNuevaContrasena;
        private SistemaCentroSalud.Controles.cuTextBox txtRepetirContrasena;
        private SistemaCentroSalud.Controles.cuTextBox txtNuevaContrasena;
        private System.Windows.Forms.Label lblRepetirContrasena;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private SistemaCentroSalud.Controles.cuTextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pbxIncorrecto;
        private System.Windows.Forms.PictureBox pbxCorrecto;
    }
}