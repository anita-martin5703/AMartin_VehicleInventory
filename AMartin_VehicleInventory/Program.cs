// Anita Martin
// amartin98@cnm.edu
// Title: Vehicle Class Inventory
// Objectives:
//      - Demonstrate how to use ListBox Controls.
//      - Demonstrate how to use ComboBox Controls.
//      - Demonstrate how to use TabControls.

// Program.cs


using System;
using System.Windows.Forms;

namespace AMartin_VehicleInventory
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
            Application.Run(new VehicleInventoryForm());
        }
    }
}
