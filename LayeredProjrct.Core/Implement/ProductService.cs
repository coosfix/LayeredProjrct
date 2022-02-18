namespace LayeredProjrct.Core.Implement
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }
        public bool AddProduct(ProductInfo data)
        {
            // add product
            return repository.Add(data);
        }
        public ProductDto GetProduct(int id)
        {
            return repository.GetData(id);
        }
        public bool UpdateProduct(ProductInfo data)
        {
            return repository.Update(data);
        }
    }
}
