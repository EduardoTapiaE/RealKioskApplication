using LyFService.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LyFService.Models.Response;
using LyFService.Models.Request;

namespace LyFService.Services
{
    public class KioskService : IKioskService
    {
        private string _token = "6587737b260445db2c727db0dacbe17d";
        public async Task<AccountBalanceModel> GetAccountBalance(int account_number)
        {
            
            AccountBalanceModel account = null;
            if (account_number.ToString().Length > 0)
            {
                var url =
                    $"https://api.xenterglobal.com:2053/account_balance?token={_token}&account={account_number}";

                HttpClient Client = new HttpClient();

                var response = await Client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    account = JsonConvert.DeserializeObject<AccountBalanceModel>(content);
                }
            }

            return account;
        }

        public async Task<PaymentResponse> PostPayment(PaymentRequest payment)
        {
            string url = $"https://api.xenterglobal.com:2053/transaction?token={_token}";
            HttpClient Client = new HttpClient();
            PaymentResponse payment_response = null;

            var data = JsonConvert.SerializeObject(payment);
            HttpContent http_content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var http_response = await Client.PostAsync(url, http_content);

            if(http_response.IsSuccessStatusCode)
            {
                var result = await http_response.Content.ReadAsStringAsync();

                payment_response = JsonConvert.DeserializeObject<PaymentResponse>(result);
            }

            return payment_response;

        }
    }
}
