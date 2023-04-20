using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class FuncionarioBLL
    {
        public void Inserir(Funcionario _funcionario, string _confirmacaoSenha)
        {
            ValidarPermissao(2);
            ValidarDados(_funcionario, _confirmacaoSenha);
            new FuncionarioDAL().Inserir(_funcionario);
        }
        public void Alterar(Funcionario _funcionario, string _confirmacaoSenha)
        {
            ValidarPermissao(3);
            ValidarDados(_funcionario,_confirmacaoSenha);
            new FuncionarioDAL().Alterar(_funcionario);
        }
        public void Excluir(int _Id)
        {
            ValidarPermissao(4);
            new FuncionarioDAL().Excluir(_Id);
        }
        public List<Funcionario> BuscarTodos()
        {
            ValidarPermissao(1);
            return new FuncionarioDAL().BuscarTodos();
        }
        public Funcionario BuscarPorId(int _Id)
        {
            ValidarPermissao(1);
            return new FuncionarioDAL().BuscarPorId(_Id);
        }
        public Funcionario BuscarPorCPF(string _cPF)
        {
            ValidarPermissao(1);
            return new FuncionarioDAL().BuscarPorCPF(_cPF);
        }
        public List<Funcionario> BuscarPorNome(string _nome)
        {
            ValidarPermissao(1);
            return new FuncionarioDAL().BuscarPorNome(_nome);
        }
        public Funcionario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            ValidarPermissao(1);
            return new FuncionarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }
        private void ValidarDados (Funcionario _funcionario, string _confirmacaoSenha)
        {
            if (_funcionario.Senha != _confirmacaoSenha)
                throw new Exception("A senha e a confirmação de senha devem ser iguais.");

             if (_funcionario.Senha.Length <= 3)
                throw new Exception("A senha deve ter mais de 3 caracteres.");

            if (_funcionario.Nome.Length <= 2)
                throw new Exception("O nome deve ter mais de 2 caracteres");
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new FuncionarioDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
        public void AdicionarGrupoUsuario(int _idFuncionario, int _idGrupoFuncionario)
        {
            if (!new FuncionarioDAL().FuncionarioPertenceAoGrupo(_idFuncionario, _idGrupoFuncionario))
                new FuncionarioDAL().AdicionarGrupoFuncionario(_idFuncionario, _idGrupoFuncionario);
        }
        public void RemoverGrupoUsuario(int _idFuncionario, int _idGrupoFuncionario)
        {
            new FuncionarioDAL().RemoverGrupoUsuario(_idFuncionario, _idGrupoFuncionario);
        }
        public void Autenticar(string _NomeUsuario, string _Senha)
        {
            Funcionario funcionario = new FuncionarioDAL().BuscarPorNomeUsuario(_NomeUsuario);
            if (_Senha==funcionario.Senha && funcionario.Ativo)
            {
                Constante.IdLogado = funcionario.Id;
            }
            else
            {
                throw new Exception("Usuário ou senha incorreto");
            }
            return; 
        }
    }
}