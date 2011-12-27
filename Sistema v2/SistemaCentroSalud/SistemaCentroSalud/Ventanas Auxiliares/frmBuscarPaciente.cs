using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCentroSalud
{
    public partial class frmBuscarPaciente : Form
    {
        private frmHorario ventanaHorario; 

        public frmBuscarPaciente(frmHorario ventanaHorario)
        {
            InitializeComponent();
            this.ventanaHorario = ventanaHorario;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ventanaHorario.setearCita();
            this.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
