using LayeredProjrct.Core.Dto.Result;

namespace LayeredProjrct.Repository.Implement
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public bool Add(ProductInfo data)
        {
            //blablalbla
            return this.Add(new Product
            {
                Id = 1,
                Name = data.Name,
            });
        }
        public ProductDto GetData(int id)
        {
            return new ProductDto()
            {
                Id = Guid.NewGuid(),
                Name = "CarToy",
                Description = string.Empty
            };
        }
        public bool Update(ProductInfo data)
        {
            return this.Update(new Product
            {
                Id = 1,
                Name = data.Name,
            });
        }
    }
}
