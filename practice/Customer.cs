using System;
using System.Collections.Generic;

namespace practice;

public partial class Customer
{
    public int Customerid { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Middlename { get; set; }

    public string Contactinfo { get; set; } = null!;

    public string Orderhistory { get; set; } = null!;

    public virtual ICollection<Orderhistory> Orderhistories { get; set; } = new List<Orderhistory>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
