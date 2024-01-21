using ApiProject.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProject.Persistence.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");
            List<Product> products = new()
            {
                new Product
                {
                    Id = 1,
                    Title = faker.Commerce.ProductName(),
                    Description = faker.Commerce.ProductDescription(),
                    BrandId =1,
                    Discount=faker.Random.Decimal(0,10),
                    Price = faker.Finance.Amount(10,1000)
                },
                new Product
                {
                    Id = 2,
                    Title = faker.Commerce.ProductName(),
                    Description = faker.Commerce.ProductDescription(),
                    BrandId =3,
                    Discount=faker.Random.Decimal(0,10),
                    Price = faker.Finance.Amount(10,1000)
                }
            };
            builder.HasData(products);
        }
    }
}
