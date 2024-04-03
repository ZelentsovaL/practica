using System;
using System.Collections.Generic;

namespace practice;

public partial class Statusorder
{
    public int Idstatus { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
