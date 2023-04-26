using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int Id_Classe { get; set; }
        public string Descricao { get; set; }
        public double Valor_Diaria { get; set; }
        public int Id_Status { get; set; }
    }
}
