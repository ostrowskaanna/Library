using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryProject.DataModels;

namespace LibraryProject.DAL
{
    internal class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryDatabase") 
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<LibraryContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserBooks> UsersBooks { get; set; }
        public DbSet<Role> Roles { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Console.WriteLine("creating model");
        //    var books = modelBuilder.Entity<Book>();
        //    books.ToTable("FluentAPI.Books");
        //    books.HasKey(book => book.Id);
        //}

    }
}
