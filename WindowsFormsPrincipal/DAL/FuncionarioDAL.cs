using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL
    {
        public void Inserir(Funcionario _funcionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO FUNCIONARIO(NOME, NOME_USUARIO, EMAIL,SENHA ,CPF, ATIVO, ENDERECO,CELULAR, DATA_NASCIMENTO)
                                      VALUES(@Nome, @NomeUsuario, @Email,@Senha, @CPF, @Ativo, @ENDERECO, @CELULAR, @DATA_NASCIMENTO)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _funcionario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _funcionario.Email);
                cmd.Parameters.AddWithValue("@CPF", _funcionario.CPF);
                cmd.Parameters.AddWithValue("@Senha", _funcionario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _funcionario.Ativo);
                cmd.Parameters.AddWithValue("@ENDERECO", _funcionario.Endereco);
                cmd.Parameters.AddWithValue("@CELULAR", _funcionario.Celular);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _funcionario.Data_nascimento);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um funcionario no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Funcionario _funcionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE FUNCIONARIO SET NOME= @Nome, NOME_USUARIO= @NomeUsuario, EMAIL= @Email, SENHA=@Senha ,CPF = @CPF,
                                         ATIVO = @Ativo, ENDERECO= @ENDERECO, DATA_NASCIMENTO = @DATA_NASCIMENTO, CELULAR= @CELULAR   
                                        Where Id= @ID ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _funcionario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _funcionario.Email);
                cmd.Parameters.AddWithValue("@CPF", _funcionario.CPF);
                cmd.Parameters.AddWithValue("@Senha", _funcionario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _funcionario.Ativo);
                cmd.Parameters.AddWithValue("@ENDERECO", _funcionario.Endereco);
                cmd.Parameters.AddWithValue("@CELULAR", _funcionario.Celular);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _funcionario.Data_nascimento);
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

        public Funcionario BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                Funcionario funcionario = new Funcionario();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, NOME_USUARIO, EMAIL ,SENHA ,CPF, ATIVO, DATA_NASCIMENTO, ENDERECO,CELULAR 
                                           From FUNCIONARIO
                                       where ID=@ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                        funcionario.Data_nascimento = Convert.ToInt32(rd["DATA_NASCIMENTO"]);

                    }

                }
                return funcionario;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar  os funcionario na buscar por id", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Funcionario BuscarPorNomeFuncionario(string _nome )
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Funcionario funcionario= new Funcionario();
            try
            {
                SqlCommand cmd = new SqlCommand();

              
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, NOME_USUARIO, EMAIL ,SENHA ,CPF, ATIVO, DATA_NASCIMENTO, ENDERECO,CELULAR 
                                           From FUNCIONARIO
                                       where NOME_USUARIO like @NomeUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeUsuario", " % "+ _nome + " % ");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                        funcionario.Data_nascimento = Convert.ToInt32(rd["DATA_NASCIMENTO"]);
                      
                    }

                }
                return funcionario;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os funcionario na buscar por Nome usuario", ex);
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
                cmd.CommandText = @"DELETE FROM FUNCIONARIO 
                                    WHERE Id= @ID";

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

            public List<Funcionario> BuscarTodos()
            {

                List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                try
                {
                    SqlCommand cmd = new SqlCommand();


                    cmd.Connection = cn;
                    cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Email,Senha ,CPF, Ativo From FUNCIONARIO";


                    cmd.CommandType = System.Data.CommandType.Text;
                    cn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                   
                        while (rd.Read())
                        {
                        funcionario = new Funcionario();
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                            funcionario.Nome = rd["NOME"].ToString();
                            funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                            funcionario.Email = rd["EMAIL"].ToString();
                            funcionario.CPF = rd["CPF"].ToString();
                            funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                            funcionario.Senha = rd["SENHA"].ToString();
                            funcionario.Endereco = rd["ENDERECO"].ToString();
                            funcionario.Celular = rd["CELULAR"].ToString();
                            funcionario.Data_nascimento = Convert.ToInt32(rd["DATA_NASCIMENTO"]);
                            



                        }

                    }
                    return funcionarios;

                }
                catch (Exception ex)
                {

                    throw new Exception("Ocorreu um erro ao tentar buscar todos os usuario na buscar", ex);
                }
                finally
                {
                    cn.Close();
                }
            }


    }

      
    }

