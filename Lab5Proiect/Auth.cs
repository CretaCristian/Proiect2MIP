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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;

            using (UtilizatorDbContext db = new UtilizatorDbContext())
            {
                bool a = true;
                var user = from p in db.Utilizator
                           where p.Username == username && p.Parola == password
                           select p;
                foreach(var item in user)
                {
                    MessageBox.Show("Logat", "Succes");
                    Magazin m = new Magazin();
                    this.Hide();
                    m.Show();
                    a = false;
                    
                }
                if(a)
                    MessageBox.Show("Username sau parola gresita.");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            DeleteUser d = new DeleteUser();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListUsers l = new ListUsers();
            l.Show();
        }
    }
}
