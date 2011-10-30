using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCentroSalud.Controles
{
    public partial class cuRichTextBox : RichTextBox
    {
        public cuRichTextBox()
        {
            InitializeComponent();
        }

        public enum SoloLectura : int
        {
            falso = 0, verdadero = 1
        };

        SoloLectura soloLectura;

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
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
