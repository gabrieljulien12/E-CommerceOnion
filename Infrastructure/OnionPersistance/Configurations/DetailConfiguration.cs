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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Detail detail1 = new()
            {

                Id = 1,
                Title ="EkranKartı",
                Description ="RTX4090",
                CatagoryId =1,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Detail detail2 = new()
            {

                Id = 2,
                Title = "Ram",
                Description = "DDR5",
                CatagoryId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };
            Detail detail3 = new()
            {

                Id = 3,
                Title = "Hammadde",
                Description = "Yün",
                CatagoryId = 4,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            builder.HasData(detail1,detail2, detail3);  
        }
    }
}
