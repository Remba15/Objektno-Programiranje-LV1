using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace LV1___Win_forme_2
{
    public partial class Form1 : Form
    {
        private double coeficientA = 0, coeficientB = 0, coeficientC = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private double calculateDiscriminant(double a, double b, double c) {
            return (Math.Pow(b, 2) - (4 * a * c));
        }

      
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            coeficientA = Double.Parse(textBoxA.Text);
            coeficientB = Double.Parse(textBoxB.Text);
            coeficientC = Double.Parse(textBoxC.Text);

            Result1value.Text = (-coeficientB / (2*coeficientA)).ToString() + " + " + (Math.Sqrt(-calculateDiscriminant(coeficientA, coeficientB, coeficientC))/(2*coeficientA)).ToString() + "i";
            Result2value.Text = (-coeficientB / (2 * coeficientA)).ToString() + " - " + (Math.Sqrt(-calculateDiscriminant(coeficientA, coeficientB, coeficientC))/(2 * coeficientA)).ToString() + "i";
            //provjera za kompleksni 10,5,2
        }
    }
}
