using BodyForgeServer.Entity;
using Microsoft.EntityFrameworkCore;

namespace BodyForgeServer.Repository
{
    public class BodyForgeContext : DbContext
    {
        public BodyForgeContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-44LL7RP;Initial Catalog=bodyforge_db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            }
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<Target> Target {  get; set; }
        public DbSet<Session> Session {  get; set; }
        public DbSet<Muscle> Muscle {  get; set; }
        public DbSet<Exercise> Exercise { get; set; }
    }
}