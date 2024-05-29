using MediatR;
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

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadReposirtory<Product>().GetAllAsync();
            List<GetAllProductsQueryResponse> response = new();
            foreach (var product in products)
                response.Add(new GetAllProductsQueryResponse
                {
                    Tittle = product.Tittle,
                    Desciription = product.Desciription,
                    Price = product.Price - (product.Price * product.Discount /100),
                    Discount = product.Discount,
                });
            return response;
        }
    }
}
