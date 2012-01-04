using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Control;

namespace SistemaCentroSalud
{
    public partial class frmTriaje : Form
    {
        public frmTriaje()
        {
            InitializeComponent();
        }

        private void frmTriaje_Load(object sender, EventArgs e)
        {
            cargarComboTipoDocumento();
            cboTipoDocumentoBuscar.SelectedIndex = 0;
            cboGrupoSanguineo.SelectedIndex = 0;
            cboFactorSanguineo.SelectedIndex = 0;
        }

        private void cargarComboTipoDocumento()
        {
            clsTipoDocumento objTipoDocumento = new clsTipoDocumento();

            DataTable dt = ctrTipoDocumento.seleccionarTiposDocumento(objTipoDocumento);

            objTipoDocumento.Nombre = "SELECCIONAR";

            cboTipoDocumentoBuscar.Items.Add(objTipoDocumento);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objTipoDocumento = new clsTipoDocumento();

                objTipoDocumento.IdTipoDocumento = Int32.Parse(dt.Rows[i]["IdTipoDocumento"].ToString());
                objTipoDocumento.Nombre = dt.Rows[i]["Nombre"].ToString();
                objTipoDocumento.NumeroDigitos = dt.Rows[i]["NumeroDigitos"].ToString();

                cboTipoDocumentoBuscar.Items.Add(objTipoDocumento);
            }
        }

        private void cboTipoDocumentoBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDocumentoBuscar.SelectedIndex != 0)
            {
                txtNumeroDocumentoBuscar.Clear();
                txtNumeroDocumentoBuscar.MaxLength = Int32.Parse(((clsTipoDocumento)cboTipoDocumentoBuscar.SelectedItem).NumeroDigitos);
                txtNumeroDocumentoBuscar.Enabled = true;
            }
            else
            {
                txtNumeroDocumentoBuscar.Clear();
                txtNumeroDocumentoBuscar.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
