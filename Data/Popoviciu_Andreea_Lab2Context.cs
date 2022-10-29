using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Popoviciu_Andreea_Lab2.Models;

namespace Popoviciu_Andreea_Lab2.Data
{
    public class Popoviciu_Andreea_Lab2Context : DbContext
    {
        public Popoviciu_Andreea_Lab2Context (DbContextOptions<Popoviciu_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Popoviciu_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Popoviciu_Andreea_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Popoviciu_Andreea_Lab2.Models.Author> Author { get; set; }
    }
}
