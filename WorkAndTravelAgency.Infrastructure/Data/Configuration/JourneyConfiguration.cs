using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Infrastructure.Data.Configuration
{
    internal class JourneyConfiguration : IEntityTypeConfiguration<Journey>
    {
        public void Configure(EntityTypeBuilder<Journey> builder)
        {
            builder.HasData(CreateJourney());
        }

        private List<Journey> CreateJourney()
        {
            List<Journey> journeys = new List<Journey>()
            {
                new Journey()
                {
                    Id = 1,
                    Name = "Journey to New York",
                    CityId = 1,
                    Price = 900m,
                    AgentId = 1
                },
                new Journey()
                {
                    Id = 2,
                    Name = "Journey to London",
                    CityId = 2,
                    Price = 500m,
                    AgentId = 1
                },
                new Journey()
                {
                    Id = 3,
                    Name = "Journey to Rome",
                    CityId = 3,
                    Price = 300m,
                    AgentId = 1
                }
            };
            return journeys;
        }
    }
}
