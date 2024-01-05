using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron_Diseño
{
    public partial class Form1 : Form
    {
        double num, num2;
        string resul;
        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion(); 
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void button00_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0"; 
        }

        private void button01_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button02_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button03_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button04_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button05_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button06_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button07_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button08_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button09_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonPunt_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            resul = "-";
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            resul = "*";
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            resul = "/";
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void buttonIgu_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);

            double suma, resta, multiplicacion, division;

            switch(resul)
            {
                case "+":
                    suma = obj.suma((num), (num2));
                    textBox1.Text = suma.ToString();
                    break;

                case "-":
                    resta = obj2.resta((num), (num2));
                    textBox1.Text = resta.ToString();
                    break;

                case "*":
                    multiplicacion = obj3.multiplicacion((num), (num2));
                    textBox1.Text = multiplicacion.ToString();
                    break;

                case "/":
                    division = obj4.division((num), (num2));
                    textBox1.Text = division.ToString();
                    break;

            }
        }

        private void buttonLim_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonBorr_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            resul = "+";
            num = double.Parse(textBox1.Text);
            textBox1.Clear();

        }
    }
}
