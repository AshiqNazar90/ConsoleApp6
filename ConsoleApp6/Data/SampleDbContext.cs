using ConsoleApp6.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp6.Data
{
    public class SampleDbContext:DbContext
   
    {
           public virtual DbSet<Book> Books { get; set; }
         public virtual DbSet<Author> Authors { get; set; }
        //public virtual DbSet<Address> Addresses { get; set; }
        //public virtual DbSet<Post> Posts { get; set; }
        //public virtual DbSet<Blog> Blogs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=FluentApiDb;Trusted_Connection=True;");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //modelBuilder.HasDefaultSchema("Fluent");
                //modelBuilder.Entity<book>().ToTable("bookTable");
                //modelBuilder.Entity<book>().HasKey(s=>s.Id);//PK
                //modelBuilder.Entity<book>().Property(s=>s.Id).IsRequired();
                //modelBuilder.Entity<book>().Property(s=>s.Name).IsRequired().HasMaxLength(100);

                //modelBuilder.Entity<Address>().ToTable("AddressTable");
                //modelBuilder.Entity<Address>().HasKey(a => a.Id);//PK
                //modelBuilder.Entity<Address>().Property(a => a.Id).IsRequired();
                //modelBuilder.Entity<Address>().Property(a => a.City).IsRequired().HasMaxLength(100);

                //modelBuilder.Entity<Post>()
                // .HasOne(p => p.Blog)
                // .WithMany(b => b.Posts)
                // .HasForeignKey(p => p.BlogForeignKey);

                //modelBuilder.Entity<Blog>().HasKey(x=>x.BlogId);

                var book = modelBuilder.Entity<Book>();
                var auther = modelBuilder.Entity<Author>();
                book.Property(a => a.Title).IsRequired();
                book.HasKey(a => a.ISBN);



                book.ToTable("StudentTable");

                book.HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(z => z.AutherId).IsRequired();


                base.OnModelCreating(modelBuilder);
            }
    }
 }

