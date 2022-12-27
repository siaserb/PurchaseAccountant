using Microsoft.EntityFrameworkCore;
using PurchaseAccountant.Entities;

namespace PurchaseAccountant.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Record> Records { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>(builder =>
            {
                builder.Property(c => c.Name).IsRequired();

                builder.HasData(
                    new Currency() { Id = 1, Name = "USD" },
                    new Currency() { Id = 2, Name = "UAH" },
                    new Currency() { Id = 3, Name = "EUR" }
                );
            });

            modelBuilder.Entity<User>(builder =>
            {
                builder.HasIndex(u => u.Login).IsUnique();

                builder.Property(u => u.Name).IsRequired();
                builder.Property(u => u.Login).IsRequired();
                builder.Property(u => u.PasswordHash).IsRequired();
                builder.Property(u => u.PasswordSalt).IsRequired();
            });

            modelBuilder.Entity<Category>(builder =>
            {
                builder.Property(c => c.Name).IsRequired();
            });

            modelBuilder.Entity<Record>(builder =>
            {
                builder
                    .HasOne(r => r.Currency)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);

                builder
                    .HasOne(r => r.User)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);

                builder
                    .HasOne(r => r.Category)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);

                builder.Property(r => r.Name).IsRequired();
                builder.Property(r => r.CreatedOn).IsRequired();
                builder.Property(r => r.Sum).HasPrecision(18, 2).IsRequired();
            });
        }
    }
}
