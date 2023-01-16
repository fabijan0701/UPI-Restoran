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
using System.IO;

namespace UPI_Restoran.Forms
{
    /// <summary>
    /// Forma koja služi za čitanje rezervacija, brisanje i unos novih rezervacija
    /// </summary>
    public partial class ReservationViewForm : Form
    {
        
        public ReservationViewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja ispisuje podatke o rezervacijama u list box
        /// </summary>
        /// <param name="list"></param>
        private void IspisRezervacija(List<Rezervacija> list)
        {
            lstRezervacije.Items.Clear();
            foreach (Rezervacija r in list)
            {
                string ispis = String.Format("{0}\t {1} - {2} \t {3} {4} {5} \t Stol {6} {7} {8}", 
                    r.Broj ,r.Pocetak.TimeOfDay, r.Kraj.TimeOfDay,r.Gost.Ime, r.Gost.Prezime, 
                    r.Kontakt, r.Stol.Broj, r.Stol.Pozicija, r.Stol.Klasa);
                lstRezervacije.Items.Add(ispis);
            }
        }

        private void ReservationViewForm_Load(object sender, EventArgs e)
        {

            if (!File.Exists("DB.mdf"))
            {
                MessageBox.Show("Baza nije učitana, prebacite je iz Data foldera u Debug");
                Application.Exit();
            }

            try
            {
                DateTime t = datePicker.Value;
                string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

                DateTime pocetak = DateTime.Parse(date);
                DateTime kraj = pocetak.AddHours(24);
                List<Rezervacija> rezervacije = Connection.ŞQL_Rezervacije(pocetak, kraj);
                IspisRezervacija(rezervacije);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime t = datePicker.Value;
                string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

                DateTime pocetak = DateTime.Parse(date);
                DateTime kraj = pocetak.AddHours(24);
                List<Rezervacija> rezervacije = Connection.ŞQL_Rezervacije(pocetak, kraj);
                IspisRezervacija(rezervacije);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Project.TimeSelection_Form = new TimeSelectionForm();
            Project.TimeSelection_Form.ShowDialog();

            if(Project.TimeSelection_Form.Done != true)
            {
                return;
            }

            if(Project.NR_Form != null && Project.NR_Form.Done != true)
            {
                return;
            }

            Connection.SQL_DodajRezervaciju(Project.NR_Form.Rezervacija);
            MessageBox.Show("Rezervacija je uspješno spremljena", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                DateTime t = datePicker.Value;
                string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

                DateTime pocetak = DateTime.Parse(date);
                DateTime kraj = pocetak.AddHours(24);
                List<Rezervacija> rezervacije = Connection.ŞQL_Rezervacije(pocetak, kraj);
                IspisRezervacija(rezervacije);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return;
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (lstRezervacije.SelectedItem == null)
            {
                MessageBox.Show("Rezervacija nije odabrana!");
                return;
            }

            string[] parts = lstRezervacije.SelectedItem.ToString().Split('\t');
            int brojRez = int.Parse(parts[0]);

            try
            {
                Connection.SQL_ObrisiRezervaciju(brojRez);
                DateTime t = datePicker.Value;
                string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

                DateTime pocetak = DateTime.Parse(date);
                DateTime kraj = pocetak.AddHours(24);
                List<Rezervacija> rezervacije = Connection.ŞQL_Rezervacije(pocetak, kraj);
                IspisRezervacija(rezervacije);
            }
            catch
            {
                MessageBox.Show("Brisanje nije uspjelo");
            }
        }

        private void btnInformacije_Click(object sender, EventArgs e)
        {
            if (lstRezervacije.SelectedItem == null)
            {
                MessageBox.Show("Rezervacija nije odabrana!");
                return;
            }

            string[] parts = lstRezervacije.SelectedItem.ToString().Split('\t');
            int brojRez = int.Parse(parts[0]);

            try
            {
                DateTime t = datePicker.Value;
                string date = String.Format("{0}-{1}-{2} 00:00:00", t.Year, t.Month, t.Day);

                DateTime pocetak = DateTime.Parse(date);
                DateTime kraj = pocetak.AddHours(24);

                Rezervacija r = Rezervacija.Trazi(brojRez, pocetak, kraj);
                MessageBox.Show(r.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Povezivanje nije uspjelo");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.CurrentDirectory);
        }
    }
}
