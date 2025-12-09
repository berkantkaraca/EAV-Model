using AutoMapper;
using MediatR;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;
using Onion.Application.Mediator.Queries.AppUserQueries;

namespace Onion.Application.Mediator.Handlers.Read.AppUserHandlers
{
    public class GetAppUserQueryHandler : IRequestHandler<GetAppUserQuery, List<GetAppUserQueryResult>>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public GetAppUserQueryHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAppUserQueryResult>> Handle(GetAppUserQuery request, CancellationToken cancellationToken)
        {
            List<AppUser> values = await _repository.GetAllAsync();
            return _mapper.Map<List<GetAppUserQueryResult>>(values);
        }
    }
}
