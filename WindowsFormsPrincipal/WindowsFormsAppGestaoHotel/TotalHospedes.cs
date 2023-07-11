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
    public partial class TotalHospedes : UserControl
    {
        public TotalHospedes()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labels

        private string _qtdHospedes;

        [Category("Custom Props")]
        public string qtdHospedes
        {
            get { return _qtdHospedes; }
            set { _qtdHospedes = value; qtdHospedesLabel.Text = value; }
        }

        #endregion
    }
}
