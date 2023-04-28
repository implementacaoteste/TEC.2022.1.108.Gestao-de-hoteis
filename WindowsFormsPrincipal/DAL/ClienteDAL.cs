using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DALL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO CLIENTE(NOME, EMAIL, CPF, ATIVO, ENDERECO, CELULAR, DATA_NASCIMENTO, ID_SEXO)
                                      VALUES(@Nome, @Email, @CPF, @Endereco, @Celular, @Data_Nascimento, @Id_Sexo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@Endereco", _cliente.Endereco);
                cmd.Parameters.AddWithValue("@Celular", _cliente.Celular);
                cmd.Parameters.AddWithValue("@Data_Nascimento", _cliente.Data_nascimento);
                cmd.Parameters.AddWithValue("@Id_Sexo", _cliente.IdSexo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Cliente no Banco de Dados.", ex);
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
                cmd.CommandText = @"DELETE FROM CLIENTE 
                                    WHERE ID= @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um Cliente no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Cliente _cliente)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE CLIENTE SET NOME = @Nome,  EMAIL = @Email, CPF = @CPF, ENDERECO = @Endereco, 
                                    DATA_NASCIMENTO = @Data_Nascimento, CELULAR = @Celular , ID_SEXO = @Id_Sexo  
                                    WHERE ID = @Id ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@Endereco", _cliente.Endereco);
                cmd.Parameters.AddWithValue("@Celular", _cliente.Celular);
                cmd.Parameters.AddWithValue("@Data_Nascimento", _cliente.Data_nascimento);
                cmd.Parameters.AddWithValue("@Id_Sexo", _cliente.IdSexo);
                cmd.Parameters.AddWithValue("@Id", _cliente.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um Cliente no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscaPorCPF(string _CPF)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CLIENTE.ID, NOME, EMAIL, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO, SEXO.SEXO
                                    FROM CLIENTE
                                    INNER JOIN SEXO ON CLIENTE.ID_SEXO = SEXO.ID
                                    WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _CPF);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente.Id = Convert.ToInt32(rd["ID"]);
                        cliente.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        cliente.Nome = rd["SEXO"].ToString();
                        cliente.Nome = rd["NOME"].ToString();
                        cliente.Email = rd["EMAIL"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Endereco = rd["ENDERECO"].ToString();
                        cliente.Celular = rd["CELULAR"].ToString();
                        cliente.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o cliente por CPF: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Cliente> BuscaPorNome(string _nome)
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CLIENTE.ID, NOME, EMAIL, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO, SEXO.SEXO
                                    FROM CLIENTE
                                    INNER JOIN SEXO ON CLIENTE.ID_SEXO = SEXO.ID
                                    WHERE NOME LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(rd["ID"]);
                        cliente.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        cliente.Nome = rd["SEXO"].ToString();
                        cliente.Nome = rd["NOME"].ToString();
                        cliente.Email = rd["EMAIL"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Endereco = rd["ENDERECO"].ToString();
                        cliente.Celular = rd["CELULAR"].ToString();
                        cliente.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                    }
                }
                return clientes;
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
        public List<Cliente> BuscaPorTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT CLIENTE.ID, NOME, EMAIL, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO, SEXO.SEXO
                                    FROM CLIENTE                                    
                                    INNER JOIN SEXO ON CLIENTE.ID_SEXO = SEXO.ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(rd["ID"]);
                        cliente.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        cliente.Sexo = rd["SEXO"].ToString();
                        cliente.Nome = rd["NOME"].ToString();
                        cliente.Email = rd["EMAIL"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Endereco = rd["ENDERECO"].ToString();
                        cliente.Celular = rd["CELULAR"].ToString();
                        cliente.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                        clientes.Add(cliente);
                    }
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Clientes.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorId(int _id)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME,  EMAIL, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO
                                    FROM CLIENTE WHERE ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente.Id = Convert.ToInt32(rd["ID"]);
                        cliente.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        cliente.Nome = rd["NOME"].ToString();
                        cliente.Email = rd["EMAIL"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.Endereco = rd["ENDERECO"].ToString();
                        cliente.Celular = rd["CELULAR"].ToString();
                        cliente.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o ID no Banco de Dados.", ex);
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
