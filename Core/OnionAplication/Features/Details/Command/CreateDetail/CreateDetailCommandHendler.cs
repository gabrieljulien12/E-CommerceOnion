using MediatR;
using OnionAplication.Interface.UnitOfWorks;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Command.CreateProduct
{
    public class CreateDetailCommandHendler : IRequestHandler<CreateDetailCommnadRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateDetailCommandHendler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateDetailCommnadRequest request, CancellationToken cancellationToken)
        {
            Detail details = new(request.Title, request.Description, request.CatagoryId);
            await unitOfWork.GetWriteReposirtory<Detail>().AddAsync(details);
            await unitOfWork.SaveAsync();
        }
    }
}
