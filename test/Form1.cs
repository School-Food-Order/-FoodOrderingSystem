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
    public partial class OrderScreen : Form
    {

        public OrderScreen()
        {
            InitializeComponent();
        }

        private void burgerMealButton_Click(object sender, EventArgs e)
        {
            orderListBox.Items.Add("Burger Meal Deal\t\t\t\t£6.29");
            orderListBox.Items.Add("\tBurger");
            orderListBox.Items.Add("\tChips");
            orderListBox.Items.Add("\tRegular Coke");
        }

        private void nuggetMealButton_Click(object sender, EventArgs e)
        {
            orderListBox.Items.Add("9 Chicken Nugget Meal Deal\t\t\t£6.29");
            orderListBox.Items.Add("\tBurger");
            orderListBox.Items.Add("\tChips");
            orderListBox.Items.Add("\tRegular Coke");
        }

        private void chickenWrapButton_Click(object sender, EventArgs e)
        {
            orderListBox.Items.Add("Chicken Wrap (Grilled) Meal Deal\t\t\t£5.50");
            orderListBox.Items.Add("\tChicken Wrap (Grilled)");
            orderListBox.Items.Add("\tChips");
            orderListBox.Items.Add("\tRegular Coke");
        }

        private void largeChipsButton_Click(object sender, EventArgs e)
        {
            orderListBox.Items.Add("Large Chips\t\t\t\t£1.89");
        }

        private void checkoutLabel_Click(object sender, EventArgs e)
        {
            CheckoutScreen checkoutForm = new CheckoutScreen();
            checkoutForm.Show();
        }
    }
}
