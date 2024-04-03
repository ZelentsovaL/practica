using System;
using System.Collections.Generic;

namespace practice;

public partial class Order
{
    public int Orderid { get; set; }

    public DateOnly Orderdate { get; set; }

    public int Customerid { get; set; }

    public int Productid { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public string Paymentmethod { get; set; } = null!;

    public string Shippingaddress { get; set; } = null!;

    public int? Status { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual ICollection<Orderhistory> Orderhistories { get; set; } = new List<Orderhistory>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Product Product { get; set; } = null!;

    public virtual Statusorder? StatusNavigation { get; set; }
}
