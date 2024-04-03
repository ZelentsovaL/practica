using System;
using System.Collections.Generic;

namespace practice;

public partial class Delivery
{
    public int Deliveryid { get; set; }

    public DateOnly Deliverydate { get; set; }

    public int Orderid { get; set; }

    public string Address { get; set; } = null!;

    public int? Courierid { get; set; }

    public string Status { get; set; } = null!;

    public int Type { get; set; }

    public virtual Employee? Courier { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Typedelivery TypeNavigation { get; set; } = null!;
}
