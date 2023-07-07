using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Entities;
public class Order : BaseAuditableEntity
{
    public Order()
    {
        Products = new List<Product>();
    }

    public int OrderId { get; set; }

    public string CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public Address ShipAddress { get; set; }

    
    public Customer Customer { get; set; }

    public ICollection<Product> Products { get; private set; }
}