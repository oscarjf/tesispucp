using System;
using System.Windows.Forms;
using Comun;
using Control;

namespace SistemaCentroSalud
{
    public partial class frmCambiarContrasena : Form
    {
        private frmPrincipal ventanaPrincipal;
        private int numIdEmpleado;

        public frmCambiarContrasena(frmPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;
            this.numIdEmpleado = ventanaPrincipal.obtenerIdEmpleado();
        }

        private bool validarFormulario()
        {
            if (txtUsuario.Text.CompareTo("") != 0)
            {
                if (txtNuevaContrasena.Text.CompareTo("") != 0)
                {
                    if (txtRepetirContrasena.Text.CompareTo("") != 0)
                    {
                        if (txtNuevaContrasena.Text.CompareTo(txtRepetirContrasena.Text) == 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Verifique que volvió a ingresar la nueva contraseña correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRepetirContrasena.Clear();
                            txtRepetirContrasena.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe repetir la contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRepetirContrasena.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar la nueva contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNuevaContrasena.Focus();
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

        private void txtIngresarContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtIngresarContrasena.Text.CompareTo(ventanaPrincipal.obtenerContrasenaEmpleado()) == 0)
            {
                gbxAcceso.Enabled = true;
                txtUsuario.Text = ventanaPrincipal.obtenerNombreUsuarioEmpleado();
            }
            else
            {
                gbxAcceso.Enabled = false;
                txtUsuario.Clear();
                txtNuevaContrasena.Clear();
                txtRepetirContrasena.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                if (ctrEmpleado.validarCambioCuenta(numIdEmpleado, txtUsuario.Text, txtNuevaContrasena.Text))
                {
                    MessageBox.Show("La cuenta se actualizó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ventanaPrincipal.setearNombreUsuarioEmpleado(txtUsuario.Text);
                    ventanaPrincipal.setearContrasenaEmpleado(txtNuevaContrasena.Text);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ingresado ya existe. Por favor ingrese otro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                }
            }
        }
    }
}
