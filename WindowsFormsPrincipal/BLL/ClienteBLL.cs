using DAL;
using DALL;
using Models;
using Modelss;
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

        public void BuscaPorTodos(Cliente _cliente)
        {
            new ClienteDAL().BuscaPorTodos(_cliente);
        }

        public void Excluir(Cliente _id)
        {
            new ClienteDAL().Excluir(_id);
        }

        public void BuscarPorId(Cliente _id)
        {
            new ClienteDAL().BuscarPorId(_id);
        }

        public void BuscaPorCPF(Cliente _CPF)
        {
            new ClienteDAL().BuscaPorCPF(_CPF);
        }

        public void BuscaPorNome(Cliente _Nome)
        {
            new ClienteDAL().BuscaPorNome(_Nome);
        }

    }
}
