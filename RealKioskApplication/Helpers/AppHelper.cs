using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealKioskApplication.Helpers
{
    public class AppHelper
    {
        public static Form GetWelcomeForm()
        {
            return Application.OpenForms.OfType<Form>()
               .Where(pre => pre.Name == "FrmWelcome").SingleOrDefault<Form>();
        }

        public static Form GetBalanceForm()
        {
            return Application.OpenForms.OfType<Form>()
               .Where(pre => pre.Name == "FrmBalance").SingleOrDefault<Form>();
        }

        public static Form GetAccountForm()
        {
            return Application.OpenForms.OfType<Form>()
               .Where(pre => pre.Name == "FrmAccount").SingleOrDefault<Form>();
        }

        public static Form GetPaymentForm()
        {
            return Application.OpenForms.OfType<Form>()
               .Where(pre => pre.Name == "FrmPayment").SingleOrDefault<Form>();
        }
    }
}
