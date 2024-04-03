using System;
using System.Collections.Generic;

namespace practice;

public partial class Paymentmethod
{
    public long Idpaymentmethod { get; set; }

    public string Namemethod { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
