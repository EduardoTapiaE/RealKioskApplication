using RealKioskApplication.Helpers;
using RealKioskApplication.Services;
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
    public partial class FrmBalance : Form
    {
        public FrmBalance()
        {
            InitializeComponent();
        }

        private void FrmBalance_Load(object sender, EventArgs e)
        {
            IAccountService account_service = new AccountService();
            var account_balance = account_service.GetAccountBlance();

            TxtCuenta.Text = account_balance.Account_number.ToString();
            TxtDeuda.Text = $"${account_balance.Debt}";
            TxtUsuario.Text = account_balance.User;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            FrmPayment frmPayment = new FrmPayment();
            frmPayment.Show();
            Close();
        }

        private void FrmBalance_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var frmPayment = AppHelper.GetPaymentForm();
                var frmAccount = AppHelper.GetAccountForm();
                if (frmPayment == null)
                {
                    if(frmAccount == null)
                    {
                        frmAccount = new FrmAccount();
                        frmAccount.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error, favor de contactar al admistrador \nDetalles: {ex.Message}");
            }
        }
    }
}
