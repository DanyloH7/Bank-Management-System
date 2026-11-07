using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public static class Generator
    {
        private static Random R = new Random();
        public static string GenerateUserID()
        {
            char[] letters = new char [] { 'A', 'B', 'C', 'D', 'E' };
            char letter = letters [R.Next(letters.Length)];
            int number = R.Next(1000, 10000);
            return letter.ToString() +'-'+ number.ToString();

        }
        public static string GenarateStaffID()
        {
            char[] letters = new char[] { 'T', 'L', 'X', 'Y', 'Z' };
            char letter = letters[R.Next(letters.Length)];
            int number = R.Next(1000, 10000);
            return letter.ToString() +"-"+ number.ToString();
        }
        public static string GenerateAcountNumber()
        {
            string block2 = R.Next(1000,10000).ToString();
            string block3 = R.Next(1000,10000).ToString();
            string block4 = R.Next(1000, 10000).ToString();
            return "5585" + " " +  block2 + " " + block3 + " " + block4;
        }
        public static double PerHour(string Role)
        {
           
            if(Role == "General Manager") return 100;
            else if (Role == "CEO") return 150;
            else if (Role == "Manager") return 80;
            else if (Role == "Cashir") return 50;
            else return 0;
        }
    }   
}