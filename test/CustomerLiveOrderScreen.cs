using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class CustomerLiveOrderScreen : Form
    {
        
        private List<Order> currentOrders = new List<Order>();


        public CustomerLiveOrderScreen()
        {
            InitializeComponent();
        }

        public void orderToCustomer(Order order)
        {
            currentOrders.Add(order);
            preparingOrderListBox.Items.Add("Order " + order.OrderNo);
        }

        public void readyToCollect(string s) 
        {
            preparingOrderListBox.Items.Remove(s);
            pleaseCollectListbox.Items.Add(s);
        }

        public void moveOrderPreparing(string s) 
        {
            pleaseCollectListbox.Items.Remove(s);
            preparingOrderListBox.Items.Add(s);
        }

    }
}
