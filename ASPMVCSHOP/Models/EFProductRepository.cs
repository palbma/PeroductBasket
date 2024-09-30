
namespace ASPMVCSHOP.Models
{
    public class EFProductRepository : IProductRepository
    {
        private AplicationDbContext context;
        public IEnumerable<Product> Products => context.Product;
     
        public EFProductRepository(AplicationDbContext context)
        {
            this.context = context;
        }


    }

}
