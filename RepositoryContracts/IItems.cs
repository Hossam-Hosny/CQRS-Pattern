using CQRS_Library.Data.Models;

namespace RepositoryContracts
{
    public interface IItems
    {
        public List<Items> GetItems();
        public Items GetItem(int id);

        public int InsertItem (Items item);
        public int UpdateItem (Items item);
        public int DeleteItem (int id);
    }
}
