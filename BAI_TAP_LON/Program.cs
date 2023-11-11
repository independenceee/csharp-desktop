using BAI_TAP_LON.Views.Admin;
using BAI_TAP_LON.Views.Admin.MovieManagement;
using BAI_TAP_LON.Views.Staff;
using BAI_TAP_LON.Views.Staff.MovieScheduleWindow;
using BAI_TAP_LON.Views.Staff.OrderFood;
using BAI_TAP_LON.Views.Staff.ShowtimePage;
using BAI_TAP_LON.Views.Staff.TicketBillFoodPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_LON
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MainAdmin());
            Application.Run(new MainStaff());
            //Application.Run(new MovieManagement());
            //Application.Run(new MovieInfor());
            //Application.Run(new Form1());
            //Application.Run(new OrderBill());
            //Application.Run(new Views.Auth.Login());
        }
    }
}
