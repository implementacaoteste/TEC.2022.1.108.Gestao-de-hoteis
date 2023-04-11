using DALL;
using DAL;
using Models;
using Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class StatusBLL
    {
        public void Inserir(StatusBLL _status)
        {
            new StatusDAL().Inserir(_status);
        }
        public void Alterar(StatusBLL _status)
        {
            new StatusDAL().Alterar(_status);
        }
        public void Excluir(StatusBLL _status)
        {
            new StatusDAL().Excluir(_status);
        }
        public void BuscarPorTodos(StatusBLL _status)
        {
            return new StatusDAL().BuscaPorTodos();
        }
        public void BuscarPorStatus(StatusBLL _status)
        {
            new StatusDAL().BuscarPorStatus(_status);
        }
    }
}
