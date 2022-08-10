using Microsoft.AspNetCore.Mvc;
using my_orders.Data.Services;
using my_orders.Data.ViewModels;
using Order.Models;
using System.Collections.Generic;

namespace Order.ApiController
{
    [Route("api/OrderK")]
    [ApiController]
    public class OrderAPIController : ControllerBase
    {
        private readonly OrderDbContext _database;
        private readonly OrdersService _ordersService;
        public OrderAPIController(OrderDbContext database, OrdersService ordersService)
        {
            _database = database;
            _ordersService = ordersService;
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody] OrderModel order)
        {
            _ordersService.AddOrder(order);
            //  return Ok();


            try
            {
                _database.Add(order);
                _database.SaveChanges();
            }
            catch (System.Exception /*ex*/)
            {

                return BadRequest();
            }
            return Ok();


        }
    }
}






