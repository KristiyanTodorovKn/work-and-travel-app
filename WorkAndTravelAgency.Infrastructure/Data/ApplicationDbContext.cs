using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkAndTravelAgency.Infrastructure.Data.Configuration;

namespace WorkAndTravelAgency.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new EmployerConfiguration());
            builder.ApplyConfiguration(new JobTypeConfiguration());
            builder.ApplyConfiguration(new JourneyConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Agent> Agents { get; set; } = null!;

        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<Country> Countries { get; set; } = null!;

        public DbSet<Employer> Employers { get; set; } = null!;

        public DbSet<JobType> JobTypes { get; set; } = null!;

        public DbSet<Journey> Journeys { get; set; } = null!;
    }
}
