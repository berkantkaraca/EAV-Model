using AutoMapper;
using Onion.Application.Mediator.Commands.AppUserCommands;
using Onion.Application.Mediator.Commands.AppUserProfileCommands;
using Onion.Application.Mediator.Commands.CategoryCommands;
using Onion.Application.Mediator.Commands.OrderCommands;
using Onion.Application.Mediator.Commands.OrderDetailCommands;
using Onion.Application.Mediator.Commands.ProductCommands;
using Onion.Application.Mediator.Results.AppUserProfileResults.CommandResults;
using Onion.Application.Mediator.Results.AppUserProfileResults.QueryResults;
using Onion.Application.Mediator.Results.AppUserResults.CommandResults;
using Onion.Application.Mediator.Results.AppUserResults.QueryResults;
using Onion.Application.Mediator.Results.CategoryResults.CommandResults;
using Onion.Application.Mediator.Results.CategoryResults.QueryResults;
using Onion.Application.Mediator.Results.OrderDetailResults.CommandResults;
using Onion.Application.Mediator.Results.OrderDetailResults.QueryResults;
using Onion.Application.Mediator.Results.OrderResults.CommandResults;
using Onion.Application.Mediator.Results.OrderResults.QueryResults;
using Onion.Application.Mediator.Results.ProductResults.CommandResults;
using Onion.Application.Mediator.Results.ProductResults.QueryResults;
using Onion.Domain.Entities;

namespace Onion.Application.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //AppUser
            CreateMap<CreateAppUserCommand, AppUser>();
            CreateMap<UpdateAppUserCommand, AppUser>();
            CreateMap<AppUser, GetAppUserCommandResult>();
            CreateMap<AppUser, GetAppUserQueryResult>();
            CreateMap<AppUser, GetAppUserByIdQueryResult>();

            //AppUserProfile
            CreateMap<CreateAppUserProfileCommand, AppUserProfile>();
            CreateMap<UpdateAppUserProfileCommand, AppUserProfile>();
            CreateMap<AppUserProfile, GetAppUserProfileCommandResult>();
            CreateMap<AppUserProfile, GetAppUserProfileQueryResult>();
            CreateMap<AppUserProfile, GetAppUserProfileByIdQueryResult>();

            //Category
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<Category, GetCategoryCommandResult>();
            CreateMap<Category, GetCategoryQueryResult>();
            CreateMap<Category, GetCategoryByIdQueryResult>();

            //Order
            CreateMap<CreateOrderCommand, Order>();
            CreateMap<UpdateOrderCommand, Order>();
            CreateMap<Order, GetOrderCommandResult>();
            CreateMap<Order, GetOrderQueryResult>();
            CreateMap<Order, GetOrderByIdQueryResult>();

            //OrderDetail
            CreateMap<CreateOrderDetailCommand, OrderDetail>();
            CreateMap<UpdateOrderDetailCommand, OrderDetail>();
            CreateMap<OrderDetail, GetOrderDetailCommandResult>();
            CreateMap<OrderDetail, GetOrderDetailQueryResult>();
            CreateMap<OrderDetail, GetOrderDetailByIdQueryResult>();

            //Product
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<Product, GetProductCommandResult>();
            CreateMap<Product, GetProductQueryResult>();
            CreateMap<Product, GetProductByIdQueryResult>();
        }
    }
}
