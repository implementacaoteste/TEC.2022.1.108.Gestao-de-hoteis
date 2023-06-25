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
            ValidarDados(_contasPagar);
            new ContasPagarDAL().Inserir(_contasPagar);
        }

        private void ValidarDados(ContasPagar _contasPagar)
        {
            if (_contasPagar.Data_Vencimento.Year < DateTime.Now.Year)
                throw new Exception("Ano não reconecido");

            if (_contasPagar.Descricao == null)
                throw new Exception("Informe a descrição");

            if (_contasPagar.Descricao.Length < 5)
                throw new Exception("A descrição deve ter pelo menos 5 caracteres");

            if (_contasPagar.Valor <= 0)
                throw new Exception("Valor deve ser maior que 0");

            if (_contasPagar.Id_Cliente <= 0)
                throw new Exception("Selecione o usuario de conta a pagar");

            if (_contasPagar.Id_Funcionario <= 0)
                throw new Exception("Selecione o funcionario");
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
