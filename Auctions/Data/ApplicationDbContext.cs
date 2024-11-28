using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Auctions.Models;

namespace Auctions.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Auctions.Models.Listing> Listing { get; set; } = default!;
        public DbSet<Auctions.Models.Bid> Bid { get; set; } = default!;
        public DbSet<Auctions.Models.Comment> Comment { get; set; } = default!;
    }
}
