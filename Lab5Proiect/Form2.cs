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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(ProduseDbContext pdb = new ProduseDbContext())
            {

                try
                {
                    Produse p = new Produse();
                    p.name = DenumireTextBox.Text;
                    p.description = DescriereTextBox.Text;
                    p.ExpiryDate = Convert.ToDateTime(txtdate.Value);
                    p.quantity = int.Parse(CantitateTextBox.Text);
                    pdb.Products.Add(p);
                    pdb.SaveChanges();
                    MessageBox.Show("Produsul a fost adaugat cu succes.", "Succes");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Unul sau mai multe dintre campurile introduse sunt invalide.", "Eroare");
                }

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
