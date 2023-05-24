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
        public void Alterar(ContasPagar _contasPagar)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE CONTAS_A_PAGAR SET DESCRICAO = @DESCRICAO, VALOR = @VALOR, ID_CLIENTE = @ID_CLIENTE, ID_FUNCIONARIO = @ID_FUNCIONARIO
                                        @DATA_VENCIMENTO = DATA_VENCIMENTO, @PAGAR = PAGAR
                                        WHERE ID = @ID";
               
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DESCRICAO", _contasPagar.Descricao);
                cmd.Parameters.AddWithValue("@VALOR", _contasPagar.Valor);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _contasPagar.Id_Cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _contasPagar.Id_Funcionario);
                cmd.Parameters.AddWithValue("@DATA_VENCIMENTO", _contasPagar.Data_Vencimento);
                cmd.Parameters.AddWithValue("@PAGAR", _contasPagar.Pagar);
                cmd.Parameters.AddWithValue("@ID", _contasPagar.Id);
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

        public List<ContasPagar> BuscaPorTodos()
        {
            List<ContasPagar> contasPagas = new List<ContasPagar>();
            ContasPagar contasPagar;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CONTAS_A_PAGAR.ID,  CONTAS_A_PAGAR.DESCRICAO,  CONTAS_A_PAGAR.VALOR,  CONTAS_A_PAGAR.ID_CLIENTE,  
                                    CONTAS_A_PAGAR.ID_FUNCIONARIO,  CONTAS_A_PAGAR.DATA_VENCIMENTO, 
                                    CONTAS_A_PAGAR.PAGAR, FUNCIONARIO.NOME FUNCIONARIO_NOME, CLIENTE.NOME CLIENTE_NOME
                                    FROM CONTAS_A_PAGAR                                    
                                    INNER JOIN FUNCIONARIO ON CONTAS_A_PAGAR.ID_FUNCIONARIO = FUNCIONARIO.ID
                                    INNER JOIN CLIENTE ON CONTAS_A_PAGAR.ID_CLIENTE = CLIENTE.ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["ID"]);
                        contasPagar.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        contasPagar.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        contasPagar.Descricao = rd["DESCRICAO"].ToString();
                        contasPagar.Nome_funcionario = rd["FUNCIONARIO_NOME"].ToString();
                        contasPagar.Nome_Hospede = rd["CLIENTE_NOME"].ToString();
                        contasPagar.Valor = (double)rd["VALOR"];
                        contasPagar.Pagar = Convert.ToBoolean(rd["PAGAR"]);
                        contasPagar.Data_Vencimento = Convert.ToDateTime(rd["DATA_VENCIMENTO"]);
                        contasPagas.Add(contasPagar);
                    }
                }
                return contasPagas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as contas a pagar.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasPagar> BuscarPorData(DateTime _data)
        {
            List<ContasPagar> contasPagas = new List<ContasPagar>();
            ContasPagar contasPagar;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CONTAS_A_PAGAR.ID,  CONTAS_A_PAGAR.DESCRICAO,  CONTAS_A_PAGAR.VALOR,  CONTAS_A_PAGAR.ID_CLIENTE,  
                                    CONTAS_A_PAGAR.ID_FUNCIONARIO,  CONTAS_A_PAGAR.DATA_VENCIMENTO, 
                                    CONTAS_A_PAGAR.PAGAR, FUNCIONARIO.NOME FUNCIONARIO_NOME, CLIENTE.NOME CLIENTE_NOME
                                    FROM CONTAS_A_PAGAR                                    
                                    INNER JOIN FUNCIONARIO ON CONTAS_A_PAGAR.ID_FUNCIONARIO = FUNCIONARIO.ID
                                    INNER JOIN CLIENTE ON CONTAS_A_PAGAR.ID_CLIENTE = CLIENTE.ID
                                     WHERE CONTAS_A_PAGAR.DATA_VENCIMENTO = @DATA_VENCIMENTO";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_VENCIMENTO",  _data.Date);
                
                cn.Open();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["ID"]);
                        contasPagar.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        contasPagar.Nome_funcionario = rd["FUNCIONARIO_NOME"].ToString();
                        contasPagar.Nome_Hospede = rd["CLIENTE_NOME"].ToString();
                        contasPagar.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        contasPagar.Descricao = rd["DESCRICAO"].ToString();
                        contasPagar.Valor = (double)rd["VALOR"];
                        contasPagar.Pagar = Convert.ToBoolean(rd["PAGAR"]);
                        contasPagar.Data_Vencimento = Convert.ToDateTime(rd["DATA_VENCIMENTO"]);
                        contasPagas.Add(contasPagar);
                    }
                }
                return contasPagas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as contas a pagar.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<ContasPagar> BuscarPorPagar(bool _pagar)
        {
            List<ContasPagar> contasPagas = new List<ContasPagar>();
            ContasPagar contasPagar;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CONTAS_A_PAGAR.ID,  CONTAS_A_PAGAR.DESCRICAO,  CONTAS_A_PAGAR.VALOR,  CONTAS_A_PAGAR.ID_CLIENTE,  
                                    CONTAS_A_PAGAR.ID_FUNCIONARIO,  CONTAS_A_PAGAR.DATA_VENCIMENTO, 
                                    CONTAS_A_PAGAR.PAGAR, FUNCIONARIO.NOME FUNCIONARIO_NOME, CLIENTE.NOME CLIENTE_NOME
                                    FROM CONTAS_A_PAGAR                                    
                                    INNER JOIN FUNCIONARIO ON CONTAS_A_PAGAR.ID_FUNCIONARIO = FUNCIONARIO.ID
                                    INNER JOIN CLIENTE ON CONTAS_A_PAGAR.ID_CLIENTE = CLIENTE.ID
                                     WHERE CONTAS_A_PAGAR.PAGAR = @PAGAR";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@PAGAR", _pagar);

                cn.Open();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        contasPagar = new ContasPagar();
                        contasPagar.Id = Convert.ToInt32(rd["ID"]);
                        contasPagar.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        contasPagar.Nome_funcionario = rd["FUNCIONARIO_NOME"].ToString();
                        contasPagar.Nome_Hospede = rd["CLIENTE_NOME"].ToString();
                        contasPagar.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        contasPagar.Descricao = rd["DESCRICAO"].ToString();
                        contasPagar.Valor = (double)rd["VALOR"];
                        contasPagar.Pagar = Convert.ToBoolean(rd["PAGAR"]);
                        contasPagar.Data_Vencimento = Convert.ToDateTime(rd["DATA_VENCIMENTO"]);
                        contasPagas.Add(contasPagar);
                    }
                }
                return contasPagas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as contas a pagar.", ex);
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
                cmd.CommandText = @"DELETE FROM CONTAS_A_PAGAR 
                                    WHERE ID=@Id";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um CONTAS a PAGAR no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
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
                cmd.Parameters.AddWithValue("@VALOR", _contasPagar.Valor);  
                cmd.Parameters.AddWithValue("@DESCRICAO", _contasPagar.Descricao);
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
