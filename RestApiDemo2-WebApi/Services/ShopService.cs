using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestApiDemo2_WebApi.Models;

namespace RestApiDemo2_WebApi.Services
{
    public class ShopService<T> : IShopService<T>
        where T : BaseItem
    {
        public DbContext Context { get; set; }

        public async Task<List<T>> GetAllItemsAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }
        
        public async Task<T> GetItemAsync(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public async Task AddItemAsync(T t)
        {
            Context.Set<T>().Add(t);
            await Context.SaveChangesAsync();
        }

        public async Task EditItemAsync(int id, T t)
        {
            var item = await GetItemAsync(id);
            item.Name = t.Name;
            await Context.SaveChangesAsync();
        }
        
        public async Task DeleteItemAsync(int id)
        {
            var item = await GetItemAsync(id);
            Context.Set<T>().Remove(item);
            await Context.SaveChangesAsync();
        }
    }
}