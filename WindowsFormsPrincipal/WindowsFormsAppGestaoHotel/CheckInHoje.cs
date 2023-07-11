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
    public partial class CheckInHoje : UserControl
    {
        public CheckInHoje()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labels

        private string _qtdCheckIn;

        [Category("Custom Props")]
        public string qtdCheckIn
        {
            get { return _qtdCheckIn; }
            set { _qtdCheckIn = value; qtdCheckInLabel.Text = value; }
        }

        #endregion

    }
}
