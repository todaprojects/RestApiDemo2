using System.Collections.Generic;
using System.Threading.Tasks;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Repositories;

namespace RestApiDemo2_UnitTests
{
    public class MockItemRepository : IItemRepository<Fruit>
    {
        public async Task<List<Fruit>> GetAllItemsAsync()
        {
            var list = new List<Fruit>
            {
                new Fruit
                {
                    Id = 0,
                    Name = "NewFruit",
                    Quantity = 1
                }
            };

            return list;
        }

        public async Task<Fruit> GetItemAsync(int id)
        {
            var fruit = new Fruit
            {
                Id = id,
                Name = "NewFruit",
                Quantity = 1
            };

            return fruit;
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