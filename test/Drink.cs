using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Drink:FoodMeal
    {
        //Has access 4 items of FoodMeal:
        //OrderNumbber
        //PriceOfItem
        //NameOfItem
        //ItemCount

        private bool cokeIsRegular;
        private bool cokeIsDiet;
        
        public bool CokeIsRegular
        {
            get {return cokeIsRegular; }
            set {cokeIsRegular = value; }
        }
        public bool CokeIsDiet
        {
            get { return cokeIsDiet; }
            set { cokeIsDiet = value; }
        }

        
        
    }
}
