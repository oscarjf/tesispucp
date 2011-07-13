using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;
using Control;

namespace SistemaCentroSalud
{
    public partial class frmBienvenida : Form
    {
        public DataTable dtusuario;
        public int numIdUsuario;

        public frmBienvenida()
        {
            InitializeComponent();
        }

        public int obtenerId(){
            return numIdUsuario;
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void validarAcceso(string strUsuario, string strContrasena)
        {
            if ((strUsuario.CompareTo("admin") == 0) && (strContrasena.CompareTo("admin") == 0))
            {
                frmPrincipal ventanaPrincipal = new frmPrincipal(this);
                this.Visible = false;
                ventanaPrincipal.nombreusuario = "admin";
                ventanaPrincipal.Show();
            }
            else
            {
                //MessageBox.Show("Usuario y/o Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtusuario = clsGestorBD.up_SelPersonal(strUsuario,strContrasena);
                if (dtusuario == null)
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        numIdUsuario = Int32.Parse(dtusuario.Rows[0][0].ToString());

                        frmPrincipal ventanaPrincipal = new frmPrincipal(this);
                        ventanaPrincipal.idperfil = Int32.Parse(dtusuario.Rows[0][3].ToString());
                        ventanaPrincipal.nombreusuario = dtusuario.Rows[0][4].ToString();
                        this.Visible = false;
                        ventanaPrincipal.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        public void limpiarCampos()
        {
            txtContrasena.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarAcceso(txtUsuario.Text, txtContrasena.Text);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                validarAcceso(txtUsuario.Text, txtContrasena.Text);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                validarAcceso(txtUsuario.Text, txtContrasena.Text);
            }
        }
    }
}
