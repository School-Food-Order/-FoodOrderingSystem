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
        Burger burgerOrder = new Burger();

        public BurgerCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, Burger b)
        {
            InitializeComponent();
            orderScreen = oS;
            kitchenScreen = kOrderScreen;
            burgerOrder = b;
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
            #region Storing items into Object
           
            if (burgerCustomiseCheckBox.GetItemChecked(0))
            {
                burgerOrder.BurgerBeefPatty = true;
            }
            else
            {
                burgerOrder.BurgerBeefPatty = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(1))
            {
                burgerOrder.BurgerCheese = true;
            }
            else
            {
                burgerOrder.BurgerCheese = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(2))
            {
                burgerOrder.BurgerPickles = true;
            }
            else
            {
                burgerOrder.BurgerPickles = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(3))
            {
                burgerOrder.BurgerOnions = true;
            }
            else
            {
                burgerOrder.BurgerOnions = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(4))
            {
                burgerOrder.BurgerKetchup = true;
            }
            else
            {
                burgerOrder.BurgerKetchup = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(5))
            {
                burgerOrder.BurgerBreadRoll= true;
            }
            else
            {
                burgerOrder.BurgerBreadRoll = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(6))
            {
                burgerOrder.BurgerExtraBeefPatty = true;
            }
            else
            {
                burgerOrder.BurgerExtraBeefPatty = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(7))
            {
                burgerOrder.BurgerExtraCheese = true;
            }
            else
            {
                burgerOrder.BurgerExtraCheese = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(8))
            {
                burgerOrder.BurgerExtraPickles = true;
            }
            else
            {
                burgerOrder.BurgerExtraPickles = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(9))
            {
                burgerOrder.BurgerExtraOnions = true;
            }
            else
            {
                burgerOrder.BurgerExtraOnions = false;
            }
            if (burgerCustomiseCheckBox.GetItemChecked(10))
            {
                burgerOrder.BurgerExtraKetchup = true;
            }
            else
            {
                burgerOrder.BurgerExtraKetchup = false;
            }
            #endregion Storing items into Object

            burgerOrder.PriceOfItem = burgerOrder.ReturnTotalCost();//adds up all the prices of each additional customisation
                                                                    //store This perticular item price to Price of item 
                                                                    //chickenBoxMeal.ReturnAllCustomisation <-- sends an item list with all customisations

            orderScreen.AddToOrderList(burgerOrder);

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
