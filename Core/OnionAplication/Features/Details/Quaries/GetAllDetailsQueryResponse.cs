using OnionAplication.Dto;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Quaries
{
    public class GetAllDetailsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CatagoryId { get; set; }
        public CatagoryDto catagory { get; set; }
    }
}
