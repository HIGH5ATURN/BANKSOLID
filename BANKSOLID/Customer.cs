using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKSOLID
{
    

    public class Customer
    {
        public String Name { get; set; }
        public String NID { get; set; }

        public List<Account> Accounts { get; set; }
        
        public string PassWord { get; set; }
        public Customer(String name, String NID, string passWord)
        {
            Name = name;
            this.NID = NID;
            PassWord = passWord;
        }

    }
}
