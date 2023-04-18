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
                throw new Exception("Ocorreu um erro ao 'Inserir' um dado no banco. Favor, verificar conexão", ex);
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
                cmd.CommandText = @"UPDATE Permissao SET Descricao = @descricao WHERE Id=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("id", _permissao.Id);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao atulizar os dados.  Favor, verificar conexão", ex);
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
                cmd.CommandText = "DELETE Permissao WHERE Id = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("id", _id);

                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao 'Excluir' um dado do banco. Favor, verificar conexao", ex);
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
                cmd.CommandText = @"SELECT Id,Descricao FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader Ler = cmd.ExecuteReader())
                {
                    while (Ler.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(Ler["Id"]);
                        permissao.Descricao = (Ler["Descricao"]).ToString();
                        //permissao.Grupos = new GrupoFuncionarioDAL().BuscarPorId(permissao.Id);
                        permissaos.Add(permissao);
                    }
                }
                return permissaos;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro na busca de dados em 'Permissão'. Por favor verifique sua conexão", ex);
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
                cmd.CommandText = @"SELECT Id,Descricao FROM Permissao WHERE Id=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);

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
                throw new Exception("Ocorreu um erro ao buscar os dados no banco. favor, verificar conexao", ex);
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
                throw new Exception("Ocorreu um erro ao tentar buscar os dados no banco. Favor verificar conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorIdGrupo(int _idGrupoFuncionario)
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.Id, Permissao.Descricao FROM Permissao
                                    INNER JOIN PermissaoGrupoUsuario ON Permissao.Id = PermissaoGrupoUsuario.IdPermissao
                                    WHERE PermissaoGrupoUsuario.IdGrupoUsuario = @IdGrupoUsuario ORDER BY Permissao.Descricao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoFuncionario);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar permissoes por Id no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
