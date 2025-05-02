using BOBOrderingApp.Shared.Models;

namespace BOBOrderingApp.Shared.Services;

public interface IWeeklyMenuService
{
    public void AddItems(IEnumerable<MenuItem> items);
    public bool RemoveItem(int id);

    public IEnumerable<MenuItem> GetAllItems();
}
