using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
                cmd.CommandText = @"INSERT INTO CLIENTE(NOME,  EMAIL,CPF, ATIVO, ENDERECO,CELULAR, DATA_NASCIMENTO, ID_SEXO)
                                      VALUES(@Nome,  @Email, @CPF,  @ENDERECO, @CELULAR, @DATA_NASCIMENTO, @ID_SEXO)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@ENDERECO", _cliente.Endereco);
                cmd.Parameters.AddWithValue("@CELULAR", _cliente.Celular);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _cliente.Data_nascimento);
                cmd.Parameters.AddWithValue("@ID_SEXO", _cliente.IdSexo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um cliente no Banco de Dados", ex);
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
                                    WHERE ID= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um FUNCIONARIO no Banco de Dados", ex);
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
                cmd.CommandText = @"UPDATE CLIENTE SET NOME= @Nome,  EMAIL= @Email, ,CPF = @CPF,
                                            ENDERECO= @ENDERECO, DATA_NASCIMENTO = @DATA_NASCIMENTO, CELULAR= @CELULAR , ID_SEXO = @ID_SEXO  
                                        Where ID= @ID ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@ENDERECO", _cliente.Endereco);
                cmd.Parameters.AddWithValue("@CELULAR", _cliente.Celular);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _cliente.Data_nascimento);
                cmd.Parameters.AddWithValue("@ID_SEXO", _cliente.IdSexo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um funcionario no Banco de Dados", ex);
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
                cmd.CommandText = @"SELECT ID, NOME,  Email, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO
                                    FROM CLIENTE WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _CPF);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente.Id = Convert.ToInt32(rd["ID"]);
                        cliente.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        cliente.Nome = rd["Nome"].ToString();
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
        public List<Cliente> BuscaPorNome(Cliente _nome)
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME,  Email, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO
                                    FROM CLIENTE Where NOME Like @Nome";
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
                cmd.CommandText = @"SELECT ID, NOME,  Email, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO
                                    FROM CLIENTE ";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(rd["ID"]);
                          cliente.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
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
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuarios: ", ex);
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
                cmd.CommandText = @"SELECT ID, NOME,  Email, CPF, DATA_NASCIMENTO, CELULAR, ENDERECO, ID_SEXO
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
                throw new Exception("Ocorreu um erro ao tentar buscar o ID: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
