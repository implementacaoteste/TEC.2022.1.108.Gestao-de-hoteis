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
                throw new Exception("Ocorreu um erro ao tentar linha no final do arquivo", ex) { Data = { { "id", 1 } } };
            }

        }
        public void GravarBytesNoFinalDoArquivo(string _caminhoArquivo, byte[] _bytes)
        {
            ExcluirArquivo(_caminhoArquivo);
            using (FileStream arquivo = new FileStream(_caminhoArquivo, FileMode.Append))
            {
                if(!File.Exists(_caminhoArquivo))
                {
                    byte[] novalinhaBytes = Encoding.UTF8.GetBytes(Environment.NewLine);
                    arquivo.Write(novalinhaBytes, 0, novalinhaBytes.Length);
                }
                arquivo.Write(_bytes, 0, _bytes.Length);
            }
        }

        public void ExcluirArquivo(string _arquivo)
        {
            if(File.Exists(_arquivo))
                File.Delete(_arquivo);
        }
    }
}
