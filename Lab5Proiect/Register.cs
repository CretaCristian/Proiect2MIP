using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Proiect
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string nume, prenume, username, password;
            nume = NumeTextBox.Text;
            prenume = PrenumeTextBox.Text;
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;

            using(UtilizatorDbContext db = new UtilizatorDbContext())
            {
                Utilizator u = new Utilizator();
                u.Username = username;
                u.Nume = nume;
                u.Prenume = prenume;
                u.Parola = password;
                try
                {
                    db.Utilizator.Add(u);
                    db.SaveChanges();
                    MessageBox.Show("Succes");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unul sau mai multe dintre campurile introduse sunt invalide.", "Eroare");
                }
            }
        }
    }
}
