using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ChickenSub:Food
    {
        private const float _baseChickenSubPrice = 3.39f;
        private const float _chickenSubExtraChickenTendersCost = 0.89f;
        private const float _chickenSubExtraAmericanCheeseCost = 0.20f;
        private const float _chickenSubExtraLettuceCost = 0.25f;
        private const float _chickenSubExtraCucumber = 0.25f;
        private const float _chickenSubExtraSweetChili = 0.00f;

        #region BoolsForBurger

        //Default options are true
        private bool chickenSubChickenTenders = true;
        private bool chickenSubAmericanCheese = true;
        private bool chickenSubLettuce = true;
        private bool chickenSubCucumber = true;
        private bool chickenSubSweetChiliSauce = true;
        private bool chickenSubBageutteRoll = true;

        //Default options are false
        private bool chickenSubExtraChickenTenders = false;
        private bool chickenSubExtraAmericanCheese = false;
        private bool chickenSubExtraLettuce = false;
        private bool chickenSubExtraCucumber = false;
        private bool chickenSubExtraChiliSauce = false;

        #endregion BoolsForBurgers


        //BaseOptions
        #region BaseOptions

        public bool ChickenSubChickenTenders
        {
            get { return chickenSubChickenTenders; }
            set { chickenSubChickenTenders = value; }
        }
        public bool ChickenSubAmericanCheese
        {
            get { return chickenSubAmericanCheese; }
            set { chickenSubAmericanCheese = value; }
        }
        public bool ChickenSubLettuce
        {
            get { return chickenSubLettuce; }
            set { chickenSubLettuce = value; }
        }
        public bool ChickenSubCucumber
        {
            get { return chickenSubCucumber; }
            set { chickenSubCucumber = value; }
        }
        public bool ChickenSubSweetChiliSauce
        {
            get { return chickenSubSweetChiliSauce; }
            set { chickenSubSweetChiliSauce = value; }
        }
        public bool ChickenSubBageutteRoll
        {
            get { return chickenSubBageutteRoll; }
            set { chickenSubBageutteRoll = value; }
        }


        #endregion BaseOptions

        //ExtraOptions
        #region ExtraOptions
        public bool ChickenSubExtraChickenTenders
        {
            get { return chickenSubExtraChickenTenders; }
            set { chickenSubExtraChickenTenders = value; }
        }
        public bool ChickenSubExtraAmericanCheese
        {
            get { return chickenSubExtraAmericanCheese; }
            set { chickenSubExtraAmericanCheese = value; }
        }
        public bool ChickenSubExtraLettuce
        {
            get { return chickenSubExtraLettuce; }
            set { chickenSubExtraLettuce = value; }
        }
        public bool ChickenSubExtraCucumber
        {
            get { return chickenSubExtraCucumber; }
            set { chickenSubExtraCucumber = value; }
        }
        public bool ChickenSubExtraChiliSauce
        {
            get { return chickenSubExtraChiliSauce; }
            set { chickenSubExtraChiliSauce = value; }
        }

        #endregion ExtraOptions

        public float ReturnTotalCost()
        {
            //I could do this in switch case... but I don't like switch case
            float i = _baseChickenSubPrice;
            if (ChickenSubExtraChickenTenders == true)
            {
                i = i + _chickenSubExtraChickenTendersCost;
            }
            if (ChickenSubExtraAmericanCheese == true)
            {
                i = i + _chickenSubExtraAmericanCheeseCost;
            }
            if (ChickenSubExtraLettuce == true)
            {
                i = i + _chickenSubExtraLettuceCost;
            }
            if (ChickenSubExtraCucumber == true)
            {
                i = i + _chickenSubExtraCucumber;
            }
            if (ChickenSubExtraChiliSauce == true)
            {
                i = i + _chickenSubExtraSweetChili;
            }

            return i;
        }

        public List<string> ReturnAllCustomisation()
        {
            List<string> customisationList = new List<string>();

            #region AddingToList

            if (ChickenSubChickenTenders == true)
            {
                customisationList.Add("Chicken Tenders,");
            }
            if (ChickenSubAmericanCheese == true)
            {
                customisationList.Add("American Cheese,");
            }
            if (ChickenSubLettuce == true)
            {
                customisationList.Add("Lettuce,");
            }
            if (ChickenSubCucumber == true)
            {
                customisationList.Add("Cucumber,");
            }
            if (ChickenSubSweetChiliSauce == true)
            {
                customisationList.Add("Sweet Chili Sauce,");
            }
            if (ChickenSubBageutteRoll == true)
            {
                customisationList.Add("Bageutte Roll,");
            }

            //checking for extra customisation

            if (ChickenSubExtraChickenTenders == true)
            {
                customisationList.Add("Extra Chicken Tenders,");
            }
            if (ChickenSubExtraAmericanCheese == true)
            {
                customisationList.Add("Extra American Cheese,");
            }
            if (ChickenSubExtraLettuce == true)
            {
                customisationList.Add("Extra Lettuce,");
            }
            if (ChickenSubExtraCucumber == true)
            {
                customisationList.Add("Extra Cucumber,");
            }
            if (ChickenSubExtraChiliSauce == true)
            {
                customisationList.Add("Extra Chili Sauce,");
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
