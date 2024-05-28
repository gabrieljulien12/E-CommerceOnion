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
    public class CatagoryConfiguration : IEntityTypeConfiguration<Catagory>
    {
        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            Catagory catagor1 = new()
            {
                Id = 1,
                Name = "Elektronik",
                ParentId = 0,
                Priorty =1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Catagory catagor2 = new()
            {
                Id = 2,
                Name = "Moda",
                ParentId = 0,
                Priorty = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Catagory parent1 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                ParentId = 1,
                Priorty = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Catagory parent2 = new()
            {
                Id = 4,
                Name = "Kazak",
                ParentId = 1,
                Priorty = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            builder.HasData(catagor1, catagor2, parent1,parent2);
        }
    }
}
