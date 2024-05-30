using MediatR;
using OnionAplication.Interface.AutoMappers;
using OnionAplication.Interface.UnitOfWorks;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHendler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateProductCommandHendler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadReposirtory<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            var map = mapper.Map<Product, UpdateProductCommandRequest>(request);
            var productcatagories = await unitOfWork.GetReadReposirtory<ProductCatagory>().GetAllAsync(x => x.ProductId == product.Id);
            await unitOfWork.GetWriteReposirtory<ProductCatagory>().HardDeleteAsync(productcatagories);

            foreach (var catagoryid in request.CatagoryIds)
                await unitOfWork.GetWriteReposirtory<ProductCatagory>().AddAsync(new () { CatagoryId = catagoryid,ProductId = product.Id });

            await unitOfWork.GetWriteReposirtory<Product>().UpdateAsync(map);
            await unitOfWork.SaveAsync();
        }
    }
}
    