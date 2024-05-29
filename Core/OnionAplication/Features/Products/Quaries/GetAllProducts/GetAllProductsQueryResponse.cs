using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Products.Quaries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string Tittle { get; set; }
        public string Desciription { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
