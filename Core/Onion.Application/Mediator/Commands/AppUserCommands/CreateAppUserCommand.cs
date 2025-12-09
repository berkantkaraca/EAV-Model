using MediatR;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;

namespace Onion.Application.Mediator.Commands.AppUserCommands
{
    //Todo: Ödev
    //Burada geriye değer döndüreceği zaman Result altında onlara CommandResultlar oluşturulup IRequeste generic olarak eklenir
    public class CreateAppUserCommand : IRequest<GetAppUserByIdQueryResult>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
