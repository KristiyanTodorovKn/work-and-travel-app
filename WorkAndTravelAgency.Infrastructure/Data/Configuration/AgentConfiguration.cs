using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Infrastructure.Data.Configuration
{
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(new Agent()
            {
                    Id = 1,
                    FirstName = "Anthony",
                    LastName = "Hopkins",
                    ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg5ODk1NTc5Ml5BMl5BanBnXkFtZTYwMjAwOTI4._V1_UY1200_CR115,0,630,1200_AL_.jpg",
                    Phone = "+359777777777",
                    UserId = "92b09db3-11fe-45f8-bb4b-2552e34ac8ac"               
            });
        }

    }
}
