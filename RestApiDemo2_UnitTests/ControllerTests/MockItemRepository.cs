using System.Collections.Generic;
using System.Threading.Tasks;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Repositories;

namespace RestApiDemo2_UnitTests.ControllerTests
{
    public class MockItemRepository : IItemRepository<Fruit>
    {
        public async Task<List<Fruit>> GetAllItemsAsync()
        {
            return await Task.Run(() => new List<Fruit>
            {
                new Fruit
                {
                    Id = 0,
                    Name = "NewFruit",
                    Quantity = 1
                }
            });
        }

        public async Task<Fruit> GetItemAsync(int id)
        {
            return await Task.Run(() => new Fruit
            {
                Id = id,
                Name = "NewFruit",
                Quantity = 1
            });
        }

        public Task AddItemAsync(Fruit t)
        {
            return null;
        }

        public Task EditItemAsync(int id, Fruit t)
        {
            return null;
        }

        public Task DeleteItemAsync(int id)
        {
            return null;
        }
    }
}