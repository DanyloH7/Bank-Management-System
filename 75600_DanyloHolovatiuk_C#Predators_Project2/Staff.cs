using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public  class Staff:Person
    {
        public string StaffID { get; set; }
        public string Role {  get; set; }
        public double SalaryPerHour { get; set; }
        public int Hours { get; set; }
        public int ExtraHours { get; set; }
    }
}
