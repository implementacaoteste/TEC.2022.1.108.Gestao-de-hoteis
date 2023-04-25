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
        public int Id_cliente { get; set; }
        public string Nome_Cliente { get; set; }
        public string Cpf_Cliente { get; set; }
        public float Valor_Total { get; set; }
        public string Data_Entrada { get; set; }
        public int Id_funcionario { get; set; }
        public string Data_Saida { get; set; }
        public int Id_Pagamento { get; set; }
        public List<Quarto> Quartos { get; set; }
    }
}
