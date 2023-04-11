using DAL;
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
    }
}
