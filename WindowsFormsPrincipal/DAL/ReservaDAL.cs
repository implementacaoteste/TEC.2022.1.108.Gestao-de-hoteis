using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
                cmd.CommandText = @"INSERT INTO RESERVA (DT_ENT_RESERVA, DT_SAI_RESERVA, VALOR_TOTAL, ID_CLIENTE, QTD_HOSPEDES, ID_PAGAMENTO, ID_FUNCIONARIO, OBS_RESERVA, VALOR_ENTRADA, DATA_CHECKIN, DATA_CHECKOUT, OBS_CHECKIN, OBS_CHECKOUT, DATA_RESERVA)
                                       VALUES(@DT_ENT_RESERVA, @DT_SAI_RESERVA, @VALOR_TOTAL, @ID_CLIENTE, @QTD_HOSPEDES, @ID_PAGAMENTO, @ID_FUNCIONARIO, @OBS_RESERVA, @VALOR_ENTRADA, @DATA_CHECKIN, @DATA_CHECKOUT, @OBS_CHECKIN, @OBS_CHECKOUT, @DATA_RESERVA) SELECT SCOPE_IDENTITY() AS Id";
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
                cmd.Connection = cn;
                cn.Open();

                _reserva.Id = Convert.ToInt32(cmd.ExecuteScalar());
                VincularQuarto(_reserva);
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
                throw new Exception("Ocorreu um erro ao tentar inserir uma Reserva no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Reserva _reserva)
        {
            throw new NotImplementedException();
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM RESERVA
                                    WHERE ID= @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma Reserva no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void CancelarReserva(int _id)
        {
            throw new NotImplementedException();
        }
        public void CheckIn(Reserva reserva)
        {
            throw new NotImplementedException();
        }
        public void CheckOut(Reserva reserva)
        {
            throw new NotImplementedException();
        }
        public Reserva BuscarPorId(int _id)
        {
            Reserva reserva = new Reserva();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA
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
                        reserva.Valor_Total = (double)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (double)rd["VALOR_ENTRADA"];
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
                        reserva.Quartos = new QuartoDAL().BuscarPorIdReserva(reserva.Id);
                    }
                }
                return reserva;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar a Reserva na buscar por ID.", ex);
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
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
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
                        reserva.Valor_Total = (double)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (double)rd["VALOR_ENTRADA"];
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
                throw new Exception("Ocorreu um erro ao tentar buscar todas as Diárias.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Reserva> BuscarPorDataCheckin(DateTime _dataInicial, DateTime _dataFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA
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
                        reserva.Valor_Total = (double)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (double)rd["VALOR_ENTRADA"];
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
        public List<Reserva> BuscarPorDataCheckout(DateTime _dataInicial, DateTime _dataFinal)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Reserva> reservas = new List<Reserva>();
            Reserva reserva;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA
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
                        reserva.Valor_Total = (double)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (double)rd["VALOR_ENTRADA"];
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
                cmd.CommandText = @"SELECT R.ID, R.DT_ENT_RESERVA, R.DT_SAI_RESERVA, R.VALOR_TOTAL, R.ID_CLIENTE, C.NOME, C.CPF, R.QTD_HOSPEDES, R.ID_PAGAMENTO, P.FORMA_PAGAMENTO, R.ID_FUNCIONARIO, 
                                    F.NOME NOME_FUNCIONARIO, R.OBS_RESERVA, R.VALOR_ENTRADA, RQ.ID_QUARTO, Q.NUMERO, CL.CLASSE, R.DATA_CHECKIN, R.DATA_CHECKOUT, R.OBS_CHECKIN, R.OBS_CHECKOUT, R.DATA_RESERVA
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
                        reserva.Valor_Total = (double)rd["VALOR_TOTAL"];
                        reserva.Id_Hospede = Convert.ToInt32(rd["ID_CLIENTE"]);
                        reserva.Nome_Hospede = rd["NOME"].ToString();
                        reserva.CPF_Hopesde = rd["CPF"].ToString();
                        reserva.Qtd_Hospedes = Convert.ToInt32(rd["QTD_HOSPEDES"]);
                        reserva.Id_Pagamento = Convert.ToInt32(rd["ID_PAGAMENTO"]);
                        reserva.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        reserva.Id_Funcionario = Convert.ToInt32(rd["ID_FUNCIONARIO"]);
                        reserva.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        reserva.Obs_Reserva = rd["OBS_RESERVA"].ToString();
                        reserva.Valor_Entrada = (double)rd["VALOR_ENTRADA"];
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