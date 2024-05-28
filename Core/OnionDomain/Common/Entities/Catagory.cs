using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnionDomain.Common.Entities
{
    public class Catagory: BaseEntity
    {
        public Catagory()
        {
            
        }
        public Catagory(int parentId,string name , int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        public   int ParentId { get; set; }
        public  string  Name { get; set; }
        
        public  int Priorty { get; set; }

        public virtual ICollection<Detail> Details { get; set; }
        public virtual ICollection<Product> Products { get; set; } 

    }
}
