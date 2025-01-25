using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            if (temp != null)
            {
                textBox1.Text += temp.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("눌렀네");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(300, 200);
            btn.Location = new Point(10, 10);
            btn.Text = "MyButton";
            btn.Click += ((s, bb) => MessageBox.Show("되게 간단하네"));

            this.Controls.Add(btn);
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("우와 크다");
        //}
    }
}
