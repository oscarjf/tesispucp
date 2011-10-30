using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCentroSalud.Ventanas_Ayuda
{
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();

            string strContenido = "";

            strContenido += "Este sistema ha sido desarrollado por:\n";
            strContenido += "- Wilder Josue Chicana Vivar\n";
            strContenido += "- Claudio Roberto Ávalos Romero\n\n";
            strContenido += "Como parte de un proyecto de fin de carrera para la obtención del título\n";
            strContenido += "de Ingeniero Informático.";

            rtxtAcercaDe.Text = strContenido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
