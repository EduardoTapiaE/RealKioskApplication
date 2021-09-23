using LyFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealKioskApplication.Services
{
    public class AccountService : IAccountService
    {
        private AccountBalanceModel _accountBalance;

        public void SetAccountBlance(AccountBalanceModel account_balance)
        {
            _accountBalance = account_balance;
        }
    }
}
