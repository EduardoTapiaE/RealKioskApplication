using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealKioskApplication.Models
{
    public class AccountBalanceModel
    {
        public int Account_number { get; set; }
        public string User { get; set; }
        public double Debt { get; set; }
    }
}
