using System;
using System.Windows.Forms;
using MyProjectCsharp.OneArgument;
using MyProjectCsharp.TwoArguments;

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

        private void OneArgumentFunction(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(argument_1.Text);
                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstArgument);
                TotalResult.Text = result.ToString();
            }
            catch (Exception exc)
            {
                TotalResult.Text = exc.Message;
            }
        }

        private void TwoArgumentFunction(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(argument_1.Text);
                double secondArgument = Convert.ToDouble(argument_2.Text);
                ITwoArgumentsCalculator calculator = TwoArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstArgument, secondArgument);
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
