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
    public partial class AddCustomerForm : Form
    {
        string photoPath = "no - photo.jpg";
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            label13.Text = Generator.GenerateUserID();
            label12.Text = Generator.GenerateAcountNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string full = textBox1.Text + "," +  
               textBox2.Text + "," +  
               textBox4.Text + "," +  
               textBox3.Text + "," +  
               textBox5.Text + "," +  
               label12.Text + "," +   
               label13.Text + "," +   
               comboBox1.Text + "," + 
               textBox6.Text + "," +  
               textBox7.Text + "," +  
               photoPath;
                StreamWriter sw = new StreamWriter("Customers.txt", true);
                sw.WriteLine(full);
                sw.Close();
                this.Close();
            }
            catch 
            { 

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if(opf.ShowDialog() == DialogResult.OK)
            {
                photoPath= opf.FileName;
                pictureBox1.Image = Image.FromFile(opf.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
