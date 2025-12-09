using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Onion.Application.ErrorHandling
{
    public class ExceptionHandlerBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {
                throw new Exception($"İşlem sırasında bir hata oluştu: {ex.Message}", ex);
            }
        }
    }
}
