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
        public void Inserir(Status _status)
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
        public void Alterar(Status _status)
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
        public List<Status> BuscarPorTodos()
        {

        }
    }
}
