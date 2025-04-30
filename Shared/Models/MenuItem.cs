using BOBOrderingApp.Shared.Models.Enums;
using System.ComponentModel.DataAnnotations;


namespace BOBOrderingApp.Shared.Models;

public class MenuItem
{
    public int MenuItemId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [Range(0.01, 1000)]
    public decimal Price { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Allergens { get; set; }

    public string Ingredients { get; set; }

    public string ThumbnailUrl { get; set; }

    public List<string> ImageUrls { get; set; }

    public bool IsDiscounted { get; set; }

    public int AmountInThisWeek { get; set; }

    public MenuItemCategory Category { get; set; }

}
