using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservaDAL
    {
        public void Inserir(Reserva reserva)
        {
            throw new NotImplementedException();
        }
        public void Alterar(Reserva reserva)
        {
            throw new NotImplementedException();
        }
        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }
        public void CancelarReserva(int id)
        {
            throw new NotImplementedException();
        }
        public Reserva BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
        public List<Reserva> BuscarPorTodas()
        {
            throw new NotImplementedException();
        }
        public List<Reserva> BuscarPorDataCheckin(string dataCheckin)
        {
            throw new NotImplementedException();
        }
        public List<Reserva> BuscarPorDataCheckout(string dataCheckout)
        {
            throw new NotImplementedException();
        }
        public List<Reserva> BuscarPorDataLancamento(string dataLancamento)
        {
            throw new NotImplementedException();
        }
        public bool ValidarPermissao(int idLogado, int idPermissao)
        {
            throw new NotImplementedException();
        }
    }
}
