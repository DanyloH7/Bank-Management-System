using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public class Customer:Person
    {
        public string CustomerID { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public double Savings { get; set; }
        public string Plan {  get; set; }
       

    }
}
