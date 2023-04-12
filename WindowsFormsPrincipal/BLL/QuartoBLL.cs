using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class QuartoBLL
    {
        public void Inserir(Quarto _quarto)
        {
            new QuartoDAL().Inserir(_quarto);
        }
        public void Alterar(Quarto _quarto)
        {
            new QuartoDAL().Alterar(_quarto);
        }
        public void Excluir(int _id)
        {
            new QuartoDAL().Excluir(_id);
        }
        public List<Quarto> BuscarPorTodos()
        {
            return new QuartoDAL().BuscarPorTodos();
        }
        public void BuscarPorNumero(int _numero)
        {
             new QuartoDAL().BuscarPorNumero(_numero);
        }
    }
}
