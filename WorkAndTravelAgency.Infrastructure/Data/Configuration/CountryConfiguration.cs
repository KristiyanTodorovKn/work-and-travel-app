using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkAndTravelAgency.Infrastructure.Data.Configuration
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {

        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(CreateCountry());
        }

        private List<Country> CreateCountry()
        {
            var countries = new List<Country>()
            {
                new Country()
                {
                    Id = 1,
                    Name = "USA",
                    Flag = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1200px-Flag_of_the_United_States.svg.png",
                },

                new Country()
                {
                    Id = 2,
                    Name = "UK",
                    Flag = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/640px-Flag_of_the_United_Kingdom.svg.png",
                },
                
                new Country()
                {
                    Id = 3,
                    Name = "Italy",
                    Flag = "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/255px-Flag_of_Italy.svg.png"
                }
            };

            return countries;
        }
    }
}
