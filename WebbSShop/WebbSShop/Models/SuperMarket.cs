using System;
using System.Collections.Generic;

namespace WebbSShop.Models;

public partial class SuperMarket
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Adress { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
