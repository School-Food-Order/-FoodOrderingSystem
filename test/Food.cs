using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Food
    {
        private string nameOfItem;
        private double priceOfItem;
        private int numberOfItemCount;

        //this part is for later addition for discount options
        private bool discountAvailable;
        private double percentOfDiscount;

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
        public int NumberOfItemCount
        {
            get { return numberOfItemCount; }
            set { numberOfItemCount = value; }
        }


       public void RemoveItem()//Removes a item from 
        {
            if (NumberOfItemCount>=1)
            {
                NumberOfItemCount--;
            }
            else
            {
                //Make a form that notifies the user that it's not able to remove item. 
            }
        }
        public void AddItem()//Increments the item count by 1
        {
            NumberOfItemCount++;
        }
        

    }
}
