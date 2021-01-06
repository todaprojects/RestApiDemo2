using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestApiDemo2_WebApi.Models;

namespace RestApiDemo2_WebApi.Services
{
    public class ShopService<T> : IShopService<T>
        where T : BaseItem
    {
        public DbContext Context { get; set; }
        public DbSet<T> Items { get; set; }

        private List<T> GetItemList()
        {
            return Items.ToList();
        }

        public T GetItem(int id)
        {
            return GetItemList().Find(item => item.Id == id);
        }

        public List<T> GetAllItems()
        {
            return GetItemList();
        }

        public void AddItem(T t)
        {
            Items.Add(t);
            Context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = GetItem(id);
            Items.Remove(item);
            Context.SaveChanges();
        }

        public void EditItem(int id, T t)
        {
            var item = GetItem(id);
            item.Name = t.Name;
            Context.SaveChanges();
        }
    }
}