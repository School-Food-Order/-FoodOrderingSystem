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

        private bool burgerExtraCheese;//Add price later
        private bool burgerExtraKetchup;//Add price later
        private bool burgerExtraPatty;//Add price later

        private bool burgerHasPickles;
        private bool burgerHasOnions;

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
        public bool BurgerExtraPatty
        {
            get { return burgerExtraPatty; }
            set { burgerExtraPatty = value; }
        }
        public bool BurgerHasPickles
        {
            get { return burgerHasPickles; }
            set { burgerHasPickles = value; }
        }
        public bool BurgerHasOnions
        {
            get { return burgerHasOnions; }
            set { burgerHasOnions = value; }
        }

        //private bool mealContainsChips;
        //private bool mealContainsCoke;

    }
}
