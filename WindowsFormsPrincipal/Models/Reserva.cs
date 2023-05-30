using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int Id_Hospede { get; set; }
        public int Id_Funcionario { get; set; }
        public int Id_Pagamento { get; set; }
        public int Id_Quarto { get; set; }
        public int Qtd_Hospedes { get; set; }
        public string Nome_Hospede { get; set; }
        public string CPF_Hopesde { get; set; }
        public string Nome_Funcionario { get; set; }
        public string Pagamento { get; set; }
        public string Obs_Reserva { get; set; }
        public string Obs_Checkin { get; set; }
        public string Obs_Checkout { get; set; }
        public string Numero_Quarto { get; set; }
        public string Tipo_Quarto { get; set; }
        public double Valor_Total { get; set; }
        public double Valor_Entrada { get; set; }
        public double Valor_Restante { get; set; }
        public DateTime Data_Ent_Reserva { get; set; }
        public DateTime Data_Sai_Reserva { get; set; }
        public DateTime? Data_Checkin { get; set; }
        public DateTime? Data_Checkout { get; set; }
        public DateTime Data_Reserva { get; set; }
        public List<Quarto> Quartos { get; set; }
        public Reserva()
        {
            Quartos = new List<Quarto>();
        }
    }
}