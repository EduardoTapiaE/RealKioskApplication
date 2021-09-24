using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealKioskApplication.Models.Database
{
    public class Payment
    {
        public int Id { get; set; }
        public string Costumer { get; set; }
        public int account { get; set; }
        public double Debt { get; set; }
        public double Paid { get; set; }
        public DateTime Date { get; set; }
        public double Change { get; set; }
    }
}
