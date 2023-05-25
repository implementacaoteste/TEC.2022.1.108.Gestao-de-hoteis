using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RelatorioDAL
    {
        public List<Relatorio> BuscaPorTodos()
        {
            List<Relatorio> relatorios = new List<Relatorio>();
            Relatorio relatorio;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"
                                                    SELECT
                                                    RESERVA.DATA_CHECKIN,
                                                    CLIENTE.NOME,
                                                    CLIENTE.CPF,
                                                    FUNCIONARIO.NOME NOME_FUNCIONARIO,
                                                    FUNCIONARIO.NOME_USUARIO,
                                                    PAGAMENTO.FORMA_PAGAMENTO,
                                                    RESERVA.VALOR_TOTAL,
                                                    RESERVA.ID,
                                                    RESERVA.DATA_CHECKOUT,
                                                    QUARTO.VALOR_DIARIA,
                                                    QUARTO.DESCRICAO,
                                                    QUARTO.NUMERO,
                                                    FUNCIONARIO.NOME AS Funcionario
                                                    FROM RESERVA
                                                    INNER JOIN RESERVA_QUARTO RQ ON RESERVA.ID = RQ.ID_RESERVA
                                                    INNER JOIN CLIENTE ON RESERVA.ID_CLIENTE = CLIENTE.ID
                                                    INNER JOIN FUNCIONARIO ON RESERVA.ID_FUNCIONARIO = FUNCIONARIO.ID
                                                    INNER JOIN PAGAMENTO ON RESERVA.ID_PAGAMENTO = PAGAMENTO.ID
                                                    INNER JOIN QUARTO ON RQ.ID_QUARTO = QUARTO.ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        relatorio = new Relatorio();
                        relatorio.Id = Convert.ToInt32(rd["ID"]);
                        relatorio.Valor_Total = (double)rd["VALOR_TOTAL"];
                        relatorio.Nome_Hospede = rd["NOME"].ToString();
                        relatorio.CPF_Hopesde = rd["CPF"].ToString();
                        relatorio.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        relatorio.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        relatorio.Valor_Diaria = (double)rd["VALOR_DIARIA"];
                        relatorio.Numero_Quarto = rd["NUMERO"].ToString();
                        relatorio.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);
                        relatorio.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        relatorios.Add(relatorio);
                    }
                }
                return relatorios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os relatorios ", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Relatorio> DataCheckin(DateTime _dataCheckin)
        {
            List<Relatorio> relatorios = new List<Relatorio>();
            Relatorio relatorio;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"
                                                    SELECT
                                                    RESERVA.DATA_CHECKIN,
                                                    CLIENTE.NOME,
                                                    CLIENTE.CPF,
                                                    FUNCIONARIO.NOME NOME_FUNCIONARIO,
                                                    PAGAMENTO.FORMA_PAGAMENTO,
                                                    RESERVA.VALOR_TOTAL,
                                                    RESERVA.ID,
                                                    RESERVA.DATA_CHECKOUT,
                                                    QUARTO.VALOR_DIARIA,
                                                    QUARTO.NUMERO,
                                                    FUNCIONARIO.NOME AS Funcionario
                                                    FROM RESERVA
                                                    INNER JOIN RESERVA_QUARTO RQ ON RESERVA.ID = RQ.ID_RESERVA
                                                    INNER JOIN CLIENTE ON RESERVA.ID_CLIENTE = CLIENTE.ID
                                                    INNER JOIN FUNCIONARIO ON RESERVA.ID_FUNCIONARIO = FUNCIONARIO.ID
                                                    INNER JOIN PAGAMENTO ON RESERVA.ID_PAGAMENTO = PAGAMENTO.ID
                                                    INNER JOIN QUARTO ON RQ.ID_QUARTO = QUARTO.ID
                                                    WHERE RESERVA.DATA_CHECKIN = @DATA_CHECKIN";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_CHECKIN", _dataCheckin.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        relatorio = new Relatorio();
                        relatorio.Id = Convert.ToInt32(rd["ID"]);
                        relatorio.Valor_Total = (double)rd["VALOR_TOTAL"];
                        relatorio.Nome_Hospede = rd["NOME"].ToString();
                        relatorio.CPF_Hopesde = rd["CPF"].ToString();
                        relatorio.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        relatorio.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        relatorio.Valor_Diaria = (double)rd["VALOR_DIARIA"];
                        relatorio.Numero_Quarto = rd["NUMERO"].ToString();
                        relatorio.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);
                        relatorio.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);
                       
                        relatorios.Add(relatorio);
                    }
                }
                return relatorios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar os relatorio no CHECKIN: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Relatorio> Datas(int data)
        {
            throw new NotImplementedException();
        }

        public List<Relatorio> DataCheckout(DateTime _dataCheckout)
        {
            List<Relatorio> relatorios = new List<Relatorio>();
            Relatorio relatorio;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"
                                                    SELECT
                                                    RESERVA.DATA_CHECKIN,
                                                    CLIENTE.NOME,
                                                    CLIENTE.CPF,
                                                    FUNCIONARIO.NOME NOME_FUNCIONARIO,
                                                    FUNCIONARIO.NOME_USUARIO,
                                                    PAGAMENTO.FORMA_PAGAMENTO,
                                                    RESERVA.VALOR_TOTAL,
                                                    RESERVA.ID,
                                                    RESERVA.DATA_CHECKOUT,
                                                    QUARTO.VALOR_DIARIA,
                                                    QUARTO.DESCRICAO,
                                                    QUARTO.NUMERO,
                                                    FUNCIONARIO.NOME AS Funcionario
                                                    FROM RESERVA
                                                    INNER JOIN RESERVA_QUARTO RQ ON RESERVA.ID = RQ.ID_RESERVA
                                                    INNER JOIN CLIENTE ON RESERVA.ID_CLIENTE = CLIENTE.ID
                                                    INNER JOIN FUNCIONARIO ON RESERVA.ID_FUNCIONARIO = FUNCIONARIO.ID
                                                    INNER JOIN PAGAMENTO ON RESERVA.ID_PAGAMENTO = PAGAMENTO.ID
                                                    INNER JOIN QUARTO ON RQ.ID_QUARTO = QUARTO.ID
                                                    WHERE RESERVA.DATA_CHECKOUT = @DATA_CHECKOUT";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DATA_CHECKOUT", _dataCheckout.Date);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        relatorio = new Relatorio();
                        relatorio.Id = Convert.ToInt32(rd["ID"]);
                        relatorio.Valor_Total = (double)rd["VALOR_TOTAL"];
                        relatorio.Nome_Hospede = rd["NOME"].ToString();
                        relatorio.CPF_Hopesde = rd["CPF"].ToString();
                        relatorio.Pagamento = rd["FORMA_PAGAMENTO"].ToString();
                        relatorio.Nome_Funcionario = rd["NOME_FUNCIONARIO"].ToString();
                        relatorio.Valor_Diaria = (double)rd["VALOR_DIARIA"];
                        relatorio.Numero_Quarto = rd["NUMERO"].ToString();
                        relatorio.Data_Checkin = Convert.ToDateTime(rd["DATA_CHECKIN"]);
                        relatorio.Data_Checkout = Convert.ToDateTime(rd["DATA_CHECKOUT"]);

                        relatorios.Add(relatorio);
                    }
                }
                return relatorios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar relatorio no Checkout ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
