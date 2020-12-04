using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Order
    {
        private List<Food> foodList = new List<Food>();
        private int orderNo;

        public Order(KitchenLiveOrderScreen kOrderScreen)
        { 
            OrderNo = kOrderScreen.OrderNoCount;
        }

        public int OrderNo
        {
            get { return orderNo; }
            set { orderNo = value; }
        }

        public void addItem(Food f)
        {
            foodList.Add(f);
        }
    }
}
