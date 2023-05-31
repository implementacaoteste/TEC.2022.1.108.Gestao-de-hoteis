using Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public string Criptografar(string _texto)
        {
            if (!File.Exists(Constante.CaminhaChavePublica))
                throw new Exception("A chave publica não existe") { Data = { { "Id", 4 } } };

            byte[] chavePublicaBytes = File.ReadAllBytes(Constante.CaminhaChavePublica);

            RSAParameters chavePublica;
            using(RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportCspBlob(chavePublicaBytes);
                chavePublica = rsa.ExportParameters(false);

            }
            rsa.ImportParameters(chavePublica);
            byte[] bytesCriptografados = rsa.Encrypt(Encoding.UTF8.GetBytes(_texto), RSAEncryptionPadding.Pkcs1);
            return Convert.ToBase64String(bytesCriptografados);
        }

        public string Descriptografar(string _texto)
        {
            if (!File.Exists(Constante.CaminhaChavePrivada))
                throw new Exception("A chave privada não existe") { Data = { { "Id", 4 } } };

            byte[] chavePrivadaBytes = File.ReadAllBytes(Constante.CaminhaChavePrivada);

            RSAParameters chavePrivada;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportCspBlob(chavePrivadaBytes);
                chavePrivada = rsa.ExportParameters(false);

            }
            
            rsa.ImportParameters(chavePrivada);

            byte[] bytesCriptografados = Convert.FromBase64String(_texto);

            byte[] bytesDescriptografados = rsa.Decrypt(bytesCriptografados, RSAEncryptionPadding.Pkcs1);

            return Encoding.UTF8.GetString(bytesDescriptografados);
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
