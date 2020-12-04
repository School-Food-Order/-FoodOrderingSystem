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
    public partial class KitchenLiveOrderScreen : Form
    {
        private int orderNoCount;
        private List<Order> pastOrders = new List<Order>();

        public KitchenLiveOrderScreen()
        {
            InitializeComponent();
            orderNoCount = 0;
        }

        public int OrderNoCount
        {
            get { return orderNoCount; }
            set { orderNoCount = value; }
        }

        public void incrementOrderNo()
        {
            orderNoCount++;
        }


        private void rdyCollectionButton_Click(object sender, EventArgs e)
        {

        }

        public void orderToKitchen(Order order) 
        {
            pastOrders.Add(order);
            preparingListBox.Items.Add("Order " + order.OrderNo);
        }

        private void showOrderDetails(Order order) 
        {
            List<Food> foodList = order.FoodList;

            string foodItems;

            orderDetailsTextBox.Text = ("ORDERNO: " + order.OrderNo + "\r\nITEMS: \r\n");

            foreach (var item in foodList)
            {
                
                foodItems = item.NameOfItem;

                if (item is Burger burger)
                {
                    List<String> customisation = burger.ReturnAllCustomisation();
                    
                    orderDetailsTextBox.AppendText(">" + foodItems + "\r\n");
                    orderDetailsTextBox.AppendText("   Customisations: \r\n");
                    foreach (var customisations in customisation)
                    {
                        orderDetailsTextBox.AppendText("\t>" + customisations + "\r\n");
                    }
                }
                if (item is ChickenBox chickenBox)
                {
                    List<String> customisation = chickenBox.ReturnAllCustomisation();

                    orderDetailsTextBox.AppendText(">" + foodItems + "\r\n");
                    orderDetailsTextBox.AppendText("   Customisations: \r\n");
                    foreach (var customisations in customisation)
                    {
                        orderDetailsTextBox.AppendText("\t>" + customisations + "\r\n");
                    }
                }
                if (item is ChickenSub chickenSub)
                {
                    List<String> customisation = chickenSub.ReturnAllCustomisation();

                    orderDetailsTextBox.AppendText(">" + foodItems + "\r\n");
                    orderDetailsTextBox.AppendText("   Customisations: \r\n");
                    foreach (var customisations in customisation)
                    {
                        orderDetailsTextBox.AppendText("\t>" + customisations + "\r\n");
                    }
                }
                if (item is Chips chips)
                {
                    List<String> customisation = chips.ReturnAllCustomisation();

                    orderDetailsTextBox.AppendText(">" + foodItems + "\r\n");
                    orderDetailsTextBox.AppendText("   Customisations: \r\n");
                    foreach (var customisations in customisation)
                    {
                        orderDetailsTextBox.AppendText("\t>" + customisations + "\r\n");
                    }
                }
                if (item is Drink drink)
                {
                    List<String> customisation = drink.ReturnAllCustomisation();

                    orderDetailsTextBox.AppendText(">" + foodItems + "\r\n");
                    orderDetailsTextBox.AppendText("   Customisations: \r\n");
                    foreach (var customisations in customisation)
                    {
                        orderDetailsTextBox.AppendText("\t>" + customisations + "\r\n");
                    }
                }

            }
        }

        private void KitchenLiveOrderScreen_Load(object sender, EventArgs e)
        {
            TakeoutSelectionScreen takeOutScreen = new TakeoutSelectionScreen(this);
            CustomerLiveOrderScreen custOrderScreen = new CustomerLiveOrderScreen();
            custOrderScreen.Show();
            takeOutScreen.Show();
        }

        private void preparingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderDetailsTextBox.Clear(); // clears previous order details

            if (preparingListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                string currentlySelected = preparingListBox.SelectedItem.ToString();
                char[] charsToTrim = { 'O', 'r', 'd', 'e', ' ' };
                currentlySelected = currentlySelected.Trim(charsToTrim);
                int x = int.Parse(currentlySelected);


                foreach (var item in pastOrders)
                {
                    if (item.OrderNo == x)
                    {
                        showOrderDetails(item);
                    }
                }
            }
        }

        private void foodReadyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderDetailsTextBox.Clear(); // clears previous order details

            if (preparingListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                string currentlySelected = preparingListBox.SelectedItem.ToString();
                char[] charsToTrim = { 'O', 'r', 'd', 'e', ' ' };
                currentlySelected = currentlySelected.Trim(charsToTrim);
                int x = int.Parse(currentlySelected);


                foreach (var item in pastOrders)
                {
                    if (item.OrderNo == x)
                    {
                        showOrderDetails(item);
                    }
                }
            }
        }
    }
}
