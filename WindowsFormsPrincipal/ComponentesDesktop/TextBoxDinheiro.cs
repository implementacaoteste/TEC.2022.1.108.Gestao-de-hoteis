using System;
using System.Windows.Forms;

namespace ComponentesDesktop
{
    public class TextBoxDinheiro : TextBox
    {
        public TextBoxDinheiro()
        {
            InitializeTextBox();
            this.Text = "0,00";
            this.TextAlign = HorizontalAlignment.Right;
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
            if (decimal.TryParse(this.Text.Replace(",", ""), out decimal valorDigitado))
            {
                this.TextChanged -= TextBoxDinheiro_TextChanged; // Remove o manipulador de eventos para evitar chamadas recursivas
                valorDigitado = valorDigitado / 100;
                this.Text = valorDigitado.ToString("0.00"); // Formata o texto com duas casas decimais
                this.SelectionStart = this.Text.Length; // Define o cursor no final do texto

                this.TextChanged += TextBoxDinheiro_TextChanged; // Reatribui o manipulador de eventos
            }
        }
    }
}
