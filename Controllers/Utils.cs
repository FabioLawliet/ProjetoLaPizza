using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class Utils
    {
        public static void LimparTextBox(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                RecursivaLimparTextBox(c);
            }
        }

        private static void RecursivaLimparTextBox(Control controle)
        {
            foreach (Control c in controle.Controls)
            {
                if (c is TextBox)
                    c.Text = String.Empty;
                if (c.HasChildren)
                    RecursivaLimparTextBox(c);
            }

        }

        public static void DesativarComponentes(Control.ControlCollection controles)
        {
            foreach(Control c in controles)
            {
                RecursivaDesativarComponentes(c);
            }
        }

        private static void RecursivaDesativarComponentes(Control controle)
        {
            foreach (Control c in controle.Controls)
            {
                if (c is TextBox || c is CheckBox || c is Label)
                {
                    c.Enabled = false;
                    c.BackColor = System.Drawing.Color.DarkGray;
                }
                if (c.HasChildren)
                    RecursivaDesativarComponentes(c);
            }
        }
    }
}
