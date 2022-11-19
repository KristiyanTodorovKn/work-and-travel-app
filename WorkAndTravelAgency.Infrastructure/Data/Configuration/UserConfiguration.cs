using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorkAndTravelAgency.Infrastructure.Data.Configuration
{
    public  class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "krisi@mail.com",
                NormalizedUserName = "krisi@mail.com",
                Email = "krisi@mail.com",
                NormalizedEmail = "krisi@mail.com"
            };
            user.PasswordHash =
                hasher.HashPassword(user, "Hollering1+");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "92b09db3-11fe-45f8-bb4b-2552e34ac8ac",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com",
            };
            user.PasswordHash =
                hasher.HashPassword(user, "agent123");

            users.Add(user);

            return users;
        }
        
    }
}
