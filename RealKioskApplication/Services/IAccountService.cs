using LyFService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealKioskApplication.Services
{
    public interface IAccountService
    {
        void SetAccountBlance(AccountBalanceModel account_balance);
    }
}
