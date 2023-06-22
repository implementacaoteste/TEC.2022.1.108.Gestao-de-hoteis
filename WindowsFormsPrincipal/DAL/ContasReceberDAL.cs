using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class ContasReceberDAL
    {
        public void Alterar(ContasReceber _contasReceber)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE CONTAS_A_RECEBER SET DESCRICAO = @DESCRICAO, VALOR = @VALOR, ID_CLIENTE = @ID_CLIENTE, ID_FUNCIONARIO = @ID_FUNCIONARIO
                                        @DATA_VENCIMENTO = DATA_VENCIMENTO, @RECEBIDO = RECEBIDO
                                        WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DESCRICAO", _contasReceber.Descricao);
                cmd.Parameters.AddWithValue("@VALOR", _contasReceber.Valor);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _contasReceber.Id_Hospede);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _contasReceber.Id_Funcionario);
                cmd.Parameters.AddWithValue("@DATA_VENCIMENTO", _contasReceber.Data_Vencimento);
                cmd.Parameters.AddWithValue("@PAGAR", _contasReceber.Receber);
                cmd.Parameters.AddWithValue("@ID", _contasReceber.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma contas a receber no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscaPorTodos()
        {
            List<ContasReceber> contasRecebers = new List<ContasReceber>();
            ContasReceber contasReceber;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CA.ID,  CA.DESCRICAO,  CA.VALOR,  CA.ID_CLIENTE,  
                                    CA.ID_FUNCIONARIO,  CA.DATA_VENCIMENTO,  CA.RECEBIDO, F.NOME FUNCIONARIO_NOME, C.NOME CLIENTE_NOME
                                    FROM CONTAS_A_RECEBER CA                                
                                    INNER JOIN FUNCIONARIO F ON CA.ID_FUNCIONARIO = F.ID
                                    INNER JOIN CLIENTE C ON CA.ID_CLIENTE = C.ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["ID"]);
                        contasReceber.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        contasReceber.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        contasReceber.Descricao = rd["DESCRICAO"].ToString();
                        contasReceber.Nome_Funcionario = rd["FUNCIONARIO_NOME"].ToString();
                        contasReceber.Nome_Hospede = rd["CLIENTE_NOME"].ToString();
                        contasReceber.Valor = (decimal)rd["VALOR"];
                        contasReceber.Receber = Convert.ToBoolean(rd["RECEBIDO"]);
                        contasReceber.Data_Vencimento = Convert.ToDateTime(rd["DATA_VENCIMENTO"]);
                        contasRecebers.Add(contasReceber);
                    }
                }
                return contasRecebers;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as contas a receber.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscarPorData(DateTime _dataInicial, DateTime _dataFinal)
        {
            List<ContasReceber> contasRecebers = new List<ContasReceber>();
            ContasReceber contasReceber;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CA.ID,  CA.DESCRICAO,  CA.VALOR,  CA.ID_CLIENTE,  
                                    CA.ID_FUNCIONARIO,  CA.DATA_VENCIMENTO,  CA.RECEBIDO, F.NOME FUNCIONARIO_NOME, C.NOME CLIENTE_NOME
                                    FROM CONTAS_A_RECEBER CA                                
                                    INNER JOIN FUNCIONARIO F ON CA.ID_FUNCIONARIO = F.ID
                                    INNER JOIN CLIENTE C ON CA.ID_CLIENTE = C.ID
                                    WHERE CA.DATA_VENCIMENTO BETWEEN @DATA_INICIAL AND @DATA_FINAL";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_INICIAL", _dataInicial.Date);
                cmd.Parameters.AddWithValue("@DATA_FINAL", _dataFinal.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["ID"]);
                        contasReceber.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        contasReceber.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        contasReceber.Descricao = rd["DESCRICAO"].ToString();
                        contasReceber.Nome_Funcionario = rd["FUNCIONARIO_NOME"].ToString();
                        contasReceber.Nome_Hospede = rd["CLIENTE_NOME"].ToString();
                        contasReceber.Valor = (decimal)rd["VALOR"];
                        contasReceber.Receber = Convert.ToBoolean(rd["RECEBIDO"]);
                        contasReceber.Data_Vencimento = Convert.ToDateTime(rd["DATA_VENCIMENTO"]);
                        contasRecebers.Add(contasReceber);
                    }
                }
                return contasRecebers;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as contas a receber.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasReceber> BuscarPorPagar(bool _receber)
        {
            List<ContasReceber> contasRecebers = new List<ContasReceber>();
            ContasReceber contasReceber;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CA.ID,  CA.DESCRICAO,  CA.VALOR,  CA.ID_CLIENTE,  
                                    CA.ID_FUNCIONARIO,  CA.DATA_VENCIMENTO,  CA.RECEBIDO, F.NOME FUNCIONARIO_NOME, C.NOME CLIENTE_NOME
                                    FROM CONTAS_A_RECEBER CA                                
                                    INNER JOIN FUNCIONARIO F ON CA.ID_FUNCIONARIO = F.ID
                                    INNER JOIN CLIENTE C ON CA.ID_CLIENTE = C.ID
                                    WHERE CA.RECEBIDO = @RECEBIDO";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@RECEBIDO", _receber);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasReceber = new ContasReceber();
                        contasReceber.Id = Convert.ToInt32(rd["ID"]);
                        contasReceber.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        contasReceber.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        contasReceber.Descricao = rd["DESCRICAO"].ToString();
                        contasReceber.Nome_Funcionario = rd["FUNCIONARIO_NOME"].ToString();
                        contasReceber.Nome_Hospede = rd["CLIENTE_NOME"].ToString();
                        contasReceber.Valor = (decimal)rd["VALOR"];
                        contasReceber.Receber = Convert.ToBoolean(rd["RECEBIDO"]);
                        contasReceber.Data_Vencimento = Convert.ToDateTime(rd["DATA_VENCIMENTO"]);
                        contasRecebers.Add(contasReceber);
                    }
                }
                return contasRecebers;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as contas a receber.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM CONTAS_A_RECEBER 
                                    WHERE ID=@Id";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um contas a receber no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Inserir(ContasReceber _contasReceber)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONTAS_A_RECEBER (DESCRICAO, VALOR, ID_CLIENTE, ID_FUNCIONARIO, DATA_VENCIMENTO, RECEBIDO)
                                      VALUES(@DESCRICAO, @VALOR, @ID_CLIENTE, @ID_FUNCIONARIO, @DATA_VENCIMENTO, @RECEBIDO)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@VALOR", _contasReceber.Valor);
                cmd.Parameters.AddWithValue("@DESCRICAO", _contasReceber.Descricao);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _contasReceber.Id_Hospede);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _contasReceber.Id_Funcionario);
                cmd.Parameters.AddWithValue("@DATA_VENCIMENTO", _contasReceber.Data_Vencimento);
                cmd.Parameters.AddWithValue("@RECEBIDO", _contasReceber.Receber);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma contas a receber no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
