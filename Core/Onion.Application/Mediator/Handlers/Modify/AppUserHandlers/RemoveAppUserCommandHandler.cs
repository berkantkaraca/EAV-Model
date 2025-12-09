using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.AppUserCommands;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;

namespace Onion.Application.Mediator.Handlers.Modify.AppUserHandlers
{
    public class RemoveAppUserCommandHandler : IRequestHandler<RemoveAppUserCommand, GetAppUserByIdQueryResult>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public RemoveAppUserCommandHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserByIdQueryResult> Handle(RemoveAppUserCommand request, CancellationToken cancellationToken)
        {
            AppUser value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
            return _mapper.Map<GetAppUserByIdQueryResult>(value);
        }
    }
}
