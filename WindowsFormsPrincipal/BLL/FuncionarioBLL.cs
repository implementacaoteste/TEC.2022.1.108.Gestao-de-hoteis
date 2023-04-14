using DAL;
using Models;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BLL
{
    public class FuncionarioBLL
    {
        public void Inserir(Funcionario _funcionario, string _confirmacaoSenha)
        {
            ValidarDados(_funcionario, _confirmacaoSenha);
            new FuncionarioDAL().Inserir(_funcionario);
        }
        public void Alterar(Funcionario _funcionario, string _confirmacaoSenha)
        {
            ValidarDados(_funcionario,_confirmacaoSenha);
            new FuncionarioDAL().Alterar(_funcionario);
        }
        public void Excluir(int _Id)
        {
            new FuncionarioDAL().Excluir(_Id);
        }

        public Funcionario BuscarPorId(int _Id)
        {
            return new FuncionarioDAL().BuscarPorId(_Id);
        }

        public void BuscarPorNomeFuncionario(string _nome)
        {
            new FuncionarioDAL().BuscarPorNomeFuncionario(_nome);
        }
        public void Altenticar(string _NomeUsuario, string _Senha)
        {
            Funcionario funcionario = new FuncionarioDAL().BuscarPorNomeFuncionario(_NomeUsuario);
            
            if (_Senha==funcionario.Senha && funcionario.Ativo)
            {
                Constante.IdLogado = funcionario.Id;
            }
            else
            {
                throw new Exception("Usuário ou senha incorreto");
            }
            return; 
        }
        public List<Funcionario> BuscarTodos()
        {
            return new FuncionarioDAL().BuscarTodos();

        }
        
        private void ValidarDados (Funcionario _funcionario, string _confirmacaoSenha)
        {
            if (_funcionario.Senha != _confirmacaoSenha)
                throw new Exception("A senha e a confirmação de senha devem ser iguais.");

             if (_funcionario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres.");

            if (_funcionario.Nome.Length <= 2)
                throw new Exception("O nome deve ter mais de 2 caracteres");
        }




    }
}

