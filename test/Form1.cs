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
    public partial class Form1 : Form
    {

        public static string setValueForMainLabel = "";
        public static string setValueForSideLabel = "";
        public static string setValueForDrinkLabel = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValueForMainLabel = "Burger";
            setValueForSideLabel = "Chips";
            setValueForDrinkLabel = "Coke";
            Form2 form2 = new Form2();
            this.Hide();

            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setValueForMainLabel = "9 Chicken Nuggets";
            setValueForSideLabel = "Chips";
            setValueForDrinkLabel = "Coke";
            Form2 form2 = new Form2();
            this.Hide();

            form2.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            setValueForMainLabel = "Chicken wrap";
            setValueForSideLabel = "Chips";
            setValueForDrinkLabel = "Coke";
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            setValueForMainLabel = "N/A";
            setValueForSideLabel = "Large Chips";
            setValueForDrinkLabel = "Coke";
            Form2 form2 = new Form2(); 
            this.Hide();

            form2.ShowDialog();
           

        }
    }
}
