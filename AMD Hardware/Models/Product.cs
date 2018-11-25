using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMD Hardware.Models
{
    public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CompanyId { get; set; }
    public E_commerce _E_commerce { get; set; }
    public Customer _Customer { get; set; }
    public Company _Company { get; set; }
}
}
