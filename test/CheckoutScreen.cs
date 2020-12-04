using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class CheckoutScreen : Form
    {

        OrderScreen orderScreen;
        KitchenLiveOrderScreen kitchenScreen;
        CustomerLiveOrderScreen customerScreen;
        Order order;

        public CheckoutScreen(float total, ListBox list, Order orderObject, OrderScreen oScreen, KitchenLiveOrderScreen kOScreen, CustomerLiveOrderScreen custScreenObject)
        {
            InitializeComponent();
            totalTextBox.Text = total.ToString();
            string text = "";
            foreach (var item in list.Items)
            {
                text = item.ToString(); // /n to print each item on new line or you omit /n to print text on same line
                checkoutListBox.Items.Add(text);
            }
            order = orderObject;
            orderScreen = oScreen;
            kitchenScreen = kOScreen;
            customerScreen = custScreenObject;
        }


        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //Order Confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to place this order?", "Order Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //user said yes order goes through

                //pass order to kitchen
                kitchenScreen.orderToKitchen(order);
                customerScreen.orderToCustomer(order);
                
                //@"C:\Users\Public\Documents\"+order.OrderNo+".txt"
                //saveFile.Filter = "Text (*.txt)|*.txt";
                var saveFile = new SaveFileDialog();
                saveFile.FileName = @"C:\Users\Public\Documents\OrderNumber_" + order.OrderNo + ".txt";

                //if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{

                //}

                using (var sw = new StreamWriter(saveFile.FileName, false))
                {
                    sw.WriteLine("Order Number: " + order.OrderNo);
                    foreach (var item in checkoutListBox.Items)
                    {
                        sw.Write(item.ToString() + Environment.NewLine);
                    }
                    sw.Write("Total Cost: £" + totalTextBox.Text);
                }
                MessageBox.Show("Receipt is being printed");


                


                TakeoutSelectionScreen takeOutScreen = new TakeoutSelectionScreen(kitchenScreen, customerScreen);

                MessageBox.Show("Thank-you for placing your order, it has been sent to the kitchen to be prepared!", "Order Confirmation", MessageBoxButtons.OK);

                orderScreen.Dispose();
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