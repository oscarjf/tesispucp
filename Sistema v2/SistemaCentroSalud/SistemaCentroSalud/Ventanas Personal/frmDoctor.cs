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

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();      
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            //GRID: 788, 492		569, 417 
            //FORM: 794, 519		573, 443
            
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            cargarComboEspecialidad();
            cargarComboTipoDocumento();
            //cargarComboPais();
            //cargarCombosDepartamento();
            //cargarComboArea();
            //cargarComboPerfil();

            cboEspecialidadBuscar.SelectedIndex = 0;
            cboEstadoBuscar.SelectedIndex = 0;
        }

        private void cargarComboEspecialidad()
        {
            clsEspecialidad objEspecialidad = new clsEspecialidad();
            
            DataTable dt = ctrEspecialidad.seleccionarEspecialidades(objEspecialidad);

            objEspecialidad.Nombre = "TODAS";

            cboEspecialidadBuscar.Items.Add(objEspecialidad);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objEspecialidad = new clsEspecialidad();

                objEspecialidad.IdEspecialidad = Int32.Parse(dt.Rows[i]["IdEspecialidad"].ToString());
                objEspecialidad.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboEspecialidadBuscar.Items.Add(objEspecialidad);
            }
        }

        private void cargarComboTipoDocumento()
        {
            clsTipoDocumento objTipoDocumento = new clsTipoDocumento();

            DataTable dt = ctrTipoDocumento.seleccionarTiposDocumento(objTipoDocumento);

            objTipoDocumento.Nombre = "SELECCIONAR";

            cboTipoDocumento.Items.Add(objTipoDocumento);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objTipoDocumento = new clsTipoDocumento();

                objTipoDocumento.IdTipoDocumento = Int32.Parse(dt.Rows[i]["IdTipoDocumento"].ToString());
                objTipoDocumento.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboTipoDocumento.Items.Add(objTipoDocumento);
            }
        }

        private void cargarComboPais()
        {
            clsPais objPais = new clsPais();

            DataTable dt = ctrPais.seleccionarPaises(objPais);

            objPais.Nombre = "SELECCIONAR";

            cboPais.Items.Add(objPais);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objPais = new clsPais();

                objPais.IdPais = Int32.Parse(dt.Rows[i]["IdPais"].ToString());
                objPais.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboPais.Items.Add(objPais);
            }
        }

        private void cargarCombosDepartamento()
        {
            clsUbigeo objUbigeo = new clsUbigeo();

            DataTable dt = ctrUbigeo.seleccionarDepartamentos();

            objUbigeo.Descripcion = "SELECCIONAR";

            cboDepartamento.Items.Add(objUbigeo);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objUbigeo = new clsUbigeo();

                objUbigeo.IdUbigeo = Int32.Parse(dt.Rows[i]["IdUbigeo"].ToString());
                objUbigeo.CodDepartamento = dt.Rows[i]["CodDepartamento"].ToString();
                objUbigeo.Descripcion = dt.Rows[i]["Descripcion"].ToString();

                cboDepartamento.Items.Add(objUbigeo);
            }
        }

        private void cargarComboArea()
        {
            clsArea objArea = new clsArea();
            objArea.TipoArea = "MÉDICA";

            DataTable dt = ctrArea.seleccionarAreasCriterios(objArea);

            objArea.Nombre = "SELECCIONAR";

            cboArea.Items.Add(objArea);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objArea = new clsArea();

                objArea.IdArea = Int32.Parse(dt.Rows[i]["IdArea"].ToString());
                objArea.Nombre = dt.Rows[i]["Nombre"].ToString();

                cboArea.Items.Add(objArea);
            }
        }
    }
}
