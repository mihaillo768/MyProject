using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgectCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // char znak;
        public double argument1;
        public double argument2;
        public double result;

        /*private void buttonPlus(object sender, EventArgs e)
        {
            argument1 = Convert.ToDouble(argument_1.Text);
            argument2 = Convert.ToDouble(argument_2.Text);
            result = argument1 + argument2;
            TotalResult.Text = Convert.ToString(result);
            //  znak = '+';
        }

        private void buttonMinus(object sender, EventArgs e)
        {
            argument1 = Convert.ToDouble(argument_1.Text);
            argument2 = Convert.ToDouble(argument_2.Text);
            result = argument1 - argument2;
            TotalResult.Text = Convert.ToString(result);
            //znak = '-';
        }

        private void buttonMultiplication(object sender, EventArgs e)
        {
            argument1 = Convert.ToDouble(argument_1.Text);
            argument2 = Convert.ToDouble(argument_2.Text);
            result = argument1 * argument2;
            TotalResult.Text = Convert.ToString(result);
            //znak = '*';
        }

        private void buttonDevision(object sender, EventArgs e)
        {
            argument1 = Convert.ToDouble(argument_1.Text);
            argument2 = Convert.ToDouble(argument_2.Text);
            result = argument1 / argument2;
            TotalResult.Text = Convert.ToString(result);
            //znak = '/';
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttons(object sender, EventArgs e)
        {

            argument1 = Convert.ToDouble(argument_1.Text);
            argument2 = Convert.ToDouble(argument_2.Text);
            switch (((Button)sender).Name)
            {
                case "Plus":
                    result = argument1 + argument2;
                    TotalResult.Text = Convert.ToString(result);
                    break;
                case "Minus":
                    result = argument1 - argument2;
                    TotalResult.Text = Convert.ToString(result);
                    break;
                case "multi":
                    result = argument1 * argument2;
                    TotalResult.Text = Convert.ToString(result);
                    break;
                case "div":
                    result = argument1 / argument2;
                    TotalResult.Text = Convert.ToString(result);
                    break;
            }
        }
    }
}
