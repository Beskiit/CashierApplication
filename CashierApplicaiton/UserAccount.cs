using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplicaiton
{
    internal abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;
        
        public UserAccount(string name, string uName, string password)
        {
            this.full_name = "Airone Gamil";
            this.user_name = "cashier101";
            this.user_password = "12345";
        }

        public abstract bool validateLogin(string uName, string password);
        public string getFullName()
        {
            return this.full_name;
        }
    }
}
