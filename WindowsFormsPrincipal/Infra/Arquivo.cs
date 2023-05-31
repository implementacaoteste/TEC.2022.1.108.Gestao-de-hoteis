using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class Arquivo
    {
        public void GravarLinhaNoFinalDoArquivo(string _arquivo, string _texto)
        {
            try
            {
                using(StreamWriter arquivo = File.AppendText(_arquivo))
                {
                    arquivo.WriteLine(_texto);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar linha no final do arquivo", ex) { Data = { { "id", 3 } } };
            }
        }
    }
}
