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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            // Entities Test Verisidir
            Brand brand1 = new()
            {
                Id = 1,
                Name = "Asus",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Brand brand2 = new()
            {
                Id = 2,
                Name = "Apple",
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            };
            Brand brand3 = new()
            {
                Id = 3,
                Name = "Acer",
                CreatedDate = DateTime.Now,
                IsDeleted = false,

            };
            builder.HasData(brand1, brand2, brand3);

        }
    }
}
