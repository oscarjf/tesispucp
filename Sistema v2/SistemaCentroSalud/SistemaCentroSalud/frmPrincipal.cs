using System;
using System.Diagnostics;
using System.Windows.Forms;
using Comun;
using Control;
using Modelo;
using SistemaCentroSalud.Ventanas_Ayuda;
using SistemaCentroSalud.Ventanas_Doctor;
using SistemaCentroSalud.Ventanas_Mantenimiento;
using SistemaCentroSalud.Ventanas_Personal;
using SistemaCentroSalud.Ventanas_Seguridad;
using System.IO;

namespace SistemaCentroSalud
{
    public partial class frmPrincipal : Form
    {
        private frmBienvenida ventanaBienvenida;
        private object objEmpleado;

        public frmPrincipal(frmBienvenida ventanaBienvenida)
        {
            InitializeComponent();
            this.ventanaBienvenida = ventanaBienvenida;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            setEmpleado();

            for (int i = 0; i < ventanaBienvenida.getMenus().Rows.Count; i++)
            {
                for (int j = 0; j < menuStrip.Items.Count; j++)
                {
                    if (compararMenu(ventanaBienvenida.getMenus().Rows[i]["Menu"].ToString(), menuStrip.Items[j]))
                    {
                        break;
                    }
                }
            }

            activarBotones();

            if (objEmpleado is clsDoctor)
            {
                tslUsuario.Text = tslUsuario + ((clsDoctor)objEmpleado).Paterno + " " + ((clsDoctor)objEmpleado).Materno + ", " + ((clsDoctor)objEmpleado).Nombres;
            }
            else if (objEmpleado is clsEnfermero)
            {
                tslUsuario.Text = tslUsuario + ((clsEnfermero)objEmpleado).Paterno + " " + ((clsEnfermero)objEmpleado).Materno + ", " + ((clsEnfermero)objEmpleado).Nombres;
            }
            else if (objEmpleado is clsTecnico)
            {
                tslUsuario.Text = tslUsuario + ((clsTecnico)objEmpleado).Paterno + " " + ((clsTecnico)objEmpleado).Materno + ", " + ((clsTecnico)objEmpleado).Nombres;
            }
            else if (objEmpleado is clsAdministrativo)
            {
                tslUsuario.Text = tslUsuario + ((clsAdministrativo)objEmpleado).Paterno + " " + ((clsAdministrativo)objEmpleado).Materno + ", " + ((clsAdministrativo)objEmpleado).Nombres;
            }
        }

        private void activarBotones()
        {
            tsbPaciente.Enabled = smnuPaciente.Enabled;
            tsbCita.Enabled = smnuCita.Enabled;
            tsbHistoriaClinica.Enabled = smnuHistoriaClinica.Enabled;
            tsbFormularioHIS.Enabled = smnuFormularioHIS.Enabled;

            bbtnPaciente.Visible = smnuPaciente.Enabled;
            bbtnCita.Visible = smnuCita.Enabled;
            bbtnHistoriaClinica.Visible = smnuHistoriaClinica.Enabled;
            bbtnFormularioHIS.Visible = smnuFormularioHIS.Enabled;
            bbtnDoctor.Visible = smnuDoctor.Enabled;
            bbtnEnfermero.Visible = smnuEnfermero.Enabled;
            bbtnTecnico.Visible = smnuTecnico.Enabled;
            bbtnAdministrativo.Visible = smnuAdministrativo.Enabled;
            bbtnPerfil.Visible = smnuPerfil.Enabled;
            bbtnAuditoria.Visible = smnuAuditoria.Enabled;
        }

        private void setEmpleado()
        {
            if (ventanaBienvenida.getTipoEmpleado().CompareTo("DOCTOR") == 0)
            {
                clsDoctor objDoctor = new clsDoctor();
                objDoctor.IdDoctor = ventanaBienvenida.getIdEmpleado();

                objEmpleado = ctrDoctor.seleccionarDoctor(objDoctor);
            }
            else if (ventanaBienvenida.getTipoEmpleado().CompareTo("ENFERMERO") == 0)
            {
                clsEnfermero objEnfermero = new clsEnfermero();
                objEnfermero.IdEnfermero = ventanaBienvenida.getIdEmpleado();

                objEmpleado = ctrEnfermero.seleccionarEnfermero(objEnfermero);
            }
            else if (ventanaBienvenida.getTipoEmpleado().CompareTo("TÉCNICO") == 0)
            {
                clsTecnico objTecnico = new clsTecnico();
                objTecnico.IdTecnico = ventanaBienvenida.getIdEmpleado();

                objEmpleado = ctrTecnico.seleccionarTecnico(objTecnico);
            }
            else if (ventanaBienvenida.getTipoEmpleado().CompareTo("ADMINISTRATIVO") == 0)
            {
                clsAdministrativo objAdministrativo = new clsAdministrativo();
                objAdministrativo.IdAdministrativo = ventanaBienvenida.getIdEmpleado();

                objEmpleado = ctrAdministrativo.seleccionarAdministrativo(objAdministrativo);
            }
        }

