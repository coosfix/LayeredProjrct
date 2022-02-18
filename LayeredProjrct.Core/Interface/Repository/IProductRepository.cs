namespace LayeredProjrct.Core.Interface.Repository
{
    public interface IProductRepository
    {
        ProductDto GetData(int id);
        bool Add(ProductInfo data);
        bool Update(ProductInfo data);
    }
}
