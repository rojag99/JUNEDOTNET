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
                .HasOne(b => b.Author)                    // Each book has one author
                .WithMany(a => a.Books)                   // Each author can have many books
                .HasForeignKey(b => b.AuthorId)          // Foreign key in Book entity
                .IsRequired();                            // AuthorId is required for each book

            modelBuilder.Entity<Author>()
                .HasKey(a => a.AuthorId);                 // Primary key for Author entity
        }

    }
}
