using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initiating starting screens: Kitchen back end screen for staff
            KitchenLiveOrderScreen kitchenScreen = new KitchenLiveOrderScreen();
            //Showing the screen
            Application.Run(kitchenScreen);
        }
    }
}
