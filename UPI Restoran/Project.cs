using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPI_Restoran.Forms;

namespace UPI_Restoran
{
    /// <summary>
    /// Staticka klasa koja sadrzi informacije o formama koje se nalaze unutar projekta
    /// </summary>
    public class Project
    {
        public static ReservationViewForm ReservationView_Form;
        public static TimeSelectionForm TimeSelection_Form;
        public static NewReservationForm NR_Form;
        public static bool setupDone = false;

    }
}
