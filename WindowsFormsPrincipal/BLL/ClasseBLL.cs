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
            new ClasseDAL().Inserir(_classe);
        }

        public void Alterar(Classe _classe)
        {
            new ClasseDAL().Alterar(_classe);
        }

        public List<Classe> BuscaPorTodos()
        {
            return new ClasseDAL().BuscaPorTodos();
        }

        public List<Classe> BuscaPorClasse(string _classe)
        {
            return new ClasseDAL().BuscaPorClasse(_classe);
        }
        public void Excluir(int _id)
        {
            new ClasseDAL().Excluir(_id);
        }

        public Classe BuscarPorId(int _id)
        {
            return new ClasseDAL().BuscarPorId(_id);
        }
    }
}
