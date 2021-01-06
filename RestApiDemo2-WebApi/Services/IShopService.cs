using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RestApiDemo2_WebApi.Models;

namespace RestApiDemo2_WebApi.Services
{
    public interface IShopService<T>
        where T : BaseItem
    {
        DbContext Context { get; set; }
        DbSet<T> Items { get; set; }

        T GetItem(int id);

        List<T> GetAllItems();

        void AddItem(T item);

        void DeleteItem(int id);

        void EditItem(int id, T t);
    }
}