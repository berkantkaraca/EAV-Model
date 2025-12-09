using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.AppUserProfileCommands;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.AppUserProfileHandlers
{
    public class CreateAppUserProfileCommandHandler : IRequestHandler<CreateAppUserProfileCommand, GetAppUserProfileByIdQueryResult>
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public CreateAppUserProfileCommandHandler(IAppUserProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserProfileByIdQueryResult> Handle(CreateAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            AppUserProfile appUserProfile = _mapper.Map<AppUserProfile>(request);
            await _repository.CreateAsync(appUserProfile);
            return _mapper.Map<GetAppUserProfileByIdQueryResult>(appUserProfile);
        }
    }
}
