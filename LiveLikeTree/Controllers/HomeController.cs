using LiveLikeTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveLikeTree.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
         readonly CemeteryContext db = new CemeteryContext();

        public ActionResult Index()
        {
            IEnumerable<Tree> Trees = db.Trees;
            ViewBag.Trees = Trees;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            order.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Заказ оформлен";
        }
    }
}