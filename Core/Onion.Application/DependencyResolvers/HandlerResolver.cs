using Microsoft.Extensions.DependencyInjection;
using Onion.Application.ErrorHandling;
using Onion.Application.Mediator.Handlers.Read.CategoryHandlers;

namespace Onion.Application.DependencyResolvers
{
    public static class HandlerResolver
    {
        public static void AddHandlerService(this IServiceCollection services)
        {
            services.AddMediatR(x =>
            {
                x.RegisterServicesFromAssembly(typeof(GetCategoryByIdQueryHandler).Assembly);
            });

            // MediatR Pipeline'a Exception Handler ekleme
            services.AddTransient(typeof(MediatR.IPipelineBehavior<,>), typeof(ExceptionHandlerBehavior<,>));
        }
    }
}
