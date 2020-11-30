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
    public partial class BurgerCustomiseScreen : Form
    {

        KitchenLiveOrderScreen kitchenScreen;
        OrderScreen orderScreen;
        Burger b;

        public BurgerCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen)
        {
            InitializeComponent();
            orderScreen = oS;
            kitchenScreen = kOrderScreen;
        }

        private void BurgerCustomiseScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                burgerCustomiseCheckBox.SetItemChecked(i, true);
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (burgerCustomiseCheckBox.SelectedIndex == 1)
            {

            }

            orderScreen.Show();
            this.Dispose();
        }

    }
}
