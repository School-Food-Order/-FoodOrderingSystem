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
    public partial class TakeoutSelectionScreen : Form
    {

        KitchenLiveOrderScreen kitchenScreen;
        CustomerLiveOrderScreen customerScreen;

        public TakeoutSelectionScreen(KitchenLiveOrderScreen kOrderScreen, CustomerLiveOrderScreen customerLiveScrenObject)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            customerScreen = customerLiveScrenObject;
            kOrderScreen.incrementOrderNo();
        }
        
        private void eatInButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(kitchenScreen);
            OrderScreen orderScreen = new OrderScreen(kitchenScreen, customerScreen, order);

            if (!int.TryParse(tableNumberTextBox.Text, out int tableNumber))
            {
                MessageBox.Show("Please enter your table number :)");
                return;
            }

            orderScreen.Show();
            this.Dispose();
        }

        private void takeoutButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(kitchenScreen);
            OrderScreen orderScreen = new OrderScreen(kitchenScreen, customerScreen, order);
            orderScreen.Show();
            this.Dispose();
        }
    }
}
