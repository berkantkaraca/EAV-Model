using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.AppUserProfileCommands;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.AppUserProfileHandlers
{
    public class RemoveAppUserProfileCommandHandler : IRequestHandler<RemoveAppUserProfileCommand, GetAppUserProfileByIdQueryResult>
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public RemoveAppUserProfileCommandHandler(IAppUserProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserProfileByIdQueryResult> Handle(RemoveAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            AppUserProfile value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
            return _mapper.Map<GetAppUserProfileByIdQueryResult>(value);
        }
    }
}
