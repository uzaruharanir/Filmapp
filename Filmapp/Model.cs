using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmappApp.NewDb
{
    public class FilmappContext : DbContext
    {
        public DbSet<Filmapptbl> Filmapps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.FilmappApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Filmapptbl
    {
        [Key]
        public int FilmappId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}