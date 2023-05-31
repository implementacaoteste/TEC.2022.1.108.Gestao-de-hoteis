using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class Criptografia
    {
        private RSA rsa;

        public Criptografia()
        {
            rsa = RSA.Create();
        }
        public void GravarChaves()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(GetPublicKey());
                byte[] chavePublicaBytes = rsa.ExportCspBlob(false);
                new Arquivo().GravarBytesNoFinalDoArquivo(Constante.CaminhaChavePublica, chavePublicaBytes);
            }
            
            using(RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(GetPrivateKey());
                byte[] chavePrivadaBytes = rsa.ExportCspBlob(true);
                new Arquivo().GravarBytesNoFinalDoArquivo(Constante.CaminhaChavePrivada, chavePrivadaBytes);
            }
        }

        public RSAParameters GetPublicKey()
        {
            return rsa.ExportParameters(false);
        }

        public RSAParameters GetPrivateKey()
        {
            return rsa.ExportParameters(true);
        }
        public string CriptografarSenha(string _senha)
        {
            string retorno = _senha;

            for (int i = 0; i< _senha.Length; i++) 
            {
                retorno = GerarHash(retorno);
                retorno = ReverterTexto(retorno);
                retorno = GerarHash(retorno);
                retorno = ReverterTexto(retorno);
            }
            return GerarHash(retorno);
        }
        private string GerarHash(string _texto)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(_texto));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        private string ReverterTexto(string _texto)
        {
            char[] charArray = _texto.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
