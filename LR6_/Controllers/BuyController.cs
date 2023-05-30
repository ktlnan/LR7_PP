using LR6_.Models;
using Microsoft.AspNetCore.Mvc;


namespace LR6_.Controllers
{
    public class BuyController : Controller
    {
        MobileContext db;
        public static int Id;
        public BuyController(MobileContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Buy(int id)
        {
            Id = id;
            var phone = db.Phones.Find(id);
            return View("~/Views/Buy.cshtml", phone);
        }


        [HttpPost]
        public IActionResult Buy1(string address)
        {
            
            var id = HttpContext.Session.GetString("session");
            int search = int.Parse(id);

            var user = db.Users.Find(search);
            db.Orders.Add(
                new Order
                {
                    UserId = user.UserId,
                    ContactTelephone = user.NumberTelephone,
                    Address = address,
                    PhoneId = Id
                }
            );
            db.SaveChanges();
            return View("~/Views/Finish.cshtml", user);
        }
    }
}

