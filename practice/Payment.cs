using System;
using System.Collections.Generic;

namespace practice;

public partial class Payment
{
    public int Paymentid { get; set; }

    public DateOnly Date { get; set; }

    public int Orderid { get; set; }

    public decimal Amount { get; set; }

    public long Paymentmethod { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Paymentmethod PaymentmethodNavigation { get; set; } = null!;
}
