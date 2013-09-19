using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Modelo;

namespace Comun
{
    /// <summary>
    /// Clase que contiene métodos comunes a varios proyectos
    /// </summary>
    public class clsComun
    {
        public const int INSERTAR = 0;
        public const int MODIFICAR = 1;
        public const int ELIMINAR = 2;
        public const int RECUPERAR = 3;
        public const int SELECCIONAR = 4;
        public const int SELECCIONARTODO = 5;
        public const int SELECCIONARCRITERIO = 6;
        public const int VER = 7;

        /// <summary>
        /// Registra en un archivo de texto los errores encontrados
        /// </summary>
        /// <param name="strError"> Descripción del error </param>
        public static void registrarErrorLog(string strError)
        {
            try
            {
                string strDia = DateTime.Now.ToString("dd/MM/yyyy");
                string strHora = DateTime.Now.ToString("hh:mm:ss");
                string strRuta = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
                string strLinea = strDia + " - " + strHora + " >>>> " + strError;

                StreamWriter sw = File.AppendText(strRuta);

                sw.WriteLine(strLinea);

                sw.Close();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Valida el formato de un correo electrónico
        /// </summary>
        /// <param name="strEmail"> Correo electrónico a evaluar </param>
        /// <returns>bool</returns>
        public static bool validarCorreoElectronico(string strEmail)
        {
            string strExpresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(strEmail, strExpresion))
            {
                if (Regex.Replace(strEmail, strExpresion, String.Empty).Length == 0)
                { 
                    return true; 
                }
                else
                { 
                    return false; 
                }
            }
            else
            { 
                return false; 
            }
        }

        /// <summary>
        /// Calcula la edad
        /// </summary>
        /// <param name="fechaNacimiento"> Fecha de nacimiento </param>
        /// <returns>int</returns>
        public static int calcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            
            DateTime nacimientoAhora = fechaNacimiento.AddYears(edad);
            
            if (DateTime.Now.CompareTo(nacimientoAhora) < 0)
            {
                edad--;
            }

            return edad;
        }

