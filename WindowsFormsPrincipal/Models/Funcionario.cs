using Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string NomeUsuario { get; set; }
        public string Data_nascimento { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
       public List<Sexo> Sexos { get; set; }
    }
}
