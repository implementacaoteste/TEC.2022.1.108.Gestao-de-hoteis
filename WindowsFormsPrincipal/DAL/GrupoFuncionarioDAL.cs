using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class GrupoFuncionarioDAL
    {
        public void Inserir(GrupoFuncionario _grupoFuncionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO GRUPO_FUNCIONARIO(NOME_GRUPO)
                                    VALUES(@NomeGrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoFuncionario.NomeGrupo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um grupo no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(GrupoFuncionario _grupoFuncionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE GRUPO_FUNCIONARIO SET NOME_GRUPO = @NomeGrupo
                                    WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoFuncionario.NomeGrupo);
                cmd.Parameters.AddWithValue("@Id", _grupoFuncionario.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um grupo no banco de dados.", ex);
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
                cmd.CommandText = @"DELETE FROM GRUPO_FUNCIONARIO
                                    WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um grupo no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoFuncionario> BuscarTodos()
        {
            List<GrupoFuncionario> grupofuncionarios = new List<GrupoFuncionario>();
            GrupoFuncionario grupofuncionario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME_GRUPO
                                    FROM GRUPO_FUNCIONARIO";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupofuncionario = new GrupoFuncionario();
                        grupofuncionario.Id = Convert.ToInt32(rd["ID"]);
                        grupofuncionario.NomeGrupo = rd["NOME_GRUPO"].ToString();
                        grupofuncionarios.Add(grupofuncionario);
                    }
                }
                return grupofuncionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<GrupoFuncionario> BuscarPorId(int _id)
        {
            List<GrupoFuncionario> gpfuncionario = new List<GrupoFuncionario>();
            GrupoFuncionario grupofuncionario = new GrupoFuncionario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME_GRUPO FROM GRUPO_FUNCIONARIO
                                    WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupofuncionario.Id = Convert.ToInt32(rd["ID"]);
                        grupofuncionario.NomeGrupo = rd["NOME_GRUPO"].ToString();
                    }
                }
                return gpfuncionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o ID.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<GrupoFuncionario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            List<GrupoFuncionario> grupofuncionarios = new List<GrupoFuncionario>();
            GrupoFuncionario grupofuncionario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME_GRUPO
                                    FROM GRUPO_FUNCIONARIO WHERE NOME_GRUPO LIKE @NomeGrupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", "%" + _nomeGrupo + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupofuncionario = new GrupoFuncionario();
                        grupofuncionario.Id = Convert.ToInt32(rd["ID"]);
                        grupofuncionario.NomeGrupo = rd["NOME_GRUPO"].ToString();
                        grupofuncionarios.Add(grupofuncionario);
                    }
                }
                return grupofuncionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o nome do grupo.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
