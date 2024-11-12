using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndParimeter
{
    public partial class AAP : Form
    {
        public AAP()
        {
            InitializeComponent();
   

        

        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width = Convert.ToDecimal(txtWidth.Text);
            decimal area = length * width;
            decimal perimeter = 2 * length + 2 * width;

            txtArea.Text = area.ToString("f");
            txtPerimeter.Text = perimeter.ToString("f");
            

            txtLength.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
