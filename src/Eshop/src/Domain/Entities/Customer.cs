using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Entities;
public class Customer:BaseAuditableEntity
{
    public Customer()
    {
        Orders = new List<Order>();
    }

    public string CustomerId { get; set; }
   
    public Address Address { get; set; }

  
    public string Phone { get; set; }

    public ICollection<Order> Orders { get; private set; }
}
