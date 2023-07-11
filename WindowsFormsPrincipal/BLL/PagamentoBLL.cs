

using DAL;
using DALL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class PagamentoBLL
    {
        public void Inserir(Pagamento _pagamento)
        {
            new PagamentoDAL().Inserir(_pagamento);
        }
        public void Alterar(Pagamento _pagamento)
        {
            new PagamentoDAL().Alterar(_pagamento);
        }
        public void Excluir(int _id)
        {
            new PagamentoDAL().Excluir(_id);
        }
        public List<Pagamento> BuscaPorTodos()
        {
        return new PagamentoDAL().BuscaPorTodos();
        }
        public List<Pagamento> BuscaPorId(int _id)
        {
            return new PagamentoDAL().BuscaPorId(_id);
        }

    }
}
