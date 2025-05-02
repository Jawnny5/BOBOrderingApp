using BOBOrderingApp.Shared.Models;
using BOBOrderingApp.Shared.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOBOrderingApp.Shared.Services
{
    public class HardcodedMenuItemService : IMenuItemService
    {
        private readonly IEnumerable<MenuItem> _items;
        public HardcodedMenuItemService()
        {
            _items = new List<MenuItem>
            {
                new MenuItem { MenuItemId = 1, Name = "Spicy Tuna", Price = 8.00m},
                new MenuItem { MenuItemId = 2, Name = "Spam and Egg", Price = 5.00m},
                new MenuItem { MenuItemId = 2, Name = "Miso Beef", Price = 6.00m},
                new MenuItem { MenuItemId = 2, Name = "Gochujang Chicken", Price = 5.00m},
            };
        }

        public IEnumerable<MenuItem> GetAllMenuItems()
        {
            return _items;
        }

        public MenuItem GetMenuItemById(int id) 
        {
            return _items.FirstOrDefault(item => item.MenuItemId == id);
        }
    }
}
