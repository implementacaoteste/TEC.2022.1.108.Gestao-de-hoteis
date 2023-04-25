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
                        grupofuncionario.Permissoes = new PermissaoDAL().BuscarPorIdGrupo(grupofuncionario.Id);
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
                        grupofuncionario.Permissoes = new PermissaoDAL().BuscarPorIdGrupo(grupofuncionario.Id);
                        gpfuncionario.Add(grupofuncionario);
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
                        grupofuncionario.Permissoes = new PermissaoDAL().BuscarPorIdGrupo(grupofuncionario.Id);
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

        public bool PermissaoPertenceAoGrupo(int _idGrupoFuncionario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM PERMISSAO_GRUPO_FUNCIONARIO
                                    WHERE ID_GRUPO_FUNCIONARIO = @IdGrupoUsuario AND ID_PERMISSAO = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoFuncionario);
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
                throw new Exception("Ocorreu um erro ao tentar validar a existencia.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AdicionarPermissao(int _idGrupoFuncionario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO PERMISSAO_GRUPO_FUNCIONARIO(ID_GRUPO_FUNCIONARIO, ID_PERMISSAO)
                                    VALUES(@IdGrupoUsuario, @IdPermissao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoFuncionario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar vincular uma permissão a um grupo de funcionário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void RemoverPermissao(int _idGrupoFuncionario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM PERMISSAO_GRUPO_FUNCIONARIO
                                    WHERE ID_PERMISSAO = @IdPermissao AND ID_GRUPO_FUNCIONARIO = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoFuncionario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma permissão do grupo de funcionário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        internal List<GrupoFuncionario> BuscarPorIdFuncionario(int _idFuncionario)
        {
            List<GrupoFuncionario> grupofuncionarios = new List<GrupoFuncionario>();
            GrupoFuncionario grupofuncionario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT GRUPO_FUNCIONARIO.ID, GRUPO_FUNCIONARIO.NOME_GRUPO FROM GRUPO_FUNCIONARIO
                                    INNER JOIN FUNCIONARIO_GRUPO_FUNCIONARIO ON GRUPO_FUNCIONARIO.ID = FUNCIONARIO_GRUPO_FUNCIONARIO.ID_GRUPO_FUNCIONARIO
                                    WHERE FUNCIONARIO_GRUPO_FUNCIONARIO.ID_FUNCIONARIO = @IdFuncionario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFuncionario", _idFuncionario);
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
                throw new Exception("Ocorreu um erro ao tentar buscar grupos de funcionários por Id do funcionário.", ex);
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
