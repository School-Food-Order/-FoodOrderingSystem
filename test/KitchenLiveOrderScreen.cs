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
    public partial class KitchenLiveOrderScreen : Form
    {
        private int orderNoCount;

        public KitchenLiveOrderScreen()
        {
            InitializeComponent();
            orderNoCount = 0;
        }

        public int OrderNoCount
        {
            get { return orderNoCount; }
            set { orderNoCount = value; }
        }

        public void incrementOrderNo()
        {
            orderNoCount++;
        }


        private void rdyCollectionButton_Click(object sender, EventArgs e)
        {

        }

        public void orderToKitchen(Order order) 
        {
            preparingListBox.Items.Add("Order " + order.OrderNo.ToString());
        }

        private void addToList() 
        {

        }

        private void KitchenLiveOrderScreen_Load(object sender, EventArgs e)
        {
            TakeoutSelectionScreen takeOutScreen = new TakeoutSelectionScreen(this);
            takeOutScreen.Show();
        }

        private void preparingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
