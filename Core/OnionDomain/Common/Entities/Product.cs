using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDomain.Common.Entities
{
    public class Product:BaseEntity
    {
        public  string Tittle { get; set; }
        public  string Desciription { get; set; }
        public  int BrandId { get; set; }
        public decimal Price { get; set; }

        public decimal Discount { get; set;}
        //Relations proporties
        public virtual Brand brand { get; set; }
        public virtual ICollection<Catagory> Catagories { get; set; }
    }
}
