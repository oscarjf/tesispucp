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
using Control;
using System.Data.SqlClient;

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

        private void cargarCIE10()
        {

            SqlConnection sqlConexion = clsGestorBD.Conectar();
            
            SqlCommand sqlComando = new SqlCommand("SELECT Descripcion + ' [' + Codigo + ']' FROM Cie10", sqlConexion);

            sqlConexion.Open();


            SqlDataReader sqlLector = sqlComando.ExecuteReader();


            while (sqlLector.Read())
            {

                txtDiagnostico.AutoCompleteCustomSource.Add(sqlLector[0].ToString());

            }

            sqlLector.Close();

            sqlConexion.Close();

        }


        private void frmFormularioHIS_Load(object sender, EventArgs e)
        {
            cboSexo.SelectedIndex = 0; // para llenar el combobox de SEXO

            // para llenar el combobox de distritos de LIMA
            List<clsUbigeo> lstDistritos = clsGestorLogico.up_SelDistrito("15", "01"); 
            llenarComboDistritoDomicilio(lstDistritos);
            cboDistritoProcedencia.SelectedIndex = 0;
            cargarCIE10();
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

        private void llenar_datos(int contador)
        {
            txtNumeroHistoriaClinica.Text = lstHIS[contador].NumeroHC + "";
            cboDistritoProcedencia.Text = lstHIS[contador].CodDistritoProcedencia;
            txtEdad.Text = lstHIS[contador].Edad + "";

            if (lstHIS[contador].Sexo.ToString().CompareTo("M") == 0)
            {
                cboSexo.SelectedIndex = 1;
            }
            else
            {
                cboSexo.SelectedIndex = 2;
            }

            txtDiagnostico.Text = "diagnostico";

            if (lstHIS[contador].Tipodiagnostico.CompareTo("P") == 0)
            {
                rbtnDiagnosticoP.Checked = true;
            }

            if (lstHIS[contador].Tipodiagnostico.CompareTo("D") == 0)
            {
                rbtnDiagnosticoD.Checked = true;
            }

            if (lstHIS[contador].Tipodiagnostico.CompareTo("R") == 0)
            {
                rbtnDiagnosticoR.Checked = true;
            }
            //----------------------------------------------------------
            if (lstHIS[contador].Establecimiento.CompareTo("N") == 0)
            {
                rbtnEstablecimientoN.Checked = true;
            }

            if (lstHIS[contador].Establecimiento.CompareTo("C") == 0)
            {
                rbtnEstablecimientoC.Checked = true;
            }

            if (lstHIS[contador].Establecimiento.CompareTo("R") == 0)
            {
                rbtnEstablecimientoR.Checked = true;
            }
            //----------------------------------------------------------
            if (lstHIS[contador].Servicio.CompareTo("N") == 0)
            {
                rbtnServicioN.Checked = true;
            }

            if (lstHIS[contador].Servicio.CompareTo("C") == 0)
            {
                rbtnServicioC.Checked = true;
            }

            if (lstHIS[contador].Servicio.CompareTo("R") == 0)
            {
                rbtnServicioR.Checked = true;
            }                     
        }                                                  

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                if (contador > 0)
                {
                    contador = contador - 1;
                    if (contador > -1)
                    {
                        limpiar_campos();
                        llenar_datos(contador);                                                              
                    }
                }
            }            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                //if (contador <= lstHIS.Count - 1)
                if (contador < lstHIS.Count - 1)
                {
                    contador = contador + 1;
                    if (contador < lstHIS.Count)
                    {
                        limpiar_campos();
                        llenar_datos(contador);
                    }
                }
                else
                {
                    contador = lstHIS.Count;
                    limpiar_campos();
                }
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                contador = 0;
                limpiar_campos();
                llenar_datos(contador);                                                              
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (lstHIS.Count > 0)
            {
                contador = lstHIS.Count - 1;
                limpiar_campos();
                llenar_datos(contador);
            }
        }

        private bool validar_ventana()
        {
            if (txtNumeroHistoriaClinica.Text.CompareTo("") != 0)
            {                
                if (cboDistritoProcedencia.Text.CompareTo("SELECCIONAR") != 0)
                {
                    if (txtEdad.Text.CompareTo("") != 0)
                    {
                        if (cboSexo.Text.CompareTo("SELECCIONAR") != 0)
                        {
                            if (txtDiagnostico.Text.CompareTo("") != 0)
                            {
                                if (rbtnDiagnosticoD.Checked || rbtnDiagnosticoP.Checked || rbtnDiagnosticoR.Checked)
                                {
                                    if (rbtnEstablecimientoC.Checked || rbtnEstablecimientoN.Checked || rbtnEstablecimientoR.Checked)
                                    {
                                        if (rbtnServicioC.Checked || rbtnServicioN.Checked || rbtnServicioR.Checked)
                                        {                                            
                                            return true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Debe ingresar algún tipo de servicio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe ingresar algún tipo de establecimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar algún tipo de diagnóstico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe seleccionar la descripción del diagnóstico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtDiagnostico.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar el sexo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cboSexo.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar la edad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEdad.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el distrito de procedencia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboDistritoProcedencia.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el número de la historia clínica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumeroHistoriaClinica.Focus();
                return false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar_ventana())
            {
                contador = lstHIS.Count;
                clsHIS objHIS = new clsHIS();
                objHIS.Fecharegistro = DateTime.Today.Date;
                objHIS.NumeroHC = Int32.Parse(txtNumeroHistoriaClinica.Text);
                objHIS.CodDistritoProcedencia = cboDistritoProcedencia.Text;
                objHIS.Edad = Int32.Parse(txtEdad.Text);
                objHIS.Sexo = strSexo;



                objHIS.Idcie10 = 1;

                if (rbtnDiagnosticoP.Checked) objHIS.Tipodiagnostico = "P";
                if (rbtnDiagnosticoD.Checked) objHIS.Tipodiagnostico = "D";
                if (rbtnDiagnosticoR.Checked) objHIS.Tipodiagnostico = "R";

                if (rbtnEstablecimientoN.Checked) objHIS.Establecimiento = "N";
                if (rbtnEstablecimientoC.Checked) objHIS.Establecimiento = "C";
                if (rbtnEstablecimientoR.Checked) objHIS.Establecimiento = "R";

                if (rbtnServicioN.Checked) objHIS.Servicio = "N";
                if (rbtnServicioC.Checked) objHIS.Servicio = "C";
                if (rbtnServicioR.Checked) objHIS.Servicio = "R";

                lstHIS.Add(objHIS);
                contador = contador + 1;

                limpiar_campos();
            }
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
            if (lstHIS.Count > 0)
            {
                for (int i = 0; i < lstHIS.Count; i++)
                {
                    bool flag=clsGestorBD.up_ManHIS(lstHIS[i].Fecharegistro,lstHIS[i].NumeroHC,lstHIS[i].CodDistritoProcedencia,lstHIS[i].Edad,lstHIS[i].Sexo,lstHIS[i].Idcie10,lstHIS[i].Tipodiagnostico,lstHIS[i].Establecimiento,lstHIS[i].Servicio,0);
                }
                if (MessageBox.Show("El formulario se registró exitosamente\n¿Desea seguir registrando?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contador = 0;
                    lstHIS.Clear();
                }
                else
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Debe tener al menos un registro para poder realizar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
