using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ContasPagarBLL
    {
        public void Inserir(ContasPagar _contasPagar)
        {
            ValidarDados(_contasPagar.Data_Vencimento);
            new ContasPagarDAL().Inserir(_contasPagar);
        }

        private void ValidarDados(DateTime _dataVencimento)
        {
            if (_dataVencimento.Year < DateTime.Now.Year)
                throw new Exception("Ano não reconecido") ;
                return;
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

        public List<ContasPagar> BuscarPorData(DateTime _data)
        {
            return new ContasPagarDAL().BuscarPorData(_data);
        }
        public List<ContasPagar> BuscarPorPagar(bool _pagar)
        {
            return new ContasPagarDAL().BuscarPorPagar(_pagar);
        }
    }
}
