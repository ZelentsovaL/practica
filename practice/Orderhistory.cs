using System;
using System.Collections.Generic;

namespace practice;

public partial class Orderhistory
{
    public long Idorderhistory { get; set; }

    public int Idorder { get; set; }

    public int Idcustomer { get; set; }

    public virtual Customer IdcustomerNavigation { get; set; } = null!;

    public virtual Order IdorderNavigation { get; set; } = null!;
}
