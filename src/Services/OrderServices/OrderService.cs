﻿using Database.Entity;
using UnitOfWork;

namespace Services.OrderServices;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _unitOfWork;
    public OrderService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IQueryable<Order> GetAllOrders()
    {
        return _unitOfWork.OrderRepository.GetAllOrders();
    }

    public Order? GetOrderByCode(string code)
    {
        return _unitOfWork.OrderRepository.GetOrderByCode(code);
    }

    public Order UpdateOrder(Order order)
    {
        _unitOfWork.OrderRepository.UpdateOrder(order);
        _unitOfWork.SaveChanges();
        return order;
    }
}