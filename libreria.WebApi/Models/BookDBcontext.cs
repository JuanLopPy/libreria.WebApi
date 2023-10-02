using Microsoft.EntityFrameworkCore;

namespace libreria.WebApi.Models
{
    public class BookDBcontext : DbContext
    {
        public BookDBcontext(DbContextOptions<BookDBcontext> options):base (options) { 
         
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

       //protected override void OnModelCreating(ModelBuilder modelBuilder) {

            //modelBuilder.Entity<User>().ToTable("AppBookUsers");
            //modelBuilder.Entity<Book>().ToTable("Books");

          
        //}

    }
}
