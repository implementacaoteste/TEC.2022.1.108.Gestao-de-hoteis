using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class SexoDAL
    {
        public List<Sexo> BuscarPorTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Sexo sexo = new Sexo();
            List<Sexo> sexos= new List<Sexo>();
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT ID, SEXO FROM SEXO";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        sexo = new Sexo();
                        sexo.Id = Convert.ToInt32(rd["ID"]);
                        sexo.Genero = rd["SEXO"].ToString();
                        sexos.Add(sexo);
                    }
                }
                return sexos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o sexo por ID no banco. Favor, verificar a conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
