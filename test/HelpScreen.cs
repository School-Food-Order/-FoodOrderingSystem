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
    public partial class HelpScreen : Form
    {
        TakeoutSelectionScreen takeOutSelectionScreen;
        public HelpScreen(TakeoutSelectionScreen tS)
        {
            InitializeComponent();
            takeOutSelectionScreen = tS;
        }

        private void checkoutBackButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to go back?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                takeOutSelectionScreen.Show();
            }
            else
            {
                return;
            }
        }
    }
}
