using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DiariaDAL
    {
        public void Inserir(Diaria _diaria)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO DIARIA (VALOR_TOTAL, ID_CLIENTE, ID_FUNCIONARIO, ID_PAGAMENTO, DATA_ENTRADA, DATA_SAIDA)
                                       VALUES(@VALOR_TOTAL, @ID_CLIENTE, @ID_FUNCIONARIO, @ID_PAGAMENTO, @DATA_ENTRADA, @DATA_SAIDA)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _diaria.Valor_Total);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _diaria.Id_Cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _diaria.Id_Funcionario);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _diaria.Id_Pagamento);
                cmd.Parameters.AddWithValue("DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Parameters.AddWithValue("@DATA_SAIDA", _diaria.Data_Saida);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir a Diária no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Diaria _diaria)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE DIARIA SET VALOR_TOTAL = @VALOR_TOTAL, ID_CLIENTE = @ID_CLIENTE, 
                                    ID_FUNCIONARIO = @ID_FUNCIONARIO, ID_PAGAMENTO = @ID_PAGAMENTO, 
                                    DATA_ENTRADA = @DATA_ENTRADA, DATA_SAIDA = @DATA_SAIDA
                                    WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _diaria.Valor_Total);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _diaria.Id_Cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _diaria.Id_Funcionario);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _diaria.Id_Pagamento);
                cmd.Parameters.AddWithValue("DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Parameters.AddWithValue("@DATA_SAIDA", _diaria.Data_Saida);
                cmd.Parameters.AddWithValue("@ID", _diaria.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a Diária no Banco de Dados.", ex);
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
                cmd.CommandText = @"DELETE FROM DIARIA
                                    WHERE ID= @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma Diária no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Diaria BuscarPorId(int _id)
        {
            Diaria diaria = new Diaria();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT DIARIA.ID, VALOR_TOTAL, DATA_ENTRADA, ID_CLIENTE, ID_FUNCIONARIO, ID_PAGAMENTO, DATA_SAIDA
                                    FROM DIARIA 
                                    INNER JOIN CLIENTE ON DIARIA.ID_CLIENTE = CLIENTE.ID
                                    INNER JOIN FUNCIONARIO ON DIARIA.ID_FUNCIONARIO = FUNCIONARIO.ID
                                    INNER JOIN PAGAMENTO ON DIARIA.ID_PAGAMENTO = PAGAMENTO.ID
                                    WHERE DIARIA.ID=@ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Valor_Total = (double)rd["VALOR_TOTAL"];
                        diaria.Data_Entrada = Convert.ToDateTime(rd["DATA_ENTRADA"]);
                        diaria.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        diaria.Data_Saida = Convert.ToDateTime(rd["DATA_SAIDA"]);
                    }
                }
                return diaria;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar a Diária na buscar por ID.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Diaria> BuscarPorTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Diaria> diarias = new List<Diaria>();
            Diaria diaria;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT D.ID, C.NOME, C.CPF, F.NOME NOME_FUNCIONARIO, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE,
                                    D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
                                    FROM DIARIA D
                                    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON D.ID_FUNCIONARIO = F.ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        diaria = new Diaria();
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Nome_Cliente = rd["NOME"].ToString();
                        diaria.CPF_Cliente = rd["CPF"].ToString();
                        diaria.Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        diaria.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        diaria.Valor_Total = (double)rd["VALOR_TOTAL"];
                        diaria.Data_Entrada = Convert.ToDateTime(rd["DATA_ENTRADA"]);
                        diaria.Data_Saida = Convert.ToDateTime(rd["DATA_SAIDA"]);
                        diaria.Quartos = new QuartoDAL().BuscarPorIdDiaria(diaria.Id);
                        diarias.Add(diaria);
                    }
                }
                return diarias;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as Diárias.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Diaria> BuscarPorCPFCliente(string _cpf)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Diaria> Diaria = new List<Diaria>();
            Diaria diaria;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT D.ID, C.NOME, C.CPF, F.NOME NOME_FUNCIONARIO, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE,
                                    D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
                                    FROM DIARIA D
                                    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON D.ID_FUNCIONARIO = F.ID
                                    WHERE C.CPF LIKE @cpf";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cpf",_cpf);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        diaria = new Diaria();
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Nome_Cliente = rd["NOME"].ToString();
                        diaria.CPF_Cliente = rd["CPF"].ToString();
                        diaria.Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        diaria.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        diaria.Valor_Total = (double)rd["VALOR_TOTAL"];
                        diaria.Data_Entrada = Convert.ToDateTime(rd["DATA_ENTRADA"]);
                        diaria.Data_Saida = Convert.ToDateTime(rd["DATA_SAIDA"]);
                        diaria.Quartos = new QuartoDAL().BuscarPorIdDiaria(diaria.Id);
                        Diaria.Add(diaria);
                    }

                }
                return Diaria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a Diária pelo CPF do Cliente.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Diaria> BuscarPorNomeCliente(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Diaria> Diaria = new List<Diaria>();
            Diaria diaria = new Diaria();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT D.ID, C.NOME, C.CPF, F.NOME NOME_FUNCIONARIO, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE,
                                    D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
                                    FROM DIARIA D
                                    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON D.ID_FUNCIONARIO = F.ID
                                    WHERE C.NOME LIKE @nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", "%" + _nome + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while(rd.Read())
                    {
                        diaria = new Diaria();
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Nome_Cliente = rd["NOME"].ToString();
                        diaria.CPF_Cliente = rd["CPF"].ToString();
                        diaria.Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        diaria.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        diaria.Valor_Total = (double)rd["VALOR_TOTAL"];
                        diaria.Data_Entrada = Convert.ToDateTime(rd["DATA_ENTRADA"]);
                        diaria.Data_Saida = Convert.ToDateTime(rd["DATA_SAIDA"]);
                        diaria.Quartos = new QuartoDAL().BuscarPorIdDiaria(diaria.Id);
                        Diaria.Add(diaria);
                    }

                }
                return Diaria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a Diária pelo nome do Cliente.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Diaria> BuscarPorDataEntrada(string _dataEntrada)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Diaria> Diaria = new List<Diaria>();
            Diaria diaria = new Diaria();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT D.ID, C.NOME, C.CPF, F.NOME NOME_FUNCIONARIO, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE,
                                    D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
                                    FROM DIARIA D
                                    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON D.ID_FUNCIONARIO = F.ID
                                    WHERE C.DATA_ENTRADA LIKE @Data_Entrada";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data_Entrada", "%" + _dataEntrada + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        diaria = new Diaria();
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Nome_Cliente = rd["NOME"].ToString();
                        diaria.CPF_Cliente = rd["CPF"].ToString();
                        diaria.Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        diaria.Id_Cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        diaria.Valor_Total = (double)rd["VALOR_TOTAL"];
                        diaria.Data_Entrada = Convert.ToDateTime(rd["DATA_ENTRADA"]);
                        diaria.Data_Saida = Convert.ToDateTime(rd["DATA_SAIDA"]);
                        diaria.Quartos = new QuartoDAL().BuscarPorIdDiaria(diaria.Id);
                        Diaria.Add(diaria);
                    }
                }
                return Diaria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a data de entrada da Diária no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool ValidarPermissao(int _idFuncionario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM PERMISSAO_GRUPO_FUNCIONARIO
                                    INNER JOIN FUNCIONARIO_GRUPO_FUNCIONARIO ON PERMISSAO_GRUPO_FUNCIONARIO.ID_GRUPO_FUNCIONARIO = FUNCIONARIO_GRUPO_FUNCIONARIO.ID_GRUPO_FUNCIONARIO
                                    WHERE FUNCIONARIO_GRUPO_FUNCIONARIO.ID_FUNCIONARIO = @IdFuncionario AND PERMISSAO_GRUPO_FUNCIONARIO.ID_PERMISSAO = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFuncionario", _idFuncionario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar validar permissões do usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}


