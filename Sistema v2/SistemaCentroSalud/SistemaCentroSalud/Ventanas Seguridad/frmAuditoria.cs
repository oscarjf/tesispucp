using System;
using System.Data;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;

namespace SistemaCentroSalud
{
    public partial class frmAuditoria : Form
    {
        private frmPrincipal ventanaPrincipal;
        private DataTable dtTablas;
        private DataTable dtColumnas;
        private int numIdEmpleado;
        private string strNombreTabla;

        public frmAuditoria(frmPrincipal ventanaPrincipal)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventanaPrincipal;

            numIdEmpleado = ventanaPrincipal.getIdEmpleado();

            clsTablaAuditada objTablaAuditada = new clsTablaAuditada();

            dtTablas = ctrTablaAuditada.seleccionarTablas(objTablaAuditada);

            cargarGrilla();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
            cboTipoBuscar.SelectedIndex = 0;
            cboAuditadaBuscar.SelectedIndex = 0;
            cboTipoDetalle.SelectedIndex = 0;

            dgvTablas.Refresh();
        }

        private void cargarGrilla()
        {
            dgvTablas.DataMember = null;

            for (int i = 0; i < dtTablas.Rows.Count; i++)
            {
                string strIdTablaAuditada = dtTablas.Rows[i]["IdTablaAuditada"].ToString();
                string strTabla = dtTablas.Rows[i]["Tabla"].ToString();
                bool blnIndAuditoria = false;
                if (dtTablas.Rows[i]["IndAuditoria"].ToString().CompareTo("X") == 0)
                {
                    blnIndAuditoria = true;
                }
                bool blnInsertar = false;
                if (dtTablas.Rows[i]["Insertar"].ToString().CompareTo("X") == 0)
                {
                    blnInsertar = true;
                }
                bool blnActualizar = false;
                if (dtTablas.Rows[i]["Actualizar"].ToString().CompareTo("X") == 0)
                {
                    blnActualizar = true;
                } 
                bool blnEliminar = false;
                if (dtTablas.Rows[i]["Eliminar"].ToString().CompareTo("X") == 0)
                {
                    blnEliminar = true;
                }

                dgvTablas.Rows.Add(strIdTablaAuditada, strTabla, blnIndAuditoria, blnInsertar, blnActualizar, blnEliminar);
            }

            dgvTablas.ClearSelection();
        }

        private void limpiarFormulario()
        {
            txtTablaBuscar.Text = "";
            cboAuditadaBuscar.SelectedIndex = 0;
            cboTipoBuscar.SelectedIndex = 0;
            txtUsuarioDetalle.Text = "";
            cboTipoDetalle.SelectedIndex = 0;
            dtpFechaInicioDetalle.Value = DateTime.Now;
            dtpFechaInicioDetalle.Enabled = false;
            dtpFechaFinDetalle.Value = DateTime.Now;
            dtpFechaFinDetalle.Enabled = false;
            cbxFechaInicioDetalle.Checked = false;
            cbxFechaFinDetalle.Checked = false;
        }

