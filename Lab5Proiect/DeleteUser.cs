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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(DeleteUserTextBox.Text);
            using(UtilizatorDbContext db = new UtilizatorDbContext())
            {
                bool a = false;

                var user = from p in db.Utilizator
                           where p.id == id
                           select p;
                foreach (var item in user)
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    a = true;

                }
                if(a)
                {
                    db.SaveChanges();
                    MessageBox.Show("Utilizatorul a fost sters.", "Succes");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ID-ul nu a fost gasit");
                }

            }
        }
    }
}
