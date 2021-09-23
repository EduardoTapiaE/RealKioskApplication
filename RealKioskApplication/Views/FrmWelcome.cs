using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealKioskApplication.Views
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void PnlWelcome_Click(object sender, EventArgs e)
        {
            OpenAccountView();
        }

        private void LblWelcome_Click(object sender, EventArgs e)
        {
            OpenAccountView();
        }

        public void OpenAccountView()
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            Hide();
        }

    }
}
