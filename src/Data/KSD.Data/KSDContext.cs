using KSD.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Students.Domain.Entities;

namespace KSD.Data
{
    public class KSDContext : DbContext
    {
        public KSDContext(DbContextOptions<KSDContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<SMSLog> SMSLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new ParentConfig());
            modelBuilder.ApplyConfiguration(new MealConfig());
            modelBuilder.ApplyConfiguration(new SmsLogConfig());
        }
    }
}
