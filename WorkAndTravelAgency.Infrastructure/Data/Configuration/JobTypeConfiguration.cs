using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Infrastructure.Data.Configuration
{
    internal class JobTypeConfiguration : IEntityTypeConfiguration<JobType>
    {
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasData(CreateJobType());
        }

        private List<JobType> CreateJobType()
        {
            List<JobType> jobTypes = new List<JobType>()
            {
                new JobType()
                {
                    Id = 1,
                    Name = "Receptionist",
                    Salary = 1500.00m,
                    AgentId = 1 
                },
                new JobType()
                {
                    Id = 2,
                    Name = "Cashier",
                    Salary = 1300.00m,
                    AgentId = 1
                },
                new JobType()
                {
                    Id = 3,
                    Name = "Bartender",
                    Salary = 2200.00m,
                    AgentId = 1
                }
            };
            return jobTypes;
        }
    }
}
