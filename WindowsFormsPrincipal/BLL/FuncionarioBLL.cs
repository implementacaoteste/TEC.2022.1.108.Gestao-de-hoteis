using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BLL
{
    public class FuncionarioBLL
    {
        public void Inserir(Funcionario _funcionario)
        {
            new FuncionarioDAL().Inserir(_funcionario);
        }
        public void Alterar(Funcionario _funcionario)
        {
            new FuncionarioDAL().Alterar(_funcionario);
        }
        public void Excluir(int _Id)
        {
            new FuncionarioDAL().Excluir(_Id);
        }

        public void BuscarPorId(int _Id)
        {
            new FuncionarioDAL().BuscarPorId(_Id);
        }

        public void BuscarPorNomeFuncionario(string _nome)
        {
             new FuncionarioDAL().BuscarPorNomeFuncionario(_nome);
        }

        public List<Funcionario> BuscarTodos()
        {
            return new FuncionarioDAL().BuscarTodos();
        }
    }
}

