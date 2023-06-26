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
                        quarto.Valor_Diaria = (decimal)rd["VALOR_DIARIA"];
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
        public Quarto BuscarPorNumero(string _numero)
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
                cmd.Parameters.AddWithValue("@Numero", _numero);
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
                        quarto.Valor_Diaria = (decimal)rd["VALOR_DIARIA"];
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
        internal List<Quarto> BuscarPorIdReserva(int _idReserva)
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
                                    LEFT JOIN RESERVA_QUARTO ON QUARTO.ID = RESERVA_QUARTO.ID_QUARTO
                                    WHERE RESERVA_QUARTO.ID_RESERVA = @IdReserva";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReserva", _idReserva);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
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

        public Quarto BuscarPorId(int _id)
        {
            Quarto quarto = new Quarto();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT QUARTO.ID, QUARTO.NUMERO, QUARTO.ID_CLASSE, QUARTO.DESCRICAO, QUARTO.VALOR_DIARIA, QUARTO.ANDAR, QUARTO.ID_STATUS, CLASSE.CLASSE, STATUS.STATUS FROM QUARTO
                                    INNER JOIN CLASSE ON QUARTO.ID_CLASSE = CLASSE.ID
                                    INNER JOIN STATUS ON QUARTO.ID_STATUS = STATUS.ID
                                    LEFT JOIN RESERVA_QUARTO ON QUARTO.ID = RESERVA_QUARTO.ID_QUARTO
                                    WHERE QUARTO.ID = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        quarto.Id = Convert.ToInt32(rd["ID"]);
                        quarto.Numero = rd["NUMERO"].ToString();
                        quarto.Id_Classe = Convert.ToInt32(rd["ID_CLASSE"]);
                        quarto.Descricao = rd["DESCRICAO"].ToString();
                        quarto.Valor_Diaria = Convert.ToInt32(rd["VALOR_DIARIA"]);
                        quarto.Andar = rd["ANDAR"].ToString();
                        quarto.Id_Status = Convert.ToInt32(rd["ID_STATUS"]);
                        quarto.Classe = rd["CLASSE"].ToString();
                        quarto.Status = rd["STATUS"].ToString();
                    }
                }
                return quarto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por código do quarto", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Quarto> BuscarPorQuartoDisponivel()
        {
            List<Quarto> quartos = new List<Quarto>();
            Quarto quarto;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Q.ID, Q.NUMERO, Q.ID_CLASSE, CLASSE.CLASSE, Q.DESCRICAO, Q.VALOR_DIARIA, Q.ANDAR, Q.ID_STATUS, S.STATUS
                                    FROM QUARTO Q
                                    INNER JOIN CLASSE ON CLASSE.ID = Q.ID_CLASSE
                                    INNER JOIN STATUS S ON S.ID = Q.ID_STATUS
                                    WHERE S.STATUS LIKE 'Disponível'";
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
                        quarto.Valor_Diaria = (decimal)rd["VALOR_DIARIA"];
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
                throw new Exception("Ocorreu um erro ao tentar buscar um Quarto disponível.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Quarto> BuscarPorDia(DateTime _dia)
        {
            List<Quarto> quartos = new List<Quarto>();
            Quarto quarto = new Quarto();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT QUARTO.ID, QUARTO.NUMERO, QUARTO.ID_CLASSE,QUARTO.DESCRICAO,QUARTO.VALOR_DIARIA,QUARTO.ANDAR,
                                    CASE
	                                    WHEN RESERVA.ID IS NULL THEN '1'
	                                    WHEN RESERVA.DATA_CHECKIN <= @Data AND RESERVA.DATA_CHECKOUT >= @Data THEN '2'
	                                    WHEN RESERVA.DT_ENT_RESERVA <= @Data AND RESERVA.DT_SAI_RESERVA >= @Data THEN '3'
	                                    ELSE '5'
	                                    END AS ID_STATUS
                                    ,CLASSE.CLASSE FROM QUARTO
                                    LEFT JOIN CLASSE ON QUARTO.ID_CLASSE = CLASSE.ID
                                    LEFT JOIN RESERVA_QUARTO ON QUARTO.ID = RESERVA_QUARTO.ID_QUARTO
                                    LEFT JOIN  RESERVA ON RESERVA_QUARTO.ID_RESERVA = RESERVA.ID
                                    LEFT JOIN STATUS ON QUARTO.ID_STATUS = STATUS.ID
                                    WHERE QUARTO.ID_STATUS <> 4";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", _dia.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (quarto.Numero != rd["NUMERO"].ToString())
                        {
                            quarto = new Quarto();
                            quarto.Id = Convert.ToInt32(rd["ID"]);
                            quarto.Id_Classe = Convert.ToInt32(rd["ID_CLASSE"]);
                            quarto.Classe = rd["CLASSE"].ToString();
                            quarto.Numero = rd["NUMERO"].ToString();
                            quarto.Descricao = rd["DESCRICAO"].ToString();
                            quarto.Valor_Diaria = (decimal)rd["VALOR_DIARIA"];
                            quarto.Andar = rd["ANDAR"].ToString();
                            quarto.Id_Status = Convert.ToInt32(rd["ID_STATUS"]);
                            //quarto.Status = rd["STATUS"].ToString();
                            quartos.Add(quarto);
                        }
                    }
                }
                return quartos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Quarto disponível.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Quarto> BuscarQuartoDisponivelPorPeriodo(DateTime _dataEntrada, string _classe)
        {
            List<Quarto> quartos = new List<Quarto>();
            Quarto quarto = new Quarto();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT QUARTO.ID, QUARTO.NUMERO, CLASSE.CLASSE, QUARTO.VALOR_DIARIA, QUARTO.ANDAR, RESERVA.DT_ENT_RESERVA, RESERVA.DT_SAI_RESERVA, RESERVA.DATA_CHECKIN, RESERVA.DATA_CHECKOUT,
                                    CASE
	                                    WHEN RESERVA.ID IS NULL OR RESERVA.DT_ENT_RESERVA > @Data THEN 'Disponível' 
	                                    WHEN RESERVA.DATA_CHECKIN <= @Data AND RESERVA.DATA_CHECKOUT >= @Data THEN 'Ocupado'
										WHEN RESERVA.DT_SAI_RESERVA <= @Data OR (RESERVA.DATA_CHECKOUT IS NOT NULL AND RESERVA.DATA_CHECKOUT <= @Data) THEN 'Disponível'
	                                    --WHEN RESERVA.DATA_CHECKIN IS NULL THEN 'Reservado'
	                                    WHEN RESERVA.DT_ENT_RESERVA <= @Data AND RESERVA.DT_SAI_RESERVA >= @Data AND DATA_CHECKIN IS NULL THEN 'Reservado'
	                                    WHEN RESERVA.DT_ENT_RESERVA <= @Data AND RESERVA.DT_SAI_RESERVA >= @Data AND DATA_CHECKIN IS NOT NULL THEN 'Ocupado'
	                                    END AS STATUS
                                    FROM QUARTO
                                    INNER JOIN CLASSE ON QUARTO.ID_CLASSE = CLASSE.ID
                                    LEFT JOIN RESERVA_QUARTO ON QUARTO.ID = RESERVA_QUARTO.ID_QUARTO
                                    LEFT JOIN  RESERVA ON RESERVA_QUARTO.ID_RESERVA = RESERVA.ID
                                    LEFT JOIN STATUS ON QUARTO.ID_STATUS = STATUS.ID
                                    WHERE QUARTO.ID_STATUS <> 4 AND CLASSE.CLASSE = @Classe";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Data", _dataEntrada.Date);
                cmd.Parameters.AddWithValue("@classe", _classe);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        if (rd["NUMERO"].ToString() != quarto.Numero || rd["STATUS"].ToString() == "Reservado" || rd["STATUS"].ToString() == "Ocupado")
                        {
                            if (rd["NUMERO"].ToString() == quarto.Numero)
                                quartos.Remove(quarto);

                            quarto = new Quarto();
                            quarto.Id = Convert.ToInt32(rd["ID"]);
                            quarto.Numero = rd["NUMERO"].ToString();
                            quarto.Classe = rd["CLASSE"].ToString();
                            quarto.Valor_Diaria = (decimal)rd["VALOR_DIARIA"];
                            quarto.Andar = rd["ANDAR"].ToString();

                            if (rd["DT_ENT_RESERVA"].ToString() != "")
                                quarto.Dt_Ent_Checkin = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);

                            if (rd["DATA_CHECKIN"].ToString() != "")
                                quarto.Dt_Sai_Checkout = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);

                            if (rd["DATA_CHECKIN"].ToString() != "")
                                quarto.CheckIn = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                            if (rd["DATA_CHECKOUT"].ToString() != "")
                                quarto.CheckOut = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                            quarto.Status = rd["STATUS"].ToString();
                            quartos.Add(quarto);
                        }
                    }
                }
                return quartos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Quarto disponível.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Quarto> BuscarPorStatus(string _status)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Quarto> quartos = new List<Quarto>();
            Quarto quarto;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Q.ID, Q.NUMERO, Q.ID_CLASSE, CLASSE.CLASSE, Q.DESCRICAO, Q.VALOR_DIARIA, Q.ANDAR, Q.ID_STATUS, S.STATUS
                                    FROM QUARTO Q
                                    INNER JOIN CLASSE ON CLASSE.ID = Q.ID_CLASSE
                                    INNER JOIN STATUS S ON S.ID = Q.ID_STATUS
                                    WHERE S.STATUS LIKE @Status";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Status", "%" + _status + "%");
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
                        quarto.Valor_Diaria = (decimal)rd["VALOR_DIARIA"];
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
                throw new Exception("Ocorreu um erro ao tentar buscar o Quarto pelo Status banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}

