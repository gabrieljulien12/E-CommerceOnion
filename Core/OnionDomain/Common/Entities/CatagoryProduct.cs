using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDomain.Common.Entities
{
    public class ProductCatagory: IentityBase
    {
        public int ProductId{ get; set; }
        public int CatagoryId { get; set; }
        public Product Product { get; set; }
        public Catagory Catagory { get; set; }
    }
}
