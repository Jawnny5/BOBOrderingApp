using BOBOrderingApp.Shared.Models;

namespace BOBOrderingApp.Shared.Services;

public interface IMenuItemService
{
    public IEnumerable<MenuItem> GetAllMenuItems();

    public MenuItem GetMenuItemById(int id);
}
