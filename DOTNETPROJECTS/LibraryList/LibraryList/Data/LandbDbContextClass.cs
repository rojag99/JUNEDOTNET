using LibraryList.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryList.Data
{
    public class LandbDbContextClass : DbContext
    {
        public LandbDbContextClass(DbContextOptions<LandbDbContextClass> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasKey(b => b.BookId);

            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .IsRequired();

            modelBuilder.Entity<Author>()
                .HasKey(a => a.AuthorId);

            modelBuilder.Entity<Author>()
                .Property(a => a.Name)
                .IsRequired();
        }
    }
}
