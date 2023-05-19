using DAL;
using DALL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RelatorioBLL
    {
        public List<Relatorio> BuscarPortodos()
        {
            return new RelatorioDAL().BuscaPorTodos();
        }

        public List<Relatorio> DataCheckout(string _dataCheckout)
        {
            return new RelatorioDAL().DataCheckout(_dataCheckout);
        }

        public List<Relatorio> DataCheckin(string _dataCheckin)
        {
            return new RelatorioDAL().DataCheckin(_dataCheckin);
        }
        public List<Relatorio> Datas(int _data)
        {
            return new RelatorioDAL().Datas(_data);
        }

    }
}
