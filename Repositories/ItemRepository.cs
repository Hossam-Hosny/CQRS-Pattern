using CQRS_Library.Data;
using CQRS_Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryContracts;

namespace Repositories
{
    public class ItemRepository : IItems
    {
        private readonly AppDbContext _db;
        public ItemRepository(AppDbContext db)
        {
            _db = db;
        }

        public int DeleteItem(int id)
        {
            var item = _db.DBItems.FirstOrDefault(temp => temp.Id == id);
            if (item is not null) { _db.DBItems.Remove(item); }
            return _db.SaveChanges();
        }

        public Items GetItem(int id)
        {
            Items? item = _db.DBItems.FirstOrDefault(temp => temp.Id == id);
            return item ?? new();
        }

        public List<Items> GetItems()
        {
           return _db.DBItems.ToList();
        }

        public int InsertItem(Items item)
        {
            var NewItem = new Items();
            NewItem.Name = item.Name;
            NewItem.Price = item.Price;
            _db.DBItems.Add(NewItem);
            return _db.SaveChanges();
        }

        public int UpdateItem(Items item)
        {
            try
            {
                _db.DBItems.Attach(item);
                _db.Entry(item).State = EntityState.Modified;
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
