namespace SistemaCentroSalud
{
    partial class frmConfigurar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurar));
            this.gbxSistema = new System.Windows.Forms.GroupBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblContrasenaSeguridad = new System.Windows.Forms.Label();
            this.txtContrasenaSeguridad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtContrasena = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtUsuario = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtBaseDatos = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtServidor = new SistemaCentroSalud.Controles.cuTextBox();
            this.gbxSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSistema
            // 
            this.gbxSistema.Controls.Add(this.txtContrasena);
            this.gbxSistema.Controls.Add(this.txtUsuario);
            this.gbxSistema.Controls.Add(this.txtBaseDatos);
            this.gbxSistema.Controls.Add(this.txtServidor);
            this.gbxSistema.Controls.Add(this.lblContrasena);
            this.gbxSistema.Controls.Add(this.lblUsuario);
            this.gbxSistema.Controls.Add(this.lblBaseDatos);
            this.gbxSistema.Controls.Add(this.lblServidor);
            this.gbxSistema.Enabled = false;
            this.gbxSistema.Location = new System.Drawing.Point(12, 32);
            this.gbxSistema.Name = "gbxSistema";
            this.gbxSistema.Size = new System.Drawing.Size(406, 197);
            this.gbxSistema.TabIndex = 1;
            this.gbxSistema.TabStop = false;
            this.gbxSistema.Text = "Sistema";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(22, 149);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(64, 13);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(22, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Location = new System.Drawing.Point(19, 69);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(80, 13);
            this.lblBaseDatos.TabIndex = 1;
            this.lblBaseDatos.Text = "Base de Datos:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(19, 29);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(343, 235);
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
            this.btnCancelar.Location = new System.Drawing.Point(227, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblContrasenaSeguridad
            // 
            this.lblContrasenaSeguridad.AutoSize = true;
            this.lblContrasenaSeguridad.Location = new System.Drawing.Point(44, 9);
            this.lblContrasenaSeguridad.Name = "lblContrasenaSeguridad";
            this.lblContrasenaSeguridad.Size = new System.Drawing.Size(130, 13);
            this.lblContrasenaSeguridad.TabIndex = 10;
            this.lblContrasenaSeguridad.Text = "Contraseña de Seguridad:";
            // 
            // txtContrasenaSeguridad
            // 
            this.txtContrasenaSeguridad.Location = new System.Drawing.Point(180, 6);
            this.txtContrasenaSeguridad.Name = "txtContrasenaSeguridad";
            this.txtContrasenaSeguridad.PasswordChar = '*';
            this.txtContrasenaSeguridad.Size = new System.Drawing.Size(153, 20);
            this.txtContrasenaSeguridad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtContrasenaSeguridad.TabIndex = 0;
            this.txtContrasenaSeguridad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            this.txtContrasenaSeguridad.TextChanged += new System.EventHandler(this.txtContrasenaSeguridad_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(120, 146);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(153, 20);
            this.txtContrasena.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(120, 106);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '*';
            this.txtUsuario.Size = new System.Drawing.Size(153, 20);
            this.txtUsuario.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(120, 66);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(153, 20);
            this.txtBaseDatos.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtBaseDatos.TabIndex = 3;
            this.txtBaseDatos.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(120, 26);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(269, 20);
            this.txtServidor.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtServidor.TabIndex = 2;
            this.txtServidor.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // frmConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 266);
            this.Controls.Add(this.txtContrasenaSeguridad);
            this.Controls.Add(this.lblContrasenaSeguridad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar";
            this.Load += new System.EventHandler(this.frmConfigurar_Load);
            this.gbxSistema.ResumeLayout(false);
            this.gbxSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSistema;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private SistemaCentroSalud.Controles.cuTextBox txtContrasena;
        private SistemaCentroSalud.Controles.cuTextBox txtUsuario;
        private SistemaCentroSalud.Controles.cuTextBox txtBaseDatos;
        private SistemaCentroSalud.Controles.cuTextBox txtServidor;
        private System.Windows.Forms.Label lblContrasenaSeguridad;
        private SistemaCentroSalud.Controles.cuTextBox txtContrasenaSeguridad;
    }
}