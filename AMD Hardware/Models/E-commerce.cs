﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMD Hardware.Models
{
    public class E_commerce
{
    public int E_commerceId { get; set; }
    public string Name { get; set; }
    public string WebAddress { get; set; }
    public int Hotline { get; set; }
    public int ProductId { get; set; }
    public int Credit_CardId { get; set; }
    public Product _Product { get; set; }
    public Credit_Card _Credit_Card { get; set; }
}
}
