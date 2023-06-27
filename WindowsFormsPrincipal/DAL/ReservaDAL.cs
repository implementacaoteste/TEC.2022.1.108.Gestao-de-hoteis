using Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaDAL
    {
        public void Inserir(Reserva _reserva)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO RESERVA (DT_ENT_RESERVA, DT_SAI_RESERVA, VALOR_TOTAL, ID_CLIENTE, QTD_HOSPEDES, ID_PAGAMENTO, ID_FUNCIONARIO, OBS_RESERVA, VALOR_ENTRADA, DATA_CHECKIN, DATA_CHECKOUT, OBS_CHECKIN, OBS_CHECKOUT, DATA_RESERVA, VALOR_RESTANTE)
                                       VALUES(@DT_ENT_RESERVA, @DT_SAI_RESERVA, @VALOR_TOTAL, @ID_CLIENTE, @QTD_HOSPEDES, @ID_PAGAMENTO, @ID_FUNCIONARIO, @OBS_RESERVA, @VALOR_ENTRADA, @DATA_CHECKIN, @DATA_CHECKOUT, @OBS_CHECKIN, @OBS_CHECKOUT, @DATA_RESERVA, @VALOR_RESTANTE) SELECT SCOPE_IDENTITY() AS Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DT_ENT_RESERVA", _reserva.Data_Ent_Reserva);
                cmd.Parameters.AddWithValue("@DT_SAI_RESERVA", _reserva.Data_Sai_Reserva);
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _reserva.Valor_Total);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _reserva.Id_Hospede);
                cmd.Parameters.AddWithValue("@QTD_HOSPEDES", _reserva.Qtd_Hospedes);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _reserva.Id_Pagamento);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", Constante.IdLogado);
                cmd.Parameters.AddWithValue("@OBS_RESERVA", _reserva.Obs_Reserva);
                cmd.Parameters.AddWithValue("@VALOR_ENTRADA", _reserva.Valor_Entrada);
                cmd.Parameters.AddWithValue("@DATA_CHECKIN", DBNull.Value);
                cmd.Parameters.AddWithValue("DATA_CHECKOUT", DBNull.Value);
                cmd.Parameters.AddWithValue("@OBS_CHECKIN", _reserva.Obs_Checkin);
                cmd.Parameters.AddWithValue("@OBS_CHECKOUT", _reserva.Obs_Checkout);
                cmd.Parameters.AddWithValue("@DATA_RESERVA", _reserva.Data_Reserva);
                cmd.Parameters.AddWithValue("@VALOR_RESTANTE", _reserva.Valor_Restante);
                cmd.Connection = cn;
                cn.Open();

                _reserva.Id = Convert.ToInt32(cmd.ExecuteScalar());
                VincularQuarto(_reserva);
                ReservaEntrada(_reserva);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma Reserva no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private void ReservaEntrada(Reserva _reserva)
        {
            if (_reserva.Valor_Entrada == 0)
                return;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONTAS_A_RECEBER(DESCRICAO,VALOR, ID_CLIENTE, 
                                    ID_FUNCIONARIO, DATA_VENCIMENTO, RECEBIDO)
                                    VALUES(@DESCRICAO, @VALOR, @ID_CLIENTE, @ID_FUNCIONARIO, @DATA_VENCIMENTO, @RECEBIDO)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DESCRICAO", "Entrada Reserva - Quarto " + _reserva.Quartos[0].Numero);
                cmd.Parameters.AddWithValue("@VALOR", _reserva.Valor_Entrada);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _reserva.Id_Hospede);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", Constante.IdLogado);
                cmd.Parameters.AddWithValue("@DATA_VENCIMENTO", _reserva.Data_Ent_Reserva);
                cmd.Parameters.AddWithValue("@RECEBIDO", 0);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar gerar uma Conta a Receber no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private void VincularQuarto(Reserva _reserva)
        {
            if (_reserva.Quartos.Count == 0)
                return;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO RESERVA_QUARTO(ID_RESERVA, ID_QUARTO)
                                       VALUES(@ID_RESERVA, @ID_QUARTO)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_RESERVA", _reserva.Id);
                cmd.Parameters.AddWithValue("@ID_QUARTO", _reserva.Quartos[0].Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Vincular um Quarto em uma Reserva no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Reserva _reserva)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE RESERVA SET DT_ENT_RESERVA = @DT_ENT_RESERVA, DT_SAI_RESERVA = @DT_SAI_RESERVA, VALOR_TOTAL = @VALOR_TOTAL, ID_CLIENTE = @ID_CLIENTE, QTD_HOSPEDES = @QTD_HOSPEDES, ID_PAGAMENTO = @ID_PAGAMENTO, 
                                    ID_FUNCIONARIO = @ID_FUNCIONARIO, OBS_RESERVA = @OBS_RESERVA, VALOR_ENTRADA = @VALOR_ENTRADA, DATA_CHECKIN = @DATA_CHECKIN, DATA_CHECKOUT = @DATA_CHECKOUT, OBS_CHECKIN = @OBS_CHECKIN, OBS_CHECKOUT = @OBS_CHECKOUT, DATA_RESERVA = @DATA_RESERVA
                                    WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DT_ENT_RESERVA", _reserva.Data_Ent_Reserva);
                cmd.Parameters.AddWithValue("@DT_SAI_RESERVA", _reserva.Data_Sai_Reserva);
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _reserva.Valor_Total);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _reserva.Id_Hospede);
                cmd.Parameters.AddWithValue("@QTD_HOSPEDES", _reserva.Qtd_Hospedes);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _reserva.Id_Pagamento);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", Constante.IdLogado);
                cmd.Parameters.AddWithValue("@OBS_RESERVA", _reserva.Obs_Reserva);
                cmd.Parameters.AddWithValue("@VALOR_ENTRADA", _reserva.Valor_Entrada);
                
                if (_reserva.Data_Checkin != null)
                    cmd.Parameters.AddWithValue("@DATA_CHECKIN", _reserva.Data_Checkin);
                else
                    cmd.Parameters.AddWithValue("@DATA_CHECKIN", DBNull.Value);

                if (_reserva.Data_Checkout != null)
                    cmd.Parameters.AddWithValue("DATA_CHECKOUT", _reserva.Data_Checkout);
                else
                    cmd.Parameters.AddWithValue("@DATA_CHECKOUT", DBNull.Value);

                cmd.Parameters.AddWithValue("@OBS_CHECKIN", _reserva.Obs_Checkin);
                cmd.Parameters.AddWithValue("@OBS_CHECKOUT", _reserva.Obs_Checkout);
                cmd.Parameters.AddWithValue("@DATA_RESERVA", _reserva.Data_Reserva);
                cmd.Parameters.AddWithValue("@ID", _reserva.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a Reserva no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM RESERVA WHERE ID = @ID", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ID", _id);

                        if (transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        RemoverReservaQuarto(_id, transaction);
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir uma Reserva no Banco de Dados.", ex);
                    }
                }
            }
        }

        public void CancelarReserva(Reserva _reserva, int _id, int _idHospede, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM RESERVA WHERE ID = @ID", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ID", _id);

                        if (transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        RemoverReservaQuarto(_id, transaction);
                        RemoverContasReceber(_idHospede, transaction);
                        EstornoReserva(_reserva, _idHospede);
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir uma Reserva no Banco de Dados.", ex);
                    }
                }
            }
        }

        private void RemoverContasReceber(int _idHospede, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM CONTAS_A_RECEBER WHERE ID_CLIENTE = @ID_CLIENTE", cn))
                {
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", _idHospede);

                    if (transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir uma Reserva no Banco de Dados.", ex);
                    }
                }
            }
        }

        private void EstornoReserva(Reserva _reserva, int _idHospede)
        {
            if (_reserva.Valor_Entrada == 0)
                return;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO CONTAS_A_PAGAR(DESCRICAO,VALOR, ID_CLIENTE, 
                                    ID_FUNCIONARIO, DATA_VENCIMENTO, PAGAR)
                                    VALUES(@DESCRICAO, @VALOR, @ID_CLIENTE, @ID_FUNCIONARIO, @DATA_VENCIMENTO, @PAGAR)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DESCRICAO", "Estorno - Entrada Reserva - Quarto " + _reserva.Quartos[0].Numero);
                cmd.Parameters.AddWithValue("@VALOR", _reserva.Valor_Entrada);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _idHospede);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", Constante.IdLogado);
                cmd.Parameters.AddWithValue("@DATA_VENCIMENTO", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@PAGAR", 0);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar gerar uma Conta a Pagar no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private void RemoverReservaQuarto(int _id, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM RESERVA_QUARTO WHERE ID_RESERVA = @ID_RESERVA", cn))
                {
                    cmd.Parameters.AddWithValue("@ID_RESERVA", _id);

                    if (transaction == null)
                    {
                        cn.Open();
                        transaction = cn.BeginTransaction();
                    }

                    cmd.Transaction = transaction;
                    cmd.Connection = transaction.Connection;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir uma Reserva no Banco de Dados.", ex);
                    }
                }
            }
        }

        public void CheckIn(Reserva _reserva)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE RESERVA SET ID_PAGAMENTO = @ID_PAGAMENTO, DATA_CHECKIN = @DATA_CHECKIN, OBS_CHECKIN = @OBS_CHECKIN WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _reserva.Id_Pagamento);
                cmd.Parameters.AddWithValue("@DATA_CHECKIN", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@OBS_CHECKIN", _reserva.Obs_Checkin);
                cmd.Parameters.AddWithValue("@ID", _reserva.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao realizar o Check In.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void CheckOut(Reserva _reserva)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE RESERVA SET DATA_CHECKOUT = @DATA_CHECKOUT, OBS_CHECKOUT = @OBS_CHECKOUT WHERE ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_CHECKIN", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@OBS_CHECKOUT", _reserva.Obs_Checkout);
                cmd.Parameters.AddWithValue("@ID", _reserva.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao efetuar o Check Out.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Reserva BuscarPorId(int _id)
        {
            Reserva reserva = new Reserva();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, C.CELULAR, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA, VALOR_RESTANTE
                                    FROM RESERVA R
                                    INNER JOIN RESERVA_QUARTO RQ ON R.ID = RQ.ID_RESERVA
                                    INNER JOIN CLIENTE C ON R.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON R.ID_FUNCIONARIO = F.ID
									INNER JOIN QUARTO Q ON RQ.ID_QUARTO = Q.ID
									INNER JOIN CLASSE CL ON Q.ID_CLASSE = CL.ID
									INNER JOIN PAGAMENTO P ON R.ID_PAGAMENTO = P.ID
                                    WHERE R.ID=@ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["ID"]);
                        reserva.Data_Ent_Reserva = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);
                        reserva.Data_Sai_Reserva = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);
                        reserva.Valor_Total = (decimal)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Celular_Hospede = rd["CELULAR"].ToString();
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (decimal)rd["VALOR_ENTRADA"];
                        reserva.Id_Quarto = Convert.ToInt32(rd["ID_QUARTO"]);
                        reserva.Numero_Quarto = rd["NUMERO"].ToString();
                        reserva.Tipo_Quarto = rd["CLASSE"].ToString();

                        if (rd["DATA_CHECKIN"].ToString() != "")
                            reserva.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                        if (rd["DATA_CHECKOUT"].ToString() != "")
                            reserva.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        reserva.Data_Reserva = Convert.ToDateTime(rd["DATA_RESERVA"]);
                        reserva.Obs_Checkin = rd["OBS_CHECKIN"].ToString();
                        reserva.Obs_Checkout = rd["OBS_CHECKOUT"].ToString();
                        reserva.Valor_Restante = (decimal)rd["VALOR_RESTANTE"];
                        reserva.Quartos = new QuartoDAL().BuscarPorIdReserva(reserva.Id);
                    }
                }
                return reserva;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar a Reserva na buscar por código.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Reserva BuscarPorIdReserva(int _idReserva)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> BuscarPorTodas()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, C.CELULAR, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT
                                    FROM RESERVA R
                                    INNER JOIN RESERVA_QUARTO RQ ON R.ID = RQ.ID_RESERVA
                                    INNER JOIN CLIENTE C ON R.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON R.ID_FUNCIONARIO = F.ID
									INNER JOIN QUARTO Q ON RQ.ID_QUARTO = Q.ID
									INNER JOIN PAGAMENTO P ON R.ID_PAGAMENTO = P.ID";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["ID"]);
                        reserva.Data_Ent_Reserva = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);
                        reserva.Data_Sai_Reserva = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);
                        reserva.Valor_Total = (decimal)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Celular_Hospede = rd["CELULAR"].ToString();
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (decimal)rd["VALOR_ENTRADA"];
                        reserva.Id_Quarto = Convert.ToInt32(rd["ID_QUARTO"]);
                        reserva.Numero_Quarto = rd["NUMERO"].ToString();

                        if (rd["DATA_CHECKIN"].ToString() != "")
                            reserva.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                        if (rd["DATA_CHECKOUT"].ToString() != "")
                            reserva.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        reserva.Obs_Checkin = rd["OBS_CHECKIN"].ToString();
                        reserva.Obs_Checkout = rd["OBS_CHECKOUT"].ToString();
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as reservas.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Reserva> BuscarPorDataEntCheckin(DateTime _dataInicial, DateTime _dataFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, C.CELULAR, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA, R.VALOR_RESTANTE
                                    FROM RESERVA R
                                    INNER JOIN RESERVA_QUARTO RQ ON R.ID = RQ.ID_RESERVA
                                    INNER JOIN CLIENTE C ON R.ID_CLIENTE = C.ID
                                    INNER JOIN QUARTO Q ON RQ.ID_QUARTO = Q.ID
									INNER JOIN FUNCIONARIO F ON R.ID_FUNCIONARIO = F.ID
									INNER JOIN CLASSE CL ON Q.ID_CLASSE = CL.ID
									INNER JOIN PAGAMENTO P ON R.ID_PAGAMENTO = P.ID
                                    WHERE R.DT_ENT_RESERVA BETWEEN @DATA_INICIAL AND @DATA_FINAL";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_INICIAL", _dataInicial.Date);
                cmd.Parameters.AddWithValue("@DATA_FINAL", _dataFinal.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["ID"]);
                        reserva.Data_Ent_Reserva = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);
                        reserva.Data_Sai_Reserva = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);
                        reserva.Valor_Total = (decimal)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Celular_Hospede = rd["CELULAR"].ToString();
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (decimal)rd["VALOR_ENTRADA"];
                        reserva.Id_Quarto = Convert.ToInt32(rd["ID_QUARTO"]);
                        reserva.Numero_Quarto = rd["NUMERO"].ToString();
                        reserva.Tipo_Quarto = rd["CLASSE"].ToString();

                        if (rd["DATA_CHECKIN"].ToString() != "")
                            reserva.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                        if (rd["DATA_CHECKOUT"].ToString() != "")
                            reserva.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        reserva.Data_Reserva = Convert.ToDateTime(rd["DATA_RESERVA"]);
                        reserva.Obs_Checkin = rd["OBS_CHECKIN"].ToString();
                        reserva.Obs_Checkout = rd["OBS_CHECKOUT"].ToString();
                        reserva.Valor_Restante = (decimal)rd["VALOR_RESTANTE"];
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as Reservas pela data.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Reserva> BuscarPorDataCheckin(DateTime _dataCheckin)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, C.CELULAR, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA, R.VALOR_RESTANTE
                                    FROM RESERVA R
                                    INNER JOIN RESERVA_QUARTO RQ ON R.ID = RQ.ID_RESERVA
                                    INNER JOIN CLIENTE C ON R.ID_CLIENTE = C.ID
                                    INNER JOIN QUARTO Q ON RQ.ID_QUARTO = Q.ID
									INNER JOIN FUNCIONARIO F ON R.ID_FUNCIONARIO = F.ID
									INNER JOIN CLASSE CL ON Q.ID_CLASSE = CL.ID
									INNER JOIN PAGAMENTO P ON R.ID_PAGAMENTO = P.ID
                                    WHERE R.DATA_CHECKIN = @DATA_CHECKIN";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_CHECKIN", _dataCheckin.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["ID"]);
                        reserva.Data_Ent_Reserva = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);
                        reserva.Data_Sai_Reserva = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);
                        reserva.Valor_Total = (decimal)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Celular_Hospede = rd["CELULAR"].ToString();
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (decimal)rd["VALOR_ENTRADA"];
                        reserva.Id_Quarto = Convert.ToInt32(rd["ID_QUARTO"]);
                        reserva.Numero_Quarto = rd["NUMERO"].ToString();
                        reserva.Tipo_Quarto = rd["CLASSE"].ToString();

                        if (rd["DATA_CHECKIN"].ToString() != "")
                            reserva.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                        if (rd["DATA_CHECKOUT"].ToString() != "")
                            reserva.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        reserva.Data_Reserva = Convert.ToDateTime(rd["DATA_RESERVA"]);
                        reserva.Obs_Checkin = rd["OBS_CHECKIN"].ToString();
                        reserva.Obs_Checkout = rd["OBS_CHECKOUT"].ToString();
                        reserva.Valor_Restante = (decimal)rd["VALOR_RESTANTE"];
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as Reservas pela data.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Reserva> BuscarPorDataSaiCheckout(DateTime _dataInicial, DateTime _dataFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, C.CELULAR, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA, R.VALOR_RESTANTE
                                    FROM RESERVA R
                                    INNER JOIN RESERVA_QUARTO RQ ON R.ID = RQ.ID_RESERVA
                                    INNER JOIN CLIENTE C ON R.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON R.ID_FUNCIONARIO = F.ID
									INNER JOIN QUARTO Q ON RQ.ID_QUARTO = Q.ID
									INNER JOIN CLASSE CL ON Q.ID_CLASSE = CL.ID
									INNER JOIN PAGAMENTO P ON R.ID_PAGAMENTO = P.ID
                                    WHERE R.DT_SAI_RESERVA BETWEEN @DATA_INICIAL AND @DATA_FINAL";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_INICIAL", _dataInicial.Date);
                cmd.Parameters.AddWithValue("@DATA_FINAL", _dataFinal.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["ID"]);
                        reserva.Data_Ent_Reserva = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);
                        reserva.Data_Sai_Reserva = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);
                        reserva.Valor_Total = (decimal)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Celular_Hospede = rd["CELULAR"].ToString();
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (decimal)rd["VALOR_ENTRADA"];
                        reserva.Id_Quarto = Convert.ToInt32(rd["ID_QUARTO"]);
                        reserva.Numero_Quarto = rd["NUMERO"].ToString();
                        reserva.Tipo_Quarto = rd["CLASSE"].ToString();

                        if (rd["DATA_CHECKIN"].ToString() != "")
                            reserva.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                        if (rd["DATA_CHECKOUT"].ToString() != "")
                            reserva.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        reserva.Data_Reserva = Convert.ToDateTime(rd["DATA_RESERVA"]);
                        reserva.Obs_Checkin = rd["OBS_CHECKIN"].ToString();
                        reserva.Obs_Checkout = rd["OBS_CHECKOUT"].ToString();
                        reserva.Valor_Restante = (decimal)rd["VALOR_RESTANTE"];
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as Reservas pela data.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Reserva> BuscarPorDataCheckout(DateTime _dataCheckout)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, C.CELULAR, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA, R.VALOR_RESTANTE
                                    FROM RESERVA R
                                    INNER JOIN RESERVA_QUARTO RQ ON R.ID = RQ.ID_RESERVA
                                    INNER JOIN CLIENTE C ON R.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON R.ID_FUNCIONARIO = F.ID
									INNER JOIN QUARTO Q ON RQ.ID_QUARTO = Q.ID
									INNER JOIN CLASSE CL ON Q.ID_CLASSE = CL.ID
									INNER JOIN PAGAMENTO P ON R.ID_PAGAMENTO = P.ID
                                    WHERE R.DATA_CHECKOUT = @DATA_CHECKOUT";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_CHECKOUT", _dataCheckout.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["ID"]);
                        reserva.Data_Ent_Reserva = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);
                        reserva.Data_Sai_Reserva = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);
                        reserva.Valor_Total = (decimal)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Celular_Hospede = rd["CELULAR"].ToString();
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (decimal)rd["VALOR_ENTRADA"];
                        reserva.Id_Quarto = Convert.ToInt32(rd["ID_QUARTO"]);
                        reserva.Numero_Quarto = rd["NUMERO"].ToString();
                        reserva.Tipo_Quarto = rd["CLASSE"].ToString();

                        if (rd["DATA_CHECKIN"].ToString() != "")
                            reserva.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                        if (rd["DATA_CHECKOUT"].ToString() != "")
                            reserva.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        reserva.Data_Reserva = Convert.ToDateTime(rd["DATA_RESERVA"]);
                        reserva.Obs_Checkin = rd["OBS_CHECKIN"].ToString();
                        reserva.Obs_Checkout = rd["OBS_CHECKOUT"].ToString();
                        reserva.Valor_Restante = (decimal)rd["VALOR_RESTANTE"];
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as Reservas pela data.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Reserva> BuscarPorDataLancamento(DateTime _dataInicial, DateTime _dataFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, C.CELULAR,R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA, R.VALOR_RESTANTE
                                    FROM RESERVA R
                                    INNER JOIN RESERVA_QUARTO RQ ON R.ID = RQ.ID_RESERVA
                                    INNER JOIN CLIENTE C ON R.ID_CLIENTE = C.ID
									INNER JOIN FUNCIONARIO F ON R.ID_FUNCIONARIO = F.ID
									INNER JOIN QUARTO Q ON RQ.ID_QUARTO = Q.ID
									INNER JOIN CLASSE CL ON Q.ID_CLASSE = CL.ID
									INNER JOIN PAGAMENTO P ON R.ID_PAGAMENTO = P.ID
                                    WHERE R.DATA_RESERVA BETWEEN @DATA_INICIAL AND @DATA_FINAL";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_INICIAL", _dataInicial.Date);
                cmd.Parameters.AddWithValue("@DATA_FINAL", _dataFinal.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        reserva = new Reserva();
                        reserva.Id = Convert.ToInt32(rd["ID"]);
                        reserva.Data_Ent_Reserva = Convert.ToDateTime(rd["DT_ENT_RESERVA"]);
                        reserva.Data_Sai_Reserva = Convert.ToDateTime(rd["DT_SAI_RESERVA"]);
                        reserva.Valor_Total = (decimal)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Celular_Hospede = rd["CELULAR"].ToString();
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (decimal)rd["VALOR_ENTRADA"];
                        reserva.Id_Quarto = Convert.ToInt32(rd["ID_QUARTO"]);
                        reserva.Numero_Quarto = rd["NUMERO"].ToString();
                        reserva.Tipo_Quarto = rd["CLASSE"].ToString();

                        if (rd["DATA_CHECKIN"].ToString() != "")
                            reserva.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);

                        if (rd["DATA_CHECKOUT"].ToString() != "")
                            reserva.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        reserva.Data_Reserva = Convert.ToDateTime(rd["DATA_RESERVA"]);
                        reserva.Obs_Checkin = rd["OBS_CHECKIN"].ToString();
                        reserva.Obs_Checkout = rd["OBS_CHECKOUT"].ToString();
                        reserva.Valor_Restante = (decimal)rd["VALOR_RESTANTE"];
                        reservas.Add(reserva);
                    }
                }
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as Reservas pela data específica.", ex);
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

        public void SelecionarQuarto(int _idReserva, int _idQuarto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO DIARIA_QUARTO(ID_DIARIA, ID_QUARTO)
                                    VALUES(@ID_DIARIA, @ID_QUARTO)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID_DIARIA", _idReserva);
                cmd.Parameters.AddWithValue("@ID_QUARTO", _idQuarto);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar vincular uma Quarto em uma diaria no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool ReservaPertenceQuarto(int idReserva, int idQuarto)
        {
            throw new NotImplementedException();
        }
    }
}