using ApiProject.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProject.Persistence.Configurations
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            Faker faker = new Faker("tr");

            List<Brand> brands = new()
            {
                new Brand()
                {
                    Id = 1,
                    Name = faker.Commerce.Department(),
                    CreatedDated = DateTime.Now,
                    IsDeleted = false
                },
                new Brand()
                {
                    Id = 2,
                    Name = faker.Commerce.Department(),
                    CreatedDated = DateTime.Now,
                    IsDeleted = false
                },
                new Brand()
                {
                    Id = 3,
                    Name = faker.Commerce.Department(),
                    CreatedDated = DateTime.Now,
                    IsDeleted = true
                }
            };

            builder.HasData(brands);
        }
    }
}
