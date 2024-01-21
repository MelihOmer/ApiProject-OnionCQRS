using ApiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProject.Persistence.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            List<Category> categories = new()
            {
                new Category
                {
                    Id=1,
                    Name = "Elektronik",
                    Priority=1,
                    ParentId=0
                },
                new Category
                {
                    Id=2,
                    Name = "Moda",
                    Priority=2,
                    ParentId=0
                },
                new Category
                {
                    Id=3,
                    Name = "Bilgisayar",
                    Priority=1,
                    ParentId=1
                },
                new Category
                {
                    Id=4,
                    Name = "Kadın",
                    Priority=1,
                    ParentId=2,
                }
            };
            builder.HasData(categories);
        }
    }

}
