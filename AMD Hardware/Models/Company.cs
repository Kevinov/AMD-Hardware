﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMD Hardware.Models
{
    public class Company
{
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int ProductId { get; set; }
    public Product _Product { get; set; }
}
}
