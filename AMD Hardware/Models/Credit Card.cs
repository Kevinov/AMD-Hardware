using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMD Hardware.Models
{
    public class Credit_Card
{
    public int Credit_CardId { get; set; }
    public int CardNumber { get; set; }
    public int VVC { get; set; }
    public Customer _Customer { get; set; }
    public E_commerce _E_commerce { get; set; }
}
}