        private bool compararMenu(string strNombre, object objObjeto)
        {
            if (objObjeto is ToolStripMenuItem)
            {
                if (((ToolStripMenuItem)objObjeto).DropDownItems.Count > 0)
                {
                    for (int i = 0; i < ((ToolStripMenuItem)objObjeto).DropDownItems.Count; i++)
                    {
                        compararMenu(strNombre, ((ToolStripDropDownItem)objObjeto).DropDownItems[i]);
                    }
                }
                else
                {
                    if (strNombre.CompareTo(((ToolStripMenuItem)objObjeto).Text) == 0)
                    {
                        ((ToolStripMenuItem)objObjeto).Enabled = true;
                        return true;
                    }
                }
            }
            else if (objObjeto is ToolStripDropDownItem)
            {
                if (((ToolStripDropDownItem)objObjeto).DropDownItems.Count > 0)
                {
                    for (int i = 0; i < ((ToolStripDropDownItem)objObjeto).DropDownItems.Count; i++)
                    {
                        compararMenu(strNombre, ((ToolStripDropDownItem)objObjeto).DropDownItems[i]);
                    }
                }
                else
                {
                    if (strNombre.CompareTo(((ToolStripDropDownItem)objObjeto).Name) == 0)
                    {
                        ((ToolStripDropDownItem)objObjeto).Enabled = true;
                        return true;
                    }
                }
            }

            return false;
        }

        private void smnuContrasena_Click(object sender, EventArgs e)
        {
            frmCambiarContrasena ventanaCambiarContrasena = new frmCambiarContrasena(this);
            ventanaCambiarContrasena.ShowDialog();
        }

        private void smnuPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente ventanaPaciente = new frmPaciente(this);
            ventanaPaciente.MdiParent = this;
            ventanaPaciente.Show();
        }

        private void smnuCitas_Click(object sender, EventArgs e)
        {
            frmCita ventanaCita = new frmCita();
            ventanaCita.MdiParent = this;
            ventanaCita.Show();
        }

