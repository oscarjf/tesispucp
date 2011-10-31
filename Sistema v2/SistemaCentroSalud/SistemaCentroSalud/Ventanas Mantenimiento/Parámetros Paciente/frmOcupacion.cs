using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;
using Modelo;
using Control;

namespace SistemaCentroSalud.Ventanas_Mantenimiento
{
    public partial class frmOcupacion : Form
    {
        private DataTable dtOcupaciones;
        private int numAccion;
        private int numIdOcupacion;

        public frmOcupacion()
        {
            InitializeComponent();
        }

        private void frmOcupacion_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarGrilla()
        {
            dgvOcupaciones.DataMember = null;

            for (int i = 0; i < dtOcupaciones.Rows.Count; i++)
            {
                dgvOcupaciones.Rows.Add(new String[] { dtOcupaciones.Rows[i]["IdOcupacion"].ToString(), 
                                                 dtOcupaciones.Rows[i]["Nombre"].ToString(),
                                                 dtOcupaciones.Rows[i]["Estado"].ToString() });

                if (dtOcupaciones.Rows[i]["Estado"].ToString().CompareTo("INACTIVO") == 0)
                {
                    dgvOcupaciones.Rows[i].Cells[1].Style.ForeColor = Color.White;
                    dgvOcupaciones.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    dgvOcupaciones.Rows[i].Cells[2].Style.ForeColor = Color.White;
                    dgvOcupaciones.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
            }

            dgvOcupaciones.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtNombreBuscar.Clear();
            cboEstadoBuscar.SelectedIndex = 0;
            txtNombreDetalle.Clear();
            rtxtDescripcionDetalle.Clear();
        }

        private void mostrarInformacion(clsOcupacion objOcupacion, int numAccion)
        {
            if (numAccion != clsComun.INSERTAR)
            {
                txtNombreDetalle.Text = objOcupacion.Nombre;
                rtxtDescripcionDetalle.Text = objOcupacion.Descripcion;
            }

            if (numAccion == clsComun.VER)
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;

                btnCancelar.Visible = false;
                btnGuardar.Text = "Volver";
            }
            else
            {
                txtNombreDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
                rtxtDescripcionDetalle.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;

                btnCancelar.Visible = true;
                btnGuardar.Text = "Guardar";
            }

            clsComun.tabSiguiente(tbcOcupacion, tbpBuscar, tbpDetalle);
        }

