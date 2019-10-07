using Microsoft.EntityFrameworkCore;
using YourBabyDiary.DAL.Entities;
using YourBabyDiary.DAL.Interfaces;

namespace YourBabyDiary.DAL.EF
{
    public class YourBabyDiaryContext: DbContext, IYourBabyDiaryContext
    {
        private static readonly string ConnectionString = @"Server=ABEDENKOPC\SQLEXPRESS;Database=YourBabyDiary;Integrated Security=True;MultipleActiveResultSets=True;";

        public YourBabyDiaryContext() : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Baby> Babies { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>()
                .HasMany(l => l.Babies)
                .WithOne(u => u.Parent)
                .HasForeignKey(u => u.ParentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Baby>()
                .HasMany(l => l.Events)
                .WithOne(u => u.Baby)
                .HasForeignKey(u => u.BabyId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
