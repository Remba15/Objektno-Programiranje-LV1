using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV1___win_forme
{
    public partial class Form1 : Form
    {
        private int label1Counter = 0, label2Counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2Counter++;
            label2.Text = "Tipka 2 pritisnuta " + label2Counter + " puta.";
        }

        private void t(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Pritisnuta je Tipka 1";
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Pritisnuta je Tipka 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1Counter++;
            label1.Text = "Tipka 1 pritisnuta " + label1Counter + " puta.";
        }
    }
}
