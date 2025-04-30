using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOBOrderingApp.Shared.Models;

public class PreOrder
{
    public int PreOrderId { get; set; }

    // Identity Related Properties
    public string CustomerGoogleId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }

    // Order Information
    public List<MenuItem> ItemsOrdered { get; set; } = new();
    public Dictionary<int, int> QuantitiesByMenuItemId { get; set; } = new();
    public DateTime PickupTime { get; set; }
    public string PickupLocation { get; set; }
    public DateTime OrderPlacedAt { get; set; } = DateTime.UtcNow;

    public string PaymentMethod { get; set; }
    public string PaymentReference { get; set; }

}
