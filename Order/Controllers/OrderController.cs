using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Order.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderDbContext _database;

        [BindProperty]
        public OrderModel Order { get; set; }


        public OrderController(OrderDbContext database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            return View();
        }

        public OrderDbContext Get_database()
        {
            return _database;
        }

        public IActionResult Upsert(int? id, OrderDbContext _database)
        {
            Order = new OrderModel(); //prepare a creation by default

            if (id != null) //detemins if it is an update
            {
                Order = _database.Order.FirstOrDefault(Order => Order.OrderId == id); //sets the new Order state

                if (Order == null)
                {
                    return NotFound();
                }
            }

            return View(Order);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Order.OrderId == 0)
                {
                    //Create
                    _database.Add(Order);
                }
                else
                {
                    //Update
                    _database.Order.Update(Order);
                }

                _database.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(Order);
        }

        #region API Calls

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _database.Order.ToListAsync() }); //linq
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var orderFromDb = await _database.Order.FirstOrDefaultAsync(order => order.OrderId == id);
            if (orderFromDb == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            _database.Order.Remove(orderFromDb);
            await _database.SaveChangesAsync();

            return Json(new { success = true, message = "Delete Successfull" });
        }

        #endregion
    }
}
