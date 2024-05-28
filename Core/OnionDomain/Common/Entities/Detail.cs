using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDomain.Common.Entities
{
    public class Detail : BaseEntity
    {
        public Detail()
        {

        }
        public Detail(string title, string description, int catagoryıd)
        {
            Title = title;
            Description = description;
            CatagoryId = catagoryıd;
        }
        public  string Title { get; set; }
        public  string Description { get; set; } 
        public   int CatagoryId { get; set; }

        // relation proporties
        public virtual Catagory Catagory { get; set; }
    }
}
