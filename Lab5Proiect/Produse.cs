using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Lab5Proiect
{
    internal class Produse
    {
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string name { get; set; }
        [Required]
        [MaxLength(500)]
        public string description { get; set; }

        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public int quantity { get; set; }
    }

    class ProduseDbContext : DbContext
    {
        public DbSet<Produse> Products { get; set; }
    }
}
