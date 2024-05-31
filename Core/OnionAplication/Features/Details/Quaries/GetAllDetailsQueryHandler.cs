using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionAplication.Dto;
using OnionAplication.Features.Products.Quaries.GetAllProducts;
using OnionAplication.Interface.AutoMappers;
using OnionAplication.Interface.UnitOfWorks;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Quaries
{
    public class GetAllDetailsQueryHandler : IRequestHandler<GetAllDetailsQueryRequest, IList<GetAllDetailsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            this.unitOfWork = unitOfWork;
            mapper = _mapper;
        }
        public async Task<IList<GetAllDetailsQueryResponse>> Handle(GetAllDetailsQueryRequest request, CancellationToken cancellationToken)
        {
            var details = await unitOfWork.GetReadReposirtory<Detail>().GetAllAsync(inculude: x => x.Include(c => c.Catagory));
           var catagory = mapper.Map<CatagoryDto, Catagory>(new Catagory());
            var map = mapper.Map<GetAllDetailsQueryResponse, Detail>(details);
            return map;
        }
    }
}
