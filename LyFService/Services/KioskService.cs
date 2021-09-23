using LyFService.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LyFService.Services
{
    public class KioskService : IKioskService
    {
        public async Task<AccountBalanceModel> GetAccountBalance(int account_number)
        {
            string token = "6587737b260445db2c727db0dacbe17d";
            AccountBalanceModel account = null;
            if (account_number.ToString().Length > 0)
            {
                var url =
                    $"https://api.xenterglobal.com:2053/account_balance?token={token}&account={account_number}";

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
    }
}
