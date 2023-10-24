namespace DataLayer;

public interface IDataService
{
    IList<Category> GetCategories();
    Category? GetCategory(int categoryId);
    IList<Category> GetCategoriesByName(string searchTerm);
    Category? CreateCategory(Category categoryToCreate);
    bool DeleteCategory(Category category);
    bool DeleteCategory(int categoryId);
    Category CreateCategory(string name, string description);
    bool UpdateCategory(int Id, string name, string description);
    ProductWithCategoryInfo? GetProduct(int productId);
    IList<ProductWithCategoryInfo> GetProductByCategory(int categoryId);
    IList<ProductAndCategoryInfo> GetProductByName(string searchString);
    Order? GetOrder(int searchId);
    IList<Order> GetOrders();
    IList<OrderDetails> GetOrderDetailsByOrderId(int searchId);
    IList<OrderDetails> GetOrderDetailsByProductId(int searchId);
}