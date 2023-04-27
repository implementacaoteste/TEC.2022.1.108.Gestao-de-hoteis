using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class QuartoDAL
    {
        public void Inserir(Quarto _quarto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO QUARTO(NUMERO,DESCRICAO,VALOR_DIARIA)
                                      VALUES(@Numero, @Descricao, @Valor_Diaria)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _quarto.Numero);
                cmd.Parameters.AddWithValue("@Descricao", _quarto.Descricao);
                cmd.Parameters.AddWithValue("@Valor_Diaria", _quarto.Valor_Diaria);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um quarto no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Quarto _quarto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE QUARTO SET NUMERO= @Numero,DESCRICAO= @Descricao,VALOR_DIARIA = @Valor_Diaria
                                        Where ID= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _quarto.Numero);
                cmd.Parameters.AddWithValue("@Descricao", _quarto.Descricao);
                cmd.Parameters.AddWithValue("@Valor_Diaria", _quarto.Valor_Diaria);
                cmd.Connection = cn;
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um quarto no Banco de Dados", ex);
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
                cmd.CommandText = @"DELETE FROM QUARTO 
                                    WHERE ID=@Id";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um quarto no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Quarto> BuscarPorTodos()
        {
            List<Quarto> quartos = new List<Quarto>();
            Quarto quarto;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NUMERO, ID_CLASSE, DESCRICAO, VALOR_DIARIA, ID_STATUS
                                    FROM QUARTO";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        quarto = new Quarto();
                        quarto.Id = Convert.ToInt32(rd["ID"]);
                        quarto.Id_Classe = Convert.ToInt32(rd["ID_CLASSE"]);
                        quarto.Numero = rd["NUMERO"].ToString();
                        quarto.Descricao = rd["DESCRICAO"].ToString();
                        quarto.Valor_Diaria = (double)rd["VALOR_DIARIA"];
                        quarto.Id_Status = Convert.ToInt32(rd["ID_STATUS"]);
                        quartos.Add(quarto);
                    }
                }
                return quartos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os quartos: ", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public Quarto BuscarPorNumero(int _numero)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Quarto quarto = new Quarto();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NUMERO,DESCICAO,VALOR_DIARIA
                                    FROM QUARTO WHERE NUMERO = @Numero";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _numero);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        quarto = new Quarto();
                        quarto.Id = Convert.ToInt32(rd["Id"]);
                        quarto.Numero = rd["Numero"].ToString();
                        quarto.Descricao = rd["Descricao"].ToString();
                        quarto.Valor_Diaria = Convert.ToInt32(rd["Valor_Diaria"]);
                    }
                }
                return quarto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o número no banco de dados: ", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public bool ValidarPermissao(int idLogado, int idPermissao)
        {
            throw new NotImplementedException();
        }
    }
}

