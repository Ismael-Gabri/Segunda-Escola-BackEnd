using Microsoft.EntityFrameworkCore;
using Seo.Domain.Entities;

namespace Seo.Domain.infra.Data
{
    public class SeoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public SeoContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().Property(x => x.Id);
            builder.Entity<User>().Property(x => x.Name.FirstName).HasColumnName("FirstName").HasColumnType("NVARCHAR").HasMaxLength(30);
            builder.Entity<User>().Property(x => x.Name.LastName).HasColumnName("LastName").HasColumnType("NVARCHAR").HasMaxLength(30);
            builder.Entity<User>().Property(x => x.Email).HasMaxLength(160);
            builder.Entity<User>().Property(x => x.PasswordHash).HasMaxLength(160);
            builder.Entity<User>().Property(x => x.CreationDate);
        }
    }
}
