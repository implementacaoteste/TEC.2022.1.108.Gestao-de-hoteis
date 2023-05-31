using System;
using System.IO;

namespace Models
{
    public static class Constante
    {
        // Dados do funcionario logado
        public static int IdLogado;
        public static string Nome;
        public static string Cargo;
        public static string CPF;
        public static string Email;
        public static string Celular;
        public static string Endereco;
        public static string NomeUsuario;
        public static DateTime Data_nascimento;
        public static string Senha;
        public static bool Ativo;
        public static int IdSexo;
        public static string Sexo;

        public static string CaminhoArquivoLog
        {
            get
            {
                string diretorio = Environment.CurrentDirectory + "\\Logs\\";
                Directory.CreateDirectory(diretorio);
                return diretorio + "Log.Log";
            }
        }
    }
}
