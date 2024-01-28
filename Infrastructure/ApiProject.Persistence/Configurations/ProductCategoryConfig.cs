using ApiProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ApiProject.Persistence.Configurations
{
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new {x.ProductId,x.CategoryId});
            builder.HasOne(p => p.Product).WithMany(pc => pc.ProductCategories).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Category).WithMany(cp => cp.ProductCategories).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
