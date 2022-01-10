using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace FinCalculator
{
    public partial class FinCalc : Form
    {
 
        string operand1 = string.Empty;     // string storing first operand
        string operand2 = string.Empty;     // string storing second operand
        string operand3 = string.Empty;     // string storing third operand

        double result = 0.0;                // calculated result

        public FinCalc()
        {
            InitializeComponent();
        }


        private void FinCalc_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
            // future value. compound interest
            /* FV = PV * (1 + i)^n  
             * FV = future value
             * R = repayment/deposit made each period
             * i = interest rate  => i = r/m
             * i = periodic rate of interest
             * r = nominal interest rate
             * m = number of compounding periods
             */

            operand1 = textBox1.Text;
            operand2 = textBox5.Text;
            operand3 = textBox6.Text;

            string calculatedOutput;
            double pv, n, i; 
            double.TryParse(operand1, out n);
            double.TryParse(operand2, out i);
            double.TryParse(operand3, out pv);


            i /= 100;
            result = pv * (Math.Pow(1 + i, n)); 
            calculatedOutput = result.ToString("C", CultureInfo.CurrentCulture);
            textBox7.Text = calculatedOutput;
            Console.WriteLine(calculatedOutput);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // clear button on Future Value tab
            textBox1.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // solve for p value
            /* P = R * ( r(1+r)^n) / ((1+r)^n - 1)
             * P = total monthly payment
             * R = principal loan amount
             * i = rate per period (usually i = r/m) for 5% interest annualized => i = 0.05/12 = 0.004167 
             * n = total number of times compouunded (n = mt), 30 year fixed rate => n = 30*12 = 360
             */

            operand1 = textBox11.Text;
            operand2 = textBox10.Text;
            operand3 = textBox9.Text;

            string calculatedOutput;
            double pv, n, i ;
            double.TryParse(operand1, out n);
            double.TryParse(operand2, out i);
            double.TryParse(operand3, out pv);

            i /= 100;
            i = i / 12;
            result = pv * i * Math.Pow((1 + i), n) / (Math.Pow(1 + i, n) - 1);
            calculatedOutput = result.ToString("C", CultureInfo.CurrentCulture);
            textBox8.Text = calculatedOutput;
            Console.WriteLine(calculatedOutput);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // 'clear' button on payment tab
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {   

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
