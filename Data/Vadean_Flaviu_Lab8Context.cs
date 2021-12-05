using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vadean_Flaviu_Lab8.Models;

namespace Vadean_Flaviu_Lab8.Data
{
    public class Vadean_Flaviu_Lab8Context : DbContext
    {
        public Vadean_Flaviu_Lab8Context (DbContextOptions<Vadean_Flaviu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Vadean_Flaviu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Vadean_Flaviu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Vadean_Flaviu_Lab8.Models.Category> Category { get; set; }
    }
}
