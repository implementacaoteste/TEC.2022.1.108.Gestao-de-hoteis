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
            ValidarPermissao(10);
            ValidarDados(_cliente);
            new ClienteDAL().Inserir(_cliente);
        }
        public void Alterar(Cliente _cliente)
        {
            ValidarPermissao(11);
            ValidarDados(_cliente);
            new ClienteDAL().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(12);
            new ClienteDAL().Excluir(_id);
        }
        public List<Cliente> BuscaPorTodos()
        {
            ValidarPermissao(9);
            return new ClienteDAL().BuscaPorTodos();
        }
        public Cliente BuscarPorId(int _id)
        {
            ValidarPermissao(9);
            return new ClienteDAL().BuscarPorId(_id);
        }
        public Cliente BuscaPorCPF(string _CPF)
        {
            ValidarPermissao(9);
            return new ClienteDAL().BuscaPorCPF(_CPF);
        }
        public List<Cliente> BuscaPorNome(string _nome)
        {
            ValidarPermissao(9);
            return new ClienteDAL().BuscaPorNome(_nome);
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new ClienteDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
                return;
        }
        private void ValidarDados(Cliente _cliente)
        {
            if (_cliente.Nome == null)
                throw new Exception("Insira o nome do cliente");

            if (_cliente.Nome.Length <= 2)
                throw new Exception("O nome deve ter mais de 2 caracteres.");

            if (_cliente.Data_nascimento.Year < 1900)
                throw new Exception("Selecione a data de nascimento válida para o cliente");

            if (_cliente.IdSexo == 0)
                throw new Exception("Selecione o sexo do cliente");
            return;
        }
    }
}
