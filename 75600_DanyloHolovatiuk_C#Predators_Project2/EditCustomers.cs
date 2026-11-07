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
    public partial class EditCustomers : Form
    {
        private string photoPath = "";
        public EditCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditCustomers_Load(object sender, EventArgs e)
        {
            if (File.Exists("customers.txt"))
            {
                StreamReader sr = new StreamReader("customers.txt");
                int currentLine = 0;
                while (!sr.EndOfStream)
                {
                    string line= sr.ReadLine();
                    if (currentLine == ShowCustomers.i)
                    {
                        string[] info = line.Split(',');
                        textBox1.Text = info[0]; 
                        textBox2.Text = info[1]; 
                        textBox3.Text = info[2]; 
                        textBox4.Text = info[3]; 
                        textBox5.Text = info[7]; 
                        textBox6.Text = info[4]; 
                        textBox7.Text = info[5]; 
                        textBox8.Text = info[8]; 
                        textBox9.Text = info[6]; 
                        textBox10.Text = info[9];

                        if (info.Length > 10  && File.Exists(info[10]))
                        {
                            pictureBox1.Image = Image.FromFile(info[10]);
                        }
                        break;
                    }
                    currentLine = currentLine + 1;
                }
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] data = ShowCustomers.alllines[ShowCustomers.i].Split(',');
            data[0] = textBox1.Text;  
            data[1] = textBox2.Text;  
            data[2] = textBox3.Text;  
            data[3] = textBox4.Text;  
            data[4] = textBox6.Text;  
            data[5] = textBox7.Text;  
            data[6] = textBox9.Text;  
            data[7] = textBox5.Text;
            data[8] = textBox8.Text; 
            data[9] = textBox10.Text;
            if (photoPath == "")
            {
                data[10] = ShowCustomers.alllines[ShowCustomers.i].Split(',')[10];
            }
            else
            {
                data[10] = photoPath;
            }

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
            this.Close();

                
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                photoPath = ofd.FileName;
            }
          

        }
    }
}
