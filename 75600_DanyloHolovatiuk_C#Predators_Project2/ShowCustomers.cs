using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public partial class ShowCustomers : Form
    {
       public static string[] alllines = new string[1000];
       public static int i = 0;
       public static int count = 0;
        public ShowCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowCustomers_Load(object sender, EventArgs e)
        { 
            count = 0;
            if (File.Exists("customers.txt"))
            {
                StreamReader sr = new StreamReader("customers.txt");
                while(! sr.EndOfStream)
                {
                    string line = sr.ReadLine();   
                    if( line != "")
                    {
                        alllines[count] = line;
                        count=count+1;
                    }
                }
                sr.Close();
                if (count > 0)
                {
                    i = count - 1;
                    ShowData(i);
                }
            }
        
       
       
       
            
        }
        private void ShowData(int index)
        {
            string[] information = alllines[index].Split(',');

            textBox1.Text = information[0]; 
            textBox2.Text = information[1]; 
            textBox3.Text = information[2]; 
            textBox4.Text = information[3]; 
            textBox5.Text = information[4]; 
            textBox6.Text = information[5]; 
            textBox7.Text = information[6]; 
            textBox8.Text = information[7]; 
            textBox9.Text = information[8]; 
            textBox10.Text = information[9];

            if (information.Length > 10 && File.Exists(information[10]))
            {
                pictureBox1.Image = Image.FromFile(information[10]);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (i < count - 1)
            {
                i = i +1;
                ShowData(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( i > 0)
            {
                i = i -1;
                ShowData(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCustomers ec = new EditCustomers();
            ec.ShowDialog();
            ShowData(i);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.ShowDialog();
            ShowData(i);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
