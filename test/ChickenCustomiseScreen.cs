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
    public partial class ChickenCustomiseScreen : Form
    {

        KitchenLiveOrderScreen kitchenScreen;
        OrderScreen orderScreen;
        Burger b;

        public ChickenCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            orderScreen = oS;
        }

        private void ChickenCustomiseScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                chickenCustomizeCheckBox.SetItemChecked(i, true);
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (chickenCustomizeCheckBox.SelectedIndex == 1)
            {

            }

            orderScreen.Show();
            this.Dispose();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?","", MessageBoxButtons.YesNo);
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
