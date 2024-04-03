using System;
using System.Collections.Generic;

namespace practice;

public partial class Typedelivery
{
    public int Typedeliveriesid { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
}
