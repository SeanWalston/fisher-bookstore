using Fisher.Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Fisher.Bookstore.Data
{
    public class BookstoreContext : DbContext 
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base (options)
            { }

            protected override void OnModelCreating(ModelBuilder builder) =>
            base.OnModelCreating(builder);

    
}}