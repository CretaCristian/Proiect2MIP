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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }


        public Form3(string id, string nume, string cantitate)
        {
            
            Form3 f3 = new Form3();
            f3.labelul1.Text = id;
            f3.labelul2.Text = nume;
            f3.labelul3.Text = cantitate;
            int idChange = int.Parse(id);
            f3.Show();
        }


        private void buttonVinde_Click(object sender, EventArgs e)
        {
            
            int res, cantitate;
            bool c=false;
            try
            {
                c = int.TryParse(textBoxVinde.Text, out res);
            }

            catch(Exception ex)

            {

            }
            
            if (c)
            {
                cantitate = Int32.Parse(textBoxVinde.Text);

                if (cantitate > Int32.Parse(labelul3.Text))
                {
                    MessageBox.Show("Nu exista stoc suficient");
                    this.Close();
                }
                else if (cantitate == Int32.Parse(labelul3.Text))
                {
                    
                    using (ProduseDbContext pdb = new ProduseDbContext())
                    {

                        var itemToRemove = pdb.Products.SingleOrDefault(x => x.quantity == cantitate);
                            pdb.Products.Remove(itemToRemove);
                            pdb.SaveChanges();
                        using (IstoricVanzariDbContext db = new IstoricVanzariDbContext())
                        {
                            IstoricVanzari iv = new IstoricVanzari();
                            iv.id_user = itemToRemove.id;
                            iv.quantity = cantitate;
                            iv.DenumireProdus = itemToRemove.name;
                            db.IstoricVanzari.Add(iv);
                            db.SaveChanges();
                        }
                        
                        MessageBox.Show("Succes, apasa butonul \"Refresh\" ");

                        this.Close();
                    }
                    
                }
                else
                {
                    int idActual = int.Parse(labelul1.Text);
                    using(ProduseDbContext pdb = new ProduseDbContext())
                    {
                        var itemToChange = pdb.Products.SingleOrDefault(x => x.id == idActual);
                        itemToChange.quantity = itemToChange.quantity - cantitate;
                        pdb.Entry(itemToChange).State = System.Data.Entity.EntityState.Modified;
                        pdb.SaveChanges();
                        using (IstoricVanzariDbContext db = new IstoricVanzariDbContext())
                        {
                            IstoricVanzari iv = new IstoricVanzari();
                            iv.id_user = itemToChange.id;
                            iv.quantity = cantitate;
                            iv.DenumireProdus = itemToChange.name;
                            db.IstoricVanzari.Add(iv);
                            db.SaveChanges();
                        }
                    }

                    MessageBox.Show("Succes, apasa butonul \"Refresh\" ");
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Eroare");
                this.Close();
            }

        }

        private void textBoxVinde_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
