using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Food
    {
        private int orderNumber;//Link the orders together with items on the menu
        private string nameOfItem;
        private double priceOfItem;

        //this part is for later addition for discount options

        //private bool discountAvailable;
        //private double percentOfDiscount;

        public string NameOfItem
        {
            get {return nameOfItem; }
            set { nameOfItem = value; }
        }
        public double PriceOfItem
        {
            get { return priceOfItem; }
            set { priceOfItem = value; }
        }
        public int OrderNumber
        {
            get{ return orderNumber; }
            set{ orderNumber = value; }
        }
        
    }
}
