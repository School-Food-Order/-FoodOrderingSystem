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
    public partial class DrinkCustomiseScreen : Form
    {

        KitchenLiveOrderScreen kitchenScreen;
        OrderScreen orderScreen;
        ChickenBox drink;

        public DrinkCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, Drink d)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            orderScreen = oS;
            drink = d;
        }

        private void DrinkCustomiseScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                drinkCustomiseCheckBox.SetItemChecked(i, true);
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (drinkCustomiseCheckBox.SelectedIndex == 1)
            {

            }

            orderScreen.Show();
            this.Dispose();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orderScreen.Show();
                this.Dispose();
            }
            else
            {
                return;
            }
        }
    }
}
