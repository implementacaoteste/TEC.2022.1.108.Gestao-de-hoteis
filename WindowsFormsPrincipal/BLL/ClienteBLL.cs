using DAL;
using DALL;
using Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente _cliente)
        {
            new ClienteDAL().Inserir(_cliente);
        }

        public void Alterar(Cliente _cliente)
        {
            new ClienteDAL().Alterar(_cliente);
        }

        public List<Cliente> BuscaPorTodos()
        {
           return new ClienteDAL().BuscaPorTodos();
        }

        public void Excluir(int _id)
        {
            new ClienteDAL().Excluir(_id);
        }

        public void BuscarPorId(int _id)
        {
            new ClienteDAL().BuscarPorId(_id);
        }

        public void BuscaPorCPF(string _CPF)
        {
            new ClienteDAL().BuscaPorCPF(_CPF);
        }

        public List<Cliente> BuscaPorNome(Cliente _Nome)
        {
             return new ClienteDAL().BuscaPorNome(_Nome);
        }

    }
}
