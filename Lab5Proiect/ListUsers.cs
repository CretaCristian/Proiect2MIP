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
    public partial class ListUsers : Form
    {
        public ListUsers()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            using(UtilizatorDbContext db = new UtilizatorDbContext())
            {
                var res = from p in db.Utilizator
                          select new
                          {
                              p.id,
                              p.Nume,
                              p.Prenume,
                              p.Username,
                              p.Parola
                          };
                dgvUsers.DataSource = res.ToList();
            }

        }
    }
}
