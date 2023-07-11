using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Relatorio
    {
        public int Id { get; set; }
        public int Id_Hospede { get; set; }
        public int Id_Funcionario { get; set; }
        public int Id_Pagamento { get; set; }
        public int Id_Quarto { get; set; }
        public string Nome_Hospede { get; set; }
        public string CPF_Hopesde { get; set; }
        public string Nome_Funcionario { get; set; }
        public string Pagamento { get; set; }
        public string Numero_Quarto { get; set; }
        public string Descricao_Quarto { get; set; }
        public decimal Valor_Total { get; set; }
        public decimal Valor_Diaria { get; set; }
        public DateTime Data_Checkin { get; set; }
        public DateTime Data_Checkout { get; set; }
    }
}
