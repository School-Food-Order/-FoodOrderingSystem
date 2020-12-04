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
    public partial class ChipsCustomiseScreen : Form
    {

        KitchenLiveOrderScreen kitchenScreen;
        OrderScreen orderScreen;
        Chips chipsOrder = new Chips();

        public ChipsCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, Chips c)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            orderScreen = oS;
        }

        private void ChipsCustomiseScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                chipsCustomiseCheckBox.SetItemChecked(i, true);
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            chipsOrder.NameOfItem = "Chips";

            #region Storing items into Object
            if (chipsCustomiseCheckBox.GetItemChecked(0))
            {
                chipsOrder.ChipsSalt = true;
            }
            else
            {
                chipsOrder.ChipsSalt = false;
            }
            if (chipsCustomiseCheckBox.GetItemChecked(1))
            {
                chipsOrder.ChipsPepper = true;
            }
            else
            {
                chipsOrder.ChipsPepper = false;
            }
            if (chipsCustomiseCheckBox.GetItemChecked(2))
            {
                chipsOrder.ChipsCheese = true;
            }
            else
            {
                chipsOrder.ChipsCheese = false;
            }
            if (chipsCustomiseCheckBox.GetItemChecked(3))
            {
                chipsOrder.ChipsKetchupDip = true;
            }
            else
            {
                chipsOrder.ChipsKetchupDip = false;
            }

            #endregion Storing items into Object

            chipsOrder.PriceOfItem = chipsOrder.ReturnTotalCost();//adds up all the prices of each additional customisation
                                                                  //store This perticular item price to Price of item 
            orderScreen.AddToOrderList(chipsOrder);

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
