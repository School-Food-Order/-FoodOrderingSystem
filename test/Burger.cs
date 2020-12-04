using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Burger:Food
    {
        //Has access 4 items of FoodMeal:
        //OrderNumbber
        //PriceOfItem
        //NameOfItem
        //ItemCount

        
        //Current prices
        private const float _baseBurgerCost = 2.49f;
        private const float _extraBeefPattyCost = 0.89f;
        private const float _extraCheeseCost = 0.20f;
        private const float _extraPicklesCost = 0.25f;
        private const float _extraOnionsCost = 0.25f;
        private const float _extraKetchupCost = 0f;

        #region BoolsForBurger

        //Default options are true
        private bool burgerBeefPatty = true;
        private bool burgerCheese = true;
        private bool burgerPickles = true;
        private bool burgerOnions = true;
        private bool burgerKetchup = true;
        private bool burgerBreadRoll = true;

        //Default options are false
        private bool burgerExtraBeefPatty = false;
        private bool burgerExtraCheese = false;
        private bool burgerExtraKetchup = false;
        private bool burgerExtraPickles = false;
        private bool burgerExtraOnions = false;

        #endregion BoolsForBurgers


        //BaseOptions
        #region BaseOptions

        public bool BurgerBeefPatty
        {
            get { return burgerBeefPatty; }
            set { burgerBeefPatty = value; }
        }
        public bool BurgerCheese
        {
            get { return burgerCheese; }
            set { burgerCheese = value; }
        }
        public bool BurgerPickles
        {
            get { return burgerPickles; }
            set { burgerPickles = value; }
        }
        public bool BurgerOnions
        {
            get { return burgerOnions; }
            set { burgerOnions = value; }
        }
        public bool BurgerKetchup
        {
            get { return burgerKetchup; }
            set { burgerKetchup = value; }
        }
        public bool BurgerBreadRoll
        {
            get { return burgerBreadRoll; }
            set { burgerBreadRoll = value; }
        }

        #endregion BaseOptions

        //ExtraOptions
        #region ExtraOptions
        public bool BurgerExtraBeefPatty
        {
            get { return burgerExtraBeefPatty; }
            set { burgerExtraBeefPatty = value; }
        }
        public bool BurgerExtraCheese
        {
            get { return burgerExtraCheese; }
            set { burgerExtraCheese = value; }
        }
        public bool BurgerExtraKetchup
        {
            get { return burgerExtraKetchup; }
            set { burgerExtraKetchup = value; }
        }
        public bool BurgerExtraPickles
        {
            get { return burgerExtraPickles; }
            set { burgerExtraPickles = value; }
        }
        public bool BurgerExtraOnions
        {
            get { return burgerExtraOnions; }
            set { burgerExtraOnions = value; }
        }
        #endregion ExtraOptions
        


        public float ReturnTotalCost()
        {
            //I could do this in switch case... but I don't like switch case
            float i = _baseBurgerCost;
            if (BurgerExtraBeefPatty == true)
            {
                i = i + _extraBeefPattyCost;
            }
            if (BurgerExtraCheese == true)
            {
                i = i + _extraCheeseCost;
            }
            if (BurgerExtraPickles ==true)
            {
                i = i + _extraPicklesCost;
            }
            if (BurgerExtraOnions)
            {
                i = i + _extraOnionsCost;
            }
            if (BurgerExtraKetchup == true)
            {
                i = i + _extraKetchupCost;
            }
            return i;
        }

        public List<string> ReturnAllCustomisation()
        {
            List<string> customisationList = new List<string>();
            //ref line 115

            #region AddingToList

            if (BurgerBeefPatty == true)
            {
                customisationList.Add("BeefPatty");
                //they can have base: (BeefPatty =! true && ExtraBeefPatty == true), so we have to check individually 
            }
            if (BurgerCheese == true)
            {
                customisationList.Add("Cheese");
            }
            if (BurgerPickles== true)
            {
                customisationList.Add("Pickles");
            }
            if (BurgerOnions == true)
            {
                customisationList.Add("Onions");
            }
            if (BurgerKetchup == true)
            {
                customisationList.Add("Ketchup");
            }
            if (BurgerBreadRoll == true)
            {
                customisationList.Add("BreadRoll");
            }
            //checking for extra customisation
            if (BurgerExtraBeefPatty == true)
            {
                customisationList.Add("ExtraBeefPatty");
            }
            if (BurgerExtraCheese == true)
            {
                customisationList.Add("ExtraCheese");
            }
            if (BurgerExtraPickles == true)
            {
                customisationList.Add("ExtraPickles");
            }
            if (BurgerExtraOnions)
            {
                customisationList.Add("ExtraOnions");
            }
            if (BurgerExtraKetchup == true)
            {
                customisationList.Add("ExtraKetchup");
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
