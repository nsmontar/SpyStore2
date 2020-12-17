using System.Collections.Generic;
using System.Threading.Tasks;
using SpyStore.Models.Entities;
using SpyStore.Models.ViewModels;
using SpyStore.Mvc.Models.ViewModels;

namespace SpyStore.Mvc.Support
{
    public interface ISpyStoreServiceWrapper
    {
        //Category Controller
        Task<IList<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryAsync(int id);
        Task<IList<ProductViewModel>> GetProductsForACategoryAsync(
            int categoryId);
        //Orders Controller

         Task<IList<Order>> GetOrdersAsync(int customerId);
         Task<OrderWithDetailsAndProductInfo> GetOrderDetailsAsync(int orderId);

         //Product Controller 
         Task<ProductViewModel> GetOneProductAsync(int productId);
         Task<IList<ProductViewModel>> GetFeaturedProductsAsync();

         //Search Controller
         Task<IList<ProductViewModel>> SearchAsync(string searchTerm);

         //ShoppingCartRecord Controller
         Task<IList<CartRecordWithProductInfo>> GetCartRecordsAsync(int id);
         Task AddToCartAsync(int customerId, int productId, int quantity);
         Task<CartRecordWithProductInfo> UpdateShoppingCartRecordAsync(
                int rexordId, ShoppingCartRecord item);
        Task RemoveCartItemAsync(int id, ShoppingCartRecord item);
        
        //Shopping Cart Controller
        Task<CartWithCustomerInfo> GetCartAsync(int customerId);
        Task<string> PurchaseAsync(int customerId, Customer customer);

        //Customer controller
        Task<Customer> GetCustomerAsync(int customerId);
        Task<IList<Customer>> GetCustomersAsync();
    }
}