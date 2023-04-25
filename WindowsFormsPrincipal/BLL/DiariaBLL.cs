using System;
using System.Collections.Generic;
using DAL;
using Models;

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
            if (!new GrupoFuncionarioDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))
                throw new Exception("Não foi possível realizar essa operação.");
        }

        public object BuscarPorCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public object BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}


