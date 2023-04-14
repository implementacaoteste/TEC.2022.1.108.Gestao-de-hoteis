﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrincipal1
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        public int Id;
        public FormCadastroCliente(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                bindingSourceCadastroCliente.EndEdit();
                if (Id == 0)
                    clienteBLL.Inserir((Cliente)bindingSourceCadastroCliente.Current);
                else
                    clienteBLL.Alterar((Cliente)bindingSourceCadastroCliente.Current);
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar salvar um cliente no Banco de Dados", ex);
            }

        }
    }
}
