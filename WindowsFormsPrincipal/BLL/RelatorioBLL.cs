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

        public List<Relatorio> DataSaida(int _dataSaida)
        {
            return new RelatorioDAL().DataSaida(_dataSaida);
        }

        public List<Relatorio> DataEntrada(int _dataEntrada)
        {
            return new RelatorioDAL().DataEntrada(_dataEntrada);
        }
        public List<Relatorio> Datas(int _data)
        {
            return new RelatorioDAL().Datas(_data);
        }

    }
}
