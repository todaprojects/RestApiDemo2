using System.Collections.Generic;
using System.Threading.Tasks;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Repositories
{
    public interface IItemRepository<T>
        where T : BaseItem
    {
        Task<List<T>> GetAllItemsAsync();
        
        Task<T> GetItemAsync(int id);

        Task AddItemAsync(T t);

        Task EditItemAsync(int id, T t);
        
        Task DeleteItemAsync(int id);
    }
}