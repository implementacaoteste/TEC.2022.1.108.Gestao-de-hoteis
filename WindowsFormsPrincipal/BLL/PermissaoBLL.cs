using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            new PermissaoDAL().Inserir(_permissao);
        }
        public void Alterar(Permissao _permissao)
        {
            new PermissaoDAL().Alterar(_permissao);
        }
        public void Excluir(int _id)
        {
            new PermissaoDAL().Excluir(_id);
        }
        public List<Permissao> BuscarTodos()
        {
            return new PermissaoDAL().BuscarTodos();
        }
        public List<Permissao> BuscarPorId(int _id)
        {
            return new PermissaoDAL().BuscarPorId(_id);
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            return new PermissaoDAL().BuscarPorDescricao(_descricao);
        }
    }
}
