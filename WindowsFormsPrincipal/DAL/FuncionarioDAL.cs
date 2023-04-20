using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                cmd.CommandText = @"INSERT INTO FUNCIONARIO(NOME, NOME_USUARIO, EMAIL,SENHA ,CPF, ATIVO, ENDERECO,CELULAR, DATA_NASCIMENTO, ID_SEXO)
                                      VALUES(@NOME, @NOME_USUARIO, @EMAIL,@SENHA, @CPF, @Ativo, @ENDERECO, @CELULAR, @DATA_NASCIMENTO,@IDSEXO)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NOME", _funcionario.Nome);
                cmd.Parameters.AddWithValue("@NOME_USUARIO", _funcionario.NomeUsuario);
                cmd.Parameters.AddWithValue("@EMAIL", _funcionario.Email);
                cmd.Parameters.AddWithValue("@CPF", _funcionario.CPF);
                cmd.Parameters.AddWithValue("@SENHA", _funcionario.Senha);
                cmd.Parameters.AddWithValue("@IDSEXO", _funcionario.IdSexo);
                cmd.Parameters.AddWithValue("@ATIVO", _funcionario.Ativo);
                cmd.Parameters.AddWithValue("@ENDERECO", _funcionario.Endereco);
                cmd.Parameters.AddWithValue("@CELULAR", _funcionario.Celular);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", _funcionario.Data_nascimento);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Funcionário no Banco de Dados", ex);
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
                                         ATIVO = @Ativo, ENDERECO= @ENDERECO, DATA_NASCIMENTO = @DATA_NASCIMENTO, CELULAR= @CELULAR, ID_SEXO=@SEXO   
                                        Where ID= @ID ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _funcionario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _funcionario.Email);
                cmd.Parameters.AddWithValue("@CPF", _funcionario.CPF);
                cmd.Parameters.AddWithValue("@IDSEXO", _funcionario.IdSexo);
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
                throw new Exception("Ocorreu erro ao tentar alterar um Funcionário no Banco de Dados.", ex);
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
                                    WHERE ID= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um Funcionário no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Funcionario BuscarPorId(int _id)
        {
            Funcionario funcionario = new Funcionario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, NOME_USUARIO, EMAIL ,SENHA ,CPF, ATIVO, DATA_NASCIMENTO,  ENDERECO,CELULAR , ID_SEXO
                                    From FUNCIONARIO WHERE ID=@ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                        funcionario.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                    }
                }
                return funcionario;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar o Funcionário na buscar por ID.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Funcionario> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, ID_SEXO, NOME, NOME_USUARIO, EMAIL ,SENHA , CPF, ATIVO, DATA_NASCIMENTO, ENDERECO, CELULAR 
                                    FROM FUNCIONARIO";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                        funcionario.GrupoFuncionarios = new GrupoFuncionarioDAL().BuscarPorIdFuncionario(funcionario.Id);
                        funcionarios.Add(funcionario);
                    }
                }
                return funcionarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar os funcionarios", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Funcionario> BuscarPorNome(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, NOME_USUARIO, EMAIL ,SENHA ,CPF, ATIVO, DATA_NASCIMENTO, 
                                    ENDERECO, CELULAR, ID_SEXO FROM FUNCIONARIO WHERE NOME LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _nome);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                        funcionario.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                        funcionario.GrupoFuncionarios = new GrupoFuncionarioDAL().BuscarPorIdFuncionario(funcionario.Id);
                        funcionarios.Add(funcionario);
                    }
                }
                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o nome do funcionario.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Funcionario BuscarPorNomeUsuario(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Funcionario funcionario = new Funcionario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, NOME_USUARIO, EMAIL ,SENHA ,CPF, ATIVO, DATA_NASCIMENTO, 
                                    ENDERECO, CELULAR, ID_SEXO FROM FUNCIONARIO WHERE NOME_USUARIO LIKE @NomeUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeUsuario", _nome);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                        funcionario.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                    }
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o nome de usuário do funcionario.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Funcionario BuscarPorCPF(string _cPF)
        {
            Funcionario funcionario = new Funcionario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT ID, NOME, NOME_USUARIO, EMAIL ,SENHA ,CPF, ATIVO, DATA_NASCIMENTO, 
                                    ENDERECO, CELULAR, ID_SEXO FROM FUNCIONARIO WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _cPF);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        funcionario.Id = Convert.ToInt32(rd["ID"]);
                        funcionario.IdSexo = Convert.ToInt32(rd["ID_SEXO"]);
                        funcionario.Nome = rd["NOME"].ToString();
                        funcionario.NomeUsuario = rd["NOME_USUARIO"].ToString();
                        funcionario.Email = rd["EMAIL"].ToString();
                        funcionario.CPF = rd["CPF"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["ATIVO"]);
                        funcionario.Senha = rd["SENHA"].ToString();
                        funcionario.Endereco = rd["ENDERECO"].ToString();
                        funcionario.Celular = rd["CELULAR"].ToString();
                        funcionario.Data_nascimento = Convert.ToDateTime(rd["DATA_NASCIMENTO"]);
                        funcionario.GrupoFuncionarios = new GrupoFuncionarioDAL().BuscarPorIdFuncionario(funcionario.Id);
                    }
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o CPF: ", ex);
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
        public bool FuncionarioPertenceAoGrupo(int _idFuncionario, int _idGrupoFuncionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM FUNCIONARIO_GRUPO_FUNCIONARIO
                                    WHERE ID_FUNCIONARIO = @IdFuncionario AND ID_GRUPO_FUNCIONARIO = @IdGrupoFuncionario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFuncionario", _idFuncionario);
                cmd.Parameters.AddWithValue("@IdGrupoFuncionario", _idGrupoFuncionario);
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
        public void AdicionarGrupoFuncionario(int _idFuncionario, int _idGrupoFuncionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO FUNCIONARIO_GRUPO_FUNCIONARIO(ID_FUNCIONARIO, ID_GRUPO_FUNCIONARIO)
                                    VALUES(@IdFuncionario, @IdGrupoFuncionario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFuncionario", _idFuncionario);
                cmd.Parameters.AddWithValue("@IdGrupoFuncionario", _idGrupoFuncionario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar vincular um grupo a um funcionário no banco de dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void RemoverGrupoUsuario(int _idFuncionario, int _idGrupoFuncionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM FUNCIONARIO_GRUPO_FUNCIONARIO
                                    WHERE ID_FUNCIONARIO = @IdFuncionario AND ID_GRUPO_FUNCIONARIO = @IdGrupoFuncionario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFuncionario", _idFuncionario);
                cmd.Parameters.AddWithValue("@IdGrupoFuncionario", _idGrupoFuncionario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um grupo do funcionário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}