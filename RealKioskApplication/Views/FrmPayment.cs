using LyFService.Models.Request;
using LyFService.Services;
using RealKioskApplication.Helpers;
using RealKioskApplication.Models;
using RealKioskApplication.Models.Database;
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
    public partial class FrmPayment : Form
    {
        private double _depositado = 0;
        private double _restante = 0;
        private double _cambio = 0;
        private AccountBalanceModel _accountBalance;

        public FrmPayment()
        {
            InitializeComponent();
        }

        private async void AddPayment(double amount)
        {
            if(_accountBalance.Debt > 0)
            {
                _depositado += Math.Round(amount, 2);

                if (_accountBalance.Debt >= _depositado)
                {
                    _restante = Math.Round(_accountBalance.Debt - _depositado, 2);
                }
                else
                {
                    _restante = 0;
                    _cambio = Math.Round(_depositado - _accountBalance.Debt, 2);
                    var result = await SavePayment(_accountBalance.Debt);
                    if (result)
                    {
                        _depositado = 0;
                        MessageBox.Show($"Su cambio es de ${_cambio}");
                        Form frmWelcome = AppHelper.GetWelcomeForm();
                        frmWelcome.Show();
                        Close();
                    }
                }


                TxtDepositado.Text = $"${_depositado}";
                TxtRestante.Text = $"${_restante}";
                TxtCambio.Text = $"${_cambio}";
            }
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            IAccountService account_service = new AccountService();
            _accountBalance = account_service.GetAccountBlance();

            _restante = _accountBalance.Debt - _depositado;
            TxtDeuda.Text = $"${_accountBalance.Debt}";
            TxtDepositado.Text = $"${_depositado}";
            TxtRestante.Text = $"${_restante}";
            TxtCambio.Text = $"${_cambio}";
        }

        private void BtnQuinientos_Click(object sender, EventArgs e)
        {
            AddPayment(500);
        }

        private void BtnDocientos_Click(object sender, EventArgs e)
        {
            AddPayment(200);
        }

        private void BtnCien_Click(object sender, EventArgs e)
        {
            AddPayment(100);
        }

        private void BtnCincuenta_Click(object sender, EventArgs e)
        {
            AddPayment(50);
        }

        private void BtnVeinte_Click(object sender, EventArgs e)
        {
            AddPayment(20);
        }

        private void BtnDiez_Click(object sender, EventArgs e)
        {
            AddPayment(10);
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            AddPayment(5);
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            AddPayment(2);
        }

        private void BtnUno_Click(object sender, EventArgs e)
        {
            AddPayment(1);
        }

        private void BtnCincoCentavos_Click(object sender, EventArgs e)
        {
            AddPayment(0.5);
        }

        private async void BtnAbonar_Click(object sender, EventArgs e)
        {
            if (_depositado > 0)
            {
                var result = await SavePayment(_depositado);
                if (result)
                {
                    _depositado = 0;
                    Form frmWelcome = AppHelper.GetWelcomeForm();
                    frmWelcome.Show();
                    Close();
                }
            }
        }

        private async Task<bool> SavePayment(double depositado)
        {
            bool succesfull = false;
            IKioskService kiosk_service = new KioskService();
            var response = await kiosk_service.PostPayment(new PaymentRequest()
            {
                account = _accountBalance.Account_number.ToString(),
                paid = depositado
            });

            if (response.debt != null)
            {
                var db_response = DbContext.Instantiate.InsertPayment(new Payment()
                {
                    account = _accountBalance.Account_number,
                    Costumer = response.user,
                    Debt = double.Parse(response.debt),
                    Paid = _depositado,
                    Change = _cambio,
                    Date = DateTime.UtcNow

                });
                succesfull = true;
            }

            return succesfull;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (_depositado == 0)
            {
                Form frmWelcome = AppHelper.GetWelcomeForm();
                frmWelcome.Show();
                Close();
            }
        }

        private void FrmPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_depositado == 0)
            {
                Form frmWelcome = AppHelper.GetWelcomeForm();
                frmWelcome.Show();
            }
        }

        private void FrmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_depositado > 0)
            {
                e.Cancel = true;
            }
        }
    }
}
