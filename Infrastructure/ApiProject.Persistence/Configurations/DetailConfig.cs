using ApiProject.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProject.Persistence.Configurations
{
    public class DetailConfig : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new Faker("tr");

            List<Detail> list = new()
            {
                new Detail
                {
                    Id=1,
                    Title = faker.Lorem.Sentence(1),
                    Description = faker.Lorem.Sentence(2),
                    CategoryId = 1
                },
                new Detail
                {
                    Id=2,
                    Title = faker.Lorem.Sentence(1),
                    Description = faker.Lorem.Sentence(2),
                    CategoryId = 3,
                    IsDeleted = true
                },
                new Detail
                {
                    Id=3,
                    Title = faker.Lorem.Sentence(1),
                    Description = faker.Lorem.Sentence(2),
                    CategoryId = 4
                }
            };

            builder.HasData(list);
        }
    }
}
