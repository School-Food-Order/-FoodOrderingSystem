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

        public TakeoutSelectionScreen(KitchenLiveOrderScreen kOrderScreen)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
        }
        
        private void eatInButton_Click(object sender, EventArgs e)
        {

            OrderScreen orderScreen = new OrderScreen(kitchenScreen);

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
            OrderScreen orderScreen = new OrderScreen(kitchenScreen);
            orderScreen.Show();
            this.Dispose();
        }
    }
}
