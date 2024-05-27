using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDomain.Common.Entities
{
    public class Product:BaseEntity
    {
        public required string Tittle { get; set; }
        public required string Desciription { get; set; }
        public required int BrandId { get; set; }
        public required decimal Price { get; set; }

        public required decimal Discount { get; set;}
        //Relations proporties
        public virtual Brand brand { get; set; }
        public virtual ICollection<Catagory> Catagories { get; set; }
    }
}
