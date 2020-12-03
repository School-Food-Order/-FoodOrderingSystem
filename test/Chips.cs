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

        private const float _baseChipsCost = 2.49f;
        private const float _chipsCheeseCost = 0.50f;
        private const float _chipsKetchupDip = 0.00f;

        private bool chipsSalt = true;
        private bool chipsPepper = true;

        private bool chipsCheese = false;
        private bool chipsKetchupDip = false;

        #region BaseOptions
        public bool ChipsSalt
        {
            get { return chipsSalt; }
            set { chipsSalt = value; }
        }
        public bool ChipsPepper
        {
            get { return chipsPepper; }
            set { chipsPepper = value; }
        }

        #endregion BaseOptions

        #region ExtraOptions
        public bool ChipsCheese
        {
            get { return chipsCheese; }
            set { chipsCheese = value; }
        }
        public bool ChipsKetchupDip
        {
            get { return chipsKetchupDip; }
            set { chipsKetchupDip = value; }
        }

        #endregion ExtraOptions

        public float ReturnTotalCost()
        {
            //I could do this in switch case... but I don't like switch case
            float i = _baseChipsCost;
            if (ChipsCheese == true)
            {
                i = i + _chipsCheeseCost;
            }
            if (ChipsKetchupDip == true)
            {
                i = i + _chipsKetchupDip;
            }
            return i;
        }


        public List<string> ReturnAllCustomisation()
        {
            List<string> customisationList = new List<string>();
            //ref line 115

            #region AddingToList

            if (ChipsSalt == true)
            {
                customisationList.Add("Chips Salt,");
            }
            if (ChipsPepper == true)
            {
                customisationList.Add("Chips Pepper,");
            }

            //checking for extra custimisation
            if (ChipsCheese == true)
            {
                customisationList.Add("Chips Cheese,");
            }
            if (ChipsKetchupDip == true)
            {
                customisationList.Add("Ketchup Dip,");
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
