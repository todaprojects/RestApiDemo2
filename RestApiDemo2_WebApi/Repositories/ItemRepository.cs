using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestApiDemo_WebApi.Models;

namespace RestApiDemo_WebApi.Repositories
{
    public class ItemRepository<T> : IItemRepository<T>
        where T : BaseItem
    {
        private readonly DbContext _context;

        public ItemRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllItemsAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        
        public async Task<T> GetItemAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task AddItemAsync(T t)
        {
            _context.Set<T>().Add(t);
            await _context.SaveChangesAsync();
        }

        public async Task EditItemAsync(int id, T t)
        {
            var item = await GetItemAsync(id);
            item.Name = t.Name;
            item.Price = t.Price;
            item.Quantity = t.Quantity;
            await _context.SaveChangesAsync();
        }
        
        public async Task DeleteItemAsync(int id)
        {
            var item = await GetItemAsync(id);
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}