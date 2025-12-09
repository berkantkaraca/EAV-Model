using AutoMapper;
using MediatR;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;
using Onion.Application.Mediator.Queries.AppUserQueries;

namespace Onion.Application.Mediator.Handlers.Read.AppUserHandlers
{
    public class GetAppUserByIdQueryHandler : IRequestHandler<GetAppUserByIdQuery, GetAppUserByIdQueryResult>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserByIdQueryHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserByIdQueryResult> Handle(GetAppUserByIdQuery request, CancellationToken cancellationToken)
        {
            AppUser value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<GetAppUserByIdQueryResult>(value);
        }
    }
}
