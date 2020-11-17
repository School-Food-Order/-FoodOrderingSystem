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
            float totalCost;

            orderListBox.Items.Add("Burger Meal Deal\t\t\t\t£6.29");
            orderListBox.Items.Add("\tBurger");
            orderListBox.Items.Add("\tChips");
            orderListBox.Items.Add("\tRegular Coke");
           
            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401" ,MessageBoxButtons.OK);
                return;
            }else
            {
                totalCost += 6.29f;
                totalCostTextBox.Text = totalCost.ToString();
            }

        }

        private void nuggetMealButton_Click(object sender, EventArgs e)
        {
            float totalCost;

            orderListBox.Items.Add("9 Chicken Nugget Meal Deal\t\t\t£6.29");
            orderListBox.Items.Add("\tBurger");
            orderListBox.Items.Add("\tChips");
            orderListBox.Items.Add("\tRegular Coke");

            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401", MessageBoxButtons.OK);
                return;
            }
            else
            {
                totalCost += 6.29f;
                totalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void chickenWrapButton_Click(object sender, EventArgs e)
        {
            float totalCost;

            orderListBox.Items.Add("Chicken Wrap (Grilled) Meal Deal\t\t£5.50");
            orderListBox.Items.Add("\tChips");
            orderListBox.Items.Add("\tRegular Coke");

            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401", MessageBoxButtons.OK);
                return;
            }
            else
            {
                totalCost += 5.50f;
                totalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void largeChipsButton_Click(object sender, EventArgs e)
        {
            float totalCost;

            orderListBox.Items.Add("Large Chips\t\t\t\t£1.89");

            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401", MessageBoxButtons.OK);
                return;
            }
            else
            {
                totalCost += 1.89f;
                totalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void checkoutLabel_Click(object sender, EventArgs e)
        {
            float totalCost;

            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401", MessageBoxButtons.OK);
                return;
            }

            CheckoutScreen checkoutForm = new CheckoutScreen(totalCost, orderListBox, this);
            this.Hide();
            checkoutForm.Show();
        }

        public void clearList()
        {
            orderListBox.Items.Clear();
            totalCostTextBox.Text = "0.00";
        }
    }
}
