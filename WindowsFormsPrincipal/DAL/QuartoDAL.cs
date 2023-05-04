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
                cmd.CommandText = @"INSERT INTO QUARTO (NUMERO, ID_CLASSE, DESCRICAO, VALOR_DIARIA, ANDAR, ID_STATUS)
                                    VALUES(@Numero, @Id_Classe, @Descricao, @Valor_Diaria, @Andar, @Id_Status)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _quarto.Numero);
                cmd.Parameters.AddWithValue("@Id_Classe", _quarto.Id_Classe);
                cmd.Parameters.AddWithValue("@Descricao", _quarto.Descricao);
                cmd.Parameters.AddWithValue("@Valor_Diaria", _quarto.Valor_Diaria);
                cmd.Parameters.AddWithValue("@Andar", _quarto.Andar);
                cmd.Parameters.AddWithValue("@Id_Status", _quarto.Id_Status);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Quarto no Banco de Dados.", ex);
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
                cmd.CommandText = @"UPDATE QUARTO SET NUMERO = @Numero, ID_CLASSE = @Id_Classe, DESCRICAO = @Descricao, 
                                    VALOR_DIARIA = @Valor_Diaria, ANDAR = @Andar, ID_STATUS = @Id_Status
                                    WHERE ID= @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _quarto.Numero);
                cmd.Parameters.AddWithValue("@Id_Classe", _quarto.Id_Classe);
                cmd.Parameters.AddWithValue("@Descricao", _quarto.Descricao);
                cmd.Parameters.AddWithValue("@Valor_Diaria", _quarto.Valor_Diaria);
                cmd.Parameters.AddWithValue("@Andar", _quarto.Andar);
                cmd.Parameters.AddWithValue("@Id_Status", _quarto.Id_Status);
                cmd.Parameters.AddWithValue("@ID", _quarto.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um Quarto no Banco de Dados.", ex);
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
                throw new Exception("Ocorreu erro ao tentar excluir um Quarto no Banco de Dados.", ex);
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
                cmd.CommandText = @"SELECT Q.ID, Q.NUMERO, Q.ID_CLASSE, CLASSE.CLASSE, Q.DESCRICAO, Q.VALOR_DIARIA, Q.ANDAR, Q.ID_STATUS, STATUS.STATUS
                                    FROM QUARTO Q
                                    INNER JOIN CLASSE ON CLASSE.ID = Q.ID_CLASSE
                                    INNER JOIN STATUS ON STATUS.ID = Q.ID_STATUS";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        quarto = new Quarto();
                        quarto.Id = Convert.ToInt32(rd["ID"]);
                        quarto.Id_Classe = Convert.ToInt32(rd["ID_CLASSE"]);
                        quarto.Classe = rd["CLASSE"].ToString();
                        quarto.Numero = rd["NUMERO"].ToString();
                        quarto.Descricao = rd["DESCRICAO"].ToString();
                        quarto.Valor_Diaria = (double)rd["VALOR_DIARIA"];
                        quarto.Andar = rd["ANDAR"].ToString();
                        quarto.Id_Status = Convert.ToInt32(rd["ID_STATUS"]);
                        quarto.Status = rd["STATUS"].ToString();
                        quartos.Add(quarto);
                    }
                }
                return quartos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Quartos.", ex);
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
                cmd.CommandText = @"SELECT Q.ID, Q.NUMERO, Q.ID_CLASSE, CLASSE.CLASSE, Q.DESCRICAO, Q.VALOR_DIARIA, Q.ANDAR, Q.ID_STATUS, STATUS.STATUS
                                    FROM QUARTO Q
                                    INNER JOIN CLASSE ON CLASSE.ID = Q.ID_CLASSE
                                    INNER JOIN STATUS ON STATUS.ID = Q.ID_STATUS
                                    WHERE NUMERO LIKE @Numero";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", "%" + _numero + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        quarto = new Quarto();
                        quarto.Id = Convert.ToInt32(rd["ID"]);
                        quarto.Id_Classe = Convert.ToInt32(rd["ID_CLASSE"]);
                        quarto.Classe = rd["CLASSE"].ToString();
                        quarto.Numero = rd["NUMERO"].ToString();
                        quarto.Descricao = rd["DESCRICAO"].ToString();
                        quarto.Valor_Diaria = (double)rd["VALOR_DIARIA"];
                        quarto.Andar = rd["ANDAR"].ToString();
                        quarto.Id_Status = Convert.ToInt32(rd["ID_STATUS"]);
                        quarto.Status = rd["STATUS"].ToString();
                    }
                }
                return quarto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o número do Quarto no banco de dados.", ex);
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
                                    LEFT JOIN FUNCIONARIO_GRUPO_FUNCIONARIO ON PERMISSAO_GRUPO_FUNCIONARIO.ID_GRUPO_FUNCIONARIO = FUNCIONARIO_GRUPO_FUNCIONARIO.ID_GRUPO_FUNCIONARIO
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
        internal List<Quarto> BuscarPorIdDiaria(int _idDiaria)
        {
            List<Quarto> quartos = new List<Quarto>();
            Quarto quarto;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT QUARTO.ID, QUARTO.NUMERO, QUARTO.ID_CLASSE, QUARTO.DESCRICAO, QUARTO.VALOR_DIARIA, QUARTO.ANDAR, QUARTO.ID_STATUS, CLASSE.CLASSE, STATUS.STATUS FROM QUARTO
                                    INNER JOIN CLASSE ON QUARTO.ID_CLASSE = CLASSE.ID
                                    INNER JOIN STATUS ON QUARTO.ID_STATUS = STATUS.ID
                                    INNER JOIN DIARIA_QUARTO ON QUARTO.ID = DIARIA_QUARTO.ID_QUARTO
                                    WHERE DIARIA_QUARTO.ID_DIARIA = @IdDiaria";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdDiaria", _idDiaria);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        quarto = new Quarto();
                        quarto.Id = Convert.ToInt32(rd["ID"]);
                        quarto.Numero = rd["NUMERO"].ToString();
                        quarto.Id_Classe = Convert.ToInt32(rd["ID_CLASSE"]);
                        quarto.Descricao = rd["DESCRICAO"].ToString();
                        quarto.Valor_Diaria = Convert.ToInt32(rd["VALOR_DIARIA"]);
                        quarto.Andar = rd["ANDAR"].ToString();
                        quarto.Id_Status = Convert.ToInt32(rd["ID_STATUS"]);
                        quarto.Classe = rd["CLASSE"].ToString();
                        quarto.Status = rd["STATUS"].ToString();
                        quartos.Add(quarto);
                    }
                }
                return quartos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a diária por Id do Quarto.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

