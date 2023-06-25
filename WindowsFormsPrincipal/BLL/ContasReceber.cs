using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContasReceberBLL
    {
        public void Inserir(ContasReceber _contasReceber)
        {
            new ContasReceberDAL().Inserir(_contasReceber);
        }
        public void Alterar(ContasReceber _contasReceber)
        {
            new ContasReceberDAL().Alterar(_contasReceber);
        }
        public void Excluir(int _id)
        {
            new ContasReceberDAL().Excluir(_id);
        }
        public List<ContasReceber> BuscaPorTodos()
        {
            return new ContasReceberDAL().BuscaPorTodos();
        }

        public List<ContasReceber> BuscarPorData(DateTime _data)
        {
            return new ContasReceberDAL().BuscarPorData(_data);
        }
        public List<ContasReceber> BuscarPorPagar(bool _receber)
        {
            return new ContasReceberDAL().BuscarPorPagar(_receber);
        }
    }
}
