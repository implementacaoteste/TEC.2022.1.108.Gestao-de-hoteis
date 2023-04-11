using DAL;
using Modelss;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class ClasseDAL
    {
        public void Alterar(Classe _classe)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE CLASSE SET CLASSE = @CLASSE 
                                        Where ID= @ID ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CLASSE", _classe.Class);
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um classe no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Classe> BuscaPorClasse(string _classe)
        {
            List<Classe> classes = new List<Classe>();
            Classe classe;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, CLASSE
                    FROM CLASSE Where CLASSE Like @CLASSE";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CLASSE", "%" + _classe + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        classe = new Classe();
                        classe.Id = Convert.ToInt32(rd["Id"]);
                        classe.Class = rd["Nome"].ToString();
                    }
                }
                return classes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuarios: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Classe> BuscaPorTodos()
        {
            List<Classe> classes = new List<Classe>();
            Classe classe;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, CLASSE
                                    FROM CLASSE ";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        classe = new Classe();
                        classe.Id = Convert.ToInt32(rd["Id"]);
                        classe.Class = rd["Nome"].ToString();
                       
                    }
                }
                return classes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as Classes: ", ex);
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
                cmd.CommandText = @"DELETE FROM CLASSE 
                                    WHERE ID= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma Classe no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Inserir(Classe _classe)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO CLASSE(CLASSE)
                                      VALUES(@CLASSE)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CLASSE", _classe.Class);
            
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma Classe no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
    
}
