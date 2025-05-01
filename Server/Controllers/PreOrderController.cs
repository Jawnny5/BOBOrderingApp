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

        public PreOrderController(IMapper mapper, IMenuItemService menuItemService)
        {
            _mapper = mapper;
            _menuItemService = menuItemService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuItemDTO>>> GetMenuItems()
        {
            var menuItems = _menuItemService.GetAllMenuItems();

            await Task.Delay(30);

            var result = _mapper.Map<IEnumerable<MenuItemDTO>>(menuItems);

            return Ok(result);
        }
    }
}
