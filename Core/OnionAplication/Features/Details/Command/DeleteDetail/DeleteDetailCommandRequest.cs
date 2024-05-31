using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Command.DeleteDetail
{
    public class DeleteDetailCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
