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
        public DateTime Data_nascimento { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int IdSexo { get; set; }
        public string Sexo { get; set; }
        public List<GrupoFuncionario> GrupoFuncionarios { get; set; }

        public void LimparDados()
        {
            this.Id = 0;
            this.Nome = null;
            this.CPF = null;
            this.Email = null;
            this.Celular = null;
            this.Endereco = null;
            this.NomeUsuario = null;
            this.Data_nascimento = DateTime.MinValue;
            this.Senha = null;
            this.Ativo = false;
            this.IdSexo = 0;
            this.Sexo = null;
        }

    }
}
