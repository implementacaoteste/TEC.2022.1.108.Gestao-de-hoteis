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
        public void Inserir(Statuses _status)
        {
            new StatusDAL().Inserir(_status);
        }
        public void Alterar(Statuses _status)
        {
            new StatusDAL().Alterar(_status);
        }
        public void Excluir(int _id)
        {
            new StatusDAL().Excluir(_id);
        }
        public List<Statuses> BuscaPorTodos()
        {
            return new StatusDAL().BuscarPorTodos();
        }
        public void BuscarPorStatus(string _status)
        {
            new StatusDAL().BuscarPorStatus(_status);
        }
    }
}
