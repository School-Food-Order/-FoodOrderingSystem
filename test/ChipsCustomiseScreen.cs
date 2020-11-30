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
        Chips chips;

        public ChipsCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, Chips c)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            orderScreen = oS;
            chips = c;
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
            if (chipsCustomiseCheckBox.SelectedIndex == 1)
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
