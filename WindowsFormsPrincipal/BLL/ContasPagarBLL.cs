using DALL;
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
            new ContasPagarDLL().Inserir(_contasPagar);
        }
        public void Alterar(Classe _classe)
        {
            new ClasseDAL().Alterar(_classe);
        }
        public void Excluir(int _id)
        {
            new ClasseDAL().Excluir(_id);
        }
        public List<Classe> BuscaPorTodos()
        {
            return new ClasseDAL().BuscaPorTodos();
        }-
    }
}
