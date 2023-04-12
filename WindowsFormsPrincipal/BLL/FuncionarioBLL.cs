using DAL;
using Models;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            return   new FuncionarioDAL().BuscarPorId(_Id);
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
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, NOME_USUARIO, EMAIL ,SENHA ,CPF, ATIVO, DATA_NASCIMENTO, ENDERECO, CELULAR 
                                    From FUNCIONARIO";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Data_nascimento = rd["DATA_NASCIMENTO"].ToString();
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                    }

                }
                return funcionarios;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar os funcionarios", ex);
            }
            finally
            {
                cn.Close();
            }
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

