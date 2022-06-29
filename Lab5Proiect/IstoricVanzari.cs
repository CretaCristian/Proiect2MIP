using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Proiect
{
    internal class IstoricVanzari
    {
        public int id { get; set; }
        public int id_user { get; set; }

        public string DenumireProdus { get; set; }

        public int quantity { get; set; }
    }
    class IstoricVanzariDbContext : System.Data.Entity.DbContext
    {
        public DbSet<IstoricVanzari> IstoricVanzari { get; set; }
    }
}
