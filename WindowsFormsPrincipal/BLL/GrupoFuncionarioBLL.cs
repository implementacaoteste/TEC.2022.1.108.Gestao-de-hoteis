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
            ValidarDados(_grupoFuncionario);
            GrupoFuncionarioDAL grupoFuncionarioDAL = new GrupoFuncionarioDAL();
            grupoFuncionarioDAL.Inserir(_grupoFuncionario);
        }
        public void Alterar(GrupoFuncionario _grupoFuncionario)
        {
            ValidarDados(_grupoFuncionario);
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
        public List<GrupoFuncionario> BuscarPorId(int _id)
        {
            return new GrupoFuncionarioDAL().BuscarPorId(_id);
        }
        public List<GrupoFuncionario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            return new GrupoFuncionarioDAL().BuscarPorNomeGrupo(_nomeGrupo);
        }
        private void ValidarDados(GrupoFuncionario _grupoFuncionario)
        {
            if (_grupoFuncionario.NomeGrupo.Length <= 2)
                throw new Exception("O nome deve ter mais de 2 caracteres.");
        }
        public void AdicionarPermissao(int _idGrupoFuncionario, int _idPermissao)
        {
            if (!new GrupoFuncionarioDAL().PermissaoPertenceAoGrupo(_idGrupoFuncionario, _idPermissao))
                new GrupoFuncionarioDAL().AdicionarPermissao(_idGrupoFuncionario, _idPermissao);
        }
        public void RemoverPermissao(int _idGrupoFuncionario, int _idPermissao)
        {
            new GrupoFuncionarioDAL().RemoverPermissao(_idGrupoFuncionario, _idPermissao);
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new GrupoFuncionarioDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
    }
}
