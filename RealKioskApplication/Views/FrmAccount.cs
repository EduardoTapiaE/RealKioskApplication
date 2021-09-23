using RealKioskApplication.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LyFService.Services;
using RealKioskApplication.Services;

namespace RealKioskApplication.Views
{
    public partial class FrmAccount : Form
    {
        private IKioskService _kioskService;

        public FrmAccount()
        {
            InitializeComponent();
        }

        private void AddNumberToAccountNumber(int number)
        {
            TxtNoCuenta.Text += number.ToString();
        }
        private void DeleteLlastNumber()
        {
            var account_number = TxtNoCuenta.Text;
            if (account_number.Length > 0)
            {
                TxtNoCuenta.Text = account_number.Remove(account_number.Length - 1);
            }
        }

        private void BtnUno_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(1);
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(2);
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(3);
        }

        private void BtnCuatro_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(4);
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(5);
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(6);
        }

        private void BtnSiete_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(7);
        }

        private void BtnOcho_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(8);
        }

        private void BtnNueve_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(9);
        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            AddNumberToAccountNumber(0);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DeleteLlastNumber();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                var frmWelcome = AppHelper.GetWelcomeForm();
                frmWelcome.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrio un error, favor de contactar al admistrador \nDetalles: {ex.Message}");
            }
        }

        private void FrmAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var frmWelcome = AppHelper.GetWelcomeForm();
                var frmBalance = AppHelper.GetBalanceForm();
                if (frmWelcome != null && frmBalance == null)
                {
                    frmWelcome.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error, favor de contactar al admistrador \nDetalles: {ex.Message}");
            }

        }

        private async void BtnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNoCuenta.Text.Length > 0)
                {
                    _kioskService = new KioskService();
                    int account_number = int.Parse(TxtNoCuenta.Text);
                    var account_balance = await _kioskService.GetAccountBalance(account_number);
                    if (account_balance.message == null)
                    {
                        IAccountService account_service = new AccountService();
                        account_service.SetAccountBlance(account_balance);
                        FrmBalance frmBalance = new FrmBalance();
                        frmBalance.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(account_balance.message);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrio un error, favor de contactar al admistrador \nDetalles: {ex.Message}");
            }
            
        }
    }
}