        /// <summary>
        /// Envía un correo eléctronico a un destinatario
        /// </summary>
        /// <param name="strDestinatario"> Correo electrónico del destinatario </param>
        /// <param name="strPaterno"> Apellido paterno del destinatario </param>
        /// <param name="strMaterno"> Apellido materno del destinatario </param>
        /// <param name="strNombres"> Nombres del destinatario </param>
        /// <param name="strUsuario"> Nombre de usuario  del destinatario </param>
        /// <param name="strContrasena"> Contraseña  del destinatario </param>
        /// <returns>bool</returns>
        public static bool enviarCorreo(string strDestinatario, string strPaterno, string strMaterno, string strNombres, string strUsuario, string strContrasena)
        {
            try
            {
                MailMessage correo = new MailMessage();

                string asunto = "Contraseña Sistema Centro de Salud";
                string cuerpo = "";

                correo.From = new MailAddress("sistema.centro.salud@gmail.com", "Sistema Centro de Salud", System.Text.Encoding.UTF8);
                correo.To.Add(strDestinatario);
                correo.Subject = asunto;
                correo.SubjectEncoding = System.Text.Encoding.UTF8;

                cuerpo += "Estimado(a):\n";
                cuerpo += strPaterno + " " + strMaterno + ", " + strNombres + "\n\n";

                cuerpo += "Sus datos de acceso al Sistema son:\n";
                cuerpo += "=====================================\n";
                cuerpo += "Usuario: " + strUsuario + "\n";
                cuerpo += "Contraseña: " + strContrasena + "\n\n";
                cuerpo += "*Recuerde que puede cambiar su contraseña\n";
                cuerpo += "\n";


                correo.Body = cuerpo;
                correo.BodyEncoding = System.Text.Encoding.UTF8;
                correo.IsBodyHtml = false;
                correo.Priority = MailPriority.High;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("sistema.centro.salud@gmail.com", "tesispucp");
                try
                {
                    smtp.Send(correo);
                }
                catch (System.Net.Mail.SmtpException ex)
                {
                    registrarErrorLog(ex.ToString());
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                registrarErrorLog(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Cambia a la segunda pestaña de un 'TabControl'
        /// </summary>
        /// <param name="tbc"> TabControl </param>
        /// <param name="tbpBuscar"> Primera pestaña del TabControl </param>
        /// <param name="tbpDetalle"> Segunta pestaña del TabControl </param>
        public static void tabSiguiente(TabControl tbc, TabPage tbpBuscar, TabPage tbpDetalle)
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbc.SelectedTab = tbpDetalle;
        }

        /// <summary>
        /// Cambia a la primera pestaña de un 'TabControl'
        /// </summary>
        /// <param name="tbc"> TabControl </param>
        /// <param name="tbpBuscar"> Primera pestaña del TabControl </param>
        /// <param name="tbpDetalle"> Segunta pestaña del TabControl </param>
        public static void tabAnterior(TabControl tbc, TabPage tbpBuscar, TabPage tbpDetalle)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbc.SelectedTab = tbpBuscar;
        }

        /// <summary>
        /// Cambia de tamaño a un 'TabControl'
        /// </summary>
        /// <param name="tbc"> TabControl </param>
        /// <param name="numAncho"> Ancho del TabControl </param>
        /// <param name="numAlto"> Alto del TabControl </param>
        public static void redimensionarTabControl(TabControl tbc, int numAncho, int numAlto)
        {
            tbc.Width = numAncho;
            tbc.Height = numAlto;
        }

        /// <summary>
        /// Cambia de tamaño a un 'Form'
        /// </summary>
        /// <param name="frmVentana"> Formulario </param>
        /// <param name="numAncho"> Ancho del formulario </param>
        /// <param name="numAlto"> Alto del formulario </param>
        public static void redimensionarVentana(Form frmVentana, int numAncho, int numAlto)
        {
            frmVentana.Width = numAncho;
            frmVentana.Height = numAlto;
        }

        /// <summary>
        /// Convierte una cadena 'SELECCIONAR' a una cadena vacía
        /// </summary>
        /// <param name="strCadena"> Cadena a ser evaluada </param>
        /// <returns>string</returns>
        public static string seleccionarToVacio(string strCadena)
        {
            if (strCadena.CompareTo("SELECCIONAR") == 0)
            {
                return "";
            }
            else
            {
                return strCadena;
            }
        }

        /// <summary>
        /// Convierte una cadena vacia a 'SELECCIONAR'
        /// </summary>
        /// <param name="strCadena"> Cadena a ser evaluada </param>
        /// <returns>string</returns>
        public static string vacioToSeleccionar(string strCadena)
        {
            if (strCadena.CompareTo("") == 0)
            {
                return "SELECCIONAR";
            }
            else
            {
                return strCadena;
            }
        }

        /// <summary>
        /// Convierte una cadena vacia a '0'
        /// </summary>
        /// <param name="strCadena"> Cadena a ser evaluada </param>
        /// <returns>string</returns>
        public static string vacioToCero(string strCadena)
        {
            if (strCadena.CompareTo("") == 0)
            {
                return "0";
            }
            else
            {
                return strCadena;
            }
        }

        /// <summary>
        /// Convierte una lista a un archivo XML
        /// </summary>
        /// <param name="lstDetalleDisponibilidad"> Lista a ser convertida </param>
        /// <returns>string</returns>
        public static string Serializar(List<clsDetalleDisponibilidad> lstDetalleDisponibilidad)
        {
            string strXML = null;

            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(List<clsDetalleDisponibilidad>));
            XmlTextWriter xtw = new XmlTextWriter(ms, Encoding.Default);

            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add(String.Empty, String.Empty);

            xs.Serialize(xtw, lstDetalleDisponibilidad, xsn);
            ms = (MemoryStream)xtw.BaseStream;

            UTF8Encoding encoding = new UTF8Encoding();
            strXML = encoding.GetString(ms.ToArray());

            XmlDocument xmlDocumento = new XmlDocument();
            xmlDocumento.LoadXml(strXML);

            CambiarXmlEncoding(xmlDocumento, "UTF-16");
            StringWriter sr = new StringWriter();
            XmlTextWriter xmltr = new XmlTextWriter(sr);
            xmlDocumento.WriteTo(xmltr);

            strXML = sr.ToString();

            sr.Close();
            xmltr.Close();

            return strXML;
        }

        /// <summary>
        /// Convierte una lista a un archivo XML
        /// </summary>
        /// <param name="lstDetalleDisponibilidad"> Lista a ser convertida </param>
        /// <returns>string</returns>
        public static string Serializar(List<clsDetalleDiagnostico> lstDetalleDiagnostico)
        {
            string strXML = null;

            MemoryStream ms = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(List<clsDetalleDiagnostico>));
            XmlTextWriter xtw = new XmlTextWriter(ms, Encoding.Default);

            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add(String.Empty, String.Empty);

            xs.Serialize(xtw, lstDetalleDiagnostico, xsn);
            ms = (MemoryStream)xtw.BaseStream;

            UTF8Encoding encoding = new UTF8Encoding();
            strXML = encoding.GetString(ms.ToArray());

            XmlDocument xmlDocumento = new XmlDocument();
            xmlDocumento.LoadXml(strXML);

            CambiarXmlEncoding(xmlDocumento, "UTF-16");
            StringWriter sr = new StringWriter();
            XmlTextWriter xmltr = new XmlTextWriter(sr);
            xmlDocumento.WriteTo(xmltr);

            strXML = sr.ToString();

            sr.Close();
            xmltr.Close();

            return strXML;
        }

        /// <summary>
        /// Cambia el codificado de un archivo XML
        /// </summary>
        /// <param name="xmlDocumento"> Documento XML </param>
        /// <param name="strEncoding"> Codificación </param>
        /// <returns>XmlDocument</returns>
        private static XmlDocument CambiarXmlEncoding(XmlDocument xmlDocumento, string strEncoding)
        {
            if (xmlDocumento.FirstChild.NodeType == XmlNodeType.XmlDeclaration)
            {
                XmlDeclaration xmlDeclaration = (XmlDeclaration)xmlDocumento.FirstChild;
                xmlDeclaration.Encoding = strEncoding;
            }
            return xmlDocumento;
        }
    }
}
