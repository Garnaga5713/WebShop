using System;
using System.Collections.Generic;

namespace WebbSShop.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public virtual ICollection<OrderDetail> OrderDatails { get; } = new List<OrderDetail>();
}
