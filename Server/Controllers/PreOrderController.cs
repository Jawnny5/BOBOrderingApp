using AutoMapper;
using BOBOrderingApp.Shared.Models;
using BOBOrderingApp.Shared.Models.DTOS;
using BOBOrderingApp.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BOBOrderingApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreOrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMenuItemService _menuItemService;
        private readonly IWeeklyMenuService _weeklyMenuService;

        public PreOrderController(IMapper mapper, IMenuItemService menuItemService, IWeeklyMenuService weeklyMenuService)
        {
            _mapper = mapper;
            _menuItemService = menuItemService;
            _weeklyMenuService = weeklyMenuService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuItemDTO>>> GetMenuItems()
        {
            var menuItems = _menuItemService.GetAllMenuItems();

            await Task.Delay(30);

            var result = _mapper.Map<IEnumerable<MenuItemDTO>>(menuItems);

            return Ok(result);
        }

        [HttpGet]
        [Route("item/{itemId}")]
        public async Task<ActionResult<MenuItemDTO>> GetMenuItemById(int itemId)
        {
            var menuItem = _menuItemService.GetMenuItemById(itemId);

            await Task.Delay(30);

            var result = _mapper.Map<MenuItemDTO>(menuItem);

            return Ok(result);  
        }

        [HttpPost]
        public async Task<ActionResult<WeeklyMenu>> AddItemsToWeeklyMenu(List<MenuItem> menuItems)
        {
            _weeklyMenuService.AddItems(menuItems);

            return CreatedAtAction(nameof(GetWeeklyMenu), null, menuItems);
        }

        [HttpGet("WeeklyMenu")]
        public async Task<ActionResult<IEnumerable<MenuItem>>> GetWeeklyMenu()
        {
            await Task.Delay(30);

            var menu = _weeklyMenuService.GetAllItems();

            return Ok(menu);
        }

        [HttpDelete("WeeklyMenu/{id}")]
        public async Task<IActionResult> RemoveItemFromWeeklyMenu(int id)
        {
            var success = _weeklyMenuService.RemoveItem(id);
            if (!success)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
