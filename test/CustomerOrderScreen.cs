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
        private int orderNo;
        KitchenLiveOrderScreen kitchenScreen;
        Order order;

        public OrderScreen(KitchenLiveOrderScreen kOrderScreen, Order orderObject)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            order = orderObject;
        }

        private void burgerMealButton_Click(object sender, EventArgs e)
        {
            //Maybe have public interger to increment orderNumber?
            float totalCost = float.Parse(totalCostTextBox.Text);
            //create object to pass to kitchen screen
            Burger burger = new Burger();
            //setting name of item
            burger.NameOfItem = "Burger";
            burger.PriceOfItem = 2.49f;
            order.addItem(burger);

            orderListBox.Items.Add(burger.NameOfItem + " \t\t\t\t\t £" + burger.PriceOfItem);

            totalCost += (float)(burger.PriceOfItem);
            totalCostTextBox.Text = totalCost.ToString();
        }


        private void chickenBoxButton_Click(object sender, EventArgs e)
        {
            float totalCost = float.Parse(totalCostTextBox.Text);

            ChickenBox chickenItem = new ChickenBox();
            chickenItem.NameOfItem = "Chicken Box";
            chickenItem.PriceOfItem = 6.29f;
            order.addItem(chickenItem);

            orderListBox.Items.Add(chickenItem.NameOfItem + " \t\t\t\t £" + chickenItem.PriceOfItem);

            totalCost += (float)(chickenItem.PriceOfItem);
            totalCostTextBox.Text = totalCost.ToString();
        }
    

        private void chickenWrapButton_Click(object sender, EventArgs e)
        {
            //grabbing current total cost from total text box
            float totalCost = float.Parse(totalCostTextBox.Text);

            //creating setting name and price of object
            ChickenSub chickenSubItem = new ChickenSub();
            chickenSubItem.NameOfItem = "Chicken Sub";
            chickenSubItem.PriceOfItem = 3.39f;
            order.addItem(chickenSubItem);
            
            //adding to customer order list
            orderListBox.Items.Add(chickenSubItem.NameOfItem + " \t\t\t\t £" + chickenSubItem.PriceOfItem.ToString());
            
            //adding cost of item to total
            totalCost += (float)(chickenSubItem.PriceOfItem);
            totalCostTextBox.Text = totalCost.ToString();
         }
        
        
        private void chipsButton_Click(object sender, EventArgs e)
        {
            float totalCost = float.Parse(totalCostTextBox.Text);

            //creating setting name and price of object
            Chips chipsItem = new Chips();
            chipsItem.NameOfItem = "Medium Chips";
            chipsItem.PriceOfItem = 1.69f;
            order.addItem(chipsItem);

            //adding to customer order list
            orderListBox.Items.Add(chipsItem.NameOfItem + " \t\t\t\t £" + chipsItem.PriceOfItem);

            //adding cost of item to total
            totalCost += (float)(chipsItem.PriceOfItem);
            totalCostTextBox.Text = totalCost.ToString();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            float totalCost = float.Parse(totalCostTextBox.Text);

            CheckoutScreen checkoutForm = new CheckoutScreen(totalCost, orderListBox, order, this, kitchenScreen);
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

        public void AddToOrderList(Food mealObj)
        {
            List<string> customisationList;
            float totalCost = float.Parse(totalCostTextBox.Text);


            if (mealObj is Burger burger)
            {
                customisationList = burger.ReturnAllCustomisation();
                totalCost += (float)(burger.PriceOfItem);
                order.addItem(burger);
                totalCostTextBox.Text = totalCost.ToString();
                orderListBox.Items.Add(burger.NameOfItem + " \t\t\t\t £" + burger.PriceOfItem);
            }

            if (mealObj is ChickenSub chickenSub)
            {
                customisationList = chickenSub.ReturnAllCustomisation();
                totalCost += (float)(chickenSub.PriceOfItem);
                order.addItem(chickenSub);
                totalCostTextBox.Text = totalCost.ToString();
                orderListBox.Items.Add(chickenSub.NameOfItem + " \t\t\t £" + chickenSub.PriceOfItem);
            }

            if (mealObj is ChickenBox chickenBox)
            {
                customisationList = chickenBox.ReturnAllCustomisation();
                totalCost += (float)(chickenBox.PriceOfItem);
                order.addItem(chickenBox);
                totalCostTextBox.Text = totalCost.ToString();
                orderListBox.Items.Add(chickenBox.NameOfItem + " \t\t\t £" + chickenBox.PriceOfItem);
            }
            if (mealObj is Chips chips)
            {
                customisationList = chips.ReturnAllCustomisation();
                totalCost += (float)(chips.PriceOfItem);
                order.addItem(chips);
                totalCostTextBox.Text = totalCost.ToString();
                orderListBox.Items.Add(chips.NameOfItem + " \t\t\t\t £" + chips.PriceOfItem);
            }
            if (mealObj is Drink drink)
            {
                customisationList = drink.ReturnAllCustomisation();
                totalCost += (float)(drink.PriceOfItem);
                order.addItem(drink);
                totalCostTextBox.Text = totalCost.ToString();
                orderListBox.Items.Add(drink.NameOfItem + " \t\t\t £" + drink.PriceOfItem);
            }

        }

        private void orderScreenRemoveButton_Click_1(object sender, EventArgs e)
        {
            orderListBox.Items.Remove(orderListBox.SelectedItem);
        }

        private void burgerCustomize_Click(object sender, EventArgs e)
        {
            Burger burger = new Burger();
            SubCustomiseScreen bCustomiseScreen = new SubCustomiseScreen(this, kitchenScreen, burger);
            this.Hide();
            bCustomiseScreen.Show();
        }

        private void chickenBoxCustomise_Click(object sender, EventArgs e)
        {
            ChickenBox chickenBox = new ChickenBox();
            ChickenBoxCustomiseScreen customiseChickenScreen = new ChickenBoxCustomiseScreen(this, kitchenScreen, chickenBox);
            this.Hide();
            customiseChickenScreen.Show();
        }

        private void friesCustomise_Click(object sender, EventArgs e)
        {
            Chips chips = new Chips();
            ChipsCustomiseScreen customiseChipsScreen = new ChipsCustomiseScreen(this, kitchenScreen, chips);
            this.Hide();
            customiseChipsScreen.Show();
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            float totalCost;

            Drink drinkItem = new Drink();
            drinkItem.NameOfItem = "Medium Coke";
            drinkItem.PriceOfItem = 1.69f;
            orderListBox.Items.Add(drinkItem.NameOfItem + " \t\t\t\t £" + drinkItem.PriceOfItem);

            if (!float.TryParse(totalCostTextBox.Text, out totalCost))
            {
                MessageBox.Show("This is a number only field", "Error401", MessageBoxButtons.OK);
                return;
            }
            else
            {
                totalCost += (float)(drinkItem.PriceOfItem);
                totalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void drinkCustomiseButton_Click(object sender, EventArgs e)
        {
            Drink drink = new Drink();
            DrinkCustomiseScreen customiseDrinkScreen = new DrinkCustomiseScreen(this, kitchenScreen, drink);//this, kitchenScreen, drink
            this.Hide();
            customiseDrinkScreen.Show();
        }

        private void chickenSubCustomise_Click(object sender, EventArgs e)
        {
            ChickenSub chickenSub = new ChickenSub();
            ChickenSubCustomiseScreen customiseChickenSubScreen = new ChickenSubCustomiseScreen(this, kitchenScreen, chickenSub);
            this.Hide();
            customiseChickenSubScreen.Show();
        }
    }
}
