using System;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public static class Log
    {
        public static void Gravar(string _texto)
        {
            new Arquivo().GravarLinhaNoFinalDoArquivo(Constante.CaminhoArquivoLog, new Criptografia().Criptografar(DateTime.Now + ":" + _texto)); 
        }
    }
}
