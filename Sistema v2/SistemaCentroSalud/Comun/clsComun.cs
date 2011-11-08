using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Comun
{
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

        //public static bool enviarCorreo(string strDestinatario, clsPersonal objPersonal)
        //{
        //    try
        //    {
        //        MailMessage correo = new MailMessage();

        //        string asunto = "Contraseña Biblioteca Virtual";
        //        string cuerpo = "";

        //        correo.From = new MailAddress("sistema.centro.salud@gmail.com", "Sistema Centro de Salud", System.Text.Encoding.UTF8);
        //        correo.To.Add(strDestinatario);
        //        correo.Subject = asunto;
        //        correo.SubjectEncoding = System.Text.Encoding.UTF8;

        //        cuerpo += "Estimado(a):\n";
        //        cuerpo += objPersonal.StrApellidoPaterno + " " + objPersonal.StrApellidoMaterno + ", " + objPersonal.StrNombres + "\n\n";

        //        cuerpo += "Sus datos de acceso al Sistema son:\n";
        //        cuerpo += "=====================================\n";
        //        cuerpo += "Usuario: " + objPersonal.StrUsuario + "\n";
        //        cuerpo += "Contraseña: " + objPersonal.StrContrasena + "\n\n";
        //        cuerpo += "*Recuerde que puede cambiar su contraseña\n";
        //        cuerpo += "\n";


        //        correo.Body = cuerpo;
        //        correo.BodyEncoding = System.Text.Encoding.UTF8;
        //        correo.IsBodyHtml = false;
        //        correo.Priority = MailPriority.High;

        //        SmtpClient smtp = new SmtpClient();
        //        smtp.Host = "smtp.gmail.com";
        //        smtp.Port = 587;
        //        smtp.EnableSsl = true;
        //        smtp.Credentials = new System.Net.NetworkCredential("sistema.centro.salud@gmail.com", "tesispucp");
        //        try
        //        {
        //            smtp.Send(correo);
        //        }
        //        catch (System.Net.Mail.SmtpException ex)
        //        {
        //            registrarErrorLog(ex.ToString());
        //            return false;
        //        }

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        registrarErrorLog(ex.ToString());
        //        return false;
        //    }
        //}

        public static string generarContrasenaAleatoria(int numLongitudContrasena)
        {
            string strCaracteresPermitidos = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789!@$?";
            Byte[] bytAleatorio = new Byte[numLongitudContrasena];
            char[] chrCaracteres = new char[numLongitudContrasena];
            int numContadorCaracteresPermitidos = strCaracteresPermitidos.Length;

            for (int i = 0; i < numLongitudContrasena; i++)
            {
                Random randomObj = new Random();
                randomObj.NextBytes(bytAleatorio);
                chrCaracteres[i] = strCaracteresPermitidos[(int)bytAleatorio[i] % numContadorCaracteresPermitidos];
            }

            return new string(chrCaracteres);
        }

        public static void tabSiguiente(TabControl tbc, TabPage tbpBuscar, TabPage tbpDetalle)
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbc.SelectedTab = tbpDetalle;
        }

        public static void tabAnterior(TabControl tbc, TabPage tbpBuscar, TabPage tbpDetalle)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbc.SelectedTab = tbpBuscar;
        }

        public static void redimensionarTabControl(TabControl tbc, int numAncho, int numAlto)
        {
            tbc.Width = numAncho;
            tbc.Height = numAlto;
        }

        public static void redimensionarVentana(Form frmVentana, int numAncho, int numAlto)
        {
            frmVentana.Width = numAncho;
            frmVentana.Height = numAlto;
        }

        public static byte[] ImageABytes(Image imgFoto)
        {
            string strTemporal = Path.GetTempFileName();
            FileStream fs = new FileStream(strTemporal, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            imgFoto.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;
            
            int numTamano = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[numTamano];
            
            fs.Read(bytes, 0, numTamano);
            fs.Close();

            return bytes;
        }

        public static Image BytesAImage(byte[] bytes)
        {
            if (bytes == null) return null;
            
            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return bm;
        }

        public static string textoCombo(string strCadena)
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
    }
}
