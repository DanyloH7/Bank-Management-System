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

namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public partial class ShowStaff : Form
    {
        public static string[] alllines;
        public static int count;
        public static int i = 0;
        public ShowStaff()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("staff.txt");
            count = 0;
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                count = count + 1;
            }
            sr.Close();

            alllines = new string[count];
            sr = new StreamReader("staff.txt");
            for (int j = 0; j < count; j++)
            {
                alllines[j] = sr.ReadLine();
            }
            sr.Close();
            ShowData(i);
        }
        private void ShowData(int index)
        {
            string[] information = alllines[index].Split(',');

            textBox1.Text = information[0];  
            textBox2.Text = information[1];  
            textBox3.Text = information[2];  
            textBox4.Text = information[4];   
            textBox5.Text = information[3];   
            textBox6.Text = information[5];  
            textBox7.Text = information[6];  
            textBox8.Text = information[7];  
            textBox9.Text = information[8];  
            textBox10.Text = information[9]; 
            textBox11.Text = textBox11.Text = Generator.PerHour(information[6]).ToString(); ;

            if (information.Length > 10 && File.Exists(information[11]))
            {
                pictureBox1.Image = Image.FromFile(information[11]);
            }

                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i = i - 1;
                ShowData(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i < count - 1)
            {
                i= i + 1;
                ShowData(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffManaging sm = new StaffManaging();
            sm.ShowDialog();
            ShowData(i);
        }
    }
}

