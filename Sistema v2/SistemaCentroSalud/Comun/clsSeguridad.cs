using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Comun
{
    public class clsSeguridad
    {
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
    }
}
