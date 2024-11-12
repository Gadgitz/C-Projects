using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int years = Convert.ToInt32(txtYears.Text);
            int months = years * 12;
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);

            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0m;
 
            int x = 0;
            do
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
                x++;
            } while (x < months);
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
