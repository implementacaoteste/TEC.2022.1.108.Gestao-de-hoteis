using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class ContasPagarDAL
    {
        public void Alterar(ContasPagar contasPagar)
        {
            throw new NotImplementedException();
        }

        public List<ContasPagar> BuscaPorTodos()
        {
            throw new NotImplementedException();
        }

        public List<ContasPagar> BuscarPorData(DateTime _data)
        {
            throw new NotImplementedException();
        }

        public List<ContasPagar> BuscarPorPagar(bool pagar)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int _id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(ContasPagar _contasPagar)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONTAS_A_PAGAR (DESCRICAO, VALOR, ID_CLIENTE, ID_FUNCIONARIO, DATA_VENCIMENTO, PAGAR)
                                      VALUES(@DESCRICAO, @VALOR, @ID_CLIENTE, @ID_FUNCIONARIO, @DATA_VENCIMENTO, @PAGAR)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DESCRICAO", _contasPagar.Descricao);
                cmd.Parameters.AddWithValue("@VALOR", _contasPagar.Valor);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _contasPagar.Id_Cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _contasPagar.Id_Funcionario);
                cmd.Parameters.AddWithValue("@DATA_VENCIMENTO", _contasPagar.Data_Vencimento);
                cmd.Parameters.AddWithValue("@PAGAR", _contasPagar.Pagar);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma contas a pagar no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
