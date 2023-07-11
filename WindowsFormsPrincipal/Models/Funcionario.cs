using System;
using System.Collections.Generic;

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
        public string CargoFuncionario { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int IdSexo { get; set; }
        public string Sexo { get; set; }
        public List<GrupoFuncionario> GrupoFuncionarios { get; set; }

    }
}
