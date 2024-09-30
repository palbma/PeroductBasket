using System.Collections;

namespace ASPMVCSHOP.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
