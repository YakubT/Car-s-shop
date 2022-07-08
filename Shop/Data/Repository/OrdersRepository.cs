﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;
namespace Shop.Data.Repository
{
    public class OrdersRepository:IAllOrders
    {
        public readonly AppDBContent appDBContent;
        public readonly ShopCart shopCart;

        public OrdersRepository(AppDBContent appDBContent,ShopCart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
        public void createOrder (Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            var items = shopCart.listShopItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = el.car.id,
                    orderID = order.id,
                    price = el.price

                };
                appDBContent.OrderDetail.Add(orderDetail);
                
            }
            appDBContent.SaveChanges();
        }
    }
}
