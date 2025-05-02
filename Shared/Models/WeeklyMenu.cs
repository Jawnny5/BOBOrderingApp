using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOBOrderingApp.Shared.Models;

public class WeeklyMenu
{
    public List<MenuItem> Menu {  get; set; }
    public DateTime ExpiresAt { get; set; }
}
