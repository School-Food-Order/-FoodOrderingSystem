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

        OrderScreen oS;
        
        public CheckoutScreen(float total, ListBox list, OrderScreen oScreen)
        {
            InitializeComponent();
            totalTextBox.Text = total.ToString();
            string text = "";
            foreach (var item in list.Items)
            {
                text = item.ToString(); // /n to print each item on new line or you omit /n to print text on same line
                checkoutListBox.Items.Add(text);
            }
            oS = oScreen;
        }


        private void checkoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to place this order?", "Order Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank-you for placing your order, it has been sent to the kitchen to be prepared!", "Order Confirmation", MessageBoxButtons.OK);
            }
            else
            {
                return;
            }
            oS.clearList();
            oS.Show();
            this.Dispose();
        }

        private void CheckoutScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
