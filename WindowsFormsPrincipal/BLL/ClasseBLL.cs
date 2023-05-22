using DALL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClasseBLL
    {
        public void Inserir(Classe _classe)
        {
            new ContasPagarDAL().Inserir(_classe);
        }
        public void Alterar(Classe _classe)
        {
            new ContasPagarDAL().Alterar(_classe);
        }
        public void Excluir(int _id)
        {
            new ContasPagarDAL().Excluir(_id);
        }
        public List<Classe> BuscaPorTodos()
        {
            return new ContasPagarDAL().BuscaPorTodos();
        }
        public List<Classe> BuscaPorClasse(string _classe)
        {
            return new ContasPagarDAL().BuscaPorClasse(_classe);
        }
        public Classe BuscarPorId(int _id)
        {
            return new ContasPagarDAL().BuscarPorId(_id);
        }
    }
}
