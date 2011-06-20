using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data;
using Control;
using Comun;

namespace Logica
{
    public class clsGestorLogico
    {
        public static int numeroOcurrenciasUsuario(string strNombreUsuario)
        {
            string strSentenciaSql;

            strSentenciaSql = "SELECT COUNT(Usuario) AS NumeroOcurrencias ";
            strSentenciaSql += "FROM Personal ";
            strSentenciaSql += "WHERE Usuario = '" + strNombreUsuario + "'";

            DataTable dt = clsGestorBD.consultarSentencia(strSentenciaSql);

            return Int32.Parse(dt.Rows[0][0].ToString());
        }

        public static List<clsTipoDocumento> up_SelTipoDocumento()
        {
            List<clsTipoDocumento> lstTipoDocumentos = new List<clsTipoDocumento>();
            DataTable dtTipoDocumentos = clsGestorBD.up_SelTipoDocumento();

            for (int i = 0; i < dtTipoDocumentos.Rows.Count; i++)
            {
                string strId = dtTipoDocumentos.Rows[i][0].ToString();
                string strNombre = dtTipoDocumentos.Rows[i][1].ToString();
                string strDescripcion = dtTipoDocumentos.Rows[i][2].ToString();
                string strNumeroDigitos = dtTipoDocumentos.Rows[i][3].ToString();
                string strEstado = dtTipoDocumentos.Rows[i][4].ToString();

                clsTipoDocumento objTipoDocumento = new clsTipoDocumento();

                objTipoDocumento.NumIdTipoDocumento = Int32.Parse(strId);
                objTipoDocumento.StrNombre = strNombre;
                objTipoDocumento.StrDescripcion = strDescripcion;
                objTipoDocumento.NumNumeroDigitos = Int32.Parse(strNumeroDigitos);
                objTipoDocumento.StrEstado = strEstado;

                lstTipoDocumentos.Add(objTipoDocumento);
            }

            return lstTipoDocumentos;
        }

        public static List<clsPais> up_SelPais()
        {
            List<clsPais> lstPaises = new List<clsPais>();
            DataTable dtPaises = clsGestorBD.up_SelPais();

            for (int i = 0; i < dtPaises.Rows.Count; i++)
            {
                string strId = dtPaises.Rows[i][0].ToString();
                string strNombre = dtPaises.Rows[i][1].ToString();

                clsPais objPais = new clsPais();

                objPais.NumIdPais = Int32.Parse(strId);
                objPais.StrNombre = strNombre;
                
                lstPaises.Add(objPais);
            }

            return lstPaises;
        }

        public static List<clsUbigeo> up_SelDepartamento()
        {
            List<clsUbigeo> lstDepartamentos = new List<clsUbigeo>();
            DataTable dtDepartamentos = clsGestorBD.up_SelDepartamento();

            for (int i = 0; i < dtDepartamentos.Rows.Count; i++)
            {
                string strCodigoDepartamento = dtDepartamentos.Rows[i][1].ToString();
                string strCodigoProvincia = dtDepartamentos.Rows[i][2].ToString();
                string strCodigoDistrito = dtDepartamentos.Rows[i][3].ToString();
                string strNombre = dtDepartamentos.Rows[i][4].ToString();
                
                clsUbigeo objDepartamento = new clsUbigeo();

                objDepartamento.StrCodigoDepartamento = strCodigoDepartamento;
                objDepartamento.StrCodigoProvincia = strCodigoProvincia;
                objDepartamento.StrCodigoDistrito = strCodigoDistrito;
                objDepartamento.StrNombre = strNombre;
                
                lstDepartamentos.Add(objDepartamento);
            }

            return lstDepartamentos;
        }

        public static List<clsUbigeo> up_SelProvincia(string strCodigoDepartamento)
        {
            List<clsUbigeo> lstProvincias = new List<clsUbigeo>();
            DataTable dtProvincias = clsGestorBD.up_SelProvincia(strCodigoDepartamento);

            for (int i = 0; i < dtProvincias.Rows.Count; i++)
            {
                string strCodigoDpto = dtProvincias.Rows[i][1].ToString();
                string strCodigoProvincia = dtProvincias.Rows[i][2].ToString();
                string strCodigoDistrito = dtProvincias.Rows[i][3].ToString();
                string strNombre = dtProvincias.Rows[i][4].ToString();

                clsUbigeo objProvincia = new clsUbigeo();

                objProvincia.StrCodigoDepartamento = strCodigoDpto;
                objProvincia.StrCodigoProvincia = strCodigoProvincia;
                objProvincia.StrCodigoDistrito = strCodigoDistrito;
                objProvincia.StrNombre = strNombre;

                lstProvincias.Add(objProvincia);
            }

            return lstProvincias;
        }

