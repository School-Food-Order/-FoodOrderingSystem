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

        OrderScreen orderScreen;
        KitchenLiveOrderScreen kitchenScreen;

        public CheckoutScreen(float total, ListBox list, OrderScreen oScreen, KitchenLiveOrderScreen kOScreen)
        {
            InitializeComponent();
            totalTextBox.Text = total.ToString();
            string text = "";
            foreach (var item in list.Items)
            {
                text = item.ToString(); // /n to print each item on new line or you omit /n to print text on same line
                checkoutListBox.Items.Add(text);
            }
            orderScreen = oScreen;
            kitchenScreen = kOScreen;
        }


        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //Order Confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to place this order?", "Order Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //user said yes order goes through

                TakeoutSelectionScreen takeOutScreen = new TakeoutSelectionScreen(kitchenScreen);

                MessageBox.Show("Thank-you for placing your order, it has been sent to the kitchen to be prepared!", "Order Confirmation", MessageBoxButtons.OK);
                orderScreen.clearList();
                takeOutScreen.Show();
                this.Dispose();
            }
            else
            {
                //user said no, does nothing
                return;
            }
        }

        private void checkoutBackButton_Click(object sender, EventArgs e)
        {
            orderScreen.Show();
            this.Dispose();
        }
    }
}