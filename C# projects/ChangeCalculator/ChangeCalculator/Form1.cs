using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int ChangeDue = Convert.ToInt32(txtChangeDue.Text);
            int Quarters;
            int Dimes;
            int Nickels;
            int Pennies;
            decimal coins;

            Quarters = (int)(ChangeDue / 25);
            coins = ChangeDue % 25;
            txtQuarters.Text = Quarters.ToString();

            ChangeDue = ChangeDue - (25 * Quarters);

            Dimes = (int)(ChangeDue / 10);
            coins = ChangeDue % 10;
            txtDimes.Text = Dimes.ToString();

            ChangeDue = ChangeDue - (10 * Dimes);

            Nickels = (int)(ChangeDue / 5);
            coins = ChangeDue % 5;
            txtNickels.Text = Nickels.ToString();

            ChangeDue = ChangeDue - (5 * Nickels);

            Pennies = (int)(ChangeDue / 1);
            coins = ChangeDue % 1;
            txtPennies.Text = Pennies.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
