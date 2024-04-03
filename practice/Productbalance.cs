using System;
using System.Collections.Generic;

namespace practice;

public partial class Productbalance
{
    public int Balanceid { get; set; }

    public int Productid { get; set; }

    public int Quantity { get; set; }

    public virtual Product Product { get; set; } = null!;
}
