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
    public partial class ChickenBoxCustomiseScreen : Form
    {

        KitchenLiveOrderScreen kitchenScreen;
        OrderScreen orderScreen;
        ChickenBox chickenBoxMeal = new ChickenBox();//this is where i declare the object

        public ChickenBoxCustomiseScreen(OrderScreen oS, KitchenLiveOrderScreen kOrderScreen, ChickenBox c)
        {
            InitializeComponent();
            kitchenScreen = kOrderScreen;
            orderScreen = oS;
            chickenBoxMeal = c;
        }

        private void ChickenCustomiseScreen_Load(object sender, EventArgs e)
        {


            
            for (int i = 0; i < 4; i++)
            {
                chickenCustomizeCheckBox.SetItemChecked(i, true);//this shows that checkbox is selected
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            chickenBoxMeal.NameOfItem = "Chicken Box";

            //need to use .GetItemChecked(index) to retrieve check state (returns true/false)
            #region Storing items into Object
            if (chickenCustomizeCheckBox.GetItemChecked(0))
            {
                chickenBoxMeal.ChickenWings = true;
            }
            else
            {
                chickenBoxMeal.ChickenWings = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(1))
            {
                chickenBoxMeal.ChickenBreast = true;
            }
            else
            {
                chickenBoxMeal.ChickenBreast = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(2))
            {
                chickenBoxMeal.ChickenDrumstick = true;
            }
            else
            {
                chickenBoxMeal.ChickenDrumstick = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(3))
            {
                chickenBoxMeal.ChickenPopcorn = true;
            }
            else
            {
                chickenBoxMeal.ChickenPopcorn = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(4))
            {
                chickenBoxMeal.DipKetchup = true;
            }
            else
            {
                chickenBoxMeal.DipKetchup = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(5))
            {
                chickenBoxMeal.DipBBQ = true;
            }
            else
            {
                chickenBoxMeal.DipBBQ = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(6))
            {
                chickenBoxMeal.DipSweetChili = true;
            }
            else
            {
                chickenBoxMeal.DipSweetChili = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(7))
            {
                chickenBoxMeal.DipCurry = true;
            }
            else
            {
                chickenBoxMeal.DipCurry = false;
            }
            if (chickenCustomizeCheckBox.GetItemChecked(7))
            {
                chickenBoxMeal.DipGravy = true;
            }
            else
            {
                chickenBoxMeal.DipGravy = false;
            }

            #endregion Storing items into Object

            chickenBoxMeal.PriceOfItem = chickenBoxMeal.ReturnTotalCost();  //adds up all the prices of each additional customisation
                                                                            //store This perticular item price to Price of item             
                              
            orderScreen.AddToOrderList(chickenBoxMeal);


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

        private void chickenCustomizeCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
