using DeviceLibrary;
using DeviceLibrary.Models;
using DeviceLibrary.Models.Enums;
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
            DeviceSimulator.instantiate.Open();
            DeviceSimulator.instantiate.AcceptedDocument += Instantiate_AcceptedDocument;
            InitializeComponent();
        }

        private void Instantiate_AcceptedDocument(Document document)
        {
            AddPayment(double.Parse(document.Value.ToString()));
        }

        private void ValidateAcceptCoinsOrBills()
        {
            DeviceSimulator.instantiate.Enable();
            if (_accountBalance.Debt <= 0)
            {
                DeviceSimulator.instantiate.Disable();
            }
        }

        private void InsertCoinsOrBills(decimal value, DocumentType type)
        {
            var device_status = DeviceSimulator.instantiate.Status;

            if (device_status == DeviceStatus.Enabled)
            {
                Document document = new Document(value, type, 1);
                DeviceSimulator.instantiate.SimulateInsertion(document);
            }
        }

        private async void AddPayment(double amount)
        {
            var device_status = DeviceSimulator.instantiate.Status;

            if(device_status == DeviceStatus.Enabled)
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
                        DeviceSimulator.instantiate.Dispense(Convert.ToDecimal(_cambio));
                        DeviceSimulator.instantiate.Close();

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
            ValidateAcceptCoinsOrBills();
            _restante = _accountBalance.Debt - _depositado;
            TxtDeuda.Text = $"${_accountBalance.Debt}";
            TxtDepositado.Text = $"${_depositado}";
            TxtRestante.Text = $"${_restante}";
            TxtCambio.Text = $"${_cambio}";
        }


        private void BtnQuinientos_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(500, DocumentType.Bill);
        }
       
        private void BtnDocientos_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(200, DocumentType.Bill);
        }

        private void BtnCien_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(100, DocumentType.Bill);
        }

        private void BtnCincuenta_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(50, DocumentType.Bill);
        }

        private void BtnVeinte_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(20, DocumentType.Bill);
        }

        private void BtnDiez_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(10, DocumentType.Coin);
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(5, DocumentType.Coin);
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(2, DocumentType.Coin);
        }

        private void BtnUno_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(1, DocumentType.Coin);
        }

        private void BtnCincoCentavos_Click(object sender, EventArgs e)
        {
            InsertCoinsOrBills(Convert.ToDecimal(0.5), DocumentType.Coin);
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
            try
            {
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
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al guardar el pago. Detalles: {ex.Message}");
            }

            return succesfull;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (_depositado == 0)
            {

                Form frmWelcome = AppHelper.GetWelcomeForm();
                frmWelcome.Show();
                DeviceSimulator.instantiate.Close();
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
