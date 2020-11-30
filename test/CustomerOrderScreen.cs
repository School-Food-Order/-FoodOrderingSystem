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

        KitchenLiveOrderScreen kitchenScreen;

        public OrderScreen(KitchenLiveOrderScreen kOrderScreen)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
        }

        private void burgerMealButton_Click(object sender, EventArgs e)
        {
            //Maybe have public interger to increment orderNumber?
            float totalCost;
            //create object to pass to kitchen screen
            Burger burger = new Burger();

            burger.NameOfItem = "Burger";
            burger.PriceOfItem = 2.49;

            orderListBox.Items.Add(burger.NameOfItem + " \t\t\t\t £" + burger.PriceOfItem);
            orderListBox.Items.Add("\tBurger");//Add obj of burger (for customisation)
            orderListBox.Items.Add("\tChips");//Add obj of chips
            orderListBox.Items.Add("\tRegular Coke");//Add obj of drink
           
            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401" ,MessageBoxButtons.OK);
                return;
            }else
            {
                totalCost += (float)(burger.PriceOfItem);
                totalCostTextBox.Text = totalCost.ToString();
            }

        }

        private void nuggetMealButton_Click(object sender, EventArgs e)
        {
            float totalCost;

            Food mealObj = new Food();
            mealObj.NameOfItem = "Nugget Meal";
            mealObj.PriceOfItem = 6.29;

            orderListBox.Items.Add(mealObj.NameOfItem + " \t\t\t\t £" + mealObj.PriceOfItem);
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
                totalCost += (float)(mealObj.PriceOfItem);
                totalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void chickenWrapButton_Click(object sender, EventArgs e)
        {
            float totalCost;

            Food mealObj = new Food();
            mealObj.NameOfItem = "Chicken wrap";
            mealObj.PriceOfItem = 5.50;

            orderListBox.Items.Add(mealObj.NameOfItem + " \t\t\t\t £" + mealObj.PriceOfItem);
            orderListBox.Items.Add("\tChips");
            orderListBox.Items.Add("\tRegular Coke");

            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401", MessageBoxButtons.OK);
                return;
            }
            else
            {
                totalCost += (float)(mealObj.PriceOfItem);
                totalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void largeChipsButton_Click(object sender, EventArgs e)
        {
            float totalCost;

            Food mealObj = new Food();
            mealObj.NameOfItem = "Large Chips";
            mealObj.PriceOfItem = 1.89;

            orderListBox.Items.Add(mealObj.NameOfItem + " \t\t\t\t £" + mealObj.PriceOfItem);

            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401", MessageBoxButtons.OK);
                return;
            }
            else
            {
                totalCost += (float)(mealObj.PriceOfItem);
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

            CheckoutScreen checkoutForm = new CheckoutScreen(totalCost, orderListBox, this, kitchenScreen);
            this.Hide();
            checkoutForm.Show();
        }

        public void clearList()
        {
            orderListBox.Items.Clear();
            totalCostTextBox.Text = "0.00";
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            kitchenScreen.Show();
        }

        private void orderScreenRemoveButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void burgerCustomize_Click(object sender, EventArgs e)
        {
            Burger burger = new Burger();
            BurgerCustomiseScreen bCustScreen = new BurgerCustomiseScreen(this, kitchenScreen);
            this.Hide();
            bCustScreen.Show();
        }
    }
}
