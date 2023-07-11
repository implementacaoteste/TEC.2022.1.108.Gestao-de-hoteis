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
        public string Classe { get; set; }
        public string Descricao { get; set; }
        public decimal Valor_Diaria { get; set; }
        public int Id_Status { get; set; }
        public string Status { get; set; }
        public string Andar { get; set; }
        public DateTime Dt_Ent_Checkin { get; set; }
        public DateTime Dt_Sai_Checkout { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
