using RealKioskApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealKioskApplication.Services
{
    public class AccountService : IAccountService
    {
        private static AccountBalanceModel _accountBalance;

        public AccountBalanceModel GetAccountBlance()
        {
            return _accountBalance;
        }

        public void SetAccountBlance(AccountBalanceModel account_balance)
        {
            _accountBalance = account_balance;
        }
    }
}
