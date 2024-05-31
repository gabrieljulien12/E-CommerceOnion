using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Command.CreateProduct
{
    public class CreateDetailCommnadRequest : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CatagoryId { get; set; }
    }
}
