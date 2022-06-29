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
    public partial class EvidentaCumparaturi : Form
    {
        public EvidentaCumparaturi()
        {
            InitializeComponent();
            LoadData();
        }
        public EvidentaCumparaturi(int c)
        {
        }
        public void LoadData()
        {
            using (IstoricVanzariDbContext db = new IstoricVanzariDbContext())
            {
                var res = from p in db.IstoricVanzari
                          select new
                          {
                              p.id,
                              p.id_user,
                              p.DenumireProdus,
                              p.quantity
                          };
                dgvIstoricCumparaturi.DataSource = res.ToList();
            }
        }
    }
}
