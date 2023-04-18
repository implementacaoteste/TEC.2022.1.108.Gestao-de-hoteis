using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;
using System.Threading.Tasks;

namespace BLL
{
    public class DiariaBLL
    {
        public void Inserir(Diaria _diaria)
        {
            new DiariaDAL().Inserir(_diaria);
        }
        public void Alterar(Diaria _diaria)
        {
            new DiariaDAL().Alterar(_diaria);
        }
        public void Excluir(int _id)
        {
            new DiariaDAL().Excluir(_id);
        }
        public List<Diaria> BuscarPorTodos()
        {
            return new DiariaDAL().BuscarPorTodos();
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new DiariaDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))
                throw new Exception("Não foi possível realizar essa operação.");
        }
    }
}


