using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class LpText : TextBox
    {
        private tipoCampo lpTipo = tipoCampo.String;
        private Color lpCorFoco = Color.FromArgb(230, 190, 190);
        private Color lpCorPadrao;
        private char TeclaPressionada;

        public LpText()
        {
            lpCorPadrao = this.BackColor;
            this.ForeColor = Color.Black;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.CharacterCasing = CharacterCasing.Upper;
        }
        

        public tipoCampo LpTipo { get => lpTipo; set => lpTipo = value; }
        public Color LpCorFoco { get => lpCorFoco; set => lpCorFoco = value; }
        public Color LpCorPadrao { get => lpCorPadrao; set => lpCorPadrao = value; }

        public enum tipoCampo
        {
            Integer,
            Currency,
            String,
            Date        
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = LpCorFoco;
            if (this.TextAlign == HorizontalAlignment.Left)
                this.Select(this.Text.Length, 0);
            else
                this.Select(0, this.Text.Length); 
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = LpCorPadrao;
            base.OnLostFocus(e);

            switch (LpTipo)
            {
                case tipoCampo.Currency:
                    if (this.Text == String.Empty)
                        this.Text = "0,00";
                    else
                        this.Text = Convert.ToDecimal(this.Text).ToString("N2");
                    break;

                default:
                    this.Text = this.Text;
                    break;
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (this.Enabled)
                this.BackColor = LpCorPadrao;
            else
                this.BackColor = Color.Silver;

            base.OnEnabledChanged(e);
        }

        private string SomenteNumeros(string text)
        {
            string aux = string.Empty;
            string numeros = "1234567890";

            foreach (char c in text)
                if (numeros.Contains(c.ToString()))
                    aux += c;

            return aux;
        }

        private string CriaMascaraData(string text)
        {
            string aux = string.Empty;
            string data = SomenteNumeros(text);

            for(int i = 0; i < data.Length; i++)
            {
                aux += data[i];

                if (i == 1)
                    aux += "/";                 

                if (i == 3)
                    aux += "/";
            }
            return aux;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (lpTipo == tipoCampo.Date)
            {
                if (TeclaPressionada != (char)Keys.Back)
                {
                    this.Text = CriaMascaraData(this.Text);
                    this.Select(this.Text.Length, 0);
                }
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            TeclaPressionada = e.KeyChar;

            if (e.KeyChar == (char)Keys.F2)
            {
                base.OnKeyPress(e);
                return;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                base.OnKeyPress(e);
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                base.OnKeyPress(e);
                return;
            }

            switch (LpTipo)
            {
                case tipoCampo.Integer:
                    if (!char.IsDigit(e.KeyChar))
                        e.Handled = true;
                    break;

                case tipoCampo.Currency:
                    if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                        e.Handled = true;
                    else
                    {
                        if (this.Text.Length == 0 && e.KeyChar == ',')
                            e.Handled = true;

                        foreach (char c in this.Text)
                            if ((c == ',' && e.KeyChar == ','))
                                e.Handled = true;
                    }
                    break;

                case tipoCampo.Date:
                    if (!char.IsDigit(e.KeyChar))
                        e.Handled = true;
                    break;

                default:
                    base.OnKeyPress(e);
                    break;
            } 
        }
    }
}
