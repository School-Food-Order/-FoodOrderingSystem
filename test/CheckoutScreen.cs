using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class CheckoutScreen : Form
    {
        
        public CheckoutScreen(float total)
        {
            InitializeComponent();
            totalTextBox.Text = total.ToString();
        }


        private void checkoutButton_Click(object sender, EventArgs e)
        {

        }

    }
}
