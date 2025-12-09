using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.ProductCommands;
using Onion.Application.Mediator.Results.ProductResults.QueryResults;
using Onion.Domain.Enums;

namespace Onion.Application.Mediator.Handlers.Modify.ProductHandlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, GetProductByIdQueryResult>
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductByIdQueryResult> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            Product value = await _repository.GetByIdAsync(request.Id);

            value.ProductName = request.ProductName;
            value.UnitPrice = request.UnitPrice;
            value.CategoryId = request.CategoryId;
            value.Status = DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;

            await _repository.SaveChangesAsync();
            return _mapper.Map<GetProductByIdQueryResult>(value);
        }
    }
}
