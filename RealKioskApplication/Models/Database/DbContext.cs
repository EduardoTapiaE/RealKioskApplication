using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;

namespace RealKioskApplication.Models.Database
{
    public class DbContext
    {
        private static string _connection = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static DbContext _intance = null;

        public DbContext()
        {

        }

        public static DbContext Instantiate 
        {
            get 
            {
                if(_intance == null)
                {
                    _intance = new DbContext();
                }

                return _intance;
            }
        }

        public bool InsertPayment(Payment payment) 
        {
            bool successful = true;

            using(SQLiteConnection connection = new SQLiteConnection(_connection))
            {
                connection.Open();
                string query = "insert into payment(costumer,account,debt,paid,date,change) values (@costumer,@account,@debt,@paid,@date,@change) ";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.Add(new SQLiteParameter("@costumer", payment.Costumer));
                cmd.Parameters.Add(new SQLiteParameter("@account", payment.account));
                cmd.Parameters.Add(new SQLiteParameter("@debt", payment.Debt));
                cmd.Parameters.Add(new SQLiteParameter("@paid", payment.Paid));
                cmd.Parameters.Add(new SQLiteParameter("@date", payment.Date));
                cmd.Parameters.Add(new SQLiteParameter("@change", payment.Change));
                cmd.CommandType = System.Data.CommandType.Text;
                
                if(cmd.ExecuteNonQuery() < 1)
                {
                    successful = false;
                }

            }

            return successful;

        }

    }
}
