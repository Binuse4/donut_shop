using DonutShop.Data;
using DonutShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DonutShop.Controllers
{
    [Route("orders")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly DonutShopContext _db;

        public OrdersController(DonutShopContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderWithStatus>>> GetOrders()
        {
            var orders = await _db.Orders
             .Include(o => o.Donuts).ThenInclude(p => p.Special)
             .Include(o => o.Donuts).ThenInclude(p => p.Decorations).ThenInclude(t => t.Decoration)
             .OrderByDescending(o => o.CreatedTime)
             .ToListAsync();

            return orders.Select(o => OrderWithStatus.FromOrder(o)).ToList();
        }

        [HttpPost]
        public async Task<ActionResult<int>> PlaceOrder(Order order)
        {
            order.CreatedTime = DateTime.Now;

            // Enforce existence of Pizza.SpecialId and Topping.ToppingId
            // in the database - prevent the submitter from making up
            // new specials and toppings
            foreach (var donut in order.Donuts)
            {
                donut.SpecialId = donut.Special.Id;
                donut.Special = null;
            }

            _db.Orders.Attach(order);
            await _db.SaveChangesAsync();

            return order.OrderId;
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<OrderWithStatus>> GetOrderWithStatus(int orderId)
        {
            var order = await _db.Orders
                .Where(o => o.OrderId == orderId)
                .Include(o => o.Donuts).ThenInclude(p => p.Special)
                .Include(o => o.Donuts).ThenInclude(p => p.Decorations).ThenInclude(t => t.Decoration)
                .SingleOrDefaultAsync();

            if (order == null)
            {
                return NotFound();
            }

            return OrderWithStatus.FromOrder(order);
        }
    }
}
