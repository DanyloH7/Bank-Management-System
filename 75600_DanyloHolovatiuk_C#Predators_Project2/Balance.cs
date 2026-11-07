using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void SaveData()
        {
            string[] data = ShowCustomers.alllines[ShowCustomers.i].Split(',');
            data[8] = textBox3.Text; 
            data[9] = textBox4.Text; 

            string updateLine = data[0] + "," + data[1] + "," + data[2] + "," + data[3] + "," +
                                data[4] + "," + data[5] + "," + data[6] + "," + data[7] + "," +
                                data[8] + "," + data[9] + "," + data[10];

            ShowCustomers.alllines[ShowCustomers.i] = updateLine;

            StreamWriter sw = new StreamWriter("customers.txt");
            for (int j = 0; j < ShowCustomers.count; j++)
            {
                sw.WriteLine(ShowCustomers.alllines[j]);
            }
            sw.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            string[] info = ShowCustomers.alllines[ShowCustomers.i].Split(',');
            textBox1.Text = info[5];
            textBox2.Text = info[6];
            textBox3.Text = info[8];
            textBox4.Text = info[9];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double balance = Convert.ToDouble(textBox3.Text);
                double amount = Convert.ToDouble(textBox5.Text);
                if (amount > balance)
                {
                    return;
                }
                balance = balance - amount;
                textBox3.Text = Convert.ToString(balance);
                SaveData();
            }
            catch
            {

            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                double balance = Convert.ToDouble(textBox3.Text);
                double savings = Convert.ToDouble(textBox4.Text);
                double amount = Convert.ToDouble(textBox6.Text);
                if (amount > balance)
                {
                    
                    return;
                    
                }
                balance = balance - amount;
                savings = savings + amount;               
                textBox3.Text = Convert.ToString(balance);            
                textBox4.Text = Convert.ToString(savings);          
                SaveData();        
            }
            catch
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                double balance = Convert.ToDouble(textBox3.Text);         
                double amount = Convert.ToDouble(textBox7.Text);            
                balance = balance +  amount;           
                textBox3.Text = Convert.ToString(balance);           
                SaveData();           
            }
            catch
            {
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
       
            
            

            
        
    
       
}
