using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionAplication.Dto;
using OnionAplication.Interface.AutoMappers;
using OnionAplication.Interface.UnitOfWorks;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Products.Quaries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            this.unitOfWork = unitOfWork;
            mapper = _mapper;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadReposirtory<Product>().GetAllAsync(inculude: x => x.Include(b=> b.brand));
            var brand = mapper.Map<BrandDto, Brand>(new Brand());



            var map = mapper.Map<GetAllProductsQueryResponse ,Product>(products);
            //return map;
            throw new Exception("ErorMessage");
        }
    }
}
