using DAL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class SexoBLL
    {
        public List<Sexo> BuscarPorTodos()
        {
            return new SexoDAL().BuscarPorTodos();
        }
    }
}
