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
using System.IO;

namespace _75600_DanyloHolovatiuk_C_Predators_Project2
{
    public partial class AddStaff : Form
    {
        private string photoPath = "";
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
           

            textBox1.Text = Generator.GenarateStaffID();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                photoPath = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string photo = photoPath == "" ? "no-photo.jpg" : photoPath;

                string salary = Convert.ToString(Generator.PerHour(comboBox1.Text));

                string full = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," +
                              textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," +
                              comboBox1.Text + "," + "0," + "0," + salary + ",0," + photo;

                StreamWriter sw = new StreamWriter("staff.txt", true);
                sw.WriteLine(full);
                sw.Close();
                this.Close();
            }
            catch
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
