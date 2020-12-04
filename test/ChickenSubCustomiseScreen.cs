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
    public partial class ChickenSubCustomiseScreen : Form
    {
        KitchenLiveOrderScreen kitchenScreen;
        OrderScreen orderScreen;
        ChickenSub chickenSubItem = new ChickenSub();

        public ChickenSubCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, ChickenSub cs)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            orderScreen = oS;
            chickenSubItem = cs;
        }
        private void ChickenSubCustomiseScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                ChickenSubCustomiseCheckBox.SetItemChecked(i, true);
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            chickenSubItem.NameOfItem = "Chicken Sub*CUSTOM*";
            #region Storing items into Object



            if (ChickenSubCustomiseCheckBox.GetItemChecked(0))
            {
                chickenSubItem.ChickenSubChickenTenders = true;
            }
            else
            {
                chickenSubItem.ChickenSubChickenTenders = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(1))
            {
                chickenSubItem.ChickenSubAmericanCheese = true;
            }
            else
            {
                chickenSubItem.ChickenSubAmericanCheese = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(2))
            {
                chickenSubItem.ChickenSubLettuce = true;
            }
            else
            {
                chickenSubItem.ChickenSubLettuce =false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(3))
            {
                chickenSubItem.ChickenSubCucumber = true;
            }
            else
            {
                chickenSubItem.ChickenSubCucumber = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(4))
            {
                chickenSubItem.ChickenSubSweetChiliSauce = true;
            }
            else
            {
                chickenSubItem.ChickenSubSweetChiliSauce = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(5))
            {
                chickenSubItem.ChickenSubBageutteRoll = true;
            }
            else
            {
                chickenSubItem.ChickenSubBageutteRoll = false;
            }
           
            //Extra Option
            if (ChickenSubCustomiseCheckBox.GetItemChecked(6))
            {
                chickenSubItem.ChickenSubExtraChickenTenders = true;
            }
            else
            {
                chickenSubItem.ChickenSubExtraChickenTenders = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(7))
            {
                chickenSubItem.ChickenSubExtraAmericanCheese = true;
            }
            else
            {
                chickenSubItem.ChickenSubExtraAmericanCheese = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(8))
            {
                chickenSubItem.ChickenSubExtraLettuce = true;
            }
            else
            {
                chickenSubItem.ChickenSubExtraLettuce = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(9))
            {
                chickenSubItem.ChickenSubExtraCucumber = true;
            }
            else
            {
                chickenSubItem.ChickenSubExtraCucumber = false;
            }
            if (ChickenSubCustomiseCheckBox.GetItemChecked(10))
            {
                chickenSubItem.ChickenSubExtraChiliSauce = true;
            }
            else
            {
                chickenSubItem.ChickenSubExtraChiliSauce = false;
            }
            #endregion Storing items into Object
            chickenSubItem.PriceOfItem = chickenSubItem.ReturnTotalCost();//adds up all the prices of each additional customisation
                                                                  //store This perticular item price to Price of item 
                                                                  //chickenBoxMeal.ReturnAllCustomisation <-- sends an item list with all customisations

            orderScreen.AddToOrderList(chickenSubItem);

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
