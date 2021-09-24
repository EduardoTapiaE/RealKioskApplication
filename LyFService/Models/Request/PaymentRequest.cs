using System;
using System.Collections.Generic;
using System.Text;

namespace LyFService.Models.Request
{
    public class PaymentRequest
    {
        public string account { get; set; }
        public double paid { get; set; }
    }
}
