using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
       
        public int n = 0;
        public double secs;
        public double[] sec;
        public Form1()
        {
            InitializeComponent();

                        
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
            pictureBox1.Visible = true;
            label2.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y + 30);
            label2.Visible = true;
            label1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            secs = 0;
            n++;
            Random rnd = new Random();
            label4.Text = Convert.ToString(n);
            switch (n)
            {
                case 1:
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200),rnd.Next(0, this.Size.Height - 100));
                    label3.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y + 30);
                    label3.Visible = true;
                    label2.Visible = false; 
                    break;
                case 2:
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    if (pictureBox1.Location.X >= this.Size.Width - 400)
                    {
                        label3.Location = new Point(pictureBox1.Location.X - 400, pictureBox1.Location.Y + 30);
                    }
                    label3.Visible = false;
                    label4.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    timer1.Start();
                    if (secs < Double.Parse(label8.Text))
                        label8.Text = Convert.ToString(secs);
                    break;
                case 35:
                    label5.Visible = true;
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    break;
                case 45:
                    label5.Visible = false;
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    break;
                case 100:
                    label5.Visible = true;
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    break;
                case 115:
                    label5.Visible = false;
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    break;
                case 250:
                    label5.Visible = true;
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    break;
                case 265:
                    label5.Visible = false;
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    break;
                default :
                    pictureBox1.Location = new Point(rnd.Next(0, this.Size.Width - 200), rnd.Next(0, this.Size.Height - 100));
                    if (secs < Double.Parse(label8.Text)) { label8.Text = Convert.ToString(secs); }
                    break;
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            label4.Visible = false;
            label4.Enabled = false;
            label6.Visible = true;
            label7.Visible = false;
            label7.Enabled = false;
            label8.Visible = false;
            label8.Enabled = false;
            label6.Text = "Ты тыкнул в какаху " + n + " раз! Поздравляю!";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secs++;
            label7.Text = Convert.ToString(secs);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
