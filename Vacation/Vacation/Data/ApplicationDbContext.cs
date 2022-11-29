using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vacation.Data.TimeOffs;

namespace Vacation.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>()
                .HasOne(u => u.Team)
                .WithMany(t => t.Developers)
                .OnDelete(DeleteBehavior.NoAction);
            

            modelBuilder.Entity<Team>()
                .HasOne(t => t.TeamLead)
                .WithMany(u => u.LedTeams)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Teams)
                .WithOne(t => t.Project)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Team> Teams { get; set; }

        public virtual DbSet<Project> Projects { get; set; }

        public virtual DbSet<PaidTimeOff> PaidTimeOffs { get; set; }

        public virtual DbSet<UnpaidTimeOff> UnpaidTimeOffs { get; set; }

        public virtual DbSet<SickTimeOff> SickTimeOffs { get; set; }
    }
}