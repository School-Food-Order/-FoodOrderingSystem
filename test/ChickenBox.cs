using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ChickenBox:Food
    {
        //Has access 4 items of FoodMeal:
        //OrderNumbber
        //PriceOfItem
        //NameOfItem
        //ItemCount
        private const float _baseChickenBoxCost = 6.29f;
        private const float _dipKetchupCost = 0f;
        private const float _dipBBQCost = 0f;
        private const float _dipSweetChiliCost = 0f;
        private const float _dipCurryCost = 0f;
        private const float _dipGravyCost = 0.20f;


        private bool chickenWings = true;
        private bool chickenBreast = true;
        private bool chickenDrumstick = true;
        private bool chickenPopcorn = true; //It's names Popcorn Chicken on form

        private bool dipKetchup = false;
        private bool dipBBQ = false;
        private bool dipSweetChili = false;
        private bool dipCurry = false;
        private bool dipGravy = false;
     

        #region BaseOptions
        public bool ChickenWings
        {
            get { return chickenWings; }
            set { chickenWings = value; }
        }
        public bool ChickenBreast
        {
            get { return chickenBreast; }
            set { chickenBreast = value; }
        }
        public bool ChickenDrumstick
        {
            get { return chickenDrumstick; }
            set { chickenDrumstick = value; }
        }
        public bool ChickenPopcorn
        {
            get { return chickenPopcorn; }
            set { chickenPopcorn = value; }
        }

        #endregion BaseOptions

        #region ExtraOptions
        public bool DipKetchup
        {
            get { return dipKetchup; }
            set { dipKetchup = value; }
        }
        public bool DipBBQ
        {
            get { return dipBBQ; }
            set { dipBBQ = value; }
        }
        public bool DipSweetChili
        {
            get { return dipSweetChili; }
            set { dipSweetChili = value; }
        }
        public bool DipCurry
        {
            get { return dipCurry; }
            set { dipCurry = value; }
        }
        public bool DipGravy
        {
            get { return dipGravy; }
            set { dipGravy = value; }
        }

        #endregion ExtraOptions

        public float ReturnTotalCost()
        {
            float i = _baseChickenBoxCost;
            if (DipKetchup == true)
            {
                i = i + _dipKetchupCost;
            }
            if (DipBBQ == true)
            {
                i = i + _dipBBQCost;
            }
            if (DipSweetChili == true)
            {
                i = i + _dipSweetChiliCost;
            }
            if (DipCurry == true)
            {
                i = i + _dipCurryCost;
            }
            if (DipGravy == true)
            {
                i = i + _dipGravyCost;
            }

            return i;
        }

        public List<string> ReturnAllCustomisation()
        {
            List<string> customisationList = new List<string>();
            //ref line 115

            #region AddingToList

            if (ChickenWings == true)
            {
                customisationList.Add("Chicken Wing X 6");
            }
            if (ChickenBreast == true)
            {
                customisationList.Add("Chicken Wing X 2");
            }
            if (ChickenDrumstick == true)
            {
                customisationList.Add("Chicken Drumstick X 2");
            }
            if (ChickenPopcorn == true)
            {
                customisationList.Add("Popcorn Chicken X 2");
            }

            //checking for extra custimisation
            if (DipKetchup == true)
            {
                customisationList.Add("Ketchup Dip");
            }
            if (DipBBQ == true)
            {
                customisationList.Add("BBQ Dip");
            }
            if (DipSweetChili == true)
            {
                customisationList.Add("SweetChili Dip");
            }
            if (DipCurry == true)
            {
                customisationList.Add("Curry Dip");
            }
            if (DipGravy == true)
            {
                customisationList.Add("Gravy Dip");
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
