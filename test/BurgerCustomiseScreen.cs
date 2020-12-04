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
    public partial class SubCustomiseScreen : Form
    {

        KitchenLiveOrderScreen kitchenScreen;
        OrderScreen orderScreen;
        Burger burgerItem = new Burger();

        public SubCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, Burger b)
        {
            InitializeComponent();
            orderScreen = oS;
            kitchenScreen = kOrderScreen;
            burgerItem = b;
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
            burgerItem.NameOfItem = "Burger*CUSTOM*";

            #region Storing items into Object


            if (burgerCustomiseCheckBox.GetItemChecked(0))
            {
                burgerItem.BurgerBeefPatty = true;
            }
            else
            {
                burgerItem.BurgerBeefPatty = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(1))
            {
                burgerItem.BurgerCheese = true;
            }
            else
            {
                burgerItem.BurgerCheese = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(2))
            {
                burgerItem.BurgerPickles = true;
            }
            else
            {
                burgerItem.BurgerPickles = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(3))
            {
                burgerItem.BurgerOnions = true;
            }
            else
            {
                burgerItem.BurgerOnions = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(4))
            {
                burgerItem.BurgerKetchup = true;
            }
            else
            {
                burgerItem.BurgerKetchup = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(5))
            {
                burgerItem.BurgerBreadRoll= true;
            }
            else
            {
                burgerItem.BurgerBreadRoll = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(6))
            {
                burgerItem.BurgerExtraBeefPatty = true;
            }
            else
            {
                burgerItem.BurgerExtraBeefPatty = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(7))
            {
                burgerItem.BurgerExtraCheese = true;
            }
            else
            {
                burgerItem.BurgerExtraCheese = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(8))
            {
                burgerItem.BurgerExtraPickles = true;
            }
            else
            {
                burgerItem.BurgerExtraPickles = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(9))
            {
                burgerItem.BurgerExtraOnions = true;
            }
            else
            {
                burgerItem.BurgerExtraOnions = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(10))
            {
                burgerItem.BurgerExtraKetchup = true;
            }
            else
            {
                burgerItem.BurgerExtraKetchup = false;
            }
            #endregion Storing items into Object

            burgerItem.PriceOfItem = burgerItem.ReturnTotalCost();//adds up all the prices of each additional customisation
                                                                    //store This perticular item price to Price of item 
                                                                    //chickenBoxMeal.ReturnAllCustomisation <-- sends an item list with all customisations

            orderScreen.AddToOrderList(burgerItem);

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