        private void mostrarInformacion()
        {
            if (dtColumnas != null)
            {
                dgvColumnas.DataMember = null;

                for (int i = 0; i < dtColumnas.Rows.Count; i++)
                {
                    string strFecha = ((DateTime)dtColumnas.Rows[i]["Fecha"]).ToShortDateString();
                    string strHora = ((DateTime)dtColumnas.Rows[i]["Fecha"]).ToShortTimeString();
                    string strTipo = dtColumnas.Rows[i]["Tipo"].ToString();

                    switch (strTipo)
                    {
                        case "I": strTipo = "Insertar"; break;
                        case "U": strTipo = "Actualizar"; break;
                        case "D": strTipo = "Eliminar"; break;
                    }

                    dgvColumnas.Rows.Add(new String[] { dtColumnas.Rows[i]["IdAuditoria"].ToString(), 
                                                 strFecha,
                                                 strHora,
                                                 dtColumnas.Rows[i]["Empleado"].ToString(),
                                                 strTipo, 
                                                 dtColumnas.Rows[i]["Columna"].ToString(),
                                                 dtColumnas.Rows[i]["AntiguoValor"].ToString(),
                                                 dtColumnas.Rows[i]["NuevoValor"].ToString() });
                }

                clsComun.tabSiguiente(tbcAuditoria, tbpBuscar, tbpDetalle);

                dgvColumnas.ClearSelection();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvTablas.SelectedRows.Count > 0)
            {
                strNombreTabla = dgvTablas.CurrentRow.Cells[1].Value.ToString();

                clsAuditoria objAuditoria = new clsAuditoria();
                objAuditoria.NombreTabla = strNombreTabla;

                dtColumnas = ctrTablaAuditada.seleccionarColumnas(objAuditoria);

                limpiarFormulario();

                mostrarInformacion();

                txtUsuarioDetalle.Focus();

                dgvColumnas.Refresh();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcAuditoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcAuditoria.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }

        private void tbcAuditoria_Selecting(object sender, TabControlCancelEventArgs e)
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
                clsTablaAuditada objTablaAuditada = new clsTablaAuditada();
                objTablaAuditada.Tabla = txtTablaBuscar.Text;
                try
                {
                    if (cboAuditadaBuscar.SelectedItem.ToString().CompareTo("TODOS") == 0)
                    {
                        objTablaAuditada.IndAuditoria = "TODOS";
                    }
                    else if (cboAuditadaBuscar.SelectedItem.ToString().CompareTo("SI") == 0)
                    {
                        objTablaAuditada.IndAuditoria = "X";
                    }
                    else
                    {
                        objTablaAuditada.IndAuditoria = "";
                    }
                }
                catch
                {
                    objTablaAuditada.IndAuditoria = "TODOS";
                }
                try
                {
                    if (cboTipoBuscar.SelectedItem.ToString().CompareTo("TODAS") == 0)
                    {
                        objTablaAuditada.IndInsertar = "";
                        objTablaAuditada.IndActualizar = "";
                        objTablaAuditada.IndEliminar = "";
                    }
                    else if (cboTipoBuscar.SelectedItem.ToString().CompareTo("INSERTAR") == 0)
                    {
                        objTablaAuditada.IndInsertar = "X";
                        objTablaAuditada.IndActualizar = "";
                        objTablaAuditada.IndEliminar = "";
                    }
                    else if (cboTipoBuscar.SelectedItem.ToString().CompareTo("ACTUALIZAR") == 0)
                    {
                        objTablaAuditada.IndInsertar = "";
                        objTablaAuditada.IndActualizar = "X";
                        objTablaAuditada.IndEliminar = "";
                    }
                    else
                    {
                        objTablaAuditada.IndInsertar = "";
                        objTablaAuditada.IndActualizar = "";
                        objTablaAuditada.IndEliminar = "X";
                    }
                }
                catch
                {
                    objTablaAuditada.IndInsertar = "";
                    objTablaAuditada.IndActualizar = "";
                    objTablaAuditada.IndEliminar = "";
                }
                
                dtTablas = ctrTablaAuditada.seleccionarTablasCriterios(objTablaAuditada);
                cargarGrilla();
            }
            catch
            {
            }
        }

        private void seleccionarCriterios(object sender, EventArgs e)
        {
            try
            {
                clsAuditoria objAuditoria = new clsAuditoria();
                objAuditoria.NombreTabla = strNombreTabla;
                objAuditoria.NombreEmpleado = txtUsuarioDetalle.Text;
                
                if (cbxFechaInicioDetalle.Checked)
                {
                    objAuditoria.IndFechaInicio = "X";
                    objAuditoria.FechaInicio = dtpFechaInicioDetalle.Value;
                }
                if (cbxFechaFinDetalle.Checked)
                {
                    objAuditoria.IndFechaFin = "X";
                    objAuditoria.FechaFin = dtpFechaFinDetalle.Value;
                }

                if (cboTipoDetalle.SelectedItem.ToString().CompareTo("INSERTAR") == 0)
                {
                    objAuditoria.Tipo = "INSERT";
                }
                else if (cboTipoDetalle.SelectedItem.ToString().CompareTo("ACTUALIZAR") == 0)
                {
                    objAuditoria.Tipo = "UPDATE";
                }
                else if (cboTipoDetalle.SelectedItem.ToString().CompareTo("ELIMINAR") == 0)
                {
                    objAuditoria.Tipo = "DELETE";
                }

                dtColumnas = ctrTablaAuditada.seleccionarColumnasCriterios(objAuditoria);
                mostrarInformacion();
            }
            catch
            {
            }
        }

        private void dgvTablas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTablas.CommitEdit(DataGridViewDataErrorContexts.Commit); 
        }

        private void dgvTablas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numCelda = dgvTablas.CurrentCell.ColumnIndex;

                if (numCelda == 3)
                {
                    clsAuditoria objAuditoria = new clsAuditoria();
                    objAuditoria.NombreTabla = dgvTablas.CurrentRow.Cells[1].Value.ToString();
                    objAuditoria.IdEmpleado = numIdEmpleado;
                    objAuditoria.Tipo = "INSERT";

                    if (dgvTablas.CurrentRow.Cells[3].Value.ToString().CompareTo("True") == 0) //Insertar
                    {
                        if (ctrTablaAuditada.crearTrigger(objAuditoria))
                        {
                            MessageBox.Show("El trigger de auditoría para inserciones se creó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error mientras se intentaba crear el trigger de auditoría para inserciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        if (ctrTablaAuditada.eliminarTrigger(objAuditoria))
                        {
                            MessageBox.Show("El trigger de auditoría para inserciones se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el trigger de auditoría para inserciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else if (numCelda == 4)
                {
                    clsAuditoria objAuditoria = new clsAuditoria();
                    objAuditoria.NombreTabla = dgvTablas.CurrentRow.Cells[1].Value.ToString();
                    objAuditoria.IdEmpleado = numIdEmpleado;
                    objAuditoria.Tipo = "UPDATE";

                    if (dgvTablas.CurrentRow.Cells[4].Value.ToString().CompareTo("True") == 0) //Actualizar
                    {
                        if (ctrTablaAuditada.crearTrigger(objAuditoria))
                        {
                            MessageBox.Show("El trigger de auditoría para actualizaciones se creó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error mientras se intentaba crear el trigger de auditoría para actualizaciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        if (ctrTablaAuditada.eliminarTrigger(objAuditoria))
                        {
                            MessageBox.Show("El trigger de auditoría para actualizaciones se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el trigger de auditoría para actualizaciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else if (numCelda == 5)
                {
                    clsAuditoria objAuditoria = new clsAuditoria();
                    objAuditoria.NombreTabla = dgvTablas.CurrentRow.Cells[1].Value.ToString();
                    objAuditoria.IdEmpleado = numIdEmpleado;
                    objAuditoria.Tipo = "DELETE";

                    if (dgvTablas.CurrentRow.Cells[5].Value.ToString().CompareTo("True") == 0) //Eliminar
                    {
                        if (ctrTablaAuditada.crearTrigger(objAuditoria))
                        {
                            MessageBox.Show("El trigger de auditoría para eliminaciones se creó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error mientras se intentaba crear el trigger de auditoría para eliminaciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        if (ctrTablaAuditada.eliminarTrigger(objAuditoria))
                        {
                            MessageBox.Show("El trigger de auditoría para eliminaciones se eliminó exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error mientras se intentaba eliminar el trigger de auditoría para eliminaciones", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                if (numCelda == 3 || numCelda == 4 || numCelda == 5)
                {
                    buscarCriterios(sender, e);
                }
            }
            catch
            {
            }
        }

        private void cbxFechaInicioDetalle_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaInicioDetalle.Enabled = cbxFechaInicioDetalle.Checked;
        }

        private void cbxFechaFinDetalle_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaFinDetalle.Enabled = cbxFechaFinDetalle.Checked;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            clsComun.tabAnterior(tbcAuditoria, tbpBuscar, tbpDetalle);
        }
    }
}
