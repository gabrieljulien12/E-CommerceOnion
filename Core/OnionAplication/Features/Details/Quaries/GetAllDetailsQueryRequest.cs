using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Quaries
{
    public class GetAllDetailsQueryRequest : IRequest<IList<GetAllDetailsQueryResponse>>
    {
    }
}
