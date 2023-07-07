using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Entities;
public class Supplier
{
    public Supplier()
    {
        Products = new List<Product>();
    }

    public int SupplierId { get; set; }

    public string CompanyName { get; set; }

    public string ContactTitle { get; set; }
    public Address Address { get; set; }
    
    public string Phone { get; set; }


    public ICollection<Product> Products { get; private set; }
}