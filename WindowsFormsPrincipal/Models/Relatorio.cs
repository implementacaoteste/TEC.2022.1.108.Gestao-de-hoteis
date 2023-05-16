using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Relatorio
    {
        public List<Diaria> Diarias { get; set; }
        public List<Cliente> Nome_Hospede { get; set; } 
        public List<Funcionario>Nome_Funcionario { get; set; }
        public List <Quarto> Quartos { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
    }
}
