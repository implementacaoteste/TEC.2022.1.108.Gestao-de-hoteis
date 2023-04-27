﻿using System;
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
        public List<Diaria> BuscarPorCPFCliente(string _cpf)
        {
            return new DiariaDAL().BuscarPorCPFCliente(_cpf);
        }

        public List<Diaria> BuscarPorNomeCliente(string _nome)
        {
            return new DiariaDAL().BuscarPorNomeCliente(_nome);
        }

        public List<Diaria> BuscarPorDataEntrada(string _dataEntrada)
        {
            return new DiariaDAL().BuscarPorDataEntrada(_dataEntrada);
        }
    }
}


