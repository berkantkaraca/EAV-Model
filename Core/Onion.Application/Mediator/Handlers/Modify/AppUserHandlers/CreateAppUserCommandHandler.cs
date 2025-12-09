using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.AppUserCommands;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand, GetAppUserByIdQueryResult>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public CreateAppUserCommandHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserByIdQueryResult> Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            AppUser appUser = _mapper.Map<AppUser>(request);
            await _repository.CreateAsync(appUser);

            return _mapper.Map<GetAppUserByIdQueryResult>(appUser);
        }
    }
}
