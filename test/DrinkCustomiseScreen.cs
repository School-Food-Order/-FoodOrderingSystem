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
        Drink drinkItem = new Drink();

        public DrinkCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen)
        {
            //DrinkCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, Drink d)
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            orderScreen = oS;
        }

        private void DrinkCustomiseScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                drinkCustomiseCheckBox.SetItemChecked(i, true);
            }
            smallRadioButton.Checked = true;

        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            //need to check radio buttons

            #region Storing items into Object
            if (smallRadioButton.Checked == true)
            {
                drinkItem.DrinkSizeSmall = true;
                drinkItem.DrinkSizeMed = false;
                drinkItem.DrinkSizeLrg = false;
            }
            else if (mediumRadioButton.Checked == true)
            {
                drinkItem.DrinkSizeSmall = false;
                drinkItem.DrinkSizeMed = true;
                drinkItem.DrinkSizeLrg = false;
            }
            else if (largeRadioButton.Checked == true)
            {
                drinkItem.DrinkSizeSmall = false;
                drinkItem.DrinkSizeMed = false;
                drinkItem.DrinkSizeLrg = true;
            }

            if (drinkCustomiseCheckBox.GetItemChecked(0))
            {
                drinkItem.DrinkIce = true;
            }
            else
            {
                drinkItem.DrinkIce = false;
            }
            if (drinkCustomiseCheckBox.GetItemChecked(1))
            {
                drinkItem.DrinkExtraIce = true;
            }
            else
            {
                drinkItem.DrinkExtraIce = false;
            }
            #endregion Storing items into Object



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
