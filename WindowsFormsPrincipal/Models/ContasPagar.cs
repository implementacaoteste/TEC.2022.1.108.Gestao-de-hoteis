using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContasPagar
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Funcionario { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public DateTime  Data_Vencimento { get; set; }
        public bool Pagar { get; set; }
    }
}
