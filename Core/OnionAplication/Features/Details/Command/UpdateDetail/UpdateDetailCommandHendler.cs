using MediatR;
using OnionAplication.Features.Products.Command.UpdateProduct;
using OnionAplication.Interface.AutoMappers;
using OnionAplication.Interface.UnitOfWorks;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Command.UpdateDetail
{
    public class UpdateDetailCommandHendler : IRequestHandler<UpdateDetailCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateDetailCommandHendler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var Detail = await unitOfWork.GetReadReposirtory<Detail>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            var map = mapper.Map<Detail, UpdateDetailCommandRequest>(request);
            await unitOfWork.GetWriteReposirtory<Detail>().UpdateAsync(map);
            await unitOfWork.SaveAsync();
        }
    }
}
