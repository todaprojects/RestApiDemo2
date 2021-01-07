using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestApiDemo2_WebApi.Models;

namespace RestApiDemo2_WebApi.Services
{
    public interface IShopService<T>
        where T : BaseItem
    {
        DbContext Context { get; set; }

        Task<List<T>> GetAllItemsAsync();
        
        Task<T> GetItemAsync(int id);

        Task AddItemAsync(T t);

        Task EditItemAsync(int id, T t);
        
        Task DeleteItemAsync(int id);
    }
}