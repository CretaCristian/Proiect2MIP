using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Proiect
{
    internal class Utilizator
    {
        public int id { get; set; }
        [Required]
        public string Nume { get; set; }
        [Required]
        public string Prenume { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Parola { get; set; }
    }
    class UtilizatorDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Utilizator> Utilizator { get; set; }
    }
}
