using Models;
using System;
using System.IO;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                if (String.IsNullOrEmpty(Constante.StringDeConexao))
                {
                    if (File.Exists(Constante.DiretorioStringDeConexao + Constante.NomeArquivoConexao))
                        Constante.StringDeConexao = File.ReadAllText(Constante.DiretorioStringDeConexao + Constante.NomeArquivoConexao);
                    else throw new Exception("É preciso criar a string de conexão") { Data = { {  "Id", 1 } } };
                }
                return Constante.StringDeConexao;
            }
        }   
    }
}
