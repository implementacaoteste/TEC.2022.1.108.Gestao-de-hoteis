using System;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace ComponentesDesktop
{
    public class TextBoxDinheiro : TextBox
    {
        public TextBoxDinheiro()
        {
            InitializeTextBox();
            this.Text = "0,00";
            this.TextAlign = HorizontalAlignment.Right;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void InitializeTextBox()
        {
            this.KeyPress += TextBoxDinheiro_KeyPress;
            this.TextChanged += TextBoxDinheiro_TextChanged;
        }

        private void TextBoxDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; // Ignora o caractere digitado se não for um número ou uma tecla de controle
        }

        private void TextBoxDinheiro_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(this.Text.Replace(",", "").Replace("R$ ", ""), out decimal valorDigitado))
            {
                this.TextChanged -= TextBoxDinheiro_TextChanged; // Remove o manipulador de eventos para evitar chamadas recursivas
                
                if (this.Text.Contains(","))
                    valorDigitado = valorDigitado / 100;

                this.Text = valorDigitado.ToString("C", CultureInfo.CurrentCulture); // Formata o texto com duas casas decimais
                this.SelectionStart = this.Text.Length; // Define o cursor no final do texto

                this.TextChanged += TextBoxDinheiro_TextChanged; // Reatribui o manipulador de eventos
            }
        }
    }
}
