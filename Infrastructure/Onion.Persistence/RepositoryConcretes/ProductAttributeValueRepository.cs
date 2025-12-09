using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;
using Onion.Persistence.ContextClasses;

namespace Onion.Persistence.RepositoryConcretes
{
    public class ProductAttributeValueRepository(MyContext context) : BaseRepository<ProductAttributeValue>(context), IProductAttributeValueRepository
    {

    }
}
