using Microsoft.AspNetCore.Mvc;
using Producer_Api.DbContexts;
using Producer_Api.DTOs;
using Producer_Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producer_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMessageProducer _messagePublisher;
        public OrdersController(ApplicationDbContext context, IMessageProducer messagePublisher)
        {
            _context = context;
            _messagePublisher = messagePublisher;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderDto orderDto)
        {
            Order order = new()
            {
                ProductName = orderDto.ProductName,
                Price = orderDto.Price,
                Quantity = orderDto.Quantity
            };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            _messagePublisher.SendMessage(order);
            return Ok(new { id = order.Id });
        }
    }
}
