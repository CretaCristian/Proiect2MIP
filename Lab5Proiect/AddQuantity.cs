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
    public partial class AddQuantity : Form
    {
        public AddQuantity()
        {
            InitializeComponent();
        }

        private void AddCantitateButton_Click(object sender, EventArgs e)
        {
            using(ProduseDbContext context = new ProduseDbContext())
            {
                int s = int.Parse(IdProdusTextBox.Text);
                try
                {
                    var result = context.Products.SingleOrDefault(i => i.id == s);
                    int cantitate = int.Parse(CantitateDeAdaugatTextBox.Text);
                    if (result != null)
                    {
                        result.quantity = result.quantity + cantitate;
                        context.Entry(result).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Cantitate a fost adaugata cu succes", "Succes");
                        this.Close();
                    }
                    else
                        MessageBox.Show("ID este invalid");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unul sau mai multe dintre campurile introduse sunt invalide.");
                }

            }
        }
    }
}
