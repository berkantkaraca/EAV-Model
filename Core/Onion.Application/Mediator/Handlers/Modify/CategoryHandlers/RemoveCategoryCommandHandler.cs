using AutoMapper;
using MediatR;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using Onion.Application.Mediator.Commands.CategoryCommands;
using Onion.Application.Mediator.Results.CategoryResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.CategoryHandlers
{
    public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand, GetCategoryByIdQueryResult>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public RemoveCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            Category value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
            return _mapper.Map<GetCategoryByIdQueryResult>(value);
        }
    }
}
