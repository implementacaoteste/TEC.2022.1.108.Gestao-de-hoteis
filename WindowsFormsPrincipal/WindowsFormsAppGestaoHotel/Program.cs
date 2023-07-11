using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPrincipal1;

namespace WindowsFormsAppGestaoHotel
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             
            //new Arquivo().GravarLinhaNoFinalDoArquivo(Environment.CurrentDirectory + "\\ArquivoTeste.txt", "Texto a ser gravado no arquivo");
            //new Arquivo().GravarLinhaNoFinalDoArquivo(Environment.CurrentDirectory + "\\ArquivoTeste.txt", "usuario a ser gravado no arquivo");
            new Criptografia().GravarChaves();
            Log.Gravar("Usuario abriu o sistema");

            Application.Run(new FormPrincipal());

           
        }
    }
}
