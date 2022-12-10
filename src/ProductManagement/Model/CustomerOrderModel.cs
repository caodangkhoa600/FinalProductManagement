﻿namespace ProductManagement.Model;

public class CustomerOrderModel
{
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public int Total { get; set; }
}