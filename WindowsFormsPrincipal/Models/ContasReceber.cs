﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContasReceber
    {
        public int Id { get; set; }
        public int Id_Hospede { get; set; }
        public int Id_Funcionario { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal Valor_Receber { get; set; }
        public decimal Valor_Recebido { get; set; }
        public DateTime Data_Vencimento { get; set; }
        public bool Receber { get; set; }
        public string Nome_Hospede { get; set; }
        public string Nome_Funcionario { get; set; }
    }
}
