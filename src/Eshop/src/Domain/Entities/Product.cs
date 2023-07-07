using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Domain.Common;

namespace Eshop.Domain.Entities;
public class Product : BaseAuditableEntity
{
    public Product()
    {
       
    }

    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string ProductDescription { get; set; }

    public int? SupplierId { get; set; }

    public int? CategoryId { get; set; }

    public string Quantity { get; set; }

    public decimal? Price { get; set; }

    public short? UnitsInStock { get; set; }


    public Category Category { get; set; }
    public Supplier Supplier { get; set; }
}
