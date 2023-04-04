using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoFuncionarioBLL
    {
        public void Inserir(GrupoFuncionario _grupoFuncionario)
        {
            GrupoFuncionarioDAL grupoFuncionarioDAL = new GrupoFuncionarioDAL();
            grupoFuncionarioDAL.Inserir(_grupoFuncionario);
        }
        public void Alterar(GrupoFuncionario _grupoFuncionario)
        {
            GrupoFuncionarioDAL grupoFuncionarioDAL = new GrupoFuncionarioDAL();
            grupoFuncionarioDAL.Alterar(_grupoFuncionario);
        }
        public void Excluir(int _id)
        {
            new GrupoFuncionarioDAL().Excluir(_id);
        }
        public List<GrupoFuncionario> BuscarTodos()
        {
            return new GrupoFuncionarioDAL().BuscarTodos();
        }
        public GrupoFuncionario BuscarPorId(int _id)
        {
            return new GrupoFuncionarioDAL().BuscarPorId(_id);
        }
        public List<GrupoFuncionario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            return new GrupoFuncionarioDAL().BuscarPorNomeGrupo(_nomeGrupo);
        }
    }
}
