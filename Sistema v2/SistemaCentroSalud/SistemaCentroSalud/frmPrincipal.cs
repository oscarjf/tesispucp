using System;
using System.Diagnostics;
using System.Windows.Forms;
using Comun;
using SistemaCentroSalud.Ventanas_Ayuda;
using SistemaCentroSalud.Ventanas_Doctor;
using SistemaCentroSalud.Ventanas_Mantenimiento;
using SistemaCentroSalud.Ventanas_Personal;
using SistemaCentroSalud.Ventanas_Seguridad;

namespace SistemaCentroSalud
{
    public partial class frmPrincipal : Form
    {
        private frmBienvenida ventanaBienvenida;

        public frmPrincipal(frmBienvenida ventanaBienvenida)
        {
            InitializeComponent();
            this.ventanaBienvenida = ventanaBienvenida;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void smnuPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente ventanaPaciente = new frmPaciente(this);
            ventanaPaciente.MdiParent = this;
            ventanaPaciente.Show();
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

        private void smnuSalir_Click(object sender, EventArgs e)
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

        public int obtenerIdEmpleado()
        {
            return ventanaBienvenida.getIdEmpleado();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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
}
