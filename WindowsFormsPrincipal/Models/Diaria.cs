using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Diaria
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Funcionario { get; set; }
        public int Id_Pagamento { get; set; }
        public string Nome_Cliente { get; set; }
        public string CPF_Cliente { get; set; }
        public double Valor_Total { get; set; }
        public DateTime Data_Entrada { get; set; }
        public DateTime Data_Saida { get; set; }
        public List<Quarto> Quartos { get; set; }
    }
}
