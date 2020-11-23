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

        Food[] foods;

        public KitchenLiveOrderScreen()
        {
            InitializeComponent();
        }

        private void rdyCollectionButton_Click(object sender, EventArgs e)
        {

        }

        private void orderToKitchen(Food[] f) 
        {
            int i=0;
            foreach (var item in f) 
            {
                foods[i] = item;
                i++;
            }
            addToList();
        }

        private void addToList() 
        {
            foreach (var item in foods) 
            {
                
            }
        }

        private void preparingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
