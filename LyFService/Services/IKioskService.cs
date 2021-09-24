using LyFService.Models;
using LyFService.Models.Request;
using LyFService.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LyFService.Services
{
    public interface IKioskService
    {
        Task<AccountBalanceModel> GetAccountBalance(int account_number);
        Task<PaymentResponse> PostPayment(PaymentRequest payment);
    }
}
