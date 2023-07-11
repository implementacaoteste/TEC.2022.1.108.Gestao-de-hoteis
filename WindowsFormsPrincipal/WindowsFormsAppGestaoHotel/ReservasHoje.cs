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
    public partial class ReservasHoje : UserControl
    {
        public ReservasHoje()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labels

        private string _qtdReservas;

        [Category("Custom Props")]
        public string qtdReservas
        {
            get { return _qtdReservas; }
            set { _qtdReservas = value; qtdReservasLabel.Text = value; }
        }

        #endregion
    }
}
