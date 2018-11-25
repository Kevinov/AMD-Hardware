using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMD Hardware.Models
{
    public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public int Credit_CardId { get; set; }
    public int ProductId { get; set; }
    public Credit_Card _credit_Card { get; set; }
    public Product _Product { get; set; }


}
}
