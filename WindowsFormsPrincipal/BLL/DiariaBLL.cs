using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using DAL;
using Models;

namespace BLL
{
    public class DiariaBLL
    {
        public void Inserir(Diaria _diaria)
        {
            ValidarPermissao(14);
            ValidarDados(_diaria);
            new DiariaDAL().Inserir(_diaria);
        }
        public void Alterar(Diaria _diaria)
        {
            ValidarPermissao(15);
            new DiariaDAL().Alterar(_diaria);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(16);
            new DiariaDAL().Excluir(_id);
        }
        public Diaria BuscarPorId(int _id)
        {
            ValidarPermissao(13);
            return new DiariaDAL().BuscarPorId(_id);
        }
        public List<Diaria> BuscarPorTodos()
        {
            ValidarPermissao(13);
            return new DiariaDAL().BuscarPorTodos();
        }
        public List<Diaria> BuscarPorCPFCliente(string _cpf)
        {
            ValidarPermissao(13);
            return new DiariaDAL().BuscarPorCPFCliente(_cpf);
        }
        public List<Diaria> BuscarPorNomeCliente(string _nome)
        {
            ValidarPermissao(13);
            return new DiariaDAL().BuscarPorNomeCliente(_nome);
        }
        public List<Diaria> BuscarPorDataEntrada(string _dataEntrada)
        {
            ValidarPermissao(13);
            return new DiariaDAL().BuscarPorDataEntrada(_dataEntrada);
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new DiariaDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
        private void ValidarDados(Diaria _diaria)
        {
            if (_diaria.Data_Entrada < DateTime.Now.Date)
                throw new Exception("Data Inválida! Você não pode colocar uma data Retroativa!");

            if (_diaria.Data_Saida < DateTime.Now.Date.AddDays(1))
                throw new Exception("Data Inválida! Você não pode colocar uma data Retroativa!");
        }

        public void SelecionarQuarto(int _idDiaria, int _idQuarto)
        {
            if (!new DiariaDAL().DiariaPertenceQuarto(_idDiaria, _idQuarto))
                new DiariaDAL().SelecionarQuarto(_idDiaria, _idQuarto);
        }
    }
}