        private bool validarFormulario()
        {
            if (txtNombreDetalle.Text.CompareTo("") != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la ocupación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombreDetalle.Focus();
                return false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numAccion = clsComun.INSERTAR;

            numIdOcupacion = 0;

            limpiarFormulario();

            mostrarInformacion(null, numAccion);

            txtNombreDetalle.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                clsOcupacion objOcupacion = new clsOcupacion();
                objOcupacion.IdOcupacion = numIdOcupacion;
                objOcupacion.Nombre = txtNombreDetalle.Text;
                objOcupacion.Descripcion = rtxtDescripcionDetalle.Text;

                if (numAccion == clsComun.INSERTAR)
                {
                    if (ctrOcupacion.registrarOcupacion(objOcupacion))
                    {
                        if (MessageBox.Show("La ocupación se registró exitosamente\n¿Desea seguir registrando ocupaciones?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            limpiarFormulario();

                            txtNombreDetalle.Focus();
                        }
                        else
                        {
                            clsComun.tabAnterior(tbcOcupacion, tbpBuscar, tbpDetalle);

                            limpiarFormulario();

                            txtNombreBuscar.Focus();

                            dtOcupaciones = ctrOcupacion.seleccionarOcupaciones(objOcupacion);
                            cargarGrilla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba registrar la ocupación", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else if (numAccion == clsComun.MODIFICAR)
                {
                    if (ctrOcupacion.modificarOcupacion(objOcupacion))
                    {
                        MessageBox.Show("La ocupación se modificó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clsComun.tabAnterior(tbcOcupacion, tbpBuscar, tbpDetalle);

                        limpiarFormulario();

                        txtNombreBuscar.Focus();

                        dtOcupaciones = ctrOcupacion.seleccionarOcupaciones(objOcupacion);
                        cargarGrilla();
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba modificar la ocupacion", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnGuardar_Click(sender, e);
                        }
                    }
                }
                else
                {
                    clsComun.tabAnterior(tbcOcupacion, tbpBuscar, tbpDetalle);

                    limpiarFormulario();

                    txtNombreBuscar.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcOcupacion, tbpBuscar, tbpDetalle);

            limpiarFormulario();

            txtNombreBuscar.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvOcupaciones.SelectedRows.Count > 0)
            {
                numAccion = clsComun.VER;

                numIdOcupacion = Int32.Parse(dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsOcupacion objOcupacion = new clsOcupacion();
                objOcupacion.IdOcupacion = numIdOcupacion;

                objOcupacion = ctrOcupacion.seleccionarOcupacion(objOcupacion);

                mostrarInformacion(objOcupacion, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ocupación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvOcupaciones.SelectedRows.Count > 0)
            {
                numAccion = clsComun.MODIFICAR;

                numIdOcupacion = Int32.Parse(dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[0].Value.ToString());

                limpiarFormulario();

                clsOcupacion objOcupacion = new clsOcupacion();
                objOcupacion.IdOcupacion = numIdOcupacion;

                objOcupacion = ctrOcupacion.seleccionarOcupacion(objOcupacion);

                mostrarInformacion(objOcupacion, numAccion);

                txtNombreDetalle.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ocupación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOcupaciones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este modo de ingreso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    numAccion = clsComun.ELIMINAR;

                    numIdOcupacion = Int32.Parse(dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[0].Value.ToString());

                    clsOcupacion objOcupacion = new clsOcupacion();
                    objOcupacion.IdOcupacion = numIdOcupacion;

                    if (ctrOcupacion.eliminarOcupacion(objOcupacion))
                    {
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[2].Value = "INACTIVO";

                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = true;
                        btnEliminar.Visible = false;

                        MessageBox.Show("La ocupación se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba eliminar la ocupación", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ocupación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvOcupaciones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea activar esta ocupación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    numAccion = clsComun.RECUPERAR;

                    numIdOcupacion = Int32.Parse(dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[0].Value.ToString());

                    clsOcupacion objModoIngreso = new clsOcupacion();
                    objModoIngreso.IdOcupacion = numIdOcupacion;

                    if (ctrOcupacion.recuperarOcupacion(objModoIngreso))
                    {
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[2].Value = "ACTIVO";

                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[1].Style.ForeColor = Color.White;
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[1].Style.BackColor = Color.Red;
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[2].Style.ForeColor = Color.White;
                        dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[2].Style.BackColor = Color.Red;

                        btnActivar.Visible = false;
                        btnEliminar.Visible = true;

                        MessageBox.Show("La ocupación se activó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Ocurrió un error mientras se intentaba activar la ocupación", "Mensaje", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) != DialogResult.Cancel)
                        {
                            btnEliminar_Click(sender, e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una ocupación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcOcupacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcOcupacion.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcOcupacion_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clsOcupacion objOcupacion = new clsOcupacion();
                objOcupacion.Nombre = txtNombreBuscar.Text;
                objOcupacion.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtOcupaciones = ctrOcupacion.seleccionarOcupacionesCriterios(objOcupacion);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void cboEstadoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clsOcupacion objOcupacion = new clsOcupacion();
                objOcupacion.Nombre = txtNombreBuscar.Text;
                objOcupacion.Estado = cboEstadoBuscar.SelectedItem.ToString();

                dtOcupaciones = ctrOcupacion.seleccionarOcupacionesCriterios(objOcupacion);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void dgvOcupaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOcupaciones.Rows[dgvOcupaciones.CurrentRow.Index].Cells[2].Value.ToString().CompareTo("ACTIVO") == 0)
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
