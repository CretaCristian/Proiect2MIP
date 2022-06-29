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
    public partial class Magazin : Form
    {
        public Magazin()
        {
            InitializeComponent();
            LoadData();
        }


        public void LoadData()
        {
            using(ProduseDbContext pdb = new ProduseDbContext())
            {
                var res = from p in pdb.Products
                          select new
                          {
                              p.id,
                              p.name,
                              p.quantity,

                          };
                          dgvProduse.DataSource = res.ToList();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = SearchBox.Text;
            using(ProduseDbContext pdb = new ProduseDbContext())
            {
                var res = from p in pdb.Products
                          where p.name == s
                          select new
                          {
                              p.id,
                              p.name,
                              p.quantity,
                              p.ExpiryDate

                          };
                dgvProduse.DataSource = res.ToList();
            }
        }


        private void produsNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void maresteCantitateaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuantity aq = new AddQuantity();
            if (aq.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvProduse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                string id = dgvProduse.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nume = dgvProduse.Rows[e.RowIndex].Cells[1].Value.ToString();
                string cantitate = dgvProduse.Rows[e.RowIndex].Cells[2].Value.ToString();
                Form3 f3 = new Form3(id, nume, cantitate);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void EvidentaCumparaturiButton_Click(object sender, EventArgs e)
        {
            EvidentaCumparaturi ec = new EvidentaCumparaturi();
            ec.Show();
        }

        private void Magazin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
