using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Chips:Food
    {
        //Has access 4 items of FoodMeal:
        //OrderNumbber
        //PriceOfItem
        //NameOfItem
        //ItemCount

        private bool chipsExtraVinigar;
        private bool chipsExtraSalt;

        public bool ChipsExtraVinigar
        { 
            get { return chipsExtraVinigar; } 
            set { chipsExtraVinigar = value; }
        }
        public bool ChipsExtraSalt
        {
            get { return chipsExtraSalt; }
            set { chipsExtraSalt = value; }
        }

    }
}
