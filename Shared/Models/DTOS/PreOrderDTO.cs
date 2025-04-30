using System.ComponentModel.DataAnnotations;

namespace BOBOrderingApp.Shared.Models.DTOS;

public class PreOrderDTO
{
    public int PreOrderId { get; set; }

    [Required]
    public string CustomerGoogleId { get; set; }

    [Required]
    public string CustomerName { get; set; }

    [Required]
    public string CustomerEmail { get; set; }

    [Required]
    public List<int> MenuItemIds { get; set; }

    [Required]
    public Dictionary<int, int> QuantitiesByMenuItemId { get; set; }

    [Required]
    public DateTime PickupTime { get; set; }

    [Required]
    public string PaymentMethod { get; set; }

    [Required]
    public string PaymentReference { get; set; }

    public string PickupLocation { get; set; }

    public DateTime OrderPlaceAt { get; set; }
}
