using RealKioskApplication.Helpers;
using RealKioskApplication.Models;
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
        private AccountBalanceModel _accountBalance;
        public FrmBalance()
        {
            InitializeComponent();
        }

        private void FrmBalance_Load(object sender, EventArgs e)
        {
            IAccountService account_service = new AccountService();
            _accountBalance = account_service.GetAccountBlance();

            TxtCuenta.Text = _accountBalance.Account_number.ToString();
            TxtDeuda.Text = $"${_accountBalance.Debt}";
            TxtUsuario.Text = _accountBalance.User;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount();
            frmAccount.Show();
            Close();
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if(_accountBalance.Debt > 0)
            {
                FrmPayment frmPayment = new FrmPayment();
                frmPayment.Show();
                Close();
            }
            else
            {
                MessageBox.Show("No tiene deuda por pagar");
            }
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
