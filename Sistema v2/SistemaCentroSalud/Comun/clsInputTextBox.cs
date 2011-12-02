using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comun
{
    /// <summary>
    /// Clase que emula un InputTextBox de Java
    /// </summary>
    public class clsInputTextBox
    {
        /// <summary>
        /// Muestra el 'InputTextBox'
        /// </summary>
        /// <param name="strTexto"> Texto a mostrar en el mensaje </param>
        /// <param name="strEncabezado"> Título del InputTextBox </param>
        /// <param name="strValor"> Texto ingresado </param>
        /// <returns>DialogResult</returns>
        public static DialogResult Show(string strTexto, string strEncabezado, ref string strValor)
        {
            return Show(strTexto, strEncabezado, ref strValor, null);
        }

        /// <summary>
        /// Muestra el 'InputTextBox'
        /// </summary>
        /// <param name="strTexto"> Texto a mostrar en el mensaje </param>
        /// <param name="strEncabezado"> Título del InputTextBox </param>
        /// <param name="strValor"> Texto ingresado </param>
        /// <param name="itbValidacion"> Delegado que valida lo ingresado en el InputTextBox </param>
        /// <returns>DialogResult</returns>
        public static DialogResult Show(string strTexto, string strEncabezado, ref string strValor, InputBoxValidation itbValidacion)
        {
            Form frmFormulario = new Form();
            Label lblEtiqueta = new Label();
            TextBox txtCajaTexto = new TextBox();
            Button btnOK = new Button();
            Button btnCancel = new Button();

            frmFormulario.Text = strEncabezado;
            lblEtiqueta.Text = strTexto;
            txtCajaTexto.Text = strValor;

            btnOK.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            lblEtiqueta.SetBounds(9, 20, 372, 13);
            txtCajaTexto.SetBounds(12, 36, 372, 20);
            btnOK.SetBounds(228, 72, 75, 23);
            btnCancel.SetBounds(309, 72, 75, 23);

            lblEtiqueta.AutoSize = true;
            txtCajaTexto.Anchor = txtCajaTexto.Anchor | AnchorStyles.Right;
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            frmFormulario.ClientSize = new Size(396, 107);
            frmFormulario.Controls.AddRange(new Control[] { lblEtiqueta, txtCajaTexto, btnOK, btnCancel });
            frmFormulario.ClientSize = new Size(Math.Max(300, lblEtiqueta.Right + 10), frmFormulario.ClientSize.Height);
            frmFormulario.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmFormulario.StartPosition = FormStartPosition.CenterScreen;
            frmFormulario.MinimizeBox = false;
            frmFormulario.MaximizeBox = false;
            frmFormulario.AcceptButton = btnOK;
            frmFormulario.CancelButton = btnCancel;
            if (itbValidacion != null)
            {
                frmFormulario.FormClosing += delegate(object sender, FormClosingEventArgs e)
                {
                    if (frmFormulario.DialogResult == DialogResult.OK)
                    {
                        string errorText = itbValidacion(txtCajaTexto.Text);
                        if (e.Cancel = (errorText != ""))
                        {
                            MessageBox.Show(frmFormulario, errorText, "Mensaje",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCajaTexto.Focus();
                        }
                    }
                };
            }
            DialogResult dialogResult = frmFormulario.ShowDialog();
            strValor = txtCajaTexto.Text;
            return dialogResult;
        }
    }
}
/// <summary>
/// Delegado que valida lo ingresado en el 'InputTextBox'
/// </summary>
public delegate string InputBoxValidation(string errorMessage);