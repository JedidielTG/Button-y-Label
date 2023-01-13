using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_y_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Ingeniero";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Jedidiel";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "Toto";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "Garcia";
        }
    }
}
