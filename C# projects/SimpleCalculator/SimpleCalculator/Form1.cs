using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearResults(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Operand1 = Convert.ToDecimal(txtOperand1.Text);
            decimal Operand2 = Convert.ToDecimal(txtOperand2.Text);
            decimal result = 0m;

            decimal results = this.Calculate(Operand1, Operand2,result);
            Math.Round(results, 5);
            txtResult.Text = results.ToString("f4");
            txtOperand1.Focus();
        }
        private decimal Calculate(decimal Operand1, decimal Operand2,decimal result)
        {
            string Operator1 = txtOperator1.Text;
            switch (Operator1)
            {
                case "+":

                    result = Operand1 + Operand2;

                    break;

                case "-":

                    result = Operand1 - Operand2;
                    
                    break;

                case "*":

                    result = Operand1 * Operand2;
                    
                    break;

                case "/":

                    result = Operand1 / Operand2;
                    break;     
                 }
            return result;

            }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            this.txtOperand1.TextChanged += new System.EventHandler(this.ClearResults);
        }

        private void txtOperator1_TextChanged(object sender, EventArgs e)
        {
            this.txtOperator1.TextChanged += new System.EventHandler(this.ClearResults);
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            this.txtOperator1.TextChanged += new System.EventHandler(this.ClearResults);
        }
    }
    }

