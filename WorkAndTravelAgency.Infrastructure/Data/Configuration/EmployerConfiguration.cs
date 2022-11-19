using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Infrastructure.Data.Configuration
{
    internal class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasData(CreateEmployer());
        }

        private List<Employer> CreateEmployer()
        {
            List<Employer> employers = new List<Employer>()
            {
                new Employer()
                {
                    Id = 1,
                    Name = "Soho Grand Hotel",
                    ImageUrl = "https://www.kayak.com/rimg/himg/6b/fc/de/leonardo-2147069-139087023-H1-Club-Room_O-295961.jpg?width=1366&height=768&xhint=720&yhint=500&crop=true",
                    JobTypeId = 1,
                },

                new Employer()
                {
                    Id = 2,
                    Name = "Aldi",
                    ImageUrl = "https://www.retailgazette.co.uk/wp-content/uploads/UNP-McCann-39838-Aldi-Balham.001-1.jpg",
                    JobTypeId = 2,
                },

                new Employer()
                {
                    Id = 3,
                    Name = "Argot",
                    ImageUrl = "https://media-cdn.tripadvisor.com/media/photo-s/0a/93/cb/77/argot.jpg",
                    JobTypeId = 3,
                }

            };
            return employers;
        }
    }
}