        private void smnuDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor ventanaDoctor = new frmDoctor();
            ventanaDoctor.MdiParent = this;
            ventanaDoctor.Show();
        }

        private void smnuEnfermero_Click(object sender, EventArgs e)
        {
            frmEnfermero ventanaEnfermero = new frmEnfermero();
            ventanaEnfermero.MdiParent = this;
            ventanaEnfermero.Show();
        }

        private void smnuAdministrativo_Click(object sender, EventArgs e)
        {
            frmAdministrativo ventanaAdministrativo = new frmAdministrativo();
            ventanaAdministrativo.MdiParent = this;
            ventanaAdministrativo.Show();
        }

        private void smnuTecnico_Click(object sender, EventArgs e)
        {
            frmTecnico ventanaTecnico = new frmTecnico();
            ventanaTecnico.MdiParent = this;
            ventanaTecnico.Show();
        }

        private void smnuHistoriaClinica_Click(object sender, EventArgs e)
        {
            frmHistorialClinica ventanaHistoriaClinica = new frmHistorialClinica(true, 1);
            ventanaHistoriaClinica.MdiParent = this;
            ventanaHistoriaClinica.Show();
        }

        private void smnuHorario_Click(object sender, EventArgs e)
        {
            if (objEmpleado is clsDoctor)
            {
                if (!clsVentanas.VentanaHorarioActiva)
                {
                    clsVentanas.VentanaHorarioActiva = true;
                    frmDisponibilidad ventanaHorario = new frmDisponibilidad(((clsDoctor)objEmpleado)._IdDisponibilidad);
                    ventanaHorario.MdiParent = this;
                    ventanaHorario.Show();
                }
            }
            else
            {
                MessageBox.Show("Sólo un doctor puede modificar su disponibilidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void smnuAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventanaAcercaDe = new frmAcercaDe();
            ventanaAcercaDe.ShowDialog();
        }

        private void smnuArea_Click(object sender, EventArgs e)
        {
            frmArea ventanaArea = new frmArea();
            ventanaArea.MdiParent = this;
            ventanaArea.Show();
        }

        private void smnuEspecialidad_Click(object sender, EventArgs e)
        {
            frmEspecialidad ventanaEspecialidad = new frmEspecialidad();
            ventanaEspecialidad.MdiParent = this;
            ventanaEspecialidad.Show();
        }

        private void smnuPabellon_Click(object sender, EventArgs e)
        {
            frmPabellon ventanaPabellon = new frmPabellon();
            ventanaPabellon.MdiParent = this;
            ventanaPabellon.Show();
        }

        private void smnuConsultorio_Click(object sender, EventArgs e)
        {
            frmConsultorio ventanaConsultorio = new frmConsultorio();
            ventanaConsultorio.MdiParent = this;
            ventanaConsultorio.Show();
        }

        private void smnuModoIngreso_Click(object sender, EventArgs e)
        {
            frmModoIngreso ventanaModoIngreso = new frmModoIngreso();
            ventanaModoIngreso.MdiParent = this;
            ventanaModoIngreso.Show();
        }

        private void smnuTipoDocumento_Click(object sender, EventArgs e)
        {
            frmTipoDocumento ventanaTipoDocumento = new frmTipoDocumento();
            ventanaTipoDocumento.MdiParent = this;
            ventanaTipoDocumento.Show();
        }

        private void smnuOcupacion_Click(object sender, EventArgs e)
        {
            frmOcupacion ventanaOcupacion = new frmOcupacion();
            ventanaOcupacion.MdiParent = this;
            ventanaOcupacion.Show();
        }

        private void smnuReligion_Click(object sender, EventArgs e)
        {
            frmReligion ventanaReligion = new frmReligion();
            ventanaReligion.MdiParent = this;
            ventanaReligion.Show();
        }

        private void smnuIdioma_Click(object sender, EventArgs e)
        {
            frmIdioma ventanaIdioma = new frmIdioma();
            ventanaIdioma.MdiParent = this;
            ventanaIdioma.Show();
        }

        private void smnuEtnia_Click(object sender, EventArgs e)
        {
            frmEtnia ventanaEtnia = new frmEtnia();
            ventanaEtnia.MdiParent = this;
            ventanaEtnia.Show();
        }

        private void smnuPais_Click(object sender, EventArgs e)
        {
            frmPais ventanaPais = new frmPais();
            ventanaPais.MdiParent = this;
            ventanaPais.Show();
        }

        private void smnuCPT_Click(object sender, EventArgs e)
        {
            frmCPT ventanaCPT = new frmCPT();
            ventanaCPT.MdiParent = this;
            ventanaCPT.Show();
        }

        private void smnuLaboratorio_Click(object sender, EventArgs e)
        {
            frmLaboratorio ventanaLaboratorio = new frmLaboratorio();
            ventanaLaboratorio.MdiParent = this;
            ventanaLaboratorio.Show();
        }

        private void smnuFinanciadorSalud_Click(object sender, EventArgs e)
        {
            frmFinanciadorSalud ventanaFinanciadorSalud = new frmFinanciadorSalud();
            ventanaFinanciadorSalud.MdiParent = this;
            ventanaFinanciadorSalud.Show();
        }

        private void smnuUnidadProductoraServicios_Click(object sender, EventArgs e)
        {
            frmUnidadProductoraServicios ventanaUnidadProductoraServicios = new frmUnidadProductoraServicios();
            ventanaUnidadProductoraServicios.MdiParent = this;
            ventanaUnidadProductoraServicios.Show();
        }

        private void smnuCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                Process prsCalculadora = new Process();
                prsCalculadora.StartInfo.FileName = "calc.exe";
                prsCalculadora.StartInfo.Arguments = "";
                prsCalculadora.Start();
            }
            catch (Exception ex)
            {
                clsComun.registrarErrorLog(ex.ToString());
            }
        }

        private void smnuBlocDeNotas_Click(object sender, EventArgs e)
        {
            try
            {
                Process prsCalculadora = new Process();
                prsCalculadora.StartInfo.FileName = "notepad.exe";
                prsCalculadora.StartInfo.Arguments = "";
                prsCalculadora.Start();
            }
            catch (Exception ex)
            {
                clsComun.registrarErrorLog(ex.ToString());
            }
        }

        private void smnuPerfil_Click(object sender, EventArgs e)
        {
            frmPerfil ventanaPerfil = new frmPerfil();
            ventanaPerfil.MdiParent = this;
            ventanaPerfil.Show();
        }

        private void smnuRespaldar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdRespaldar = new SaveFileDialog();
            sfdRespaldar.Title = "Guardar respaldo como";

            sfdRespaldar.Filter = "Archivos BAK (*.bak)|*.bak";
            sfdRespaldar.FilterIndex = 2;
            sfdRespaldar.RestoreDirectory = true;

            if (sfdRespaldar.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(sfdRespaldar.FileName);

                clsBaseDatos objBaseDatos = new clsBaseDatos();
                objBaseDatos.NombreBaseDatos = "CentroSalud";
                objBaseDatos.Ruta = fi.FullName;

                Cursor.Current = Cursors.WaitCursor;

                if (ctrBaseDatos.respaldarBaseDatos(objBaseDatos))
                {
                    MessageBox.Show("Se generó el backup exitosamente", "Respaldo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error mientras se intentaba generar el backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void smnuRestaurar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Al restaurar el sistema puede que pierda infomación reciente.\nSe recomienda hacer una copia de respaldo antes.\n\n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenFileDialog ofdRestaurar = new OpenFileDialog();
                ofdRestaurar.Title = "Seleccionar archivo de respaldo";

                ofdRestaurar.Filter = "Archivos BAK (*.bak)|*.bak";
                ofdRestaurar.FilterIndex = 2;
                ofdRestaurar.RestoreDirectory = true;

                if (ofdRestaurar.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofdRestaurar.FileName);

                    clsBaseDatos objBaseDatos = new clsBaseDatos();
                    objBaseDatos.NombreBaseDatos = "CentroSalud";
                    objBaseDatos.Ruta = fi.FullName;

                    Cursor.Current = Cursors.WaitCursor;

                    if (ctrBaseDatos.restaurarBaseDatos(objBaseDatos))
                    {
                        MessageBox.Show("El sistema se restauró exitosamente", "Restaurado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error mientras se intentaba restaurar el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void smnuCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void smnuMosaicoVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void smnuMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void smnuCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void smnuBarraHerramientas_Click(object sender, EventArgs e)
        {
            tsIconos.Visible = smnuBarraHerramientas.Checked;
        }

        private void smnuBarraEstado_Click(object sender, EventArgs e)
        {
            sstInformacion.Visible = smnuBarraEstado.Checked;
        }

        private void smnuBarraAcciones_Click(object sender, EventArgs e)
        {
            smnuBarraAcciones.Checked = !smnuBarraAcciones.Checked;
            bbarIconos.Visible = smnuBarraAcciones.Checked;
        }

        private void smnuSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro(a) de que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (this.ventanaBienvenida != null)
                {
                    this.Dispose();
                    this.ventanaBienvenida.limpiarFormulario();
                    this.ventanaBienvenida.Visible = true;
                }
                else
                {
                    this.Dispose();
                }
            }
        }

        public int obtenerIdEmpleado()
        {
            return ventanaBienvenida.getIdEmpleado();
        }

        public string obtenerContrasenaEmpleado()
        {
            return ventanaBienvenida.getContrasena();
        }

        public void setearContrasenaEmpleado(string strContrasena)
        {
            ventanaBienvenida.setContrasena(strContrasena);
        }

        public string obtenerNombreUsuarioEmpleado()
        {
            return ventanaBienvenida.getUsuario();
        }

        public void setearNombreUsuarioEmpleado(string strContrasena)
        {
            ventanaBienvenida.setUsuario(strContrasena);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro(a) de que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (this.ventanaBienvenida != null)
                {
                    this.Dispose();
                    this.ventanaBienvenida.limpiarFormulario();
                    this.ventanaBienvenida.Visible = true;
                }
                else
                {
                    this.Dispose();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tsbContrasena_Click(object sender, EventArgs e)
        {
            smnuContrasena_Click(sender, e);
        }

        private void tsbPaciente_Click(object sender, EventArgs e)
        {
            smnuPaciente_Click(sender, e);
        }

        private void tsbCitas_Click(object sender, EventArgs e)
        {

        }

        private void tsbHistoriaClinica_Click(object sender, EventArgs e)
        {
            smnuHistoriaClinica_Click(sender, e);
        }

        private void tsbFormularioHIS_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            smnuSalir_Click(sender, e);
        }

        private void bbtnCambiarContrasena_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuContrasena_Click(sender, e);
        }

        private void bbtnPaciente_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuPaciente_Click(sender, e);
        }

        private void bbtnCita_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void bbtnHistoriaClinica_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuHistoriaClinica_Click(sender, e);
        }

        private void bbtnFormularioHIS_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void bbtnSalir_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuSalir_Click(sender, e);
        }

        private void bbtnCalculadora_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuCalculadora_Click(sender, e);
        }

        private void bbtnBlocDeNotas_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuBlocDeNotas_Click(sender, e);
        }

        private void bbtnDoctor_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuDoctor_Click(sender, e);
        }

        private void bbtnEnfermero_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuEnfermero_Click(sender, e);
        }

        private void bbtnTecnico_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuTecnico_Click(sender, e);
        }

        private void bbtnAdministrativo_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuAdministrativo_Click(sender, e);
        }

        private void bbtnPerfil_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            smnuPerfil_Click(sender, e);
        }

        private void bbtnAuditoria_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }
    }
}
