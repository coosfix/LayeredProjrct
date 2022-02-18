namespace LayeredProjrct.Core.Interface.Service
{
    public interface IProductService
    {
        ProductDto GetProduct(int id);
        bool AddProduct(ProductInfo data);
    }
}
