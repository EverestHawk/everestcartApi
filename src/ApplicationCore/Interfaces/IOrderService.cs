﻿using ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int basketId, Address shippingAddress);
        Order GetByIdWithItems(int orderId);
        Task<Order> GetByIdWithItemsAsync(int orderId);
    }
}
