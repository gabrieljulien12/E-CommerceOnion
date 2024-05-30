using MediatR;
using OnionAplication.Interface.UnitOfWorks;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHendler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateProductCommandHendler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new(request.Tittle, request.Desciription, request.BrandId, request.Price, request.Discount);

            await unitOfWork.GetWriteReposirtory<Product>().AddAsync(product);
            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var catagoryıd in request.CatagoryIds)
                {
                    await unitOfWork.GetWriteReposirtory<ProductCatagory>().AddAsync(new()
                    {
                       ProductId = product.Id,
                       CatagoryId = catagoryıd
                       
                    });
                    await unitOfWork.SaveAsync();

                }
            }



        }
    }
}
