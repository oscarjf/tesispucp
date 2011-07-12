using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Logica;

namespace SistemaCentroSalud
{
    public partial class frmFormularioHIS : Form
    {
        List<clsHIS> lstHIS = new List<clsHIS>();
        private string strSexo; //M:Masculino, F:Femenino
        int contador = 0;

        public frmFormularioHIS()
        {
            InitializeComponent();            
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmFormularioHIS_Load(object sender, EventArgs e)
        {
            cboSexo.SelectedIndex = 0; // para llenar el combobox de SEXO

            // para llenar el combobox de distritos de LIMA
            List<clsUbigeo> lstDistritos = clsGestorLogico.up_SelDistrito("15", "01"); 
            llenarComboDistritoDomicilio(lstDistritos);
            cboDistritoProcedencia.SelectedIndex = 0;
        }

        private void llenarComboDistritoDomicilio(List<clsUbigeo> lstDistritos)
        {
            cboDistritoProcedencia.Items.Clear();

            clsUbigeo objDistrito = new clsUbigeo();
            objDistrito.StrNombre = "SELECCIONAR";

            cboDistritoProcedencia.Items.Add(objDistrito);

            for (int i = 0; i < lstDistritos.Count; i++)
            {
                cboDistritoProcedencia.Items.Add(lstDistritos[i]);
            }
        }
        
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                contador = contador - 1;
                if (contador > -1)
                {
                                                                                    
                }
            }            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                contador = contador + 1;
                if (contador < lstHIS.Count)
                {

                }
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                contador = 0;

            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                contador = lstHIS.Count - 1;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsHIS objHIS = new clsHIS();
            objHIS.Fecharegistro = DateTime.Today.Date;
            objHIS.NumeroHC = 1;
            objHIS.CodDistritoProcedencia = cboDistritoProcedencia.Text;
            objHIS.Edad = Int32.Parse(txtEdad.Text);
            objHIS.Sexo = strSexo;
            objHIS.Idcie10 = 1;
            
            if (rbtnDiagnosticoP.Checked) objHIS.Tipodiagnostico="P";
            if (rbtnDiagnosticoD.Checked) objHIS.Tipodiagnostico = "D";
            if (rbtnDiagnosticoR.Checked) objHIS.Tipodiagnostico = "R";

            if (rbtnEstablecimientoN.Checked) objHIS.Establecimiento = "N";
            if (rbtnEstablecimientoC.Checked) objHIS.Establecimiento = "C";            
            if (rbtnEstablecimientoR.Checked) objHIS.Establecimiento = "R";

            if (rbtnServicioN.Checked) objHIS.Servicio = "N";
            if (rbtnServicioC.Checked) objHIS.Servicio = "C";
            if (rbtnServicioR.Checked) objHIS.Servicio = "R";

            lstHIS.Add(objHIS);

            limpiar_campos();
        }

        private void limpiar_campos()
        {
            txtNumeroHistoriaClinica.Clear();
            cboDistritoProcedencia.SelectedIndex = 0;
            txtEdad.Clear();
            cboSexo.SelectedIndex = 0;
            txtDiagnostico.Clear();
            
            rbtnDiagnosticoP.Checked=false;
            rbtnDiagnosticoD.Checked = false;
            rbtnDiagnosticoR.Checked = false;

            rbtnEstablecimientoN.Checked = false;
            rbtnEstablecimientoC.Checked = false;
            rbtnEstablecimientoR.Checked = false;

            rbtnServicioN.Checked = false;
            rbtnServicioC.Checked = false;
            rbtnServicioR.Checked = false;
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSexo.SelectedIndex == 1)
            {
                strSexo = "M";
            }
            if (cboSexo.SelectedIndex == 2)
            //else
            {
                strSexo = "F";
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }
    }
}
