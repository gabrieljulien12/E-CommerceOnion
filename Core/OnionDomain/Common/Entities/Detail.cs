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
        public required string Title { get; set; }
        public required string Description { get; set; } 
        public  required int CatagoryId { get; set; }

        // relation proporties
        public virtual Catagory Catagory { get; set; }
    }
}
