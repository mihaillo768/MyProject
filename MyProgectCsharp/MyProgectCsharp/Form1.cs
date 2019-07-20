using System;
using System.Windows.Forms;
using MyProjectCsharp.OneArguement;
using MyProjectCsharp.TwoArguements;

namespace MyProjectCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            try
            {
                double FirstArgument = Convert.ToDouble(argument_1.Text);
                IOneArgrumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(FirstArgument);
                TotalResult.Text = result.ToString();
            }
            catch (Exception exc)
            {
                TotalResult.Text = exc.Message;
            }
        }

        private void twoargumentcalculate(object sender, EventArgs e)
        {
            try
            {
                double FirstArgument = Convert.ToDouble(argument_1.Text);
                double SecondArgument = Convert.ToDouble(argument_2.Text);
                ITwoArgumentsCalculator calculator = TwoArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(FirstArgument, SecondArgument);
                TotalResult.Text = result.ToString();
            }
            catch (Exception exc)
            {
                TotalResult.Text = exc.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
