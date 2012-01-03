using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud.Ventanas_Seguridad
{
    public partial class frmPerfil : Form
    {
        private DataTable dtPerfiles;
        private int numAccion;
        private int numIdPerfil;

        public frmPerfil()
        {
            InitializeComponent();

            clsPerfil objPerfil = new clsPerfil();
            objPerfil.TipoEmpleado = "TODOS";
            objPerfil.Estado = "TODOS";

            dtPerfiles = ctrPerfil.seleccionarPerfilesCriterios(objPerfil);

            cargarGrilla();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cboTipoEmpleadoBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;

            dgvPerfiles.Refresh();
        }

        private void cargarGrilla()
        {
            dgvPerfiles.DataMember = null;

            for (int i = 0; i < dtPerfiles.Rows.Count; i++)
            {
                dgvPerfiles.Rows.Add(new String[] { dtPerfiles.Rows[i]["IdPerfil"].ToString(), 
                                             dtPerfiles.Rows[i]["Nombre"].ToString(),
                                             dtPerfiles.Rows[i]["TipoEmpleado"].ToString(), 
                                             dtPerfiles.Rows[i]["Estado"].ToString() });

                if (dtPerfiles.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvPerfiles.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvPerfiles.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvPerfiles.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvPerfiles.Rows[i].Cells[2].Style.BackColor = Color.Red;
                    dgvPerfiles.Rows[i].Cells[3].Style.ForeColor = Color.White;
                    dgvPerfiles.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }

            dgvPerfiles.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboTipoEmpleadoBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            cboTipoEmpleadoDetalle.SelectedIndex = 0;
            lbxAccesosPermitidos.Items.Clear();
        }

        private void mostrarInformacion(clsPerfil objPerfil, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objPerfil.Nombre;
                cboTipoEmpleadoDetalle.Text = objPerfil.TipoEmpleado;

                string[] strMenus = objPerfil.ListaMenus.Split(',');
                foreach (string menu in strMenus)
                {
                    lbxAccesosPermitidos.Items.Add(menu);
                }
            }

            if (numAccion == clsComun.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                cboTipoEmpleadoDetalle.Enabled = false;
                //lbxAccesosPermitidos.Enabled = false;

                btnTodoDerecha.Visible = false;
                btnDerecha.Visible = false;
                btnIzquierda.Visible = false;
                btnTodoIzquierda.Visible = false;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                cboTipoEmpleadoDetalle.Enabled = true;
                //lbxAccesosPermitidos.Enabled = true;

                btnTodoDerecha.Visible = true;
                btnDerecha.Visible = true;
                btnIzquierda.Visible = true;
                btnTodoIzquierda.Visible = true;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.redimensionarTabControl(tbcPerfil, 569, 318);
            clsComun.redimensionarVentana(this, 574, 345);
            clsComun.tabSiguiente(tbcPerfil, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                if (cboTipoEmpleadoDetalle.SelectedIndex != 0)
                {
                    if (lbxAccesosPermitidos.Items.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar al menos un menú", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tvAccesos.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el tipo de empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboTipoEmpleadoDetalle.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre del área", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdPerfil = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (numAccion == clsComun.VER)
            {
                clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
                clsComun.redimensionarVentana(this, 463, 345);
                clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);

                limpiarFormulario();

                txtNombreBuscar.Focus();
            }
            else
            {
                if (validarFormulario())
                {
                    clsPerfil objPerfil = new clsPerfil();
                    objPerfil.IdPerfil = numIdPerfil;
                    objPerfil.Nombre = txtNombreDetalle.Text;
                    objPerfil.TipoEmpleado = cboTipoEmpleadoDetalle.SelectedItem.ToString();

                    string strListaMenus = strListaMenus = lbxAccesosPermitidos.Items[0].ToString();

                    for (int i = 1; i < lbxAccesosPermitidos.Items.Count; i++)
                    {
                        strListaMenus += "," + lbxAccesosPermitidos.Items[i].ToString();
                    }

                    objPerfil.ListaMenus = strListaMenus;

                    if (numAccion == clsComun.INSERTAR)
                    {
                        if (ctrPerfil.registrarPerfil(objPerfil))
                        {
                            if (MessageBox.Show("El perfil se registró exitosamente\n¿Desea seguir registrando perfiles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                limpiarFormulario();

                                txtNombreDetalle.Focus();
                            }
                            else
                            {
                                clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
                                clsComun.redimensionarVentana(this, 463, 345);
                                clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);

                                limpiarFormulario();

                                txtNombreBuscar.Focus();

                                dtPerfiles = ctrPerfil.seleccionarPerfiles(objPerfil);
                                cargarGrilla();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar el perfil", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                    else if (numAccion == clsComun.MODIFICAR)
                    {
                        if (ctrPerfil.modificarPerfil(objPerfil))
                        {
                            MessageBox.Show("El perfil se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
                            clsComun.redimensionarVentana(this, 463, 345);
                            clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtPerfiles = ctrPerfil.seleccionarPerfiles(objPerfil);
                            cargarGrilla();
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar el perfil", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnGuardar_Click(sender, e);
                            }
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
            clsComun.redimensionarVentana(this, 463, 345);
            clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdPerfil = Int32.Parse(dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsPerfil objPerfil = new clsPerfil();
                objPerfil.IdPerfil = numIdPerfil;

                objPerfil = ctrPerfil.seleccionarPerfil(objPerfil);

                mostrarInformacion(objPerfil, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                if (dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString().CompareTo("1") != 0)
                {
                    numAccion = clsComun.MODIFICAR;

                    numIdPerfil = Int32.Parse(dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString());

                    limpiarFormulario();

                    clsPerfil objPerfil = new clsPerfil();
                    objPerfil.IdPerfil = numIdPerfil;

                    objPerfil = ctrPerfil.seleccionarPerfil(objPerfil);

                    mostrarInformacion(objPerfil, numAccion);

                    txtNombreDetalle.Focus();
                }
                else
                {
                    MessageBox.Show("Este perfil no se puede modificar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                if (dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString().CompareTo("1") != 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este perfil?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        numAccion = clsComun.ELIMINAR;

                        numIdPerfil = Int32.Parse(dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString());

                        clsPerfil objPerfil = new clsPerfil();
                        objPerfil.IdPerfil = numIdPerfil;

                        if (ctrPerfil.eliminarPerfil(objPerfil))
                        {
                            dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[3].Value = "INACTIVO";

                            dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                            dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                            dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                            dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;
                            dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[3].Style.ForeColor = Color.White;
                            dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[3].Style.BackColor = Color.Red;

                            btnActivar.Visible = true;
                            btnEliminar.Visible = false;

                            MessageBox.Show("El perfil se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el perfil", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                            {
                                btnEliminar_Click(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este perfil no se puede eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar este perfil?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdPerfil = Int32.Parse(dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[0].Value.ToString());

                    clsPerfil objPerfil = new clsPerfil();
                    objPerfil.IdPerfil = numIdPerfil;

                    if (ctrPerfil.recuperarPerfil(objPerfil))
                    {
                        dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[3].Value = "ACTIVO";

                        dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[1].Style.ForeColor = Color.Black;
                        dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[1].Style.BackColor = Color.White;
                        dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[2].Style.ForeColor = Color.Black;
                        dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[2].Style.BackColor = Color.White;
                        dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[3].Style.ForeColor = Color.Black;
                        dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[3].Style.BackColor = Color.White;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("El perfil se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar el perfil", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void agregarNodo(TreeNode tnNodo)
        {
            if (tnNodo.Nodes.Count > 0)
            {
                for (int i = 0; i < tnNodo.Nodes.Count; i++)
                {
                    agregarNodo(tnNodo.Nodes[i]);
                }
            }

            if (tnNodo.Name.Substring(0, 4).CompareTo("smnu") == 0)
            {
                bool blnEncontrado = false;

                foreach (string strMenu in lbxAccesosPermitidos.Items)
                {
                    if (tnNodo.Text.CompareTo(strMenu) == 0)
                    {
                        blnEncontrado = true;
                        break;
                    }
                }

                if (!blnEncontrado)
                {
                    lbxAccesosPermitidos.Items.Add(tnNodo.Text);
                }
            }
        }

        private void btnTodoDerecha_Click(object sender, EventArgs e)
        {
            foreach (TreeNode nodo in tvAccesos.Nodes)
            {
                agregarNodo(nodo);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            agregarNodo(tvAccesos.SelectedNode);
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (lbxAccesosPermitidos.SelectedItems.Count > 0)
            {
                lbxAccesosPermitidos.Items.Remove(lbxAccesosPermitidos.SelectedItem);
            }
        }

        private void btnTodoIzquierda_Click(object sender, EventArgs e)
        {
            lbxAccesosPermitidos.Items.Clear();
        }

        private void tbcPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPerfil.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcPerfil_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void buscarCriterios(object sender, EventArgs e)
        {
            try
            {
                clsPerfil objPerfil = new clsPerfil();
                objPerfil.Nombre = txtNombreBuscar.Text;
                objPerfil.TipoEmpleado = cboTipoEmpleadoBuscar.SelectedItem.ToString();
                objPerfil.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtPerfiles = ctrPerfil.seleccionarPerfilesCriterios(objPerfil);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvPerfiles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPerfiles.Rows[dgvPerfiles.CurrentRow.Index].Cells[3].Value.ToString().CompareTo("ACTIVO") == 0)
            {
                btnEliminar.Visible = true;
                btnActivar.Visible = false;
            }
            else
            {
                btnEliminar.Visible = false;
                btnActivar.Visible = true;
            }
        }
    }
}
