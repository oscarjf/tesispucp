using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaCentroSalud.Ventanas_Personal;
using SistemaCentroSalud.Ventanas_Ayuda;
using SistemaCentroSalud.Ventanas_Doctor;
using SistemaCentroSalud.Ventanas_Mantenimiento;

namespace SistemaCentroSalud
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(frmBienvenida ventanaBienvenida)
        {
            InitializeComponent();
        }

        private void smnuDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor ventanaDoctor = new frmDoctor();
            ventanaDoctor.MdiParent = this;
            ventanaDoctor.Show();
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
    }
}
