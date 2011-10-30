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
            throw new NotImplementedException();
        }

        private void cargarCombosDepartamento()
        {
            throw new NotImplementedException();
        }

        private void cargarComboArea()
        {
            throw new NotImplementedException();
        }
    }
}
