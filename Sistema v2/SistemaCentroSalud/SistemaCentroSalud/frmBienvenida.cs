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
        private string strTipoEmpleado = "";
        private DataTable dtMenus;
        
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

        public string getTipoEmpleado()
        {
            return strTipoEmpleado;
        }

        public DataTable getMenus()
        {
            return dtMenus;
        }

        private void validarAcceso()
        {
            String strUsuario, strContrasena;

            Cursor.Current = Cursors.WaitCursor;

            strUsuario = txtUsuario.Text;
            strContrasena = txtContrasena.Text;

            if ((strUsuario.CompareTo("inicio") == 0) && (strContrasena.CompareTo("tesispucp") == 0))
            {
                DataTable dtAuxiliar = new DataTable();
                DataRow drAuxiliar = null;

                dtAuxiliar.Columns.Clear();
                dtAuxiliar.Rows.Clear();
                dtAuxiliar.Columns.Add(new DataColumn("Menu", typeof(string)));
                
                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Personal";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Doctor(a)";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Enfermero(a)";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Técnico(a)";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Administrativo";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Mantenimiento";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Parámetros Centro de Salud";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Área";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Especialidad Médica";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Pabellón";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Consultorio";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Modo de Ingreso";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Parámetros Paciente";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Tipo de Documento";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Ocupación";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Religión";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Idioma";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Etnia";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "País";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Parámetros Formulario HIS";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "CPT";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Laboratorio";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Financiador de Salud";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Unidad Productora de Servicios";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Seguridad";
                dtAuxiliar.Rows.Add(drAuxiliar);

                drAuxiliar = dtAuxiliar.NewRow();
                drAuxiliar["Menu"] = "Perfil";
                dtAuxiliar.Rows.Add(drAuxiliar);

                dtMenus = dtAuxiliar;
                strTipoEmpleado = "CONFIGURACIÓN INICIAL";

                frmPrincipal ventanaPrincipal = new frmPrincipal(this);
                ventanaPrincipal.Show();
                this.Visible = false;
            }
            else
            {
                if (validarFormulario())
                {
                    int numId = ctrEmpleado.validarIngreso(strUsuario, strContrasena);
                    if (numId > 0)
                    {
                        numIdEmpleado = numId;
                        setUsuario(txtUsuario.Text);
                        setContrasena(txtContrasena.Text);

                        dtMenus = ctrEmpleado.obtenerMenusPerfil(numIdEmpleado);
                        strTipoEmpleado = ctrEmpleado.obtenerTipoEmpleado(numIdEmpleado);

                        frmPrincipal ventanaPrincipal = new frmPrincipal(this);
                        ventanaPrincipal.Show();
                        this.Visible = false;
                    }
                    else if (numId != -1)
                    {
                        MessageBox.Show("Usuario y/o contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContrasena.Clear();
                        txtContrasena.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra la base de datos\nVerifique la configuración", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarAcceso();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ingresar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                validarAcceso();
            }
        }

        private void smnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void smnuConfigurar_Click(object sender, EventArgs e)
        {
            frmConfigurar ventanaConfigurar = new frmConfigurar();
            ventanaConfigurar.ShowDialog();
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
                        Cursor.Current = Cursors.WaitCursor;
                        
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

                    Cursor.Current = Cursors.Default;
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
