using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProgectCsharp.One_argument;
using MyProgectCsharp.Two_arguments;

namespace MyProgectCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // char znak;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void oneargumentfunction(object sender, EventArgs e)
        {
            double FirstArgument = Convert.ToDouble(argument_1.Text);
            IOneArgrumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(FirstArgument);
            TotalResult.Text = result.ToString();
        }

        private void twoargumentcalculate(object sender, EventArgs e)
        {
            double FirstArgument = Convert.ToDouble(argument_1.Text);
            double SecondArgument = Convert.ToDouble(argument_2.Text);
            ITwoArgrumentsCalculator calculator = TwoArgumentFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(FirstArgument, SecondArgument);
            TotalResult.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
