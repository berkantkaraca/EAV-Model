using AutoMapper;
using MediatR;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using Onion.Application.Mediator.Commands.CategoryCommands;
using Onion.Application.Mediator.Results.CategoryResults.QueryResults;
using Onion.Domain.Enums;

namespace Onion.Application.Mediator.Handlers.Modify.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, GetCategoryByIdQueryResult>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category value = await _repository.GetByIdAsync(request.Id);

            value.CategoryName = request.CategoryName;
            value.Description = request.Description;
            value.Status = DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;

            await _repository.SaveChangesAsync();
            return _mapper.Map<GetCategoryByIdQueryResult>(value);
        }
    }
}
