using System;
using System.Collections.Generic;

namespace practice;

public partial class Product
{
    public int Productid { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public int Warranty { get; set; }

    public long Category { get; set; }

    public int Manufacturer { get; set; }

    public virtual Category CategoryNavigation { get; set; } = null!;

    public virtual Manufacturer ManufacturerNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Productbalance> Productbalances { get; set; } = new List<Productbalance>();

    public virtual ICollection<Warehouseoperation> Warehouseoperations { get; set; } = new List<Warehouseoperation>();
}
