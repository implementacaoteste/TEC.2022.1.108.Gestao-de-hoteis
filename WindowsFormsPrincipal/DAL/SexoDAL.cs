using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SexoDAL
    {
        public Sexo BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Sexo sexo = new Sexo();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT SEXO From SEXO where ID = @ID";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        sexo.Id = Convert.ToInt32(rd["ID"]);
                        sexo.Genero = rd["SEXO"].ToString();
                    }
                }
                return sexo;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar por id sexo  no banco. Favor, verificar a conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
