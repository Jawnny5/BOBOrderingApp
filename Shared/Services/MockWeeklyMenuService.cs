using BOBOrderingApp.Shared.Models;

namespace BOBOrderingApp.Shared.Services;

public class MockWeeklyMenuService : IWeeklyMenuService
{
    private readonly List<MenuItem> _menuItems = new();

    public IEnumerable<MenuItem> GetAllItems() => _menuItems;

    public void AddItems(IEnumerable<MenuItem> items)
    {
        _menuItems.AddRange(items);
    }

    public bool RemoveItem(int id)
    {
        var item = _menuItems.FirstOrDefault(i => i.MenuItemId == id);
        if (item is null) return false;

        _menuItems.Remove(item);
        return true;
    }
}
