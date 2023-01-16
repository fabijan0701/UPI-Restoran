using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPI_Restoran.Forms;

namespace UPI_Restoran
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

            Project.ReservationView_Form = new ReservationViewForm();
            Application.Run(Project.ReservationView_Form);
        }
    }
}
