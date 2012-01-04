using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaCentroSalud
{
    public partial class frmConfigurar : Form
    {
        private string strRuta = AppDomain.CurrentDomain.BaseDirectory + "\\Acceso.txt";
        private bool blnExiste = false;

        public frmConfigurar()
        {
            InitializeComponent();
        }

        private void frmConfigurar_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(strRuta))
            {
                TextReader tr = new StreamReader(strRuta);

                txtServidor.Text = tr.ReadLine();
                txtBaseDatos.Text = tr.ReadLine();
                txtUsuario.Text = tr.ReadLine();
                txtContrasena.Text = tr.ReadLine();

                tr.Close();
                tr.Dispose();

                blnExiste = true;
            }
            else
            {
                blnExiste = false;
            }
        }

        private bool validarFormulario()
        {
            if (txtServidor.Text.CompareTo("") != 0)
            {
                if (txtBaseDatos.Text.CompareTo("") != 0)
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
                            txtServidor.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el nombre de usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtServidor.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el nombre de la base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtServidor.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar la dirección del servidor de base de datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtServidor.Focus();
                return false;
            }
        }

        private bool guardarInformacion()
        {
            try
            {
                string strServidor = txtServidor.Text;
                string strBaseDatos = txtBaseDatos.Text;
                string strUsuario = txtUsuario.Text;
                string strContrasena = txtContrasena.Text;

                StreamWriter sw = File.AppendText(strRuta);

                sw.WriteLine(strServidor);
                sw.WriteLine(strBaseDatos);
                sw.WriteLine(strUsuario);
                sw.WriteLine(strContrasena);

                sw.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                if (blnExiste)
                {
                    File.Delete(strRuta);

                    if (guardarInformacion())
                    {
                        MessageBox.Show("La configuración se registró exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la configuración", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    if (guardarInformacion())
                    {
                        MessageBox.Show("La configuración se registró exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la configuración", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
