using Onion.Contract.RepositoryInterfaces;
using Onion.Domain.Entities;
using Onion.Persistence.ContextClasses;

namespace Onion.Persistence.RepositoryConcretes
{
    public class ProductAttributeRepository(MyContext context) : BaseRepository<ProductAttribute>(context), IProductAttributeRepository
    {

    }
}
