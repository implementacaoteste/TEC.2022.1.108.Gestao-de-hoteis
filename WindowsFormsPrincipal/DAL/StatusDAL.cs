using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class StatusDAL
    {
        public void Inserir(Statuses _status)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO STATUS(STATUS) VALUES(@Status)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Status", _status.Status);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Não foi possivel adicionar 'Status' no banco. Favor, verificar a conexão");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Statuses _status)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE STATUS SET STATUS=@status WHERE ID=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@status", _status.Status);
                cmd.Parameters.AddWithValue("@id", _status.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Não foi possivel alterar 'Status' no banco. Favor, verificar a conexão");
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
                cmd.CommandText = @"DELETE STATUS WHERE ID=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Não foi possivel adicionar 'Status' no banco. Favor, verificar a conexão");
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Statuses> BuscarPorTodos()
        {
            List<Statuses> stats = new List<Statuses>();
            Statuses status;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT ID,STATUS FROM STATUS";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader Ler = cmd.ExecuteReader())
                {
                    while(Ler.Read())
                    {
                        status = new Statuses();
                        status.Id = Convert.ToInt32(Ler["ID"]);
                        status.Status = (Ler["STATUS"]).ToString();
                       
                        stats.Add(status);
                    }
                }
                return stats;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar 'Status' no banco. Favor, verificar a conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Statuses BuscarPorStatus(string _status)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Statuses status = new Statuses();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT ID,STATUS FROM STATUS WHERE STATUS LIKE @Status";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Status",_status);
                cn.Open();

                using (SqlDataReader Ler = cmd.ExecuteReader())
                {
                    if(Ler.Read())
                    {
                        status.Id = Convert.ToInt32(Ler["ID"]);
                        status.Status = (Ler["STATUS"]).ToString();
                    }
                }
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar 'Status' no banco. Favor, verificar a conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
