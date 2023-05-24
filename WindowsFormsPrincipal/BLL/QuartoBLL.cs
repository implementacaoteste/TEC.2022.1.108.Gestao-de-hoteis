using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace BLL
{
    public class QuartoBLL
    {
        public void Inserir(Quarto _quarto)
        {
            ValidarPermissao(18);
            new QuartoDAL().Inserir(_quarto);
        }
        public void Alterar(Quarto _quarto)
        {
            ValidarPermissao(19);
            new QuartoDAL().Alterar(_quarto);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(20);
            new QuartoDAL().Excluir(_id);
        }
        public Quarto BuscarPorId(int _id)
        {
            ValidarPermissao(17);
            return new QuartoDAL().BuscarPorId(_id);
        }
        public List<Quarto> BuscarPorTodos()
        {
            ValidarPermissao(17);
            return new QuartoDAL().BuscarPorTodos();
        }
        public List<Quarto> BuscarPorQuartoDisponivel()
        {
            return new QuartoDAL().BuscarPorQuartoDisponivel();
        }
        public List<Quarto> BuscarPorDia(DateTime _dia)
        {
            return new QuartoDAL().BuscarPorDia(_dia);
        }
        public List<Quarto> BuscarQuartoDisponivelPorPeriodo(DateTime _dataEntrada, DateTime _dataSaida,  string _classe)
        {
            ValidarDados(_dataEntrada,_dataSaida);
            return new QuartoDAL().BuscarQuartoDisponivelPorPeriodo(_dataEntrada,_dataSaida,_classe);
        }

        private void ValidarDados(DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataEntrada.Year < DateTime.Now.Year)
                throw new Exception("Parametro inválido. Data válida a partir da atual");

            if (dataEntrada.Year == DateTime.Now.Year)
            {
                if (dataEntrada.Month < DateTime.Now.Month)
                {
                    throw new Exception("Parametro inválido. Data válida a partir da atual");
                }

                if (dataEntrada.Month == DateTime.Now.Month)
                {
                    if (dataEntrada.Day < DateTime.Now.Day)
                    {
                        throw new Exception("Parametro inválido. Data válida a partir da atual");
                    }
                }
            }
            if (dataSaida < dataEntrada)
            {
                throw new Exception("Parametro inválido. Data de 'Entrada' não deve ser maior que de 'Saida'");
            }


        }

        public List<Quarto> BuscarPorStatus(string _status)
        {
            ValidarPermissao(17);
            return new QuartoDAL().BuscarPorStatus(_status);
        }
        public Quarto BuscarPorNumero(string _numero)
        {
            ValidarPermissao(17);
            return new QuartoDAL().BuscarPorNumero(_numero);
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new QuartoDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))//Implementar o método "ValidarPermissao" na DAL
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
    }
}