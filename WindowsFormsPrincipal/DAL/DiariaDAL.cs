using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiariaDAL
    {
        public void Inserir(Diaria _diaria)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSET INTO (VALOR_TOTAL, DATA_ENTRADA, ID_CLIENTE, ID_FUNCIONARIO, ID_PAGAMENTO, DATA_SAIDA, DATA_ENRADA)
                                       VALUES(@VALOR_TOTAL, @DATA_ENTRADA, @ID_CLIENTE, @ID_FUNCIONARIO, @ID_PAGAMENTO, @DATA_SAIDA, @DATA_ENTRADA)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _diaria.Valor_Total);
                cmd.Parameters.AddWithValue("DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _diaria.Id_cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _diaria.Id_funcionario);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _diaria.Id_Pagamento);
                cmd.Parameters.AddWithValue("@DATA_SAIDA", _diaria.Data_Saida);
                cmd.Parameters.AddWithValue("@DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir a diaria no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Diaria _diaria)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE DIARIA SET VALOR_TOTAL = @VALOR_TOTAL, DATA_ENTRADA = @DATA_ENTRADA, ID_CLIENTE = @ID_CLIENTE, ID_FUNCIONARIO = @ID_FUNCIONARIO,ID_PAGAMENTO = @ID_PAGAMENTO, DATA_SAIDA = @DATA_SAIDA, DATA_ENRADA = @DATA_ENRADA
                                    WHERE ID = @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@VALOR_TOTAL", _diaria.Valor_Total);
                cmd.Parameters.AddWithValue("DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Parameters.AddWithValue("@ID_CLIENTE", _diaria.Id_cliente);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", _diaria.Id_funcionario);
                cmd.Parameters.AddWithValue("@ID_PAGAMENTO", _diaria.Id_Pagamento);
                cmd.Parameters.AddWithValue("@DATA_SAIDA", _diaria.Data_Saida);
                cmd.Parameters.AddWithValue("@DATA_ENTRADA", _diaria.Data_Entrada);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar a diaria no Banco de Dados.", ex);
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
                cmd.CommandText = @"DELETE FROM DIARIA
                                    WHERE ID= @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma diaria no Banco de Dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Diaria>BuscarPorTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Diaria> diaria = new List<Diaria>();
            Funcionario Diaria;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText
            }
        }


    } 
 } 


