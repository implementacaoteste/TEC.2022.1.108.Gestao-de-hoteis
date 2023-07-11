using BLL;
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

namespace WindowsFormsAppGestaoHotel
{
    public partial class CheckOutHoje : UserControl
    {
        int qtd_Checkout;

        public CheckOutHoje()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labels

        private string _qtdCheckOut;

        [Category("Custom Props")]
        public string qtdCheckOut
        {
            get { return _qtdCheckOut; }
            set { _qtdCheckOut = value; qtd_CheckoutLabel.Text = value; }
        }

        #endregion
    }
}
