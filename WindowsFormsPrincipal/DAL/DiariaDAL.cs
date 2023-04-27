using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
                cmd.CommandText = @"INSET INTO (VALOR_TOTAL, DATA_ENTRADA, ID_CLIENTE, ID_FUNCIONARIO, ID_PAGAMENTO, DATA_SAIDA, DATA_ENRADA)
                                       VALUES(@VALOR_TOTAL, @DATA_ENTRADA, @ID_CLIENTE, @ID_FUNCIONARIO, @ID_PAGAMENTO, @DATA_SAIDA, @DATA_ENTRADA)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _diaria.Valor_Total);
                cmd.Parameters.AddWithValue("DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _diaria.Id_cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _diaria.Id_funcionario);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _diaria.Id_Pagamento);
                cmd.Parameters.AddWithValue("@DATA_SAIDA", _diaria.Data_Saida);
                cmd.Parameters.AddWithValue("@DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir a diaria no Banco de Dados.", ex);
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
                cmd.CommandText = @"UPDATE DIARIA SET VALOR_TOTAL = @VALOR_TOTAL, DATA_ENTRADA = @DATA_ENTRADA, ID_CLIENTE = @ID_CLIENTE, ID_FUNCIONARIO = @ID_FUNCIONARIO,ID_PAGAMENTO = @ID_PAGAMENTO, DATA_SAIDA = @DATA_SAIDA, DATA_ENRADA = @DATA_ENRADA
                                    WHERE ID = @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _diaria.Valor_Total);
                cmd.Parameters.AddWithValue("DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _diaria.Id_cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _diaria.Id_funcionario);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _diaria.Id_Pagamento);
                cmd.Parameters.AddWithValue("@DATA_SAIDA", _diaria.Data_Saida);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a diaria no Banco de Dados.", ex);
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
                throw new Exception("Ocorreu erro ao tentar excluir uma diaria no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Diaria> BuscarPorTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Diaria> Diaria = new List<Diaria>();
            Diaria diaria;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, VALOR_TOTAL, DATA_ENTRADA, ID_CLIENTE, ID_FUNCIONARIO, ID_PAGAMENTO, DATA_SAIDA, DATA_ENTRADA
                                    FROM Diaria";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        diaria = new Diaria();
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Id_funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Id_cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_pagamento"]);
                        diaria.Valor_Total = Convert.ToSingle(rd["VALOR_TOTAL"]);
                        diaria.Data_Entrada = rd["DATA_ENTRADA"].ToString();
                        diaria.Data_Saida = rd["DATA_SAIDA"].ToString();
                        Diaria.Add(diaria);
                    }

                }
                return Diaria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as diarias");
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
            Diaria diaria = new Diaria();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT D.ID, C.NOME, C.CPF, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE, 
                                    D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
                                    FROM DIARIA D
                                    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
                                    WHERE C.CPF LIKE @cpf";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cpf", "%" + _cpf + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        diaria = new Diaria();
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Id_funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Nome_Cliente = rd["NOME"].ToString();
                        diaria.Cpf_Cliente = rd["CPF"].ToString();
                        diaria.Id_cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_pagamento"]);
                        diaria.Valor_Total = Convert.ToSingle(rd["VALOR_TOTAL"]);
                        diaria.Data_Entrada = rd["DATA_ENTRADA"].ToString();
                        diaria.Data_Saida = rd["DATA_SAIDA"].ToString();
                        Diaria.Add(diaria);
                    }

                }
                return Diaria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as diarias", ex);
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
                cmd.CommandText = @"SELECT D.ID, C.NOME, C.CPF, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE,
                                    D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
                                    FROM DIARIA D
                                    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
                                    WHERE C.NOME LIKE @nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", "%" + _nome + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        diaria = new Diaria();
                        diaria.Id = Convert.ToInt32(rd["ID"]);
                        diaria.Id_funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Nome_Cliente = rd["NOME"].ToString();
                        diaria.Cpf_Cliente = rd["CPF"].ToString();
                        diaria.Id_cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_pagamento"]);
                        diaria.Valor_Total = Convert.ToSingle(rd["VALOR_TOTAL"]);
                        diaria.Data_Entrada = rd["DATA_ENTRADA"].ToString();
                        diaria.Data_Saida = rd["DATA_SAIDA"].ToString();
                        Diaria.Add(diaria);
                    }

                }
                return Diaria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as diarias", ex);
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
                cmd.CommandText = @"SELECT D.ID, C.NOME, C.CPF, D.VALOR_TOTAL, D.DATA_ENTRADA, D.ID_CLIENTE,
                                    D.ID_FUNCIONARIO, D.ID_PAGAMENTO, D.DATA_SAIDA, D.DATA_ENTRADA
                                    FROM DIARIA D
                                    INNER JOIN CLIENTE C ON D.ID_CLIENTE = C.ID
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
                        diaria.Id_funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        diaria.Nome_Cliente = rd["NOME"].ToString();
                        diaria.Cpf_Cliente = rd["CPF"].ToString();
                        diaria.Id_cliente = Convert.ToInt32(rd["ID_CLIENTE"]);
                        diaria.Id_Pagamento = Convert.ToInt32(rd["ID_pagamento"]);
                        diaria.Valor_Total = Convert.ToSingle(rd["VALOR_TOTAL"]);
                        diaria.Data_Entrada = rd["DATA_ENTRADA"].ToString();
                        diaria.Data_Saida = rd["DATA_SAIDA"].ToString();
                        Diaria.Add(diaria);
                    }

                }
                return Diaria;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a data de entrada no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}


