using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPersistance.Configurations
{
    public class ProductCatagoryConfigurations : IEntityTypeConfiguration<ProductCatagory>
    {
        public void Configure(EntityTypeBuilder<ProductCatagory> builder)
        {
            builder.HasKey(x => new {x.ProductId, x.CatagoryId});
            builder.HasOne(p => p.Product).WithMany(pc => pc.CatagoryProductis).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(c => c.Catagory).WithMany(pc => pc.CatagoryProductis).HasForeignKey(c => c.CatagoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
