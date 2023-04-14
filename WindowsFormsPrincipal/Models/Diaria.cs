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
        public List<Cliente> Id_cliente { get; set; }
        public float Valor_Total { get; set; }
        public string Data_Entrada { get; set; }
        public List<Funcionario> Id_funcionario { get; set; }
        public string Data_Saida { get; set; }
        public List<Pagamento> Id_Pagamento { get; set; }
    }
}
