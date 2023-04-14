using System;

namespace Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public DateTime Data_nascimento { get; set; }
        public int IdSexo { get; set; }
        public string Sexo { get; set; }
    }
}
