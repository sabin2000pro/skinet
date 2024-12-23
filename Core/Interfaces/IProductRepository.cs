namespace Core;
public interface IProductRepository {
    Task<IReadOnlyList<Product>> GetProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
    bool CheckProductExistance(int id);
    Task<bool> SaveChangesAsync();
}