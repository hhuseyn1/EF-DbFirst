﻿namespace EF_DbFirst.DAL;

public class Product
{
    public int Id { get; set; }
    public decimal UnitPrice { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
