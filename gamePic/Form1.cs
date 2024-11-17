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

namespace gamePic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cvb;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // pictureBox1.Image = Image.FromFile("C:\\Users\\student\\Desktop\\HarryPotter\\Harry Potter.jpg");
            Random rn1 = new Random();
            
            int a = rn1.Next(1,4);
            if (a == 1) 
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\student\\Desktop\\HarryPotter\\Harry Potter.jpg");
                 cvb = "Harry";

            }
            else if (a == 2)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\student\\Desktop\\HarryPotter\\Draco Malfoy.jpg");
                 cvb = "Draco";
      
            }
            else if (a == 3)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\student\\Desktop\\HarryPotter\\Hermione Granger.jpeg");
                 cvb = "Hermione";
             
            }
             else if (a == 4)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\student\\Desktop\\HarryPotter\\Sirius Black.jpg");
                cvb = "Sirius";
                
            }       
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == cvb)
                {
                MessageBox.Show("true");
            }
        }
    }
}
