using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAndTravelAgency.Infrastructure.Data.Configuration
{
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {

        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(CreateCities());
        }

        private List<City> CreateCities()
        {
            List<City> cities = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Name = "New York",
                    CountryId = 1
                },

                new City()
                {
                    Id = 2,
                    Name = "London",
                    CountryId = 2
                },

                new City()
                {
                    Id = 3,
                    Name = "Rome",
                    CountryId = 3
                }
            };

            return cities;
        }
    }
}
