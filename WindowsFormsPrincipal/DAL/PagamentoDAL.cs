using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class PagamentoDAL
    {
        public void Alterar(Pagamento _pagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Pagamento SET FORMA_PAGAMENTO = @Forma_pagamento Where ID = @ID";


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Forma_pagamento", _pagamento.Forma_pagamento);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um pagamento do banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Pagamento> BuscaPorTodos()
        {
            List<Pagamento> pagamentos = new List<Pagamento>();
            Pagamento pagamento;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, FORMA_PAGAMENTO FROM PAGAMENTO";

                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        pagamento = new Pagamento();
                        pagamento.Id = Convert.ToInt32(rd["ID"]);
                        pagamento.Forma_pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        pagamentos.Add(pagamento);
                    }
                }
                return pagamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os pagamentos no banco de dados: ", ex);
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
                cmd.CommandText = "DELETE FROM PAGAMENTO WHERE ID= @ID";


                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um pagamento no banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Inserir(Pagamento _pagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO PAGAMENTO (FORMA_PAGAMENTO) VALUES (@Forma_pagamento)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Forma_pagamento", _pagamento.Forma_pagamento);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um pagamento no banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Pagamento> BuscaPorId(int _id)
        {
            List<Pagamento> pagamentos = new List<Pagamento>();
            Pagamento pagamento = new Pagamento();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, FORMA_PAGAMENTO FROM FORMA_PAGAMENTO
                                    WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        pagamento.Id = Convert.ToInt32(rd["ID"]);
                        pagamento.Forma_pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        pagamentos.Add(pagamento);
                    }
                }
                return pagamentos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o ID do pagamento no banco d .", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}


