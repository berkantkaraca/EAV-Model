using AutoMapper;
using Onion.Domain.Entities;
using Onion.Contract.RepositoryInterfaces;
using MediatR;
using Onion.Application.Mediator.Commands.AppUserCommands;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;
using Onion.Domain.Enums;

namespace Onion.Application.Mediator.Handlers.Modify.AppUserHandlers
{
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommand, GetAppUserByIdQueryResult>
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public UpdateAppUserCommandHandler(IAppUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetAppUserByIdQueryResult> Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            AppUser value = await _repository.GetByIdAsync(request.Id);

            value.UserName = request.UserName;
            value.Password = request.Password;
            value.Status = DataStatus.Updated;
            value.UpdatedDate = DateTime.Now;

            await _repository.SaveChangesAsync();
            return _mapper.Map<GetAppUserByIdQueryResult>(value);
        }
    }
}
