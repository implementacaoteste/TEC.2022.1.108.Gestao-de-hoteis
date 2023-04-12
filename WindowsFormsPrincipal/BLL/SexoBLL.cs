using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SexoBLL
    {
        public Sexo BuscarPorId(int _Id)
        {
            return new SexoDAL().BuscarPorId(_Id);
        }
    }
}
