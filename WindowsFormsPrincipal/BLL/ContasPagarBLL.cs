using DAL;

using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContasPagarBLL
    {
        public void Inserir(ContasPagar _contasPagar)
        {
            new ContasPagarDAL().Inserir(_contasPagar);
        }
        public void Alterar(ContasPagar _contasPagar)
        {
            new ContasPagarDAL().Alterar(_contasPagar);
        }
        public void Excluir(int _id)
        {
            new ContasPagarDAL().Excluir(_id);
        }
        public List<ContasPagar> BuscaPorTodos()
        {
            return new ContasPagarDAL().BuscaPorTodos();
        }

        public List<ContasPagar> BuscarPorData()
        {
            return new ContasPagarDAL().BuscarPorData();
        }
    }
}
