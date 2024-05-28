using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDomain.Common.Entities
{
    public class Brand:BaseEntity
    {

        public Brand()
        {

        }
        public Brand(string name)
        {
            Name = name;
        }
        public  string  Name { get; set; }


    }
}
