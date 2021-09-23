using LyFService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LyFService.Services
{
    public interface IKioskService
    {
        Task<AccountBalanceModel> GetAccountBalance(int account_number);
    }
}
