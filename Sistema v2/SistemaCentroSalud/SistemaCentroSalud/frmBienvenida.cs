using System;
using System.Data;
using System.Windows.Forms;
using Comun;
using Control;

namespace SistemaCentroSalud
{
    public partial class frmBienvenida : Form
    {
        private int numIdEmpleado = 0;
        private string strUsuario = "";
        private string strContrasena = "";
        
        public frmBienvenida()
        {
            InitializeComponent();
        }

        public void limpiarFormulario()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtUsuario.Focus();
        }

        private bool validarFormulario()
        {
            if (txtUsuario.Text.CompareTo("") != 0)
            {
                if (txtContrasena.Text.CompareTo("") != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Debe ingresar la contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContrasena.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return false;
            }
        }

        public int getIdEmpleado()
        {
            return numIdEmpleado;
        }

        public string getUsuario()
        {
            return strUsuario;
        }

        public void setUsuario(string strUsuario)
        {
            this.strUsuario = strUsuario;
        }

        public string getContrasena()
        {
            return strContrasena;
        }

        public void setContrasena(string strContrasena)
        {
            this.strContrasena = strContrasena;
        }

        private void validarAcceso()
        {
            if (validarFormulario())
            {
                int numId = ctrEmpleado.validarIngreso(txtUsuario.Text, txtContrasena.Text);
                if (numId != 0)
                {
                    numIdEmpleado = numId;
                    setUsuario(txtUsuario.Text);
                    setContrasena(txtContrasena.Text);

                    frmPrincipal ventanaPrincipal = new frmPrincipal(this);
                    ventanaPrincipal.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarAcceso();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro(a) de que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void frmBienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro(a) de que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                validarAcceso();
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                validarAcceso();
            }
        }

        private void lnkContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InputBoxValidation validation = delegate(string val)
            {
                if (clsComun.validarCorreoElectronico(val))
                {
                    return "";
                }
                else
                {
                    return "Formato de correo electrónico incorrecto";
                }
            };

            string value = "info@ejemplo.com";
            if (clsInputTextBox.Show("Ingrese su correo electrónico", "Mensaje", ref value, validation) == DialogResult.OK)
            {
                DataTable dtEmpleado = ctrEmpleado.obtenerDatosCuenta(value);
                if (dtEmpleado != null)
                {
                    string strPaterno = dtEmpleado.Rows[0]["Paterno"].ToString(),
                           strMaterno = dtEmpleado.Rows[0]["Materno"].ToString(),
                           strNombres = dtEmpleado.Rows[0]["Nombres"].ToString(),
                           strUsuario = dtEmpleado.Rows[0]["Usuario"].ToString(),
                           strContrasena = dtEmpleado.Rows[0]["Contrasena"].ToString();

                    while (true)
                    {
                        if (clsComun.enviarCorreo(value, strPaterno, strMaterno, strNombres, strUsuario, strContrasena))
                        {
                            MessageBox.Show("Se enviaron sus datos a la dirección de correo electrónico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba enviar sus datos a la dirección de correo electrónico", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                            {
                                break;
                            }                       
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El correo electrónico ingresado no se encuentra registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lnkContrasena_LinkClicked(sender, e);
                }
            }
        }
    }
}