        public static List<clsUbigeo> up_SelDistrito(string strCodigoDepartamento, string strCodigoProvincia)
        {
            List<clsUbigeo> lstDistritos = new List<clsUbigeo>();
            DataTable dtDistritos = clsGestorBD.up_SelDistrito(strCodigoDepartamento, strCodigoProvincia);

            for (int i = 0; i < dtDistritos.Rows.Count; i++)
            {
                string strCodigoDpto = dtDistritos.Rows[i][1].ToString();
                string strCodigoProv = dtDistritos.Rows[i][2].ToString();
                string strCodigoDistrito = dtDistritos.Rows[i][3].ToString();
                string strNombre = dtDistritos.Rows[i][4].ToString();

                clsUbigeo objDistrito = new clsUbigeo();

                objDistrito.StrCodigoDepartamento = strCodigoDpto;
                objDistrito.StrCodigoProvincia = strCodigoProv;
                objDistrito.StrCodigoDistrito = strCodigoDistrito;
                objDistrito.StrNombre = strNombre;

                lstDistritos.Add(objDistrito);
            }

            return lstDistritos;
        }

        public static List<clsArea> up_SelArea(string strTipoArea, string strEstadoArea)
        {
            List<clsArea> lstAreas = new List<clsArea>();
            DataTable dtAreas = clsGestorBD.up_SelArea(0, "", strTipoArea, strEstadoArea, clsGestorBD.SELECTCUSTOM);

            for (int i = 0; i < dtAreas.Rows.Count; i++)
            {
                string strId = dtAreas.Rows[i][0].ToString();
                string strNombre = dtAreas.Rows[i][1].ToString();
                string strDescripcion = dtAreas.Rows[i][2].ToString();
                string strTipo = dtAreas.Rows[i][3].ToString();
                string strEstado = dtAreas.Rows[i][4].ToString();

                clsArea objArea = new clsArea();

                objArea.NumIdArea = Int32.Parse(strId);
                objArea.StrNombre = strNombre;
                objArea.StrDescripcion = strDescripcion;
                objArea.StrTipoArea = strTipo;
                objArea.StrEstado = strEstado;

                lstAreas.Add(objArea);
            }

            return lstAreas;
        }

        public static List<clsEspecialidad> up_SelEspecialidad()
        {
            List<clsEspecialidad> lstEspecialidades = new List<clsEspecialidad>();
            DataTable dtEspecialidades = clsGestorBD.up_SelEspecialidad(0, "", "ACTIVO", clsGestorBD.SELECTCUSTOM);

            for (int i = 0; i < dtEspecialidades.Rows.Count; i++)
            {
                string strId = dtEspecialidades.Rows[i][0].ToString();
                string strNombre = dtEspecialidades.Rows[i][1].ToString();
                string strDescripcion = dtEspecialidades.Rows[i][2].ToString();
                string strEstado = dtEspecialidades.Rows[i][3].ToString();

                clsEspecialidad objEspecialidad = new clsEspecialidad();

                objEspecialidad.NumIdEspecialidad = Int32.Parse(strId);
                objEspecialidad.StrNombre = strNombre;
                objEspecialidad.StrDescripcion = strDescripcion;
                objEspecialidad.StrEstado = strEstado;

                lstEspecialidades.Add(objEspecialidad);
            }

            return lstEspecialidades;
        }

        public static List<clsPerfil> up_SelPerfil()
        {
            List<clsPerfil> lstPerfiles = new List<clsPerfil>();
            DataTable dtPerfiles = clsGestorBD.up_SelPerfil(0, "", "DOCTOR", "ACTIVO", clsGestorBD.SELECTCUSTOM);

            for (int i = 0; i < dtPerfiles.Rows.Count; i++)
            {
                string strId = dtPerfiles.Rows[i][0].ToString();
                string strNombre = dtPerfiles.Rows[i][1].ToString();
                string strTipoPersonal = dtPerfiles.Rows[i][2].ToString();
                string strEstado = dtPerfiles.Rows[i][3].ToString();

                clsPerfil objPerfil = new clsPerfil();

                objPerfil.NumIdPerfil = Int32.Parse(strId);
                objPerfil.StrNombre = strNombre;
                objPerfil.StrTipoPersonal = strTipoPersonal;
                objPerfil.StrEstado = strEstado;

                lstPerfiles.Add(objPerfil);
            }

            return lstPerfiles;
        }

    }
}
