using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReservaBLL
    {
        public void Inserir(Reserva _reserva)
        {
            ValidarPermissao(14);
            ValidarDados(_reserva);
            new ReservaDAL().Inserir(_reserva);
        }
        public void Alterar(Reserva _reserva)
        {
            ValidarPermissao(15);
            new ReservaDAL().Alterar(_reserva);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(16);
            new ReservaDAL().Excluir(_id);
        }
        public void CancelarReserva(int _id)
        {
            ValidarPermissao(16);
            new ReservaDAL().CancelarReserva(_id);
        }
        public void CheckIn(Reserva _reserva)
        {
            ValidarPermissao(15);
            new ReservaDAL().CheckIn(_reserva);
        }
        public void CheckOut(Reserva _reserva)
        {
            ValidarPermissao(15);
            new ReservaDAL().CheckOut(_reserva);
        }
        /*public Reserva BuscarPorId(int _id)
        {
            ValidarPermissao(13);
            return new ReservaDAL().BuscarPorId(_id);
        }*/
        public Reserva BuscarPorIdReserva(string _idReserva)
        {
            ValidarPermissao(13);
            return new ReservaDAL().BuscarPorIdReserva(_idReserva);
        }
        public List<Reserva> BuscarPorTodas()
        {
            ValidarPermissao(13);
            return new ReservaDAL().BuscarPorTodas();
        }
        public List<Reserva> BuscarPorDataCheckin(string _dataCheckin)
        {
            ValidarPermissao(13);
            return new ReservaDAL().BuscarPorDataCheckin(_dataCheckin);
        }
        public List<Reserva> BuscarPorDataCheckout(string _dataCheckout)
        {
            ValidarPermissao(13);
            return new ReservaDAL().BuscarPorDataCheckout(_dataCheckout);
        }
        public List<Reserva> BuscarPorDataLancamento(string _dataLancamento)
        {
            ValidarPermissao(13);
            return new ReservaDAL().BuscarPorDataLancamento(_dataLancamento);
        }
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new ReservaDAL().ValidarPermissao(Constante.IdLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");
        }
        private void ValidarDados(Reserva _reserva)
        {
            if (_reserva.Data_Ent_Reserva < DateTime.Now.Date)
                throw new Exception("Data Inválida! Você não pode colocar uma data Retroativa!");

            if (_reserva.Data_Sai_Reserva < DateTime.Now.Date)
                throw new Exception("Data Inválida! Você não pode colocar uma data Retroativa!");
        }

        /*public void SelecionarQuarto(int _idReserva, int _idQuarto)
        {
            if (!new ReservaDAL().ReservaPertenceQuarto(_idReserva, _idQuarto))
                new ReservaDAL().SelecionarQuarto(_idReserva, _idQuarto);
        }*/
    }
}