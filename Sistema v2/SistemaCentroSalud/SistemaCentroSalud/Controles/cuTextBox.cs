using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCentroSalud.Controles
{
    public partial class cuTextBox : TextBox
    {
        public cuTextBox()
        {
            InitializeComponent();
        }

        public enum TipoTextBox : int
        {
            Mixto = 0, Letras = 1, Enteros = 2, Decimales = 3 
        };

        public enum SoloLectura : int
        {
            falso = 0, verdadero = 1
        };

        TipoTextBox tipoCajaTexto;
        SoloLectura soloLectura;

        public TipoTextBox TipoCajaTexto
        {
            get
            {
                return tipoCajaTexto;
            }

            set
            {
                tipoCajaTexto = value;
            }
        }

        public SoloLectura Solo_Lectura
        {
            get
            {
                return soloLectura;
            }

            set
            {
                soloLectura = value;

                if (soloLectura == SoloLectura.verdadero)
                {
                    this.ReadOnly = true;
                }
                else
                {
                    this.ReadOnly = false;
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            if (soloLectura == SoloLectura.verdadero)
            {
                this.BackColor = Color.AliceBlue;
            }
            else
            {
                this.BackColor = Color.LightYellow;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = Color.White;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            Clipboard.Clear();

            if (tipoCajaTexto == TipoTextBox.Enteros)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (tipoCajaTexto == TipoTextBox.Letras)
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (tipoCajaTexto == TipoTextBox.Decimales)
            {
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == '.' && this.Text.IndexOf(".") > 0)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                //No hace nada
            }
        }
    }
}
