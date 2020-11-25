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
    public partial class takeoutSelection : Form
    {
        public takeoutSelection()
        {
            InitializeComponent();
        }
        
        OrderScreen orderScreen = new OrderScreen();

        private void eatInButton_Click(object sender, EventArgs e)
        {
            int tableNumber = Int32.Parse(tableNumberButton.Text);

            this.Hide();
            orderScreen.Show();
        }

        private void takeoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderScreen.Show();
        }
    }
}
