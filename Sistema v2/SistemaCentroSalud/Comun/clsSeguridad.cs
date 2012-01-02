using System;

namespace Comun
{
    /// <summary>
    /// Clase que contiene métodos relacionados con seguridad de información
    /// </summary>
    public class clsSeguridad
    {
        /// <summary>
        /// Genera una contraseña aleatoria
        /// </summary>
        /// <param name="numLongitudContrasena"> Número de caracteres de la contraseña </param>
        /// <returns>string</returns>
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
