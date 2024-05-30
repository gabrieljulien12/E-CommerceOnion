using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDomain.Common.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            
        }
        public Product( string Tittle, string Desciription,int BrandId,decimal Price,decimal Discount)
        {
            this.Tittle = Tittle;
            this.Desciription = Desciription;
            this.BrandId = BrandId;
            this.Price = Price;
            this.Discount = Discount;
        }
        public  string Tittle { get; set; }
        public  string Desciription { get; set; }
        public  int BrandId { get; set; }
        public decimal Price { get; set; }

        public decimal Discount { get; set;}
        //Relations proporties
        public virtual Brand brand { get; set; }
        public  ICollection<ProductCatagory> CatagoryProductis { get; set; }
    }
}
