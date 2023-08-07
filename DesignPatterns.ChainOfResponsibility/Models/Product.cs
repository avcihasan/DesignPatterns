﻿namespace DesignPatterns.ChainOfResponsibility.Models
{
    public class Product:BaseEntity
    {
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
