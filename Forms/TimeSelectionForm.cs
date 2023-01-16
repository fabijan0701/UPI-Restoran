using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPI_Restoran.Data;
using UPI_Restoran.Data.Other;

namespace UPI_Restoran.Forms
{
    /// <summary>
    /// Forma koja služi za odabir vremena nove rezervacije
    /// </summary>
    public partial class TimeSelectionForm : Form
    {
        /// <summary>
        /// Svojstvo koje prikazuje jesu li podaci uspješno učitani
        /// </summary>
        public bool Done;
        public TimeSelectionForm()
        {
            InitializeComponent();
            Done = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Postavlja svojstvo "Done" na true ako je vrijeme uspješno učitano
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDalje_Click(object sender, EventArgs e)
        {
            DateTime d = datePicker.Value;
            int pocH = int.Parse(numPocH.Value.ToString());
            int pocMin = int.Parse(numStartMin.Value.ToString());
            int krajH = int.Parse(numEndH.Value.ToString());
            int krajMin = int.Parse(numEndMin.Value.ToString());

            string pocetakStr = String.Format("{0}-{1}-{2} {3}:{4}:{5}",
                d.Year,d.Month,d.Day, pocH, pocMin, 0);
            DateTime pocetak = DateTime.Parse(pocetakStr);
            
            string krajStr = String.Format("{0}-{1}-{2} {3}:{4}:{5}",
                d.Year, d.Month, d.Day, krajH, krajMin, 0);
            DateTime kraj = DateTime.Parse(krajStr);

            if (pocetak.CompareTo(kraj) >= 0)
            {
                MessageBox.Show("Kraj ne može biti prije početka");
                return;
            }

            Stol.DostupniStolovi = Connection.SQL_Stolovi(pocetak, kraj);
            
            if (Stol.DostupniStolovi.Count == 0)
            {
                MessageBox.Show("U tom terminu nema dostupnih stolova!");
                return;
            }


            (DateTime, DateTime) pocKraj = (pocetak, kraj);
            Project.NR_Form = new NewReservationForm(pocKraj);
            Project.NR_Form.ShowDialog();
            Done = true;
        }

       
    }
}
