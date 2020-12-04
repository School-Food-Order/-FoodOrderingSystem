using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Drink:Food
    {

        //Has access 4 items of FoodMeal:
        //OrderNumbber
        //PriceOfItem
        //NameOfItem
        //ItemCount


        //Current prices
        private const float _baseDrinkCost = 1.49f;
        private const float _mediumDrinkCost = 1.69f;
        private const float _largeDrinkCost = 1.89f;


        #region BoolsForBurger

        //Default options are true
        private bool drinkIce = true;
        private bool drinkSizeSmall = true;

        //additional options are false
        private bool drinkExtraIce = false;
        private bool drinkSizeMed = false;
        private bool drinkSizeLrg = false;


        #endregion BoolsForBurgers


        //BaseOptions
        #region BaseOptions

        public bool DrinkIce
        {
            get { return drinkIce; }
            set { drinkIce = value; }
        }

        public bool DrinkSizeSmall
        {
            get { return drinkSizeSmall; }
            set { drinkSizeSmall = value; }
        }

        #endregion BaseOptions

        //ExtraOptions
        #region ExtraOptions
        public bool DrinkExtraIce
        {
            get { return drinkExtraIce; }
            set { drinkExtraIce = value; }
        }
        public bool DrinkSizeMed
        {
            get { return drinkSizeMed; }
            set { drinkSizeMed = value; }
        }
        public bool DrinkSizeLrg
        {
            get { return drinkSizeLrg; }
            set { drinkSizeLrg = value; }
        }
 
        #endregion ExtraOptions


        public float ReturnTotalCost()
        {
            //I could do this in switch case... but I don't like switch case
            float i = _baseDrinkCost;
            
            if (drinkSizeSmall == true)
            {
                i = _baseDrinkCost;
            }
            if (drinkSizeMed == true)
            {
                i = _mediumDrinkCost;
            }
            if (drinkSizeLrg == true)
            {
                i = _largeDrinkCost;
            }
            return i;
        }

        public List<string> ReturnAllCustomisation()
        {
            List<string> customisationList = new List<string>();
            //ref line 115

            #region AddingToList
            if (DrinkIce == true)
            {
                customisationList.Add("Drink Ice,");
            }
            if (DrinkSizeSmall == true)
            {
                customisationList.Add("Drink size Small,");
            }
            //Extra options
            if (DrinkExtraIce == true)
            {
                customisationList.Add("Drink Extra Ice,");
            }
            if (DrinkSizeMed == true)
            {
                customisationList.Add("Drink size Medium,");
            }
            if (DrinkSizeLrg == true)
            {
                customisationList.Add("Drink size Large,");
            }

            #endregion AddingToList

            if (customisationList == null)
            {
                customisationList.Add("Error Has Occurred");
                return customisationList;
            }
            else
            {
                return customisationList;
            }
        }

    }
}
