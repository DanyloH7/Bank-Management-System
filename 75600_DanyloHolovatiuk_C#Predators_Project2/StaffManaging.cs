using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public partial class StaffManaging : Form
    {
        public StaffManaging()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void StaffManaging_Load(object sender, EventArgs e)
        {
            string[] information = ShowStaff.alllines[ShowStaff.i].Split(',');
            textBox1.Text = information[0]; 
            textBox2.Text = information[7]; 
            textBox3.Text = information[8]; 
            textBox4.Text = information[9]; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double normalHours = Convert.ToDouble(textBox5.Text);
                double extraHours = Convert.ToDouble(textBox6.Text);
                double currentHours = Convert.ToDouble(textBox2.Text);
                double currentExtra = Convert.ToDouble(textBox3.Text);

                currentHours =  currentHours + normalHours;
                currentExtra = currentExtra + extraHours;

                textBox2.Text = Convert.ToString(currentHours);
                textBox3.Text = Convert.ToString(currentExtra);

                
            }
            catch
            {
                
            }
        }
        private void SaveData()
        {
            string[] data = ShowStaff.alllines[ShowStaff.i].Split(',');
            data[7] = textBox2.Text; 
            data[8] = textBox3.Text;  
            data[9] = textBox4.Text; 

            string updateLine = data[0] + "," + data[1] + "," + data[2] + "," + data[3] + "," +
                                data[4] + "," + data[5] + "," + data[6] + "," + data[7] + "," +
                                data[8] + "," + data[9] + "," + data[10] + "," + data[11];

            ShowStaff.alllines[ShowStaff.i] = updateLine;

            StreamWriter sw = new StreamWriter("staff.txt");
            for (int j = 0; j < ShowStaff.count; j++)
            {
                sw.WriteLine(ShowStaff.alllines[j]);
            }
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] information = ShowStaff.alllines[ShowStaff.i].Split(',');
                double salary = Generator.PerHour(information[6]);
                double hours = Convert.ToDouble(textBox2.Text);
                double extraHours = Convert.ToDouble(textBox3.Text);

                double totalPay = (hours * salary) + (extraHours * salary * 1.4);

                double balance = Convert.ToDouble(textBox4.Text);
                balance += totalPay;
                textBox4.Text = Convert.ToString(balance);

                textBox2.Text = "0";
                textBox3.Text = "0";

                SaveData();
            }
            catch
            {
                
            }
        }
    }
}
