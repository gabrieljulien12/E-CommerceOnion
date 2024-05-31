using MediatR;
using OnionAplication.Interface.UnitOfWorks;
using OnionDomain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Features.Details.Command.DeleteDetail
{
    public class DeleteDetailCommandHendeler : IRequestHandler<DeleteDetailCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteDetailCommandHendeler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(DeleteDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var detail = await unitOfWork.GetReadReposirtory<Detail>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
             detail.IsDeleted = true;
            await unitOfWork.GetWriteReposirtory<Detail>().UpdateAsync(detail);
            await unitOfWork.SaveAsync();
        }
    }
}
