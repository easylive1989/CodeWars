
using System;
using Kata.Models;

namespace Kata
{
    public class TransactionController
    {
        private readonly TransactionService _transactionService;

        public TransactionController(TransactionService shop)
        {
            _transactionService = shop;
        }
        
        // public IActionResult Confirm(int userId, int goodsId)
        // {
        //     try
        //     {
        //         _transactionService.Save(userId, goodsId);
        //         return Ok();
        //     }
        //     catch (OrderRejectedException)
        //     {
        //         return BadRequest();
        //     }
        // }
    }
    
    public class TransactionService
    {
        private readonly OrderService _orderService;
        private readonly UserService _userService;
        private readonly GoodsService _goodsService;

        public TransactionService(OrderService orderService, UserService userService, GoodsService goodsService)
        {
            _orderService = orderService;
            _userService = userService;
            _goodsService = goodsService;
        }
        
        public void Save(int userId, int goodsId)
        {
            var order = new Order(GetUser(userId), GetGoods(goodsId));
            try
            {
                _orderService.Save(order);
            }
            catch (OrderRejectedException e)
            {
                Refund(order);
                throw;
            }
        }

        private Goods GetGoods(int goodsId)
        {
            return _goodsService.Get(goodsId);
        }

        private User GetUser(int userId)
        {
            return _userService.Get(userId);;
        }

        private bool Refund(Order order)
        {
            // Refund user's money
            return false;
        }
    }

    public class UserService
    {
        public User Get(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class GoodsService
    {
        public Goods Get(int goodsId)
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
        public async void Save(Order order)
        {
            var orderStatus = _orderRepository.SaveOrder(order);
            if (orderStatus == OrderStatus.Rejected)
            {
                throw new OrderRejectedException(order);
            }
        }
    }

    public class OrderRejectedException : Exception
    {
        public OrderRejectedException(Order order)
        {
            throw new NotImplementedException();
        }
    }

    public enum OrderStatus
    {
        Success,
        Waiting,
        Rejected
    }
    
    public interface IOrderRepository
    {
        OrderStatus SaveOrder(Order order);
    }

    public class Order
    {
        public Order(User user, Goods goods)
        {
            throw new System.NotImplementedException();
        }
    }
}