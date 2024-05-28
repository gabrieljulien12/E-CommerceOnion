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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new()
            {
                Id = 1,
                BrandId = 1,
                Price = 15000,
                Discount = 15,
                Tittle = "Asusz9",
                Desciription ="blablabla",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Product product2 = new()
            {
                Id = 2,
                BrandId = 2,
                Price = 15000,
                Discount = 15,
                Tittle = "macbook",
                Desciription = "blablabla",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Product product3 = new()
            {
                Id = 3,
                BrandId = 3,
                Price = 15000,
                Discount = 15,
                Tittle = "aspire",
                Desciription = "blablabla",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            builder.HasData(product1, product2, product3);

        }
    }
}
