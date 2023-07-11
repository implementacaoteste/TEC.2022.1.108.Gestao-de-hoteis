using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Permissao(Descricao)VALUES(@descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", _permissao.Descricao);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Inserir uma permissão um dado no banco. Favor, verificar conexão", ex);
            }
            finally 
            {
                cn.Close();
            }
        }
        public void Alterar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE PERMISSAO SET DESCRICAO = @Descricao WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);
                cmd.Parameters.AddWithValue("Id", _permissao.Id);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atulizar uma permissão os dados.", ex);
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
                cmd.CommandText = "DELETE PERMISSAO WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("Id", _id);

                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Excluir uma permissão um dado do banco.", ex);
            }
            finally 
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarTodos() 
        {
            List<Permissao> permissaos = new List<Permissao>();
            Permissao permissao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT ID, DESCRICAO FROM PERMISSAO";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader Ler = cmd.ExecuteReader())
                {
                    while (Ler.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(Ler["ID"]);
                        permissao.Descricao = (Ler["DESCRICAO"]).ToString();
                        //permissao.Grupos = new GrupoFuncionarioDAL().BuscarPorId(permissao.Id);
                        permissaos.Add(permissao);
                    }
                }
                return permissaos;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro na busca de dados na permissão.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorId(int _id)
        {
            Permissao permissao = new Permissao();
            List<Permissao> permissaos = new List<Permissao>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "SELECT ID, DESCRICAO FROM PERMISSAO WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using(SqlDataReader Ler = cmd.ExecuteReader())
                {
                    while (Ler.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(Ler["Id"]);
                        permissao.Descricao = Convert.ToString(Ler["Descricao"]);
                        //permissao.Grupos = new GrupoFuncionarioDAL().BuscarPorId(permissao.Id);
                    }
                }
                return permissaos;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar o código da permissaõ no banco de dados . favor, verificar conexao", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT ID, DESCRICAO FROM PERMISSAO WHERE DESCRICAO LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["ID"]);
                        permissao.Descricao = Convert.ToString(rd["DESCRICAO"]);
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar pela descrição da permissão. Favor verificar conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        internal List<Permissao> BuscarPorIdGrupo(int _idGrupoFuncionario)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT PERMISSAO.ID, PERMISSAO.DESCRICAO FROM PERMISSAO
                                    INNER JOIN PERMISSAO_GRUPO_FUNCIONARIO ON PERMISSAO.ID = PERMISSAO_GRUPO_FUNCIONARIO.ID_PERMISSAO
                                    WHERE PERMISSAO_GRUPO_FUNCIONARIO.ID_GRUPO_FUNCIONARIO = @IdGrupoFuncionario ORDER BY PERMISSAO.DESCRICAO";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoFuncionario", _idGrupoFuncionario);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["ID"]);
                        permissao.Descricao = rd["DESCRICAO"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar permissoes por código mo grupo funcionario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
